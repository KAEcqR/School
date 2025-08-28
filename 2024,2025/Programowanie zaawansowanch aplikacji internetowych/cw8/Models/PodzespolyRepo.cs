using System;
using MySql.Data.MySqlClient;

namespace cw8.Models;


public class PodzespolyRepo
{
    private readonly string? _connString;

    public PodzespolyRepo(IConfiguration configuration)
    {
        _connString = configuration.GetConnectionString("MySqlConnection");
    }

    public List<Podzespol> GetPodzespoly()
    {
        List<Podzespol> podzespoly = new List<Podzespol>();
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM podzespoly WHERE cena < 1000";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Podzespol podzespol = new Podzespol();
            podzespol.id = reader.GetInt32("id");
            podzespol.nazwa = reader.GetString("nazwa");
            podzespol.opis = reader.GetString("opis");
            podzespol.cena = reader.GetInt32("cena");
            podzespoly.Add(podzespol);
        }

        return podzespoly;
    }

    public List<Podzespol> GetProcesor()
    {
        List<Podzespol> podzespoly = new List<Podzespol>();
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM podzespoly WHERE typy_id = 1";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Podzespol podzespol = new Podzespol();
            podzespol.id = reader.GetInt32("id");
            podzespol.nazwa = reader.GetString("nazwa");
            podzespol.opis = reader.GetString("opis");
            podzespol.cena = reader.GetInt32("cena");
            podzespoly.Add(podzespol);
        }

        return podzespoly;
    }

    public List<Podzespol> GetRam()
    {
        List<Podzespol> podzespoly = new List<Podzespol>();
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM podzespoly WHERE typy_id = 2";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Podzespol podzespol = new Podzespol();
            podzespol.id = reader.GetInt32("id");
            podzespol.nazwa = reader.GetString("nazwa");
            podzespol.opis = reader.GetString("opis");
            podzespol.cena = reader.GetInt32("cena");
            podzespoly.Add(podzespol);
        }

        return podzespoly;
    }

    public List<Podzespol> GetGrafika()
    {
        List<Podzespol> podzespoly = new List<Podzespol>();
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM podzespoly WHERE typy_id = 5";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Podzespol podzespol = new Podzespol();
            podzespol.id = reader.GetInt32("id");
            podzespol.nazwa = reader.GetString("nazwa");
            podzespol.opis = reader.GetString("opis");
            podzespol.cena = reader.GetInt32("cena");
            podzespoly.Add(podzespol);
        }

        return podzespoly;
    }
}
