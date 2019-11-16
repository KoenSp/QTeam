using System;
using System.Collections.Generic;
using System.Text;
using QTeam_DAL.Models;

namespace QTeam_DAL.Helpers
{
    public class QTeamForm_DAL : IQTeamForm_DAL
    {
        private QTeamContext context = new QTeamContext(); 

        public QTeamForm_DAL()
        {
            context.Database.EnsureCreated(); 
        }
        public QTeamForm_DAL(QTeamContext _context)
        {
            context = _context; 
        }
        public QTeamForm AddForm(QTeamForm qTeamForm)
        {
            context.QTeamFormDb.Add(qTeamForm);
            context.SaveChanges(); 
            return qTeamForm; 
        }

        public string IsWorking()
        {
            return "QTeamForm is working!"; 
        }
    }
}
