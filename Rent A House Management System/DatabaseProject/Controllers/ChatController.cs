using DatabaseProject.Models;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System;
namespace DatabaseProject.Controllers
{
    public class ChatController : Controller
    {
        private string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=DESKTOP-SFTP9CG)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=SweetHouse;Password=91221;";
        public ActionResult Index(int tenantId, int propertyOwnerId, int propertyId)
        {
            var chats = new List<Chat>();

            using (var connection = new OracleConnection(connectionString))
            {
                string query = @"
            SELECT ChatId, TenantId, PropertyOwnerId, PropertyId, Sender, MessageContent, Timestamp
            FROM Chat
            WHERE TenantId = :TenantId AND PropertyOwnerId = :PropertyOwnerId AND PropertyId = :PropertyId
            ORDER BY Timestamp";

                var command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":TenantId", tenantId));
                command.Parameters.Add(new OracleParameter(":PropertyOwnerId", propertyOwnerId));
                command.Parameters.Add(new OracleParameter(":PropertyId", propertyId));

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        chats.Add(new Chat
                        {
                            ChatId = Convert.ToInt32(reader["ChatId"]),
                            TenantId = Convert.ToInt32(reader["TenantId"]),
                            PropertyOwnerId = Convert.ToInt32(reader["PropertyOwnerId"]),
                            PropertyId = Convert.ToInt32(reader["PropertyId"]),
                            Sender = reader["Sender"].ToString(),
                            MessageContent = reader["MessageContent"].ToString(),
                            Timestamp = Convert.ToDateTime(reader["Timestamp"])
                        });
                    }
                }
            }

            ViewBag.TenantId = tenantId;
            ViewBag.PropertyOwnerId = propertyOwnerId;
            ViewBag.PropertyId = propertyId;

            return View(chats);
        }


        // Send a message
        [HttpPost]
        public ActionResult SendMessage(Chat chat)
        {
            chat.Timestamp = DateTime.Now;

            using (var connection = new OracleConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Chat (ChatId, TenantId, PropertyOwnerId, PropertyId, Sender, MessageContent, Timestamp)
                    VALUES (CHAT_SEQ.NEXTVAL, :TenantId, :PropertyOwnerId, :PropertyId, :Sender, :MessageContent, :Timestamp)";

                var command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":TenantId", chat.TenantId));
                command.Parameters.Add(new OracleParameter(":PropertyOwnerId", chat.PropertyOwnerId));
                command.Parameters.Add(new OracleParameter(":PropertyId", chat.PropertyId));
                command.Parameters.Add(new OracleParameter(":Sender", chat.Sender));
                command.Parameters.Add(new OracleParameter(":MessageContent", chat.MessageContent));
                command.Parameters.Add(new OracleParameter(":Timestamp", chat.Timestamp));

                connection.Open();
                command.ExecuteNonQuery();
            }

            return RedirectToAction("Index", new { tenantId = chat.TenantId, propertyOwnerId = chat.PropertyOwnerId, propertyId = chat.PropertyId });
        }
    }
}