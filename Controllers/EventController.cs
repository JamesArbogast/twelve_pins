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

      [HttpPost("/reserve/lane/{laneId}")]
      public IActionResult ReserveLane(int laneId, ReservedLane reservedLane)
      {
        if (!isLoggedIn)
        {
            return RedirectToAction("LoginReg", "Home");
        }

        ReservedLane existingReservedLane = db.ReservedLanes
            .FirstOrDefault(p => p.UserId == (int)uid && p.LaneId == laneId);

        if (existingReservedLane == null)
        {
            reservedLane.UserId = (int)uid;

            db.ReservedLanes.Add(reservedLane);
        }
        else
        {
          db.ReservedLanes.Remove(existingReservedLane);
        }

        db.SaveChanges();
        return RedirectToAction("Index", "Home");
      }
    }
}

