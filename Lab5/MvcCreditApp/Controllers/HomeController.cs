using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using MvcCreditApp.Models;
using System.Diagnostics;

namespace MvcCreditApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly CreditContext db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, CreditContext db)
        {
            _logger = logger;
            this.db = db;
        }

        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>();
            ViewBag.Credits = allCredits;
        }
        public IActionResult Index()
        {
            GiveCredits();
            return View();
        }


        [HttpGet]
        public ActionResult CreateBid()
        {

            GiveCredits();
            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;
            return View();
        }

        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
            // ��������� ����� ������ � ��
            db.Bids.Add(newBid);
            // ��������� � �� ��� ���������
            db.SaveChanges();
            return "�������, " + newBid.Name + ", �� ����� ������ �����.���� ������ ����� ����������� � ������� 10 ����.";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult BidSearch(string name)
        {
           var allBids = db.Bids.Where(a =>
           a.CreditHead.Contains(name)).ToList();
            if (allBids.Count == 0)
            {
                return Content("��������� ������ " + name + " �� ������");
            }
            return PartialView(allBids);
        }

    }
}
