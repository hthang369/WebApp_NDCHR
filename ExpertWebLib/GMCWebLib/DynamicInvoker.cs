using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ExpertWebLib
{
    public delegate object GetHandler(object source);
    public delegate void SetHandler(object source, object value);
    public delegate object InstantiateObjectHandler();
    public sealed class DynamicInvoker
    {
        public static Dictionary<string, GetHandler> lstGetHandler = new Dictionary<string, GetHandler>();
        public static Dictionary<string, SetHandler> lstSetHandler = new Dictionary<string, SetHandler>();
        public static Dictionary<string, InstantiateObjectHandler> lstInitHandler = new Dictionary<string, InstantiateObjectHandler>();
        public static Dictionary<string, PropertyInfo> lstProperties = new Dictionary<string, PropertyInfo>();

        public static object DynamicCreateInstanceObject(Type typeObj)
        {
            if (typeObj == null)
            {
                return null;
            }
            try
            {
                InstantiateObjectHandler handler = null;
                lstInitHandler.TryGetValue(typeObj.FullName, out handler);
                if (handler == null)
                {
                    handler = DynamicMethodCompiler.CreateInstantiateObjectHandler(typeObj);
                    lstInitHandler.Add(typeObj.FullName, handler);
                }
                return handler();
            }
            catch (Exception)
            {
                return typeObj.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
            }
        }

        public static object DynamicGetValue(object obj, PropertyInfo _propertyInfo)
        {
            try
            {
                string key = _propertyInfo.DeclaringType.Name + _propertyInfo.Name;
                GetHandler handler = null;
                lstGetHandler.TryGetValue(key, out handler);
                if (handler == null)
                {
                    handler = DynamicMethodCompiler.CreateGetHandler(_propertyInfo.DeclaringType, _propertyInfo);
                    lstGetHandler.Add(key, handler);
                }
                return handler(obj);
            }
            catch (Exception)
            {
                return _propertyInfo.GetValue(obj, null);
            }
        }

        public static object DynamicGetValue(object obj, string strColName)
        {
            Type type = obj.GetType();
            try
            {
                string key = type.Name + strColName;
                GetHandler handler = null;
                lstGetHandler.TryGetValue(key, out handler);
                if (handler == null)
                {
                    PropertyInfo property = null;
                    lstProperties.TryGetValue(key, out property);
                    if (property == null)
                    {
                        property = type.GetProperty(strColName);
                        if (property == null)
                        {
                            //GMCLogging.LogNewMessage("ExpertLib", "", "DynamicGetValue", type.Name + " not contain " + strColName, "FAILE", true);
                            return null;
                        }
                        lstProperties.Add(key, property);
                    }
                    handler = DynamicMethodCompiler.CreateGetHandler(type, property);
                    lstGetHandler.Add(key, handler);
                }
                return handler(obj);
            }
            catch (Exception)
            {
                PropertyInfo property = type.GetProperty(strColName);
                if (property == null)
                {
                    //GMCLogging.LogNewMessage("ExpertLib", "", "DynamicGetValue", type.Name + " not contain " + strColName, "FAILE", true);
                    return null;
                }
                return property.GetValue(obj, null);
            }
        }

        public static void DynamicSetValue(object obj, PropertyInfo _propertyInfo, object value)
        {
            try
            {
                SetHandler handler = null;
                string key = _propertyInfo.DeclaringType.Name + _propertyInfo.Name;
                lstSetHandler.TryGetValue(key, out handler);
                if (handler == null)
                {
                    handler = DynamicMethodCompiler.CreateSetHandler(_propertyInfo.DeclaringType, _propertyInfo);
                    lstSetHandler.Add(key, handler);
                }
                handler(obj, value);
            }
            catch (Exception)
            {
                _propertyInfo.SetValue(obj, value, null);
            }
        }

        public static void DynamicSetValue(object obj, string strColName, object value)
        {
            Type type = obj.GetType();
            try
            {
                SetHandler handler = null;
                string key = type.Name + strColName;
                lstSetHandler.TryGetValue(key, out handler);
                if (handler == null)
                {
                    PropertyInfo property = null;
                    lstProperties.TryGetValue(key, out property);
                    if (property == null)
                    {
                        property = type.GetProperty(strColName);
                        if (property == null)
                        {
                            //GMCLogging.LogNewMessage("ExpertLib", "", "DynamicSetValue", type.Name + " not contain " + strColName, "FAILE", true);
                            return;
                        }
                        lstProperties.Add(key, property);
                    }
                    handler = DynamicMethodCompiler.CreateSetHandler(type, property);
                    lstSetHandler.Add(key, handler);
                }
                handler(obj, value);
            }
            catch (Exception)
            {
                PropertyInfo property = type.GetProperty(strColName);
                if (property == null)
                {
                    //GMCLogging.LogNewMessage("ExpertLib", "", "DynamicSetValue", type.Name + " not contain " + strColName, "FAILE", true);
                }
                else
                {
                    property.SetValue(obj, value, null);
                }
            }
        }
    }
    public sealed class DynamicMethodCompiler
    {
        private DynamicMethodCompiler()
        {
        }

        private static void BoxIfNeeded(Type type, ILGenerator generator)
        {
            if (type.IsValueType)
            {
                generator.Emit(OpCodes.Box, type);
            }
        }

        private static DynamicMethod CreateGetDynamicMethod(Type type)
        {
            return new DynamicMethod("DynamicGet", typeof(object), new Type[] { typeof(object) }, type, true);
        }

        internal static GetHandler CreateGetHandler(Type type, FieldInfo fieldInfo)
        {
            DynamicMethod method = CreateGetDynamicMethod(type);
            ILGenerator iLGenerator = method.GetILGenerator();
            iLGenerator.Emit(OpCodes.Ldarg_0);
            iLGenerator.Emit(OpCodes.Ldfld, fieldInfo);
            BoxIfNeeded(fieldInfo.FieldType, iLGenerator);
            iLGenerator.Emit(OpCodes.Ret);
            return (GetHandler)method.CreateDelegate(typeof(GetHandler));
        }

        internal static GetHandler CreateGetHandler(Type type, PropertyInfo propertyInfo)
        {
            MethodInfo getMethod = propertyInfo.GetGetMethod(true);
            DynamicMethod method = CreateGetDynamicMethod(type);
            ILGenerator iLGenerator = method.GetILGenerator();
            iLGenerator.Emit(OpCodes.Ldarg_0);
            iLGenerator.Emit(OpCodes.Call, getMethod);
            BoxIfNeeded(getMethod.ReturnType, iLGenerator);
            iLGenerator.Emit(OpCodes.Ret);
            return (GetHandler)method.CreateDelegate(typeof(GetHandler));
        }

        internal static InstantiateObjectHandler CreateInstantiateObjectHandler(Type type)
        {
            ConstructorInfo con = type.GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
            if (con == null)
            {
                throw new ApplicationException(string.Format("The type {0} must declare an empty constructor (the constructor may be private, internal, protected, protected internal, or public).", type));
            }
            DynamicMethod method = new DynamicMethod("InstantiateObject", MethodAttributes.Static | MethodAttributes.Public, CallingConventions.Standard, typeof(object), null, type, true);
            ILGenerator iLGenerator = method.GetILGenerator();
            iLGenerator.Emit(OpCodes.Newobj, con);
            iLGenerator.Emit(OpCodes.Ret);
            return (InstantiateObjectHandler)method.CreateDelegate(typeof(InstantiateObjectHandler));
        }

        private static DynamicMethod CreateSetDynamicMethod(Type type)
        {
            return new DynamicMethod("DynamicSet", typeof(void), new Type[] { typeof(object), typeof(object) }, type, true);
        }

        internal static SetHandler CreateSetHandler(Type type, FieldInfo fieldInfo)
        {
            DynamicMethod method = CreateSetDynamicMethod(type);
            ILGenerator iLGenerator = method.GetILGenerator();
            iLGenerator.Emit(OpCodes.Ldarg_0);
            iLGenerator.Emit(OpCodes.Ldarg_1);
            UnboxIfNeeded(fieldInfo.FieldType, iLGenerator);
            iLGenerator.Emit(OpCodes.Stfld, fieldInfo);
            iLGenerator.Emit(OpCodes.Ret);
            return (SetHandler)method.CreateDelegate(typeof(SetHandler));
        }

        internal static SetHandler CreateSetHandler(Type type, PropertyInfo propertyInfo)
        {
            MethodInfo setMethod = propertyInfo.GetSetMethod(true);
            DynamicMethod method = CreateSetDynamicMethod(type);
            ILGenerator iLGenerator = method.GetILGenerator();
            iLGenerator.Emit(OpCodes.Ldarg_0);
            iLGenerator.Emit(OpCodes.Ldarg_1);
            UnboxIfNeeded(setMethod.GetParameters()[0].ParameterType, iLGenerator);
            iLGenerator.Emit(OpCodes.Call, setMethod);
            iLGenerator.Emit(OpCodes.Ret);
            return (SetHandler)method.CreateDelegate(typeof(SetHandler));
        }

        private static void UnboxIfNeeded(Type type, ILGenerator generator)
        {
            if (type.IsValueType)
            {
                generator.Emit(OpCodes.Unbox_Any, type);
            }
        }
    }
}
