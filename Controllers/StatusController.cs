using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StatusAPI.FiberConnection;
using StatusAPI.Service;

namespace StatusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(StatusController));
        private readonly IStatusServ<Status> s_serv;

        public StatusController(IStatusServ<Status> _s_serv)
        {
            s_serv = _s_serv;
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteStatus(int id)
        {
            return Ok(await s_serv.DeleteStatus(id));
        }
        [HttpGet]
        [Route("AllStatus/{id}")]
        public async Task<IActionResult> GetAllStatus(int id)
        {
            _log4net.Info($"Getting All Status from the User {id}");
            return Ok(await s_serv.GetAllStatus(id));
        }
        [HttpGet]
        [Route("StatusById/{id}")]
        public async Task<IActionResult> GetStatusByID(int id)
        {
            _log4net.Info($"Getting the Status by {id}");
            return Ok(await s_serv.GetStatusByID(id));
        }
        [HttpPut]
        public async Task<IActionResult> EditStatus(int id,Status s)
        {
            _log4net.Info($"Editing the Status from {id}");
            return Ok(await s_serv.EditStatus(s));
        }
        [HttpGet]
        [Route("AllStatus")]
        public async Task<IActionResult> AllStatus()
        {
            _log4net.Info($"Getting all the Status");
            return Ok(await s_serv.AllStatus());
        }
    }
}
