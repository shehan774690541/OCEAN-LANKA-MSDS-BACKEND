using Microsoft.AspNetCore.Mvc;
using ocl_msds.Helpers.Responces;
using ocl_msds.Services.Msds;
using ocl_msds.Helpers.Requests;
using ocl_msds.Helpers.Requests.Msds;


namespace ocl_msds.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MsdsController : ControllerBase
    {
        public IMsdsService msdsService;
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment env;

        public MsdsController(IMsdsService msdsService, IConfiguration configuration, IWebHostEnvironment env)
        {
            this.msdsService = msdsService;
            this.configuration = configuration;
            this.env = env;
        }

        [HttpGet("conn")]
        public BaseResponce connection()
        {
            return new BaseResponce
            {
                data = "",
                status_code = 200
            };
        }

        [HttpPost("list/{i}")]
        public BaseResponce ListByIthem(int i)
        {
            return msdsService.ListByIthem(i);
        }

        [HttpPost("list")]
        public BaseResponce ListAll()
        {
            return msdsService.ListAll();
        }

        [HttpPost("create")]
        public BaseResponce CreateMsds(CreateMSDSRequest r)
        {
            return msdsService.CreateMsds(r);
        }

        [HttpPost("edit")]
        public BaseResponce EditMsds(EditMSDSRequest r)
        {
            return msdsService.EditMsds(r);
        }

        [HttpPost("delete")]
        public BaseResponce DeleteMsds(int id)
        {
            return msdsService.DeleteMsds(id);
        }
    }
}
