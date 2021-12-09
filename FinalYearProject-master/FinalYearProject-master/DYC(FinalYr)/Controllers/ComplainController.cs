using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Web.Mvc;
using DYC_FinalYr_.Models;
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
        public ActionResult ComplainList()
        {
            return View(db.AddComplainInDatabaseTables.ToList());
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
                di.ComplainCataegory = d.ComplainCataegory;
                di.ComplainArea = d.ComplainArea;
                di.RoadNumber = d.RoadNumber;
                di.ComplainDeatils = d.ComplainDeatils;
                //di.Photo = path;
                di.Photo = d.Photo;
                di.ComplainerName = d.ComplainerName;
                di.ContractNumber = d.ContractNumber;
                di.Email = d.Email;
                db.AddComplainInDatabaseTables.Add(di);

                db.SaveChanges();
                ModelState.Clear();
                ViewBag.msg = "data added";
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
           int i = db.AddComplainInDatabaseTables.Where(c => c.ComplainCataegory == d.ComplainCataegory && c.ComplainArea==d.ComplainArea && c.ComplainDeatils==d.ComplainDeatils).Count();
           //string command = "SELECT * FROM AddComplainInDatabaseTable   Where ComplainCataegory = '" +d.ComplainCataegory +"'";
           //SqlCommand sqlCommand = new SqlCommand(command);

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

      

	}
}