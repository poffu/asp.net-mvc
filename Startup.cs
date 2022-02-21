using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace LabeledData
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
			services.AddDistributedMemoryCache();

			services.AddSession(option =>
			{
				option.Cookie.Name = "LabeledData";
				option.IdleTimeout = TimeSpan.FromMinutes(15);
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseSession();
			app.UseHttpsRedirection();

			DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
			defaultFilesOptions.DefaultFileNames.Clear();
			defaultFilesOptions.DefaultFileNames.Add("");
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Login}/{action=Index}/{id?}");

				endpoints.MapControllerRoute(
					name: "EditData",
					pattern: "{controller=EditData}/{action=Index}");

				endpoints.MapControllerRoute(
					name: "AddData",
					pattern: "{controller=AddData}/{action=Index}");

				endpoints.MapControllerRoute(
					name: "ChangePassword",
					pattern: "{controller=ChangePassword}/{action=Index}");

				endpoints.MapControllerRoute(
					name: "ListData",
					pattern: "{controller=ListData}/{action=Index}");

				endpoints.MapControllerRoute(
					name: "Login",
					pattern: "{controller=Login}/{action=Index}");

				endpoints.MapControllerRoute(
					name: "SystemError",
					pattern: "{controller=SystemError}/{action=Index}");
			});
		}
	}
}
