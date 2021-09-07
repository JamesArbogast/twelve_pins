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

namespace CSharpExam.Controllers
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
          ViewBag.Leagues = db.Leagues;
          return View("LeaguePage");
        }
    }
}

