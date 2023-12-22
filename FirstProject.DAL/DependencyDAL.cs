using FirstProject.DAL.DB;
using FirstProject.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.DAL
{
    public static class DependencyDAL
    {
        public static void AddDataAccessLayer(this IServiceCollection services,IConfiguration configuration )
        {
            services.AddDbContext<HospitalDB>(options => options.UseSqlServer(configuration.GetConnectionString("conn")));
            services.AddScoped<IpatientRepository, PatientRepository>();
        }
    }
}
