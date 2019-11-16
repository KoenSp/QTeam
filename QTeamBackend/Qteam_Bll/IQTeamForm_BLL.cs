using System;
using System.Collections.Generic;
using System.Text;
using QTeam_DTO; 

namespace QTeam_BLL
{
    public interface IQTeamForm_BLL
    {
        String IsWorking(); 
        QTeamForm_DTO AddForm(QTeamForm_DTO qTeam_DTO); 
    }
}
