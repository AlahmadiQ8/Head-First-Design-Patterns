namespace CommandPattern.Vendor
{
    public class Stereo : Device
    {
        public void On()
        {
            LogAction(GetCaller());
        }

        public void Off()
        {
            LogAction(GetCaller());
        }

        public void SetCd()
        {
            LogAction(GetCaller());
        }

        public void SetDvd()
        {
            LogAction(GetCaller());
        }

        public void SetRadio()
        {
            LogAction(GetCaller());
        }

        public void SetVolume()
        {
            LogAction(GetCaller());
        }

        public Stereo(string name) : base(name)
        {
        }
    }
}