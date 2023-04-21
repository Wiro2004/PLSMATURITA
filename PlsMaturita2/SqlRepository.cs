using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlsMaturita2
{
    public class SqlRepository
    {
        public string ConnectionString { get; set; }

        public SqlRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Ctenari> NactiCtenare()
        {
            List<Ctenari> list = new List<Ctenari>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))

            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Select * from Ctenari2";
                    
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Ctenari(Convert.ToInt32(reader["IdCtenar"]), reader["Jmeno"].ToString(), reader["Prijmeni"].ToString(), Convert.ToInt32(reader["PujcenychKnih"])));
                        }
                    }
                }
                conn.Close();
                return list;

            }

            
        }
        public List<Knihy> NactiKnihu()
        {
            List<Knihy> knihy = new List<Knihy>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))

            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Select * from Knihy";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            knihy.Add(new Knihy(Convert.ToInt32(reader["IdKnihy"]), reader["Nazev"].ToString(), reader["Autor"].ToString(), Convert.ToDateTime(reader["Datum"])));
                        }
                    }
                }
                conn.Close();
                return knihy;

            }


        }
        public void VytvorCtenare(string Jmeno,string Prijmeni,int PujcenychKnih)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                    using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Insert into Ctenari2 values (@Jmeno,@Prijmeni,@PujcenychKnih)";
                    cmd.Parameters.AddWithValue("Jmeno", Jmeno);
                    cmd.Parameters.AddWithValue("Prijmeni", Prijmeni);
                    cmd.Parameters.AddWithValue("PujcenychKnih", PujcenychKnih);

                    cmd.ExecuteNonQuery();

                }
                conn.Close();

            }

        }
        public void VytvorKnihu(string Nazev, string Autor, DateTime Datum)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Insert into Knihy values (@Nazev,@Autor,@Datum)";
                    cmd.Parameters.AddWithValue("Nazev", Nazev);
                    cmd.Parameters.AddWithValue("Autor", Autor);
                    cmd.Parameters.AddWithValue("Datum", Datum);

                    cmd.ExecuteNonQuery();

                }
                conn.Close();

            }

        }
        public void OdstranCtenare(int ctenar)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Delete from Ctenari2 where IdCtenar=@idCtenar";
                    cmd.Parameters.AddWithValue("IdCtenar", ctenar);
                    cmd.ExecuteNonQuery();
                }
                conn.Close(); 
            }
        }
        public void OdstranKnihu(int knihy)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Delete from Knihy where IdKnihy=@idKnihy";
                    cmd.Parameters.AddWithValue("IdKnihy", knihy);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void EditCtenare(int IdCtenar, string Jmeno, string Prijmeni, int PujcenychKnih)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Update Ctenari2 set Jmeno =@Jmeno, Prijmeni = @Prijmeni, PujcenychKnih = @PujcenychKnih where IdCtenar = @IdCtenar";
                    cmd.Parameters.AddWithValue("Jmeno", Jmeno);
                    cmd.Parameters.AddWithValue("Prijmeni", Prijmeni);
                    cmd.Parameters.AddWithValue("PujcenychKnih", PujcenychKnih);
                    cmd.Parameters.AddWithValue("IdCtenar", IdCtenar);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void EditKnihu(int IdKnihy, string Nazev, string Autor, DateTime Datum)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Update Knihy set Nazev =@Nazev, Autor = @Autor, Datum = @Datum where IdKnihy = @IdKnihy";
                    cmd.Parameters.AddWithValue("Nazev", Nazev);
                    cmd.Parameters.AddWithValue("Autor", Autor);
                    cmd.Parameters.AddWithValue("Datum", Datum);
                    cmd.Parameters.AddWithValue("IdKnihy", IdKnihy);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
      
        //public void FiltrujKnihu(string Nazev, string Autor, DateTime Datum)
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = "Select * from Knihy where Nazev = '" + tbSearch.Text + "' ";
        //            cmd.Parameters.AddWithValue("Nazev", Nazev);
        //            cmd.Parameters.AddWithValue("Autor", Autor);
        //            cmd.Parameters.AddWithValue("Datum", Datum);

        //            cmd.ExecuteNonQuery();
        //        }
        //        conn.Close();
        //    }
        //}


    }
}
