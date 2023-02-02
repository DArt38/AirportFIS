using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAeropuerto.Model;

namespace WebAeropuerto.Data.Repositories
{
    public class SalidaRepository : ISalidaRepository
    {
        private readonly MySQLConfiguration _connectionString;
        public SalidaRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> DeleteSalida(Salida salida)
        {
            var db = dbConnection();
            var sql = @"DELETE FROM salidas WHERE id = @Id";

            var result = await db.ExecuteAsync(sql, new { Id = salida.Id });
            return result > 0;
        }

        public async Task<IEnumerable<Salida>> GetAllSalidas()
        {
            var db = dbConnection();
            var sql = @"SELECT id, hora, hasta, vuelo_no, puerta, observaciones FROM salidas";

            return await db.QueryAsync<Salida>(sql, new { });
        }

        public async Task<Salida> GetSalidaDetails(int id)
        {
            var db = dbConnection();
            var sql = @"SELECT id, hora, hasta, vuelo_no, puerta, observaciones FROM salidas WHERE id = @Id";

            return await db.QueryFirstOrDefaultAsync<Salida>(sql, new { Id = id });
        }

        public async Task<bool> InsertSalida(Salida salida)
        {
            var db = dbConnection();
            var sql = @"INSERT INTO salidas (hora, hasta, vuelo_no, puerta, observaciones)
                        VALUES (@Hora, @Hasta, @Vuelo_no, @Puerta, @Observaciones)";

            var result = await db.ExecuteAsync(sql, new
            { salida.Hora, salida.Hasta, salida.Vuelo_No, salida.Puerta, salida.Observaciones });

            return result > 0;
        }

        public async Task<bool> UpdateSalida(Salida salida)
        {
            var db = dbConnection();
            var sql = @"UPDATE salidas
                        SET hora = @Hora,
                            hasta = @Hasta,
                            vuelo_no = @Vuelo_no,
                            puerta = @Puerta,
                            observaciones = @Observaciones
                            WHERE id = @Id";

            var result = await db.ExecuteAsync(sql, new
            { salida.Hora, salida.Hasta, salida.Vuelo_No, salida.Puerta, salida.Observaciones });

            return result > 0;
        }
    }
}
