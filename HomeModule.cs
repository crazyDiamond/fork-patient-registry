namespace patient_registry
{
    using Nancy;
    
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["index.html"];
        }
    }
}
