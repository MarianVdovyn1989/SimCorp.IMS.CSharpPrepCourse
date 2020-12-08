using SimCorp.IMS.CSharpPrepCourse.BL;
using System;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class SimCorpMobile : MobilePhone
    {
        #region SingletonConstructor
        private SimCorpMobile()
        {
        }
        #endregion

        #region SingletonProperties
        //===============================================
        //Simple not thread safe Singleton
        //===============================================
        //private static  MobilePhone instance;
        //public static MobilePhone Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new SimCorpMobile();
        //        }
        //        return instance;
        //    }
        //}

        //===============================================
        //Thread safe Singleton that we use in SimCorp
        //more here https://csharpindepth.com/articles/singleton
        //===============================================
        private static readonly Lazy<MobilePhone>
            lazy =
            new Lazy<MobilePhone>
            (() => new SimCorpMobile());
        public static MobilePhone Instance { get { return lazy.Value; } }

        #endregion

        #region Properties

        #endregion
    }
}
