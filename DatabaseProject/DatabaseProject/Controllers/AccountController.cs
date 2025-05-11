using DatabaseProject.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Web.Mvc;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace DatabaseProject.Controllers
{
    public class AccountController : Controller
    {
        private string connectionString = "Data Source=DESKTOP-SFTP9CG:1521/XE;User Id=SweetHouse;Password=91221;";

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password, string returnUrl)
        {
            var user = AuthenticateUser(email, password);

            if (user != null)
            {
                Session["UserId"] = user.UserId;

                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }

                if (IsTenant(user.UserId))
                {
                    return RedirectToAction("TenantProfile", "Home");
                }
                else if (IsPropertyOwner(user.UserId))
                {
                    return RedirectToAction("Profile", "Home");
                }

                return RedirectToAction("Index", "Home");
            }

            TempData["ErrorMessage"] = "Invalid email or password.";
            return View();
        }

        private User AuthenticateUser(string email, string password)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string hashedPassword = HashPassword(password);

                using (var command = new OracleCommand("SELECT UserId FROM Users WHERE Email = :email AND Password = :password", connection))
                {
                    command.Parameters.Add(new OracleParameter("email", email));
                    command.Parameters.Add(new OracleParameter("password", hashedPassword));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserId = Convert.ToInt32(reader["UserId"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        private bool IsTenant(int userId)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (var command = new OracleCommand("SELECT COUNT(*) FROM TENANT WHERE USERID = :userId", connection))
                {
                    command.Parameters.Add(new OracleParameter("userId", userId));
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
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

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string name, string phone, string email, string uCity, string password, string role)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var command = new OracleCommand("SELECT USERS_SEQ.NEXTVAL FROM DUAL", connection);
                        command.Transaction = transaction;
                        int userId = Convert.ToInt32(command.ExecuteScalar());

                        string hashedPassword = HashPassword(password);

                        command = new OracleCommand("INSERT INTO USERS (USERID, NAME, PHONE, EMAIL, U_CITY, PASSWORD) VALUES (:userId, :name, :phone, :email, :uCity, :password)", connection);
                        command.Transaction = transaction;
                        command.Parameters.Add(new OracleParameter(":userId", userId));
                        command.Parameters.Add(new OracleParameter(":name", name));
                        command.Parameters.Add(new OracleParameter(":phone", phone));
                        command.Parameters.Add(new OracleParameter(":email", email));
                        command.Parameters.Add(new OracleParameter(":uCity", uCity));
                        command.Parameters.Add(new OracleParameter(":password", hashedPassword));
                        command.ExecuteNonQuery();

                        if (role == "Tenant")
                        {
                            command = new OracleCommand("SELECT TENANT_SEQ.NEXTVAL FROM DUAL", connection);
                            command.Transaction = transaction;
                            int tenantId = Convert.ToInt32(command.ExecuteScalar());

                            command = new OracleCommand("INSERT INTO TENANT (TENANTID, USERID) VALUES (:tenantId, :userId)", connection);
                            command.Transaction = transaction;
                            command.Parameters.Add(new OracleParameter(":tenantId", tenantId));
                            command.Parameters.Add(new OracleParameter(":userId", userId));
                            command.ExecuteNonQuery();
                        }
                        else if (role == "PropertyOwner")
                        {
                            command = new OracleCommand("SELECT PROPERTYOWNER_SEQ.NEXTVAL FROM DUAL", connection);
                            command.Transaction = transaction;
                            int propertyOwnerId = Convert.ToInt32(command.ExecuteScalar());

                            command = new OracleCommand("INSERT INTO PROPERTYOWNER (PROPERTYOWNERID, USERID) VALUES (:propertyOwnerId, :userId)", connection);
                            command.Transaction = transaction;
                            command.Parameters.Add(new OracleParameter(":propertyOwnerId", propertyOwnerId));
                            command.Parameters.Add(new OracleParameter(":userId", userId));
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            throw new Exception("Invalid role selected.");
                        }

                        transaction.Commit();

                        TempData["Message"] = "Sign-Up successful!";
                        return RedirectToAction("Login", "Account");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        TempData["Error"] = $"An error occurred: {ex.Message}";
                        return RedirectToAction("Register", "Account"); // Fixed redirect
                    }
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
