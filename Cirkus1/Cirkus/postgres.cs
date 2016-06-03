using System;
using Npgsql;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Cirkus
{
    public class postgres
    {
        private NpgsqlConnection _conn;
        private NpgsqlCommand _cmd;
        private NpgsqlDataReader _dr;
        private DataTable _tablell;
        

        public postgres()
        {
                                                                      // db=vår databas
            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            _conn.Open();
            _tablell = new DataTable();
                        
            
        }
        private DataTable sqlFraga (string sql)
        {
            try
            {
                _cmd = new NpgsqlCommand(sql, _conn);

                _dr = _cmd.ExecuteReader();
                _tablell.Load(_dr);
                return _tablell;
            }
            catch (NpgsqlException ex)
            {
                // Felhantering - Retunerar datatable 
                DataColumn c1 = new DataColumn("Errormessage");
                c1.DataType = System.Type.GetType("System.String");
                _tablell.Columns.Add(c1);
                DataRow rad = _tablell.NewRow();
                rad[c1] = ex.Message;
                _tablell.Rows.Add(rad);
                return _tablell;
            }
            finally
            {
                _conn.Close();
            }



        }
        public List<medlem> hämtamedlem (string psql)
        {

            sqlFraga(psql);
            List<medlem> medlem = new List<medlem>();
            foreach (DataRow dr in _tablell.Rows)
            {
                string nr;
                string f;
                int i;
                
                medlem medl = new medlem();
                nr = dr["mednr"].ToString();
                f = dr["födelsedata"].ToString();
                medl.Förnamn = dr["förnamn"].ToString();
                medl.Efternamn = dr["efternamn"].ToString();
                medl.Gata = dr["gata"].ToString();
                medl.Postnr = dr["postnr"].ToString();
                medl.Ort = dr["ort"].ToString();
                medl.Email = dr["email"].ToString();
                medl.Telefon = dr["telefon"].ToString();
                medl.Mobilnr = dr["mobilnr"].ToString();
                medl.Kön = dr["kön"].ToString();
                medl.Medlemstyp = dr["medtyp"].ToString();
                string t =dr["foto"].ToString();
                if(t == "")
                {
                    t = "false";
                }
                 medl.Foto = Convert.ToBoolean(t); 
                if (Int32.TryParse(f, out i))
                {
                    medl.Födelsedata = i;
                }
                else
                {
                    medl.Födelsedata = 00000000;
                }
                medl.Medlemnr = Convert.ToUInt16(nr);
                medlem.Add(medl);
            }          
            return medlem;

        }
        public List<närvaro> hämtanärvaro(string psql)
        {
            sqlFraga(psql);
            List<närvaro> närvaro = new List<närvaro>();
            foreach (DataRow dr in _tablell.Rows)
            {
                string nr;
                string f;
                int i;

                närvaro medl = new närvaro();
                nr = dr["mednr"].ToString();
                f = dr["födelsedata"].ToString();
                medl.Förnamn = dr["förnamn"].ToString();
                medl.Efternamn = dr["efternamn"].ToString();
                medl.Gata = dr["gata"].ToString();
                medl.Postnr = dr["postnr"].ToString();
                medl.Ort = dr["ort"].ToString();
                medl.Email = dr["email"].ToString();
                medl.Telefon = dr["telefon"].ToString();
                medl.Mobilnr = dr["mobilnr"].ToString();
                medl.Kön = dr["kön"].ToString();
                medl.Medlemstyp = dr["medtyp"].ToString();
                string t = dr["foto"].ToString();
                if (t == "")
                {
                    t = "false";
                }
                medl.Foto = Convert.ToBoolean(t);
                if (Int32.TryParse(f, out i))
                {
                    medl.Födelsedata = i;
                }
                else
                {
                    medl.Födelsedata = 00000000;
                }
                medl.Medlemnr = Convert.ToUInt16(nr);
                närvaro.Add(medl);
            }
            return närvaro;
        }
        public List<Träningsgrupp> hämtaträningsgrupp (string psql)
        {
            sqlFraga(psql);
            List<Träningsgrupp> tgrupp = new List<Träningsgrupp>();
            foreach (DataRow dr in _tablell.Rows)
            {
                string nr;
                Träningsgrupp grupp = new Träningsgrupp();
                nr = dr["gruppid"].ToString();
                grupp.Gruppnamn= dr["namn"].ToString();
                grupp.Gruppid = Convert.ToUInt16(nr);
                tgrupp.Add(grupp);
            }
            return tgrupp;

        }
    
        public List<Träningstillfälle> hämtaTräningslista (string psql)
        {
            sqlFraga(psql);
            List<Träningstillfälle> tillfälle = new List<Träningstillfälle>();
            foreach (DataRow dr in _tablell.Rows)
            {
                string nr, datum;
                string a;
                
                Träningstillfälle t = new Träningstillfälle();
                nr = dr["id"].ToString();
                t.Plats = dr["plats"].ToString();
                datum= dr["datum"].ToString();
                t.Tid = dr["tid"].ToString();
                t.Aktivitet = dr["aktivitet"].ToString();
                a = dr["aktivtetsid"].ToString();
                t.Datum = Convert.ToInt32(datum);
                t.Id = Convert.ToUInt16(nr);
                t.AktivitetID = Convert.ToUInt16(a);
                tillfälle.Add(t);
                          
            }
            return tillfälle;
        }
        public List<Träningstillfälle> hämtadeltagare (string psql)
        {

            sqlFraga(psql);
            List<Träningstillfälle> tillfälle = new List<Träningstillfälle>();
            foreach (DataRow dr in _tablell.Rows)
            {
                string nr, datum, count;
                string a;

                Träningstillfälle t = new Träningstillfälle();
                nr = dr["id"].ToString();
                t.Plats = dr["plats"].ToString();
                datum = dr["datum"].ToString();
                t.Tid = dr["tid"].ToString();
                t.Aktivitet = dr["aktivitet"].ToString();
                a = dr["aktivtetsid"].ToString();
                count = dr["count"].ToString();
                t.antaldeltagare = Convert.ToInt32(count);
                t.Datum = Convert.ToInt32(datum);
                t.Id = Convert.ToUInt16(nr);
                t.AktivitetID = Convert.ToUInt16(a);
                tillfälle.Add(t);

            }
            return tillfälle;
        }

        private void SqlNonQuery(string sql, string par1,string par2,string par3 ,string par4 ,string par5 ,string par6)
        {
            try
            {

                _cmd = new NpgsqlCommand(sql, _conn);
                _cmd.Parameters.AddWithValue("par1", par1);
                _cmd.Parameters.AddWithValue("par2", par2);
                _cmd.Parameters.AddWithValue("par3", par3);
                _cmd.Parameters.AddWithValue("par4", par4);
                _cmd.Parameters.AddWithValue("par5", par5);
                _cmd.Parameters.AddWithValue("par6", par6);
                _cmd.ExecuteNonQuery();

            }
            catch (NpgsqlException)
            {
             
            }

            finally
            {
                _conn.Close();
            }
        }
        public void SqlAdmin2(string sql, string par1,string par2)
        {
            string  par3 = "", par4 = "", par5 = "", par6 = "";
            SqlNonQuery(sql, par1, par2, par3, par4, par5, par6);
        }
        public void SqlAdmin1(string sql, string par1)
        {
            string par2 = "", par3 = "", par4 = "", par5 = "", par6 = "";
            SqlNonQuery(sql, par1, par2, par3, par4, par5, par6);
        }
        public void SqlAdmin4(string sql, string par1,string par2,string par3,string par4)
        {
            string  par5 = "", par6 = "";
            SqlNonQuery(sql, par1, par2, par3, par4, par5, par6);
        }
        public void SqlNonQuery2(string sql, string par1, string par2, string par3, string par4, string par5, string par6, string par7, string par8, string par9, string par10, string par11, string par12)
        {
            try
            {

                _cmd = new NpgsqlCommand(sql, _conn);
                _cmd.Parameters.AddWithValue("par1", par1);
                _cmd.Parameters.AddWithValue("par2", par2);
                _cmd.Parameters.AddWithValue("par3", par3);
                _cmd.Parameters.AddWithValue("par4", par4);
                _cmd.Parameters.AddWithValue("par5", par5);
                _cmd.Parameters.AddWithValue("par6", par6);
                _cmd.Parameters.AddWithValue("par7", par7);
                _cmd.Parameters.AddWithValue("par8", par8);
                _cmd.Parameters.AddWithValue("par9", par9);
                _cmd.Parameters.AddWithValue("par10", par10);
                _cmd.Parameters.AddWithValue("par11", par11);
                _cmd.Parameters.AddWithValue("par12", par12);
                _cmd.ExecuteNonQuery();

            }
            catch (NpgsqlException)
            {

            }

            finally
            {
                _conn.Close();
            }
        }
        }
}
