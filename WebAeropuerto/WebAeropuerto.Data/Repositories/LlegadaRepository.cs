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
    public class LlegadaRepository : ILlegadaRepository
    {
        private readonly MySQLConfiguration _connectionString;
        public LlegadaRepository(MySQLConfiguration connectionString) 
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection() 
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> DeleteLlegada(Llegada llegada)
        {
            var db = dbConnection();
            var sql = @"DELETE FROM llegadas WHERE id = @Id";

            var result = await db.ExecuteAsync(sql,new {Id = llegada.Id});
            return result > 0;
        }

        public async Task<IEnumerable<Llegada>> GetAllLlegadas()
        {
            var db = dbConnection();
            var sql = @"SELECT id, hora, desde, vuelo_no, observaciones FROM llegadas";

            return await db.QueryAsync<Llegada>(sql, new { });
        }

        public async Task<Llegada> GetDetails(int id)
        {
            var db = dbConnection();
            var sql = @"SELECT id, hora, desde, vuelo_no, observaciones FROM llegadas WHERE id = @Id";

            return await db.QueryFirstOrDefaultAsync<Llegada>(sql, new { Id = id });
        }

        public async Task<bool> InsertLlegada(Llegada llegada)
        {
            var db = dbConnection();
            var sql = @"INSERT INTO llegadas (hora, desde, vuelo_no, observaciones)
                        VALUES (@Hora, @Desde, @Vuelo_no, @Observaciones)";

            var  result = await db.ExecuteAsync(sql, new 
            { llegada.Hora, llegada.Desde, llegada.Vuelo_No, llegada.Observacion });

            return result > 0;
        }

        public async Task<bool> UpdateLlegada(Llegada llegada)
        {
            var db = dbConnection();
            var sql = @" UPDATE llegadas
                        SET hora = @Hora,
                            desde = @Desde,
                            vuelo_no = @Vuelo_no,
                            observaciones = @Observaciones
                            WHERE id = @Id";

            var result = await db.ExecuteAsync(sql, new
            { llegada.Hora, llegada.Desde, llegada.Vuelo_No, llegada.Observacion });

            return result > 0;
        }
    }
}
