namespace SimCorp.IMS.CSharpPrepCourse.BL.Battery
{
    public abstract class BatteryBase : IBattery
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
                    _manufacturer = "Unknown but very reliable"; //def value;
                else
                    _manufacturer = value;
            }
        }
        #endregion

        #region Methods
        public override abstract string ToString();

        public abstract void InstallBattery();
        #endregion
    }
}
