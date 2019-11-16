using System;
using System.Collections.Generic;
using System.Text;
using QTeam_DAL.Models; 

namespace QTeam_DAL
{
    public interface IQTeamForm_DAL
    {
        string IsWorking(); 
        QTeamForm AddForm(QTeamForm qTeamForm); 
    }
}
