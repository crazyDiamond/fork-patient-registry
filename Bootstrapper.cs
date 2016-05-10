using Nancy;
using Nancy.Conventions;
 
namespace NancyAdminConsole
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("content"));
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Views"));
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("bower_components"));
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("fontsfonts"));
            base.ConfigureConventions(nancyConventions);
        }
    }
}