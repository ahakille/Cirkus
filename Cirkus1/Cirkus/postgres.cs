﻿using System;
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
                medlem medl = new medlem();
                nr = dr["mednr"].ToString();
                medl.Förnamn = dr["förnamn"].ToString();
                medl.Efternamn = dr["efternamn"].ToString();
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
