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
                //ska försöka bygga klart när erik visar
                return null;
            }
            finally
            {
               _conn.Close();
            }
                
            

        }
        public void test()
        {
            sqlFraga("select * from *");
        }

        public void SqlAdmin(string sql)
        {
            try
            {
                _cmd = new NpgsqlCommand(sql, _conn);
            }
            catch (NpgsqlException ex)
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
