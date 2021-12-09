using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.IO;
using System.Configuration;
using System.Web.Mvc;
using DYC_FinalYr_.Models;
using System.Net.Mail;

namespace DYC_FinalYr_.Controllers
{
    public class ComplainController : Controller
    {
        //
        // GET: /Complain/
        public ActionResult Index()
        {
            return View();
        }

        Database1Entities db = new Database1Entities();
        Database1Entities1 dbDatabase1Entities1 = new Database1Entities1();
        public static string EmailId;
        public ActionResult ComplainList()
        {
            return View(db.AddComplainInDatabaseTables.ToList());
        }

        public ActionResult CheckComplaiStatus(string search)
        {
            //if (String.IsNullOrEmpty(search))
            //{
            //    return View();
            //}
            //else
            //{
                int i = Convert.ToInt16(search);
                return View(dbDatabase1Entities1.AddComplainInDatabaseTables.Where(x =>x.Id == i).ToList());


          //  }

           

        }


        public ActionResult AddNewComplain()
        {

            var list = new List<string> { "Main Hall Missing", "Draingae", "Road Damage", "Dustbin Problem" };
            ViewBag.list = list;
            var ComplainArea = new List<string> { "Mohammadpur", "MirPur-1", "Dhamondli" };
            ViewBag.ComplainArea = ComplainArea;

            return View();
        }
        [HttpPost]
        public ActionResult AddNewComplain(AddComplainInDatabaseTable d, HttpPostedFileBase imgfile)
        {
            var list = new List<string> { "Main Hall Missing", "Draingae", "Road Damage", "Dustbin Problem" };
            ViewBag.list = list;
            var ComplainArea = new List<string> { "Mohammadpur", "MirPur-1", "Dhamondli" };
            ViewBag.ComplainArea = ComplainArea;

           // ViewBag.list = list;


            AddComplainInDatabaseTable di = new AddComplainInDatabaseTable();
            string path = uploadimage(imgfile);
            if (ComplainIsExist(d))
            {
                ViewBag.msg = "Complain is exist";
                return View();
            }

            if (path.Equals("-1"))
            {

            }
            else
            {
                di.Id = d.Id;
                di.ComplainCataegory = d.ComplainCataegory;
                di.ComplainArea = d.ComplainArea;
                di.RoadNumber = d.RoadNumber;
                di.ComplainDeatils = d.ComplainDeatils;
                di.Photo = path;
                //di.Photo = d.path;
                di.ComplainerName = d.ComplainerName;
                di.ContractNumber = d.ContractNumber;
                di.Email = d.Email;
                db.AddComplainInDatabaseTables.Add(di);
                EmailId = di.Email;
                db.SaveChanges();
                ModelState.Clear();
                ViewBag.ComplainId = di.Id ;
                ViewBag.msg2 = "Your Complain Id Is Given Below";
                ViewBag.msg = "data added";
                
                //string sendEmail = ConfigurationManager.AppSettings["SendEmail"];

                //SendEmail(di.Id.ToString());
                

            }
            
           

            return View();
        }

        public string uploadimage(HttpPostedFileBase file)
        {

            Random r = new Random();

            string path = "-1";

            int random = r.Next();

            if (file != null && file.ContentLength > 0)
            {

                string extension = Path.GetExtension(file.FileName);

                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png"))
                {

                    try
                    {



                        path = Path.Combine(Server.MapPath("~/Content/upload"), random + Path.GetFileName(file.FileName));

                        file.SaveAs(path);

                        path = "~/Content/upload/" + random + Path.GetFileName(file.FileName);



                        //    ViewBag.Message = "File uploaded successfully";

                    }

                    catch (Exception ex)
                    {

                        path = "-1";

                    }

                }

                else
                {

                    Response.Write("<script>alert('Only jpg ,jpeg or png formats are acceptable....'); </script>");

                }

            }



            else
            {

                Response.Write("<script>alert('Please select a file'); </script>");

                path = "-1";

            }







            return path;

        }




        public bool ComplainIsExist(AddComplainInDatabaseTable d)
        {
            //string conncetion = @"Server=DESKTOP-QREDJ0M; DATABASE=MyDataBase; Integrated Security=TRUE";
            //SqlConnection sqlConncetion = new SqlConnection(conncetion);

           // AddComplainInDatabaseTable 
         //  int i = db.AddComplainInDatabaseTables.Where(c => c.ComplainCataegory == d.ComplainCataegory && c.ComplainArea==d.ComplainArea && c.RoadNumber == d.RoadNumber).Count();
           //string command = "SELECT * FROM AddComplainInDatabaseTable   Where ComplainCataegory = '" +d.ComplainCataegory +"'";
           //SqlCommand sqlCommand = new SqlCommand(command);
          
           
             int   i = db.AddComplainInDatabaseTables.Where(c => c.ComplainCataegory == d.ComplainCataegory && c.ComplainArea == d.ComplainArea && c.RoadNumber == d.RoadNumber).Count();
           
           ////sqlConncetion.Open();
           //SqlDataAdapter sqlDataAdapater = new SqlDataAdapter(sqlCommand);
           //DataTable dataTable = new DataTable();
           //sqlDataAdapater.Fill(dataTable);

           if (i > 0)
           {
               return true;
           }

           ////sqlConncetion.Close();
           return false;

        }
     //   Database1Entities1 dbDatabase1Entities1 = new Database1Entities1();
        public ActionResult UploadStatus(int ?Id)
        {
            var result = dbDatabase1Entities1.AddComplainInDatabaseTables.Find(Id);
            return View(result);
        }

        [HttpPost]
        public ActionResult UploadStatus(AddComplainInDatabaseTable edit)
        {
            if (ModelState.IsValid)
            {
                dbDatabase1Entities1.Entry(edit).State = EntityState.Modified;
                if (dbDatabase1Entities1.SaveChanges() > 0)
                {
                   // ViewBag.msg = "Update Work Status";
                    return RedirectToAction("Report", "Complain");
                }
            }

            return View();


        }

        public ActionResult Report()
        {
            return View(dbDatabase1Entities1.AddComplainInDatabaseTables.ToList());
        }

        public ActionResult login()
        {
            return View();
        }



        [HttpPost]
        public ActionResult login(AdminLogin lg)
        {
            if (ModelState.IsValid)
            {
                using (Database1Entities2 ue = new Database1Entities2())
                {
                    var log = ue.AdminLogins.Where(a => a.UserName.Equals(lg.UserName) && a.Password.Equals(lg.Password)).FirstOrDefault();
                    if (log != null)
                    {
                        Session["UserName"] = log.UserName;
                        return RedirectToAction("ComplainList", "Complain");
                    }

                    else
                    {
                        Response.Write("<script> alert('Invaild password')</script>");
                    }
                }
            }
            return View();
        }



        public static void SendEmail(string emailbody)
        {
            // Specify the from and to email address
            // AddComplainInDatabaseTable di;
            //  Database1Entities1 db = new Database1Entities1();


            MailMessage mailMessage = new MailMessage("prantoshon14@gmail.com", EmailId);
            // Specify the email body
            mailMessage.Body = emailbody;
            // Specify the email Subject
            mailMessage.Subject = "Your Complain Id ";

            // Specify the SMTP server name and post number
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            //SmtpClient smtpClient = new SmtpClient();
            // Specify your gmail address and password
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "prantoshon14@gmail.com",
                Password = ""
            };
            // Gmail works on SSL, so set this property to true
            smtpClient.EnableSsl = true;
            // Finall send the email message using Send() method
            smtpClient.Send(mailMessage);

            // string sendEmail = ConfigurationManager.AppSettings["SendEmail"];

        }



    }
}