using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using DatabaseProject.Models;

public class DashboardController : Controller
{
    private string connectionString = "Data Source=DESKTOP-SFTP9CG:1521/XE;User Id=SweetHouse;Password=91221;";

    public ActionResult Dashboard()
    {
        var userId = Session["UserId"]?.ToString();
        if (string.IsNullOrEmpty(userId))
        {
            return RedirectToAction("Login", "Account");
        }

        var properties = GetPropertiesForOwner(userId);
        return View(properties);
    }

    private List<Property> GetPropertiesForOwner(string propertyOwnerId)
    {
        List<Property> properties = new List<Property>();

        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT PropertyId, PropertyName, RoomNo, Rent FROM Property WHERE PropertyOwnerId = :propertyOwnerId";

            using (OracleCommand command = new OracleCommand(query, connection))
            {
                command.Parameters.Add(new OracleParameter("propertyOwnerId", propertyOwnerId));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var property = new Property
                        {
                            PropertyId = reader.GetInt32(0),
                            PropertyName = reader.GetString(1),
                            RoomNo = reader.GetInt32(2),
                            Rent = reader.GetDecimal(3),
                          //ImageBase64 = reader.IsDBNull(4) ? null : ConvertImageToBase64((byte[])reader["IMAGE1"])
                        };
                        properties.Add(property);
                    }
                }
            }
        }

        return properties;
    }

    private string ConvertImageToBase64(byte[] imageBytes)
    {
        return "data:image/jpg;base64," + Convert.ToBase64String(imageBytes);
    }
}
