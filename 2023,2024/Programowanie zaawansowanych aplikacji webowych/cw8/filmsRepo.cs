using System.Data;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Data.Sqlite;

namespace cw8;

public class FilmsRepo
{
    private string dbName = "films.db";
    private string connString;
    public FilmsRepo()
    {     
        connString =  $"Data Source={System.IO.Path.Join(AppContext.BaseDirectory,dbName)}";  
    }

    public List<Film> GetAllFilms(){
        List<Film> films = new List<Film>();
        SqliteConnection connection = new SqliteConnection(connString);
        SqliteCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM films";
        connection.Open();
        SqliteDataReader rd = command.ExecuteReader();
        if (rd.HasRows){
            while(rd.Read()){
                films.Add(
                    new Film{
                        Id = rd.GetInt32(0),
                        Title = rd.GetString(1),
                        Director = rd.GetString(2),
                        Price = rd.GetDecimal(3),
                        Description = rd.GetString(4)
                    }
                );
            }
        }

        connection.Close();
        return films;
    }

    public bool InsertFilm(){
        
    }
}
