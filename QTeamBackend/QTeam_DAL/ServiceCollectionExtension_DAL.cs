using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using QTeam_DAL.Helpers;

namespace QTeam_DAL
{
    public static class ServiceCollectionExtension_DAL
    {
        public static void AddServiceCollectionDAL(this IServiceCollection services)
        {
            services.AddScoped<IQTeamForm_DAL, QTeamForm_DAL>();
            QTeamContext context;
            DbInitializer.Initialize(context = new QTeamContext()); 
        }
    }
}
