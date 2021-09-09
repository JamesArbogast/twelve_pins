using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using twelve_pins.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace twelve_pins.Controllers
{
    public class EventController : Controller
    {

      private TwelvePinsContext db;

      public EventController(TwelvePinsContext context)
      {
          db = context;
      }

      private int? uid
      {
          get
          {
              return HttpContext.Session.GetInt32("UserId");
          }
      }

      private bool isLoggedIn
      {
          get
          {
              return uid != null;
          }
      }

        [HttpGet("/reserve/lane/")]
        public IActionResult ViewReserveLane()
        {
          ViewBag.Lanes = db.Lanes;
          return View("ReserveLane");
        }

      [HttpPost("/reserve/lane/")]
      public IActionResult ReserveLane(ReservedLane newReservedLane)
      {
        if (!isLoggedIn)
        {
          return RedirectToAction("LoginReg", "Home");
        }
        newReservedLane.UserId = (int)uid;
        db.ReservedLanes.Add(newReservedLane);
        db.SaveChanges();

        return RedirectToAction("Index", "Home");
      }
      
      [HttpPost("/league/join/{leagueId}")]
      public IActionResult JoinLeague (int leagueId)
      {
        List<League> allLeagues = db.Leagues
          .Include(j => j.LeagueMembers)
          .ToList();
          ViewBag.Leagues = db.Leagues;
          ViewBag.AllLeagues = allLeagues;

        LeagueMember existingLeagueMember = db.LeagueMembers
          .FirstOrDefault(j => j.UserId == (int)uid && j.LeagueId == leagueId);

        if (!isLoggedIn)
        {
          return View("LoginReg");
        }

        if(existingLeagueMember == null)
        {
          LeagueMember newLM = new LeagueMember()
          {
            LeagueId = leagueId,
            UserId = (int)uid
          };
          db.LeagueMembers.Add(newLM);
        }
        else
        {
          db.LeagueMembers.Remove(existingLeagueMember);
        }

        db.SaveChanges();

        return View("LeaguePage");
      }

      [HttpGet("/league/new")]
        public IActionResult CreateLeague()
        {
          return View();
        }

        [HttpPost("/league/create")]
        public IActionResult CreateLeague(League newLeague)
        {
            if (ModelState.IsValid == false)
            {
              return View("CreateLeague");
            }

            db.Leagues.Add(newLeague);
            db.SaveChanges();

            return View("Admin");
        }

        [HttpPost("/lane/create")]
        public IActionResult CreateLane(Lane newLane)
        {
            if (ModelState.IsValid == false)
            {
                return View("Admin");
            }

            db.Lanes.Add(newLane);
            db.SaveChanges();

            return View("Admin");
        }

        [HttpGet("/admin")]
        public IActionResult Admin()
        {
            return View ("Admin");
        }

        [HttpGet("/league/page")]
        public IActionResult LeaguePage()
        {
          List<League> allLeagues = db.Leagues
          .Include(j => j.LeagueMembers)
          .ToList();
          ViewBag.Leagues = db.Leagues;
          ViewBag.AllLeagues = allLeagues;
          return View("LeaguePage");
        }
        
        [HttpGet("/about/page")]
        public IActionResult About()
        {
          return View();
        }

        [HttpGet("/specials/page")]
        public IActionResult Specials()
        {
          return View();
        }

        [HttpGet("/shop/page")]
        public IActionResult Shop()
        {
          return View();
        }

        [HttpGet("/eat")]
        public IActionResult EatPage()
        {
          return View();
        }

        

    }
}

