using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QTeam_DTO;
using QTeam_BLL; 


namespace QTeamBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QTeamFormController : ControllerBase
    {
        private readonly IQTeamForm_BLL qTeamForm_BLL; 
        public QTeamFormController(IQTeamForm_BLL _qTeamForm_BLL)
        {
            qTeamForm_BLL = _qTeamForm_BLL; 
        }
        [HttpGet]
        public String IsWorking()
        {
            return qTeamForm_BLL.IsWorking(); 
        }
        [HttpPost]
        public IActionResult AddForm(QTeamForm_DTO qTeam_DTO)
        {
            return Ok(qTeamForm_BLL.AddForm(qTeam_DTO));   
        }
    }
}