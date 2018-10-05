using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertWebLib
{
    [Serializable]
    public class BusinessObject : ICloneable, INotifyPropertyChanged
    {
        public static readonly string DefaultString = "---";
        public const int DefaultNumber = 0;
        public static readonly DateTime DefaultInactiveDate = DateTime.MaxValue;
        public static readonly DateTime DefaultDate = DateTime.Now;
        public static readonly string DefaultStatus = "New";
        public static readonly string DefaultAAStatus = "Alive";
        public static readonly string DeletedAAStatus = "Delete";
        public static readonly string TemplateAAStatus = "Template";
        public static readonly string DefaultActive = "true";
        public string TableName = string.Empty;
        public bool IsItemEntity = false;
        public object ItemEntity;
        public List<BusinessRule> BusinessRuleCollections = new List<BusinessRule>();
        public int _position;
        public int _relatedPosition;
        protected bool _allowPropertyChangedEvent = true;

        [field: CompilerGenerated, DebuggerBrowsable(0)]
        public event PropertyChangedEventHandler PropertyChanged;

        protected string CleanString(string s)
        {
            return (s ?? string.Empty).Trim();
        }

        public object Clone()
        {
            BusinessObject obj2 = (BusinessObject)base.MemberwiseClone();
            obj2.TableName = this.TableName;
            return obj2;
        }

        public object Clone(Type destType)
        {
            if (destType == base.GetType())
            {
                return base.MemberwiseClone();
            }
            Type type = base.GetType();
            object obj2 = Activator.CreateInstance(destType);
            PropertyInfo[] properties = destType.GetProperties();
            foreach (PropertyInfo info in properties)
            {
                PropertyInfo property = type.GetProperty(info.Name);
                if (property != null)
                {
                    object obj4 = DynamicInvoker.DynamicGetValue(this, property);
                    info.SetValue(obj2, obj4, null);
                }
            }
            return obj2;
        }

        public virtual List<BusinessRule> CreateRules()
        {
            return new List<BusinessRule>();
        }

        public virtual ReadOnlyCollection<BusinessRule> GetBrokenRules(string property)
        {
            property = this.CleanString(property);
            if (this.BusinessRuleCollections == null)
            {
                this.BusinessRuleCollections = new List<BusinessRule>();
                this.BusinessRuleCollections.AddRange(this.CreateRules());
            }
            List<BusinessRule> list = new List<BusinessRule>();
            foreach (BusinessRule rule in this.BusinessRuleCollections)
            {
                if (((rule.PropertyName == property) || (property == string.Empty)) && !rule.ValidateRule(this))
                {
                    list.Add(rule);
                }
            }
            return list.AsReadOnly();
        }

        protected BusinessRule GetBusinessRule(string propertyName)
        {
            BusinessRule rule = new BusinessRule();
            foreach (BusinessRule rule2 in this.BusinessRuleCollections)
            {
                if (rule2.PropertyName == propertyName)
                {
                    return rule2;
                }
            }
            return rule;
        }

        public void GetFromBusinessObject(BusinessObject objBusinessObject)
        {
            PropertyInfo[] properties = objBusinessObject.GetType().GetProperties();
            foreach (PropertyInfo info in properties)
            {
                PropertyInfo property = base.GetType().GetProperty(info.Name);
                if (property != null)
                {
                    object obj2 = info.GetValue(objBusinessObject, null);
                    property.SetValue(this, obj2, null);
                }
            }
        }

        protected virtual void NotifyChanged(params string[] propertyNames)
        {
            if (this.PropertyChanged != null)
            {
                foreach (string str in propertyNames)
                {
                    this.OnPropertyChanged(new PropertyChangedEventArgs(str));
                }
            }
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, e);
            }
        }

        public void RaiseEvent(EventHandler handler, EventArgs e)
        {
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public BusinessObject SetToBusinessObject(string strBusinessObjectName)
        {
            BusinessObject businessObject = BusinessObjectFactory.GetBusinessObject(strBusinessObjectName + "Info");
            PropertyInfo[] properties = businessObject.GetType().GetProperties();
            foreach (PropertyInfo info in properties)
            {
                PropertyInfo property = base.GetType().GetProperty(info.Name);
                if (property != null)
                {
                    object obj3 = property.GetValue(this, null);
                    info.SetValue(businessObject, obj3, null);
                }
            }
            return businessObject;
        }

        public bool AllowPropertyChangedEvent
        {
            get
            {
                return this._allowPropertyChangedEvent;
            }
            set
            {
                this._allowPropertyChangedEvent = value;
            }
        }

        public int Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }

        public int RelatedPosition
        {
            get
            {
                return this._relatedPosition;
            }
            set
            {
                this._relatedPosition = value;
            }
        }

        public delegate void EventHandler(object sender, EventArgs e);

        public enum ObjectStatus
        {
            New,
            Alive,
            Delete
        }
    }
    public class BusinessObjectFactory
    {
        public static BusinessObject GetBusinessObject(string strBusinessObjectName)
        {
            BusinessObject businessObjectInAppDomain = null;
            try
            {
                businessObjectInAppDomain = (BusinessObject)DynamicInvoker.DynamicCreateInstanceObject(Assembly.LoadFrom(Application.StartupPath + @"\ExpertERP.BusinessEntities.dll").GetType("ExpertERP.BusinessEntities." + strBusinessObjectName));
            }
            catch (Exception)
            {
                Type type = Assembly.GetExecutingAssembly().GetType("ExpertLib." + strBusinessObjectName);
                if (type != null)
                {
                    businessObjectInAppDomain = (BusinessObject)DynamicInvoker.DynamicCreateInstanceObject(type);
                }
            }
            if (businessObjectInAppDomain == null)
            {
                businessObjectInAppDomain = GetBusinessObjectInAppDomain(strBusinessObjectName);
            }
            return businessObjectInAppDomain;
        }

        public static BusinessObject GetBusinessObjectInAppDomain(string strBusinessObjectName)
        {
            Type typeObj = null;
            try
            {
                Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
                foreach (Assembly assembly in assemblies)
                {
                    typeObj = assembly.GetType("ExpertERP.BusinessEntities." + strBusinessObjectName, false, true);
                    if (typeObj != null)
                    {
                        break;
                    }
                }
                return (BusinessObject)DynamicInvoker.DynamicCreateInstanceObject(typeObj);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Type GetBusinessObjectType(string strBusinessObjectName)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Assembly assembly2 = Assembly.LoadFrom(Application.StartupPath + @"\ExpertERP.BusinessEntities.dll");
            try
            {
                Type type = assembly2.GetType(assembly2.GetName().Name + "." + strBusinessObjectName);
                if (type != null)
                {
                    return type;
                }
                Type type3 = executingAssembly.GetType("ExpertLib." + strBusinessObjectName);
                if (type3 != null)
                {
                    return type3;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
    public class BusinessRule
    {
        private string _description;
        private string _propertyName;
        private RuleDelegate _ruleDelegate;

        public BusinessRule()
        {
        }

        public BusinessRule(string propertyName, string brokenDescription, RuleDelegate ruleDelegate)
        {
            this.Description = brokenDescription;
            this.PropertyName = propertyName;
            this.RuleDelegate = ruleDelegate;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return this.Description;
        }

        public bool ValidateRule(BusinessObject domainObject)
        {
            return this.RuleDelegate(this.PropertyName);
        }

        public virtual string Description
        {
            get
            {
                return this._description;
            }
            protected set
            {
                this._description = value;
            }
        }

        public virtual string PropertyName
        {
            get
            {
                return (this._propertyName ?? string.Empty).Trim();
            }
            protected set
            {
                this._propertyName = value;
            }
        }

        public virtual RuleDelegate RuleDelegate
        {
            get
            {
                return this._ruleDelegate;
            }
            set
            {
                this._ruleDelegate = value;
            }
        }
    }
    public delegate bool RuleDelegate(string propertyName);
}
