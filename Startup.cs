﻿namespace	BarDaGraça

public class Startup
{
	public Startup(IConfiguration configuration)
	{
		Configuration = configuration;
	}
	public IConfiguration Configuration { get;}

	public void ConfigureServices(IServiceColection services)
	{
        Services.AddControllersWithViews();
        services.AddMvc();
    }
	
	public void Configure(WebApplication app, IWebHostEnviroment enviroment)
	{
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    }
}
