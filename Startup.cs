using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.StaticFiles;
using Microsoft.AspNet.FileProviders;

using Nancy.Owin;

public class Startup
{        
    string WebRoot { get; set; }
    public Startup(IHostingEnvironment env)
    {
        // We can't use Server.MapPath so let's stash the WebRoot
        WebRoot = env.WebRootPath;
    }
 
    public void Configure(IApplicationBuilder app)
    {   
        var options = new FileServerOptions();
        options.EnableDefaultFiles = true;
        options.FileProvider = new PhysicalFileProvider(WebRoot);
        options.StaticFileOptions.FileProvider = options.FileProvider;
        options.StaticFileOptions.ServeUnknownFileTypes = true;
        options.DefaultFilesOptions.DefaultFileNames = new[] {"index.html"};
        app.UseFileServer(options);
 
        app.Map("/api", api=>{
            api.UseOwin(x => x.UseNancy());
        });            
    }
    
     public static void Main(string[] args) => Microsoft.AspNet.Hosting.WebApplication.Run<Startup>(args);
}
