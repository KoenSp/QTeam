using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 

namespace QTeam_DAL
{
    public class DbInitializer
    {
        public static void Initialize(QTeamContext qTeamContext)
        {
            qTeamContext.Database.EnsureCreated();
            qTeamContext.SaveChanges(); 
        }
    }
}
