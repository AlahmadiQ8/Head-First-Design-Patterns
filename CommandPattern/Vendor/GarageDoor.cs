namespace CommandPattern.Vendor
{
    public class GarageDoor : Device
    {
        public void Up()
        {
            LogAction(GetCaller());
        }

        public void Down()
        {
            LogAction(GetCaller());
        }
        
        public void Stop()
        {
            LogAction(GetCaller());
        }
        
        public void LightOn()
        {
            LogAction(GetCaller());
        }
        
        public void LightOff()
        {
            LogAction(GetCaller());
        }

        public GarageDoor(string name) : base(name)
        {
        }
    }
}