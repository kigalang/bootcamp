using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [Route ("moi")]
        public string SanoMoi()
        {
        return "Moikka!";    
        }
        
        [Route ("hei")]
        public string SanoHei()
        {
        return "Heippa!";
        }

        [Route ("number")]
        public int Num()
        {
            int i = 200;
            return i;    
        }

    }
}