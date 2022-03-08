using Competition_PRO.Data;
using Competition_PRO.Data.Models;
using Competition_PRO.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Controllers
{
    public class TeamController : Controller
    {
        private readonly ApplicationDbContext db;
        private enum Role { mechanic1, mechanic2, driver, leader };
        private Role role;

        public TeamController(ApplicationDbContext db)
        {
            this.db = db;
        }
        //https://nicepage.com/templates/preview/dining-on-the-lake-91384?device=desktop
        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Create(TeamInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }
            Team team = new Team { ShortName = input.ShortSchoolName };
            int index = 1;
            foreach (var item in input.Names)
            {
                switch (index)
                {
                    case 1: role = Role.mechanic1; break;
                    case 2: role = Role.mechanic2; break;
                    case 3: role = Role.driver; break;
                    default: break;
                }
                team.TeamParticipants.Add(new TeamParticipant
                {
                    Name = item,
                    Role = (int)role,
                });
                index++;
            }
            team.TeamParticipants.Add(new TeamParticipant
            {
                Name = input.LeaderName,
                Role = (int)Role.leader,
            });

            this.db.Teams.Add(team);
            this.db.SaveChanges();
            return this.Redirect("/");

        }
    }
}
