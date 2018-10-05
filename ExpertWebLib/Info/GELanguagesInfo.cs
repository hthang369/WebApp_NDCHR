using System;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region GELanguages
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: GELanguagesInfo
    //Created Date: Friday, 03 Aug 2018
    //-----------------------------------------------------------

    public class GELanguagesInfo : BusinessObject
    {
        public GELanguagesInfo()
        {
        }
        #region Variables
        protected int _gELanguageID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _gELanguageNo = String.Empty;
        protected String _gELanguageCultur = String.Empty;
        protected String _gELanguageName = String.Empty;
        protected String _gELanguageDesc = String.Empty;
        
        #endregion

        #region Public properties
        public int GELanguageID
        {
            get { return _gELanguageID; }
            set
            {
                if (value != this._gELanguageID)
                {
                    _gELanguageID = value;
                    NotifyChanged("GELanguageID");
                }
            }
        }
        public String AAStatus
        {
            get { return _aAStatus; }
            set
            {
                if (value != this._aAStatus)
                {
                    _aAStatus = value;
                    NotifyChanged("AAStatus");
                }
            }
        }
        public String GELanguageNo
        {
            get { return _gELanguageNo; }
            set
            {
                if (value != this._gELanguageNo)
                {
                    _gELanguageNo = value;
                    NotifyChanged("GELanguageNo");
                }
            }
        }
        public String GELanguageCultur
        {
            get { return _gELanguageCultur; }
            set
            {
                if (value != this._gELanguageCultur)
                {
                    _gELanguageCultur = value;
                    NotifyChanged("GELanguageCultur");
                }
            }
        }
        public String GELanguageName
        {
            get { return _gELanguageName; }
            set
            {
                if (value != this._gELanguageName)
                {
                    _gELanguageName = value;
                    NotifyChanged("GELanguageName");
                }
            }
        }
        public String GELanguageDesc
        {
            get { return _gELanguageDesc; }
            set
            {
                if (value != this._gELanguageDesc)
                {
                    _gELanguageDesc = value;
                    NotifyChanged("GELanguageDesc");
                }
            }
        }
        
        #endregion
    }
    #endregion
}