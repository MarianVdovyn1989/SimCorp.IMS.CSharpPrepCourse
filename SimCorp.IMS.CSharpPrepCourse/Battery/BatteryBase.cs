using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public abstract class BatteryBase
    {
        #region Constructor
        public BatteryBase(int? capacity, string manufacturer)
        {
            Capacity = capacity;
            Manufacturer = manufacturer;
        }
        #endregion
        #region Properties
        public int? Capacity { get; private set; } = null; //def value

        private string _manufacturer; 
        public string Manufacturer
        {
            get { return _manufacturer; }

            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _manufacturer = "Unknown but very reliable"; //def value;

                }
                else
                {
                    _manufacturer = value;
                }
            }
        }
        #endregion

        #region Methods
        public override abstract string ToString();
        #endregion
    }
}
