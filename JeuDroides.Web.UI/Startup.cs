using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JeuAttaqueDesClones.Models;
using JeuDroides.Web.UI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JeuDroides.Web.UI
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
            services.Configure<CookiePolicyOptions>(options => {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            Famille maFamille = new Famille() {
                Libelle = "Les chewies"
            };

            // Simule l'appel à la base de données (sql serveur, ou api)
            List<Wookie> wookies = new List<Wookie>() {
                new Wookie() {
                    Id = 1,
                    Nom = "DIWILKP",
                    Prenom = "Chewie",
                    MaFamille = maFamille,
                    MesCombats = new List<Combat>()
                },
                new Wookie() {
                    Id = 2,
                    Nom = "DIWILKP",
                    Prenom = "Chouk",
                    MaFamille = maFamille,
                    MesCombats = new List<Combat>()
                },
                new Wookie() {
                    Id = 3,
                    Nom = "DIWILKP",
                    Prenom = "TIFFFF",
                    MaFamille = maFamille
                }
            };

            wookies[0].MesCombats.Add(new Combat() {
                LeWookie = wookies[0],
                LeDroide = new Clone() { Nom = "Toto" },
                Date = DateTime.Now,
                WookieGagnant = true
            });

            wookies[1].MesCombats.Add(new Combat() {
                LeWookie = wookies[1],
                LeDroide = new Clone() { Nom = "Toto" },
                Date = DateTime.Now
            });

            wookies[1].MesCombats.Add(new Combat() {
                LeWookie = wookies[1],
                LeDroide = new Clone() { Nom = "Gros minet" },
                Date = DateTime.Now.AddDays(-30),
                WookieGagnant = true
            });
            MaFausseBaseDeDonnees.WookieList = wookies;


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
