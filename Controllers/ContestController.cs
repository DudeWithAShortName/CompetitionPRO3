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
    public class ContestController : Controller
    {
        private readonly IContestService service;
        private readonly ApplicationDbContext db;


        public ContestController(IContestService service, ApplicationDbContext db)
        {
            this.service = service;
            this.db = db;
        }
        public IActionResult ListovkiTest()
        {
            var viewModel = new ListovkiAllInputModel
            {
                ListovkiInputModels = this.service.GetAllParticipants(),
            };
            return this.View(viewModel);
        }
        [HttpPost]
        public IActionResult ListovkiTest(ListovkiAllInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ListovkiAllInputModel
                {
                    ListovkiInputModels = this.service.GetAllParticipants(),
                };
                return View(viewModel);
            }
            foreach (var item in inputModel.ListovkiInputModels)
            {
                var teamParticipants = new TheoryTest
                {
                    PointsMPS = item.Points,
                };
            }
            return this.View(inputModel);
        }
        public IActionResult WorkPost1()
        {
            return this.View();
        }
        public IActionResult WorkPost(int id = 1)
        {

            var model = new WorkPostInputModel
            {
                PostNumber = id,
                JuryMemberId = 1,
                Participants = this.service.GetTeamMechanics(1),
                TeamNumber = 1,
                TeamName = this.db.Teams.Where(x => (x.Number == 1)).FirstOrDefault().ShortName

            };
            return this.View(model);
        }

        [HttpPost]
        public IActionResult WorkPost(WorkPostInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }
            foreach (var item in model.Participants)
            {
                var participant = new MechanicPrimary
                {
                    TeamParticipantId = item.Id,
                    WorkPostId = model.PostNumber,
                    //  JuryMemberId = model.JuryMemberId,
                    JuryMemberId = 1,
                    Points = this.service.PointsToString(item.Points)
                };
                this.db.MechanicPrimaries.Add(participant);
            }
            this.db.SaveChanges();
            return this.Redirect("/");
        }
    }
}
