using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using System.Windows;
using System.IO;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }
    }


    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);

            

            // Set a variable to the Documents path.
            //string docPath = Server.MapPath("/signalr");
            
            // Append text to an existing file named "WriteLines.txt".
            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "hubs.txt"), true))
            //{
            //    outputFile.WriteLine("Fourth Line");
            //}
        }
    }
}