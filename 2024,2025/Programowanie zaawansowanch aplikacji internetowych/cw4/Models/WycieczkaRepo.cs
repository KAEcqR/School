using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace cw4.Models;

public class WycieczkaRepo
{
    private readonly string? _connString;

    public WycieczkaRepo(IConfiguration configuration)
    {
        _connString = configuration.GetConnectionString("MySqlConnection");
    }

    public List<Wycieczka> GetWycieczki(){
        List<Wycieczka> wycieczki = new List<Wycieczka>();
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT dataWyjazdu, cel FROM wycieczki WHERE dostepna = 0";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read()) {
            Wycieczka wycieczka = new Wycieczka();
            wycieczka.DataWyjazdu = reader.GetDateTime("dataWyjazdu").ToString("yyyy-MM-dd");
            wycieczka.Cel = reader.GetString("cel");
            wycieczki.Add(wycieczka);
        }

        return wycieczki;
    }

    public List<Zdjecie> GetZdjecia() {
        List<Zdjecie> zdjecia = new List<Zdjecie>();
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT nazwaPliku, podpis FROM zdjecia;";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read()) {
            Zdjecie zdjecie = new Zdjecie();
            zdjecie.Plik = reader.GetString("nazwaPliku");
            zdjecie.Podpis = reader.GetString("podpis");
            zdjecia.Add(zdjecie);
        }

        return zdjecia;
    }

    public List<Wycieczka> GetWycieczki(string cel){
        List<Wycieczka> wycieczki = new List<Wycieczka>();
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        if(cel == null) {
            cmd.CommandText = "SELECT dataWyjazdu, cel FROM wycieczki;";
        }else {
            cmd.CommandText = "SELECT dataWyjazdu, cel FROM wycieczki WHERE cel LIKE '%" + cel + "%' ;";
        }
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read()) {
            Wycieczka wycieczka = new Wycieczka();
            wycieczka.DataWyjazdu = reader.GetDateTime("dataWyjazdu").ToString("yyyy-MM-dd");
            wycieczka.Cel = reader.GetString("cel");
            wycieczki.Add(wycieczka);
        }

        return wycieczki;
    }
}
