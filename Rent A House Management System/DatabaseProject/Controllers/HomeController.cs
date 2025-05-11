using DatabaseProject.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseProject.Controllers
{
    public class HomeController : Controller
    {
        private string connectionString = "Data Source=DESKTOP-SFTP9CG:1521/XE;User Id=SweetHouse;Password=91221;";
        private PropertyRepository propertyRepo = new PropertyRepository();
        public ActionResult Index()
        {
            List<Property> properties = propertyRepo.GetProperties();
            return View(properties);
        }
        [HttpGet]
        public ActionResult Profile()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        [HttpGet]
        public ActionResult TenantProfile()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }
        // POST: AddProperty
        [HttpPost]
        public ActionResult AddProperty(
            string propertyName,
            int roomNo,
            int floorNo,
            decimal rent,
            string addressId,
            string detailsLocation,
            int propertyOwnerId,
            string propertyType,
            string description
        )
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var command = new OracleCommand("SELECT PROPERTY_SEQ.NEXTVAL FROM DUAL", connection);
                        command.Transaction = transaction;
                        int propertyId = Convert.ToInt32(command.ExecuteScalar());

                        command = new OracleCommand(
                            @"INSERT INTO PROPERTY (PROPERTYID, PROPERTYNAME, ROOMNO, FLOORNO, RENT, ADDRESSID, DETAILSLOCATION, PROPERTYOWNERID, PROPERTYTYPE, DESCRIPTION) 
                              VALUES (:propertyId, :propertyName, :roomNo, :floorNo, :rent, :addressId, :detailsLocation, :propertyOwnerId, :propertyType, :description)",
                            connection
                        );
                        command.Transaction = transaction;

                        command.Parameters.Add(new OracleParameter(":propertyId", propertyId));
                        command.Parameters.Add(new OracleParameter(":propertyName", propertyName));
                        command.Parameters.Add(new OracleParameter(":roomNo", roomNo));
                        command.Parameters.Add(new OracleParameter(":floorNo", floorNo));
                        command.Parameters.Add(new OracleParameter(":rent", rent));
                        command.Parameters.Add(new OracleParameter(":addressId", addressId));
                        command.Parameters.Add(new OracleParameter(":detailsLocation", detailsLocation));
                        command.Parameters.Add(new OracleParameter(":propertyOwnerId", propertyOwnerId));
                        command.Parameters.Add(new OracleParameter(":propertyType", propertyType));
                        command.Parameters.Add(new OracleParameter(":description", description));

                        command.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();

                        TempData["Message"] = "Property added successfully!";
                        return RedirectToAction("Profile", "Home");
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if there's an error
                        transaction.Rollback();
                        TempData["Error"] = $"An error occurred: {ex.Message}";
                        return RedirectToAction("Profile", "Home");
                    }
                }
            }
        }

        /*
        public ActionResult GetUserProperties()
        {
            if (Session["UserId"] == null)
            {
                return Json(new { error = "User not authenticated" });
            }

            int userId = Convert.ToInt32(Session["UserId"]);

            var addedProperties = new List<object>();
            var reservedProperties = new List<object>();

            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (var command = new OracleCommand("SELECT PropertyId, PropertyName, A_ID, Rent FROM Property WHERE PropertyOwnerId = :UserId", connection))
                {
                    command.Parameters.Add(new OracleParameter("UserId", userId));
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            addedProperties.Add(new
                            {
                                PropertyId = reader["PropertyId"],
                                PropertyName = reader["PropertyName"],
                                Address = reader["Address"],
                                Status = reader["Status"]
                            });
                        }
                    }
                }

                using (var command = new OracleCommand("SELECT p.PropertyId, p.PropertyName, p.A_ID, p.Rent FROM Reservations r INNER JOIN Property p ON r.PropertyId = p.PropertyId WHERE r.TenantId = :UserId", connection))
                {
                    command.Parameters.Add(new OracleParameter("UserId", userId));
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservedProperties.Add(new
                            {
                                PropertyId = reader["PropertyId"],
                                PropertyName = reader["PropertyName"],
                                Address = reader["Address"],
                                Status = reader["Status"]
                            });
                        }
                    }
                }
            }

            return Json(new { addedProperties, reservedProperties });
        }
        */

        public ActionResult Index2(string propertyname, decimal? minPrice, decimal? maxPrice, int? bedrooms)
        {
            // Fetch properties from the repository, apply filters if provided
            var properties = propertyRepo.GetFilteredProperties(propertyname, minPrice, maxPrice, bedrooms);

            // Pass the filtered properties to the view
            return View(properties);
        }

        // Search and Filter action for handling the form submission
        public ActionResult SearchAndFilter(string propertyname, decimal? minPrice, decimal? maxPrice, int? bedrooms)
        {
            // Fetch the filtered properties from the repository
            var properties = propertyRepo.GetFilteredProperties(propertyname, minPrice, maxPrice, bedrooms);

            // Return a partial view with the filtered properties (to update the property list dynamically)
            return PartialView("_PropertyListPartial", properties);
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

    }
}