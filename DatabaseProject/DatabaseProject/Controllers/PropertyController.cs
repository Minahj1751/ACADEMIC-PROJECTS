using DatabaseProject.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseProject.Controllers
{
    public class PropertyController : Controller
    {
        private readonly PropertyRepository propertyRepository;
        private string connectionString = "Data Source=DESKTOP-SFTP9CG:1521/XE;User Id=SweetHouse;Password=91221;";
        public PropertyController()
        {
            propertyRepository = new PropertyRepository();
        }
        private bool IsPropertyOwner(int userId)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (var command = new OracleCommand("SELECT COUNT(*) FROM PROPERTYOWNER WHERE USERID = :userId", connection))
                {
                    command.Parameters.Add(new OracleParameter("userId", userId));
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        public ActionResult Details(int id)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Details", "Property", new { id }) });
            }

            int loggedInUserId = (int)Session["UserId"];

            var property = propertyRepository.GetProperties().FirstOrDefault(p => p.PropertyId == id);

            if (property == null)
            {
                return HttpNotFound();
            }

            if (IsPropertyOwner(loggedInUserId))
            {
                return RedirectToAction("AccessDenied", "Property");
            }

            ViewBag.TenantId = loggedInUserId;
            ViewBag.PropertyOwnerId = property.PropertyOwnerId;
            ViewBag.PropertyId = property.PropertyId;

            return View(property);
        }
        public ActionResult AddProperty()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProperty(
            string propertyName, int roomNo, int floorNo, decimal rent, string city, string detailsLocation,
            string parking, string freshWater, string outdoorSpace, string storeRoom, string securityGuard, string internetService,
            int rentalDuration, decimal securityDeposit, string utilities, string maintenance, string repair, string inspection, string renewal,
            HttpPostedFileBase image1, HttpPostedFileBase image2, HttpPostedFileBase image3, HttpPostedFileBase video)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int addressId = GetNextSequenceValue(connection, transaction, "ADDRESS_SEQ");
                        var command = new OracleCommand("INSERT INTO ADDRESS (A_ID, CITY, DETAILSLOCATION) VALUES (:a_id, :city, :detailsLocation)", connection);
                        command.Transaction = transaction;
                        command.Parameters.Add(new OracleParameter(":a_id", addressId));
                        command.Parameters.Add(new OracleParameter(":city", city));
                        command.Parameters.Add(new OracleParameter(":detailsLocation", detailsLocation));
                        command.ExecuteNonQuery();

                        int propertyId = GetNextSequenceValue(connection, transaction, "PROPERTY_SEQ");
                        int propertyOwnerId = Convert.ToInt32(Session["UserId"]);

                        command = new OracleCommand(@"INSERT INTO PROPERTY (PROPERTYID, PROPERTYNAME, ROOMNO, FLOORNO, RENT, A_ID, PROPERTYOWNERID, IMAGE1, IMAGE2, IMAGE3, VIDEO)
                                                      VALUES (:propertyId, :propertyName, :roomNo, :floorNo, :rent, :a_id, :propertyOwnerId, :image1, :image2, :image3, :video)", connection);
                        command.Transaction = transaction;
                        command.Parameters.Add(new OracleParameter(":propertyId", propertyId));
                        command.Parameters.Add(new OracleParameter(":propertyName", propertyName));
                        command.Parameters.Add(new OracleParameter(":roomNo", roomNo));
                        command.Parameters.Add(new OracleParameter(":floorNo", floorNo));
                        command.Parameters.Add(new OracleParameter(":rent", rent));
                        command.Parameters.Add(new OracleParameter(":a_id", addressId));
                        command.Parameters.Add(new OracleParameter(":propertyOwnerId", propertyOwnerId));
                        command.Parameters.Add(new OracleParameter(":image1", ConvertToBlob(image1)));
                        command.Parameters.Add(new OracleParameter(":image2", ConvertToBlob(image2)));
                        command.Parameters.Add(new OracleParameter(":image3", ConvertToBlob(image3)));
                        command.Parameters.Add(new OracleParameter(":video", ConvertToBlob(video)));
                        command.ExecuteNonQuery();

                        int facilityId = GetNextSequenceValue(connection, transaction, "FACILITY_SEQ");
                        command = new OracleCommand(@"INSERT INTO FACILITY (FACILITYID, PARKING, FRESHWATER, OUTDOORSPACE, STOREROOM, SECURITYGUARD, INTERNETSERVICE, PROPERTYID)
                                                      VALUES (:facilityId, :parking, :freshWater, :outdoorSpace, :storeRoom, :securityGuard, :internetService, :propertyId)", connection);
                        command.Transaction = transaction;
                        command.Parameters.Add(new OracleParameter(":facilityId", facilityId));
                        command.Parameters.Add(new OracleParameter(":parking", parking));
                        command.Parameters.Add(new OracleParameter(":freshWater", freshWater));
                        command.Parameters.Add(new OracleParameter(":outdoorSpace", outdoorSpace));
                        command.Parameters.Add(new OracleParameter(":storeRoom", storeRoom));
                        command.Parameters.Add(new OracleParameter(":securityGuard", securityGuard));
                        command.Parameters.Add(new OracleParameter(":internetService", internetService));
                        command.Parameters.Add(new OracleParameter(":propertyId", propertyId));
                        command.ExecuteNonQuery();

                        int termsId = GetNextSequenceValue(connection, transaction, "TERMS_SEQ");
                        command = new OracleCommand(@"INSERT INTO TERMS (TERMSID, RENTALDURATION, SECURITYDEPOSIT, UTILITIES, MAINTENANCE, REPAIR, INSPECTION, RENEWAL, PROPERTYID)
                                                      VALUES (:termsId, :rentalDuration, :securityDeposit, :utilities, :maintenance, :repair, :inspection, :renewal, :propertyId)", connection);
                        command.Transaction = transaction;
                        command.Parameters.Add(new OracleParameter(":termsId", termsId));
                        command.Parameters.Add(new OracleParameter(":rentalDuration", rentalDuration));
                        command.Parameters.Add(new OracleParameter(":securityDeposit", securityDeposit));
                        command.Parameters.Add(new OracleParameter(":utilities", utilities));
                        command.Parameters.Add(new OracleParameter(":maintenance", maintenance));
                        command.Parameters.Add(new OracleParameter(":repair", repair));
                        command.Parameters.Add(new OracleParameter(":inspection", inspection));
                        command.Parameters.Add(new OracleParameter(":renewal", renewal));
                        command.Parameters.Add(new OracleParameter(":propertyId", propertyId));
                        command.ExecuteNonQuery();

                        transaction.Commit();
                        TempData["Message"] = "Property added successfully!";
                        return RedirectToAction("Index", "Home");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        TempData["Error"] = "An error occurred: " + ex.Message;
                        return View();
                    }
                }
            }
        }

        private int GetNextSequenceValue(OracleConnection connection, OracleTransaction transaction, string sequenceName)
        {
            using (var command = new OracleCommand($"SELECT {sequenceName}.NEXTVAL FROM DUAL", connection))
            {
                command.Transaction = transaction;
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private byte[] ConvertToBlob(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    file.InputStream.CopyTo(memoryStream);
                    return memoryStream.ToArray();
                }
            }
            return null;
        }

        public ActionResult AccessDenied()
        {
            return View();
        }

        

    }
}
