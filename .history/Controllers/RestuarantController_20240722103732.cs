using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Collection.Data;

namespace Restaurant_Collection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestuarantController : Controller
    {
        private readonly IRestaurantService _service ;

        public RestuarantController (IRestaurantService service)

    }
}