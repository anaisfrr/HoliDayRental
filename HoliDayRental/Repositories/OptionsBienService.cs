using HoliDayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.DAL.Repositories
{
    class OptionsBienService : ServiceBase, IOptionsBienRepository<OptionsBien>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [OptionsBien] WHERE [Id] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public OptionsBien Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idOption],[idBien],[Valeur] FROM [OptionsBien] WHERE [idOption] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToOptionsBien(reader);
                    return null;
                }
            }
        }

        public IEnumerable<OptionsBien> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idOption],[Libelle],[idBien] FROM [OptionsBien]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToOptionsBien(reader);
                }
            }
        }

        public IEnumerable<OptionsBien> GetByBienEchange(int idBien)
        {
            throw new NotImplementedException();
        }

        public int Insert(OptionsBien entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [OptionsBien]([idOption], [idBien], [Valeur] OUTPUT [inserted].[Id] VALUES (@idOption, @idBien, @valeur)";
                    SqlParameter p_idOption = new SqlParameter { ParameterName = "idOption", Value = entity.idOption };
                    SqlParameter p_idBien = new SqlParameter { ParameterName = "idBien", Value = entity.idBien };
                    SqlParameter p_valeur = new SqlParameter { ParameterName = "valeur", Value = entity.Valeur };
                    command.Parameters.Add(p_idOption);
                    command.Parameters.Add(p_idBien);
                    command.Parameters.Add(p_valeur);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, OptionsBien entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [OptionsBien] SET [idOption] = @idOption, [idBien] = @idBien, [Valeur] = @valeur WHERE [Id] = @id";
                    SqlParameter p_idOption = new SqlParameter { ParameterName = "idOption", Value = entity.idOption };
                    SqlParameter p_idBien = new SqlParameter { ParameterName = "idBien", Value = entity.idBien };
                    SqlParameter p_valeur = new SqlParameter { ParameterName = "valeur", Value = entity.Valeur };
                    command.Parameters.Add(p_idOption);
                    command.Parameters.Add(p_idBien);
                    command.Parameters.Add(p_valeur);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
