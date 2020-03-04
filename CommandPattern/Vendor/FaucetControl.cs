namespace CommandPattern.Vendor
{
    public class FaucetControl : Device
    {
        public void OpenValve()
        {
            LogAction(GetCaller());
        }

        public void CloseValve()
        {
            LogAction(GetCaller());
        }

        public FaucetControl(string name) : base(name)
        {
        }
    }
}