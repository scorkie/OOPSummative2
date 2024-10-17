using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace OOPSummative2
{
    public class Connection
    {
        public SqlConnection connection;
        public Connection(string dataSource, string initialCatalog)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            {
                DataSource = dataSource,
                InitialCatalog = initialCatalog,
                IntegratedSecurity = true
            };

            connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
        }

        public List<RescueItem> getCurrentItems(RescueItemType type)
        {
            List<RescueItem> items = new List<RescueItem>();

            string sqlCommand = $"SELECT * FROM inventoryTable "
                              + $"WHERE itemType='{type.ToString()}' ";

            using (SqlCommand command = new SqlCommand(sqlCommand, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string itemName = reader.GetString(0);
                        decimal itemPrice = Convert.ToDecimal(reader[1]);
                        int itemCount = reader.GetInt32(2);
                        Image itemImage;
                        RescueItemType itemType = RescueItem.stringToType(reader.GetString(4));
                        using (MemoryStream ms = new MemoryStream((byte[])reader[3]))
                        {
                            itemImage = Image.FromStream(ms);
                        }

                        items.Add(new RescueItem(itemName, itemPrice, itemCount, itemImage, itemType));
                        
                    }
                }
            }

            return items;
        }
    }
}
