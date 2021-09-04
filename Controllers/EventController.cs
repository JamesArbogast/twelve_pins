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
          return View("ReserveLane");
        }

      [HttpPost("/reserve/lane/{laneId}")]
      public IActionResult ReserveLane(int laneId)
      {
        if (!isLoggedIn)
        {
            return RedirectToAction("LoginReg", "Home");
        }

        ReservedLane existingReservedLane = db.ReservedLanes
            .FirstOrDefault(p => p.UserId == (int)uid && p.LaneId == laneId);

        if (existingReservedLane == null)
        {
            ReservedLane reservedLane = new ReservedLane()
            {
                LaneId = laneId,
                UserId = (int)uid
            };

            db.ReservedLanes.Add(reservedLane);
        }
        else
        {
          db.ReservedLanes.Remove(existingReservedLane);
        }

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

            // Every time a form is submitted, check the validations.
            if (ModelState.IsValid == false)
            {
                // Go back to the form so error messages are displayed.
                return View("CreateLeague");
            }


            // If any above custom errors were added, ModelState would now be invalid.

            // HttpContext.Session.SetString("NameOne", newWedding.NameOne);
            // newLeague.UserId = (int)uid;
            db.Leagues.Add(newLeague);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}

