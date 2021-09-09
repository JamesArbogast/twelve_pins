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
      
      [HttpPost("/league/join/")]
      public IActionResult JoinLeague (LeagueMember newLeagueMember)
      {
        if (!isLoggedIn)
        {
          return View("LoginReg");
        }
        newLeagueMember.UserId = (int)uid;
        db.LeagueMembers.Add(newLeagueMember);
        db.SaveChanges();

        return RedirectToAction("Index");
      }

      [HttpGet("/league/new")]
        public IActionResult CreateLeague()
        {
          return View();
        }

        [HttpPost("/league/create")]
        public IActionResult Create(League newLeague)
        {
            if (ModelState.IsValid == false)
            {
                return View("CreateLeague");
            }

            db.Leagues.Add(newLeague);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
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
    }
}

