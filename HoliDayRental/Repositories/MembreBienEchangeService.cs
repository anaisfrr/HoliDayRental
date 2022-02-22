using HoliDayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using HoliDayRental.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HoliDayRental.DAL.Repositories
{
    public class MembreBienEchangeService : ServiceBase, IMembreBienEchangeRepository<MembreBienEchange>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [MembreBienEchange] WHERE [Id] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public MembreBienEchange Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idMembre],[idBien],[DateDebEchange],[DateFinEchange],[Assurance],[Valide] FROM [MembreBienEchange] WHERE [Id] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToMembreBienEchange(reader);
                    return null;
                }
            }
        }

        public IEnumerable<MembreBienEchange> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idMembre],[idBien],[DateDebEchange],[DateFinEchange],[Assurance],[Valide] FROM [MembreBienEchange]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembreBienEchange(reader);
                }
            }
        }

        public IEnumerable<MembreBienEchange> Get(DateTime DateDebEchange)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [MembreBienEchange].[idMembre],[idBien],[DateDebEchange],[DateFinEchange],[Assurance],[Valide] FROM [MembreBienEchange] JOIN [Membre] ON [MembreBienEchange].[idMembre] = [Membre].[MembreBienEchange_Id] WHERE [Membre].[Bien_Id] = @id_bien AND [Membre].[DateDebEchange] = @date";
                    SqlParameter p_date = new SqlParameter() { ParameterName = "date", Value = DateDebEchange };
                    command.Parameters.Add(p_date);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembreBienEchange(reader);
                }
            }
        }

        public int Insert(MembreBienEchange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [MembreBienEchange]([idMembre], [idBien], [DateDebEchange],[DateFinEchange], [Assurance], [Valide]) OUTPUT [inserted].[Id] VALUES (@idMembre, @idBien, @dateDebEchange, @dateFinEchange, @assurance, @valide)";
                    SqlParameter p_idMembre = new SqlParameter { ParameterName = "idMembre", Value = entity.idMembre };
                    SqlParameter p_idBien = new SqlParameter { ParameterName = "idBien", Value = entity.idBien };
                    SqlParameter p_dateDebEchange = new SqlParameter { ParameterName = "dateDebEchange", Value = entity.DateDebEchange };
                    SqlParameter p_dateFinEchange = new SqlParameter { ParameterName = "dateFinEchange", Value = entity.DateFinEchange };
                    SqlParameter p_assurance = new SqlParameter { ParameterName = "assurance", Value = entity.Assurance };
                    SqlParameter p_valide = new SqlParameter { ParameterName = "valide", Value = entity.Valide };
                    command.Parameters.Add(p_idMembre);
                    command.Parameters.Add(p_idBien);
                    command.Parameters.Add(p_dateDebEchange);
                    command.Parameters.Add(p_dateFinEchange);
                    command.Parameters.Add(p_assurance);
                    command.Parameters.Add(p_valide);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, MembreBienEchange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [MembreBienEchange] SET [idMembre] = @idMembre, [idBien] = @idBien, [DateDebEchange] = @dateDebEchange, [DateFinEchange] = @dateFinEchange, [Assurance] = @assurance, [Valide] = @valide WHERE [Id] = @id";
                    SqlParameter p_idMembre = new SqlParameter { ParameterName = "idMembre", Value = entity.idMembre };
                    SqlParameter p_idBien = new SqlParameter { ParameterName = "idBien", Value = entity.idBien };
                    SqlParameter p_dateDebEchange = new SqlParameter { ParameterName = "aateDebEchange", Value = entity.DateDebEchange };
                    SqlParameter p_dateFinEchange = new SqlParameter { ParameterName = "dateFinEchange", Value = entity.DateFinEchange };
                    SqlParameter p_assurance = new SqlParameter { ParameterName = "assurance", Value = entity.Assurance };
                    SqlParameter p_valide = new SqlParameter { ParameterName = "valide", Value = entity.Valide };
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_idMembre);
                    command.Parameters.Add(p_idBien);
                    command.Parameters.Add(p_dateDebEchange);
                    command.Parameters.Add(p_dateFinEchange);
                    command.Parameters.Add(p_assurance);
                    command.Parameters.Add(p_valide);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
