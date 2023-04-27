using Dapper;
using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class CityRepository
    {
        private string _connectionString;
        private Npgsql.NpgsqlConnection connection;
        public CityRepository(string connectionString)
        {
            this._connectionString = connectionString;
            this.connection = new Npgsql.NpgsqlConnection(this._connectionString);
        }

        // TODO: Add more colums to the query

        public string insert(CityModel city)
        {
            try
            {
                String query = "insert into city(state, city) " +
                     " values(@state, @city)";
                connection.Open();
                connection.Execute(query, city);
                connection.Close();

                return "Se inserto correctamente...";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string modify(CityModel city, int id)
        {
            try
            {
                // update city with params
                connection.Execute($"UPDATE city SET " +
                                   "state = @state, " +
                                   "city = @city " +
                                   $"WHERE id = {id}", city);
                return "Se modificaron los datos correctamente...";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string delete(int id)
        {
            try
            {
                connection.Execute($" DELETE FROM city WHERE id = {id}");
                return "Se eliminó correctamente el registro...";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CityModel getById(int id)
        {
            try
            {   
                return connection.QueryFirst<CityModel>($"SELECT * FROM city WHERE id = {id}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<CityModel> read()
        {
            try
            {

                // Select * from subject order by id asc
                return connection.Query<CityModel>("SELECT * FROM city order by id asc");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
