using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using QTeam_BLL.Helpers;
using QTeam_DAL; 

namespace QTeam_BLL
{
    public static class ServiceCollectionExtension_BLL
    {
        public static void AddServiceCollectionBLL(this IServiceCollection services)
        {
            services.AddScoped<IQTeamForm_BLL, QTeamForm_BLL>();
            services.AddServiceCollectionDAL(); 
        }
    }
}
