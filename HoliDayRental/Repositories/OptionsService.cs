using HoliDayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.DAL.Repositories
{
    class OptionsService : ServiceBase, IOptionsRepository<Options>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Options] WHERE [Id] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public Options Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idOption],[Libelle] FROM [Options] WHERE [idOption] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToOptions(reader);
                    return null;
                }
            }
        }

        public IEnumerable<Options> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idOption],[Libelle] FROM [Options]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToOptions(reader);
                }
            }
        }

        public IEnumerable<Options> GetByBienEchange(int idBien)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idOption],[Libelle] FROM [BienEchange] WHERE [idBien]=@bienEchange";
                    SqlParameter p_bienEchange = new SqlParameter("bienEchange", idBien);
                    command.Parameters.Add(p_bienEchange);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToOptions(reader);
                }
            }
        }

        public int Insert(Options entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [Options]([idOptions], [Libelle] OUTPUT [inserted].[Id] VALUES (@idOption, @libelle)";
                    SqlParameter p_idOption = new SqlParameter { ParameterName = "idOption", Value = entity.idOption };
                    SqlParameter p_libelle = new SqlParameter { ParameterName = "libelle", Value = entity.Libelle };
                    command.Parameters.Add(p_idOption);
                    command.Parameters.Add(p_libelle);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, Options entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [Options] SET [idOption] = @idOption, [Libelle] = @libelle WHERE [Id] = @id";
                    SqlParameter p_idOption = new SqlParameter { ParameterName = "idOption", Value = entity.idOption };
                    SqlParameter p_libelle = new SqlParameter { ParameterName = "libelle", Value = entity.Libelle };
                    command.Parameters.Add(p_idOption);
                    command.Parameters.Add(p_libelle);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
