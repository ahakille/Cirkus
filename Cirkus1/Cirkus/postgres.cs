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
                string nr;
                string a;
                Träningstillfälle t = new Träningstillfälle();
                nr = dr["id"].ToString();
                t.Plats = dr["plats"].ToString();
                t.Datum = dr["datum"].ToString();
                t.Tid = dr["tid"].ToString();
                t.Aktivitet = dr["aktivitet"].ToString();
                a = dr["aktivtetsid"].ToString();
                t.Id = Convert.ToUInt16(nr);
                t.AktivitetID = Convert.ToUInt16(a);
                tillfälle.Add(t);
                          
            }
            return tillfälle;
        }
        private void SqlNonQuery(string sql)
        {
            try
            {

                _cmd = new NpgsqlCommand(sql, _conn);
                _cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
             
            }

            finally
            {
                _conn.Close();
            }
        }

        public void SqlAdmin(string sql)
        {
            SqlNonQuery(sql);
        }


    }
}
