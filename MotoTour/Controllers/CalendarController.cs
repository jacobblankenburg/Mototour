using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DayPilot.Web.Mvc;
using DayPilot.Web.Mvc.Enums;
using DayPilot.Web.Mvc.Events.Calendar;

public class CalendarController : Controller
{

    //
    // GET: /Calendar/
    public ActionResult Index()
    {
        return View();
    }
}