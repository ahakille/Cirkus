using System;
using Npgsql;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    public class postgres
    {
        private NpgsqlConnection _conn;
        private NpgsqlCommand _cmd;
        private NpgsqlDataReader _dr;

        public Postgres()
        {
            // hej=vår databas
            _conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["hej"].ConnectionString);
            _conn.Open();
            
        }
        private NpgsqlDataReader sqlFraga (string sql)
        {
            try
            {
                _cmd = new NpgsqlCommand(sql, _conn);
                _dr = _cmd.ExecuteReader();
                return _dr;
            }
            catch (NpgsqlException ex)
            {
                //ska försöka bygga klart när erik visar
                return null;
            }
            finally
            {
            //    _conn.Close();
            }
                
            

        }
    }
}
