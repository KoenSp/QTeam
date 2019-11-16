using System;
using System.Collections.Generic;
using System.Text;
using QTeam_DTO;
using QTeam_DAL; 
using QTeam_DAL.Models;
using AutoMapper; 

namespace QTeam_BLL.Helpers
{
    class QTeamForm_BLL : IQTeamForm_BLL
    {
        private readonly IQTeamForm_DAL qTeamForm_DAL; 
        public QTeamForm_BLL(IQTeamForm_DAL _qTeamForm_DAL)
        {
            qTeamForm_DAL = _qTeamForm_DAL; 
        }
        public QTeamForm_BLL() { }
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<QTeamForm_DTO, QTeamForm>();
            cfg.CreateMap<QTeamForm, QTeamForm_DTO>();
        }));

        public string IsWorking()
        {
            return qTeamForm_DAL.IsWorking(); 
        }
        public QTeamForm_DTO AddForm(QTeamForm_DTO qTeam_DTO)
        {
            var result = qTeamForm_DAL.AddForm(mapper.Map<QTeamForm_DTO, QTeamForm>(qTeam_DTO));
            var returnResult = mapper.Map<QTeamForm, QTeamForm_DTO>(result); 
            return returnResult;  
        }
    }
}
