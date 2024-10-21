using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace OOPSummative2
{
    public class Session
    {
        public SqlConnection connection;
        public List<RescueItem> itemsToCheckout = new List<RescueItem>();

        public Session(string dataSource, string initialCatalog)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            {
                DataSource = dataSource,
                InitialCatalog = initialCatalog,
                IntegratedSecurity = true
            };

            connection = new SqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
            } 
            catch (SqlException ex)
            {
                if (ex.Number == -1 || ex.Number == 2 || ex.Number == 53)
                    MessageBox.Show("Cannot connect to database. Exiting program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"A SQL error occurred: {ex.Message}\n\nExiting program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                Environment.Exit(-1);
            }
        }

        public void AddItem(RescueItem item)
        {
            string sqlCommand = @"
                INSERT INTO RescueDB.dbo.inventoryTable (itemName, itemPrice, itemCount, itemImage, itemType)
                VALUES (@itemName, @itemPrice, @itemCount, @itemImage, @itemType)";

            using (SqlCommand command = new SqlCommand(sqlCommand, connection))
            {
                command.Parameters.AddWithValue("@itemName", item.itemName);
                command.Parameters.AddWithValue("@itemPrice", item.itemPrice);
                command.Parameters.AddWithValue("@itemCount", item.itemQuantity);
                command.Parameters.AddWithValue("@itemType", item.itemType.ToString());

                using (var ms = new MemoryStream())
                {
                    (new Bitmap(item.itemThumbnail)).Save(ms, item.itemThumbnail.RawFormat);
                    command.Parameters.AddWithValue("@itemImage", ms.ToArray());
                }

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Insert successful. Rows affected: {rowsAffected}");
                }
                else
                {
                    MessageBox.Show("Insert failed. No rows were affected.");
                }
            }
        }

        public List<RescueItem> GetItems(RescueItemType? type = null)
        {
            List<RescueItem> items = new List<RescueItem>();

            if (connection == null || connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Connection is closed. Returning.");
                return items;
            }

            string sqlCommand = "SELECT * FROM inventoryTable";
            if (type.HasValue)
            {
                sqlCommand += $" WHERE itemType = @ItemType";
            }

            using (SqlCommand command = new SqlCommand(sqlCommand, connection))
            {
                if (type.HasValue)
                {
                    command.Parameters.AddWithValue("@ItemType", type.Value.ToString());
                }

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
