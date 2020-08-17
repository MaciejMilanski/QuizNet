using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using QuizNet.BusinessLogic;
using QuizNet.BusinessLogic.Interfaces;
using QuizNet.DataAccess;
using AutoMapper;
using QuizNet.BusinessLogic.Mapper;

namespace QuizNet
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
            services.AddDbContext<DatabaseContext>
                (options => options.UseSqlServer("server = (LocalDB)\\MSSQLLocalDB; database = QuizNet; Trusted_Connection = true; MultipleActiveResultSets = true;"));

            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IQuestionsRepository, QuestionsRepository>();
            services.AddScoped<IAnswersRepository, AnswersRepository>();
            services.AddScoped<IQuizService, QuizService>();
            services.AddScoped<IQuestionsService, QuestionsService>();
            services.AddControllersWithViews();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
