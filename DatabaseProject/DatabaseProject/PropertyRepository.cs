using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using DatabaseProject.Models;

public class PropertyRepository
{
    private readonly string connectionString = "User Id=SweetHouse;Password=91221;Data Source=DESKTOP-SFTP9CG:1521/XE";

    public List<Property> GetProperties()
    {
        List<Property> properties = new List<Property>();

        try
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = @"
            SELECT p.PROPERTYID,
                   p.PROPERTYOWNERID, 
                   p.PROPERTYNAME, 
                   a.CITY, 
                   p.RENT, 
                   p.FLOORNO, 
                   p.ROOMNO, 
                   f.PARKING,
                   f.FRESHWATER
            FROM Property p
            JOIN Address a ON p.A_ID = a.A_ID
            JOIN Facility f ON p.PROPERTYID = f.PROPERTYID";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Property property = new Property
                            {
                                PropertyId = reader.GetInt32(0),
                                PropertyOwnerId = reader.GetInt32(1),
                                PropertyName = reader.GetString(2),
                                City = reader.GetString(3),
                                Rent = reader.GetDecimal(4),
                                FloorNo = reader.GetInt32(5),
                                RoomNo = reader.GetInt32(6),
                                Parking = reader.IsDBNull(7) ? null : reader.GetString(7),
                                FreshWater = reader.IsDBNull(8) ? null : reader.GetString(8),

                            };
                            properties.Add(property);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        return properties;
    }

    private string ConvertToBase64(object blobData)
    {
        if (blobData == DBNull.Value || blobData == null) return null;

        try
        {
            byte[] blobBytes = (byte[])blobData;
            return Convert.ToBase64String(blobBytes);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error converting BLOB data: " + ex.Message);
            return null;
        }
    }


    public List<Property> GetFilteredProperties(string propertyname, decimal? minPrice, decimal? maxPrice, int? bedrooms)
    {
        var query = "SELECT p.PROPERTYID, p.PROPERTYOWNERID, p.PROPERTYNAME, a.CITY, p.RENT, p.FLOORNO, p.ROOMNO, f.PARKING, f.FRESHWATER " +
                    "FROM Property p " +
                    "JOIN Address a ON p.A_ID = a.A_ID " +
                    "JOIN Facility f ON p.PROPERTYID = f.PROPERTYID WHERE 1=1"; // Default WHERE clause

        var parameters = new List<OracleParameter>();

        if (!string.IsNullOrEmpty(propertyname) && propertyname != "Any Type")
        {
            query += " AND p.PROPERTYNAME = :propertyname";
            parameters.Add(new OracleParameter(":propertyname", propertyname));
        }

        if (minPrice.HasValue)
        {
            query += " AND p.RENT >= :minPrice";
            parameters.Add(new OracleParameter(":minPrice", minPrice.Value));
        }

        if (maxPrice.HasValue)
        {
            query += " AND p.RENT <= :maxPrice";
            parameters.Add(new OracleParameter(":maxPrice", maxPrice.Value));
        }

        if (bedrooms.HasValue && bedrooms.Value > 0)
        {
            query += " AND p.ROOMNO = :bedrooms";
            parameters.Add(new OracleParameter(":bedrooms", bedrooms.Value));
        }

        using (var connection = new OracleConnection(connectionString))
        {
            connection.Open();
            using (var command = new OracleCommand(query, connection))
            {
                command.Parameters.AddRange(parameters.ToArray());

                var properties = new List<Property>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var property = new Property
                        {
                            PropertyId = Convert.ToInt32(reader["PropertyId"]),
                            PropertyName = reader["PropertyName"].ToString(),
                            Rent = Convert.ToDecimal(reader["Rent"]),
                            City = reader["City"].ToString(),
                            RoomNo = Convert.ToInt32(reader["RoomNo"]),
                            FloorNo = Convert.ToInt32(reader["FloorNo"]),
                        };
                        properties.Add(property);
                    }
                }
                return properties;
            }
        }
    }



}
