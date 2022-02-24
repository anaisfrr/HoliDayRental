using HoliDayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using HoliDayRental.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HoliDayRental.DAL.Repositories
{
    public class AvisMembreBienService : ServiceBase, IAvisMembreBienRepository<AvisMembreBien>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [AvisMembreBien] WHERE [idAvis] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public AvisMembreBien Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idAvis],[note],[message],[idMembre],[idBien],[DateAvis],[Approuve] FROM [AvisMembreBien] WHERE [idAvis] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToAvisMembreBien(reader);
                    return null;
                }
            }
        }

        public IEnumerable<AvisMembreBien> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT[idAvis],[note],[message],[idMembre],[idBien],[DateAvis],[Approuve] FROM [AvisMembreBien]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToAvisMembreBien(reader);
                }
            }
        }

        public IEnumerable<AvisMembreBien> GetByMembreId(int membre_id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idAvis],[note],[message],[idMembre],[idBien],[DateAvis],[Approuve] FROM [Membre] WHERE [Membre_Id]=@membre";
                    SqlParameter p_membre = new SqlParameter("membre", membre_id);
                    command.Parameters.Add(p_membre);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToAvisMembreBien(reader);
                }
            }
        }

        public int Insert(AvisMembreBien entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [AvisMembreBien]([note], [message], [idMembre], [idBien], [DateAvis], [Approuve] OUTPUT [inserted].[isAvis] VALUES (@note, @message, @idMembre, @idBien, @dateAvis, @approuve)";
                    SqlParameter p_note = new SqlParameter { ParameterName = "note", Value = entity.note };
                    SqlParameter p_message = new SqlParameter { ParameterName = "message", Value = entity.message };
                    SqlParameter p_idBien = new SqlParameter { ParameterName = "idBien", Value = entity.idBien };
                    SqlParameter p_idMembre = new SqlParameter { ParameterName = "idMembre", Value = entity.idMembre };
                    SqlParameter p_dateAvis = new SqlParameter { ParameterName = "dateAvis", Value = entity.DateAvis };
                    SqlParameter p_approuve = new SqlParameter { ParameterName = "approuve", Value = entity.Approuve };
                    command.Parameters.Add(p_note);
                    command.Parameters.Add(p_message);
                    command.Parameters.Add(p_idBien);
                    command.Parameters.Add(p_idMembre);
                    command.Parameters.Add(p_dateAvis);
                    command.Parameters.Add(p_approuve);;
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, AvisMembreBien entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [AvisMembreBien] SET [note] = @note, [message] = @message, [idMembre] = @idMembre, [idBien] = @idBien, [DateAvis] = @dateAvis, [Approuve] = @approuve WHERE [idAvis] = @id";
                    SqlParameter p_note = new SqlParameter { ParameterName = "note", Value = entity.note };
                    SqlParameter p_message = new SqlParameter { ParameterName = "message", Value = entity.message };
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    SqlParameter p_idMembre = new SqlParameter() { ParameterName = "idMembre", Value = entity.idMembre };
                    SqlParameter p_idBien = new SqlParameter() { ParameterName = "idBien", Value = entity.idBien };
                    SqlParameter p_dateAvis = new SqlParameter() { ParameterName = "dateAvis", Value = entity.DateAvis };
                    SqlParameter p_approuve = new SqlParameter() { ParameterName = "approuve", Value = entity.Approuve };
                    command.Parameters.Add(p_note);
                    command.Parameters.Add(p_message);
                    command.Parameters.Add(p_id);
                    command.Parameters.Add(p_idMembre);
                    command.Parameters.Add(p_idBien);
                    command.Parameters.Add(p_dateAvis);
                    command.Parameters.Add(p_approuve);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
