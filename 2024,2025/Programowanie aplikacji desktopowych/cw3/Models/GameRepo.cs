using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace cw3.Models
{
    public class GameRepo
    {
        private string _connString = "Data Source=Games.db";
        public List<Game> GetGames()
        {
            var games = new List<Game>();
            using SqliteConnection conn = new SqliteConnection(_connString);
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Games";
            conn.Open();
            SqliteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                games.Add(new Game
                {
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Genre = rd.GetString(2),
                    ReleaseYear = rd.GetInt32(3),
                    Developer = rd.GetString(4)
                });
            }
            conn.Close();
            return games;
        }

        public List<Game> Sort(string sort)
        {
            var games = new List<Game>();
            using SqliteConnection conn = new SqliteConnection(_connString);
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM Games ORDER BY {sort}";
            conn.Open();
            SqliteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                games.Add(new Game
                {
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Genre = rd.GetString(2),
                    ReleaseYear = rd.GetInt32(3),
                    Developer = rd.GetString(4)
                });
            }
            conn.Close();
            return games;
        }
    }
}
