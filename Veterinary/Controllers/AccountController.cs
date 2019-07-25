﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Veterinary.Models;

namespace Veterinary.Controllers
{
    public class AccountController : BaseController
    {




        public ActionResult Login()
        {
            return View();
        }
        



        public ActionResult LogOut()
        {

            Session.Clear();
            System.Web.HttpContext.Current.Session.RemoveAll();
            return RedirectToAction("Login");
        }






        public ActionResult Registration()
        {
            return View();
        }



        //  შესვლა
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (String.IsNullOrEmpty(loginViewModel.Email) || String.IsNullOrEmpty(loginViewModel.Password))
            {
                ViewBag.Error = "შეავსეთ გამოტოვებული ველები !";
                return View();
            }

            string password = Helper.ComputeSha256Hash(loginViewModel.Password + Helper.AuthKey);
            var User = db.ConfirmedUsers.FirstOrDefault(x => x.Email == loginViewModel.Email && x.Password == password);


            if (User == null)
            {
                ViewBag.error = "მსგავსი მონაცემებით მომხმარებელი ვერ მოიძებნა !";
                return View();
            }
            else
            {
                Session["user"] = User;
                return RedirectToAction("Index", "Home");
            }
        }





        // რეგისტრაცია
        [HttpPost]
        public ActionResult Registration(RegistrationViewModel registrationViewModel)
        {
            if (String.IsNullOrEmpty(registrationViewModel.name) || String.IsNullOrEmpty(registrationViewModel.surName) || String.IsNullOrEmpty(registrationViewModel.mail) || String.IsNullOrEmpty(registrationViewModel.birthdate) || String.IsNullOrEmpty(registrationViewModel.dog_breed) || String.IsNullOrEmpty(registrationViewModel.password) || String.IsNullOrEmpty(registrationViewModel.repeatPassword))
            {
                ViewBag.error = "საჭიროა ყველა ველის შევსება";
                return View();
            }

            if (!ModelState.IsValid)
            {
                return View(registrationViewModel);
            }

            if (db.ConfirmedUsers.Where(x => x.Email == registrationViewModel.mail).Count() > 0) //ეს კაი როჯაა
            {
                ViewBag.error = "ელფოსტა უკვე დარეგისტრირებულია !";
                return View();
            }

            if (registrationViewModel.password != registrationViewModel.repeatPassword)
            {
                ViewBag.error = "პაროლები არ ემთხვევა";
                return View();
            }
            string confirnCode = Helper.RandomString();
            var NotConfirmedUser = new NotConfirmedUser()
            {
                Name = registrationViewModel.name,
                Surname = registrationViewModel.surName,
                BirthDate = registrationViewModel.birthdate,
                DogBreed = registrationViewModel.dog_breed,
                Email = registrationViewModel.mail,
                Password = Helper.ComputeSha256Hash(registrationViewModel.password + Helper.AuthKey),
                CreateDate = DateTime.Now,
                ConfirmationCode = confirnCode,
                RequestIp = Request.UserHostAddress,
            };
            db.NotConfirmedUsers.InsertOnSubmit(NotConfirmedUser);
            db.SubmitChanges();

            // მაილზე კოდის გაგზავნა
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("levani.jalaghonia09@geolab.edu.ge", "veterinar");
                    var receiverEmail = new MailAddress(registrationViewModel.mail, "Receiver");
                    var password = "eleanoragt";
                    var sub = "ელ.ფოსტის დადასტურება";
                    var body = "დაადასტურეთ ელ.ფოსტა ამ ლინკზე გადასვლით: http://localhost:54637/Account/Confirmation/" + confirnCode; // view რო გვექნება მერე გავტესტავ, წესით უდნა იმუშაოს. შენ რომ გაუშვებ localHost შეცვალე
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = sub,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                   return RedirectToAction("succes", new { email = NotConfirmedUser.Email });
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        
            
        }





        // ელ.ფოსტით დადასტურება
        public ActionResult Confirmation(string id)           //ეს რავი თუ გინდა შენებურად გადააკეთე  // იმუშაოს მთავარია :D
        {
            var notConfirmed = db.NotConfirmedUsers.FirstOrDefault(x => x.ConfirmationCode == id);

            db.ConfirmedUsers.InsertOnSubmit(
                new ConfirmedUser
                {
                    Name = notConfirmed.Name,
                    Email = notConfirmed.Email,
                    Password = notConfirmed.Password,
                    CreateDate = DateTime.Now,
                    RequestIp = notConfirmed.RequestIp
                });
            db.SubmitChanges();

            db.NotConfirmedUsers.DeleteAllOnSubmit(
                db.NotConfirmedUsers.Where(z => z.Email == notConfirmed.Email
                ));
            db.SubmitChanges();
            return RedirectToAction("Login");
        }




        


    }
}