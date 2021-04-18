using ArtComissions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.AccountProcessor;

namespace ArtComissions.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(AccountModel account)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateAccount(account.FirstName, account.LastName, account.Email);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult ListAccount()
        {
            var data = LoadAccounts();
            List<AccountModel> accounts = new List<AccountModel>();

            foreach (var row in data)
            {
                accounts.Add(new AccountModel
                {
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    Email = row.Email,
                    ConfirmEmail = row.Email
                });
            }

            return View(accounts);
        }
    }
}