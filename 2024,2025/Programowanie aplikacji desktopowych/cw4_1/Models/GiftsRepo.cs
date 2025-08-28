using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4_1.Models
{
    public class GiftsRepo
    {
        private string connString = "Data Source = gifts.db";
        public GiftsRepo() { }
        public List<Gift> GetGifts()
        {
            var result = new List<Gift>();
            using (SqliteConnection conn = new SqliteConnection(connString))
            {
                SqliteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM gift;";

                try
                {
                    conn.Open();
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Gift
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                From_sb = reader.GetString(2),
                                For_sb = reader.GetString(3),
                                Price = reader.GetInt32(4),
                                Packaging = reader.GetString(5)
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd przy pobieraniu danych: {ex.Message}");
                    Console.WriteLine($"Szczegóły: {ex.ToString()}");
                }
            }

            return result;
        }

        public void AddGift(string Name, string From_sb, string For_sb, int Price, string Packaging)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(From_sb) || string.IsNullOrEmpty(For_sb) || Price <= 0 || string.IsNullOrEmpty(Packaging))
            {
                Console.WriteLine("Błąd: Wszystkie pola muszą być wypełnione, a cena większa niż 0.");
                return; 
            }

            using (SqliteConnection conn = new SqliteConnection(connString))
            {
                SqliteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO gift (Name, From_sb, For_sb, Price, Packaging) VALUES (@Name, @From_sb, @For_sb, @Price, @Packaging)";

                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@From_sb", From_sb);
                cmd.Parameters.AddWithValue("@For_sb", For_sb);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Packaging", Packaging);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding gift: {ex.Message}");
                    Console.WriteLine($"Details: {ex.ToString()}");
                }
            }
        }
    }
}
