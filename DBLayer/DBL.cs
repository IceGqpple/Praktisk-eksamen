using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class DBL
    {
        public DataTable SearchElev(string Etternavn)
        {
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["ConnAir"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Fornavn, Etternavn, Adresse, Elev.PostNr, Poststeder.Poststed, Klasse.KlasseNavn FROM Elev INNER JOIN Poststeder ON Poststeder.PostNr = Elev.PostNr INNER JOIN Klasse ON Klasse.KlasseID = Elev.KlasseID WHERE Etternavn = @EN", conn);
                cmd.CommandType = CommandType.Text;
                param = new SqlParameter("@EN", SqlDbType.NVarChar);
                cmd.Parameters.Add(param);
                param.Value = Etternavn;
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();
            }
            return dt;
        }
        public DataTable Elev()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnAir"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Fornavn, Etternavn, Adresse, Klasse.KlasseNavn FROM Elev INNER JOIN Klasse ON Klasse.KlasseID = Elev.KlasseID", conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();
            }
            return dt;
        }
        public DataTable SearchFag(string Fag)
        {
            SqlParameter param;
            var connectionString = ConfigurationManager.ConnectionStrings["ConnAir"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Fornavn, Etternavn, Adresse, Klasse.KlasseNavn, Fag.Fagnavn FROM Elev INNER JOIN Klasse ON Klasse.KlasseID = Elev.KlasseID INNER JOIN FagElev ON FagElev.ElevID = Elev.ElevID INNER JOIN Fag ON Fag.FagKode = FagElev.FagKode WHERE Fagnavn = @FagN", conn);
                cmd.CommandType = CommandType.Text;
                param = new SqlParameter("@FagN", SqlDbType.NVarChar);
                cmd.Parameters.Add(param);
                param.Value = Fag;
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();
            }
            return dt;
        }
    }
}
