using System;
using Microsoft.Data.Sqlite;

namespace cw2.Models;

public class GameRepo
{
    private string? _connectionString;

    public GameRepo(IConfiguration configuration){
        _connectionString = configuration.GetConnectionString("sqlite");
    }

    public List<Game> GetGames(){
        List<Game> games = new List<Game>();
        using (SqliteConnection conn = new SqliteConnection(_connectionString)) 
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Games";
            conn.Open();
            SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read()){
                games.Add(new Game{
                    Id = reader.GetInt32(0),
                    Nazwa = reader.GetString(1),
                    Rok = reader.GetInt32(2),
                    Producent = reader.GetString(3),
                    Cena = reader.GetInt32(4),
                });
            }
            conn.Close();
        }
        return games;
    }

    public void AddGame(Game game){
        using (SqliteConnection conn = new SqliteConnection(_connectionString)) 
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Games (Nazwa,Rok,Producent,Cena) VALUES " + "(@Nazwa,@Rok,@Producent,@Cena)";
            command.Parameters.AddWithValue("@Nazwa", game.Nazwa);
            command.Parameters.AddWithValue("@Rok", game.Rok);
            command.Parameters.AddWithValue("@Producent", game.Producent);
            command.Parameters.AddWithValue("@Cena", game.Cena);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }

        public void RemoveGame(int id){
        using (SqliteConnection conn = new SqliteConnection(_connectionString)) 
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Games WHERE " + "id = @id";
            command.Parameters.AddWithValue("@id", id);
  
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
