using Competition_PRO.Data;
using Competition_PRO.Data.Models;
using Competition_PRO.Models;
using Competition_PRO.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Controllers
{
    public class LeaderboardController : Controller
    {
        public IActionResult Mechanic()
        {
            return this.View();
        }
    }
}
