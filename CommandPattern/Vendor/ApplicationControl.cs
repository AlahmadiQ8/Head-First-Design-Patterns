namespace CommandPattern.Vendor
{
    public class ApplicationControl : Device
    {
        public void On()
        {
            LogAction(GetCaller());
        }

        public void Off()
        {
            LogAction(GetCaller());
        }

        public ApplicationControl(string name) : base(name)
        {
        }
    }
}