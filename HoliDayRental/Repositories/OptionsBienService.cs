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
            throw new NotImplementedException();
        }

        public void Update(int id, OptionsBien entity)
        {
            throw new NotImplementedException();
        }
    }
}
