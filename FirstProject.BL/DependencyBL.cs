using FirstProject.BL.Service.PatientServices;
using Microsoft.Extensions.DependencyInjection;

namespace FirstProject.BL
{
    public static class DependencyBL
    {
        public static void AddBussinesLogin(this IServiceCollection services)
        {
            services.AddScoped<IPatientService , PatientService>();
        }
    }
}
