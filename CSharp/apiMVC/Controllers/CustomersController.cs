using System;
using System.Collections.Generic;
using apiMVC.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiMVC.Controllers
{

     public class Auto
    {
        public string Väri { get; set; }
        public int Huippunopeus { get; set; }
    }
       

    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public List<Customers>  ListaaKaikki() 
        {
            NorthwindContext context = new NorthwindContext();
            List<Customers> kaikki = context.Customers.ToList();
            return kaikki;
        }
    
    }
}