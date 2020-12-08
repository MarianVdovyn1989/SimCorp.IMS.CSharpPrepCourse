namespace SimCorp.IMS.CSharpPrepCourse.BL.MobileComponentFactory
{
    public class FactoryOutput
    {
        public FactoryOutput(object mobileComponent)
        {
            _mobileComponent = mobileComponent;
        }
        private readonly object _mobileComponent;
        public object MobileComponent { get { return _mobileComponent; } }
    }
}
