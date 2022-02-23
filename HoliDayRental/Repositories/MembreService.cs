using HoliDayRental.Common.Repositories;
using HoliDayRental.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HoliDayRental.DAL.Repositories
{
    public class MembreService : ServiceBase, IMembreRepository<Membre>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Membre] WHERE [idMembre] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public Membre Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [Membre] WHERE [Id] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToMembre(reader);
                    return null;
                }
            }
        }

        public IEnumerable<Membre> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [Membre]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembre(reader);
                }
            }
        }

        public IEnumerable<Membre> GetByBienEchange(int idBien)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Membre].[Id],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [Membre] JOIN [BienEchange] ON [Membre].[Id] = [BienEchange_id] WHERE [BienEchange].[Id] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = idBien };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembre(reader);
                }
            }
        }

        public int Insert(Membre entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [Membre]([Nom], [Prenom], [Email], [Pays], [Telephone], [Login], [Password]) OUTPUT [inserted].[Id] VALUES (@nom, @prenom, @email, @pays, @telephone, @login, @password)";
                    SqlParameter p_nom = new SqlParameter { ParameterName = "nom", Value = entity.Nom };
                    SqlParameter p_prenom = new SqlParameter { ParameterName = "prenom", Value = entity.Prenom };
                    SqlParameter p_email = new SqlParameter { ParameterName = "email", Value = entity.Email };
                    SqlParameter p_pays = new SqlParameter { ParameterName = "pays", Value = entity.Pays };
                    SqlParameter p_telephone = new SqlParameter { ParameterName = "telephone", Value = entity.Telephone };
                    SqlParameter p_login = new SqlParameter { ParameterName = "login", Value = entity.Login };
                    SqlParameter p_password = new SqlParameter { ParameterName = "password", Value = entity.Password };
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_prenom);
                    command.Parameters.Add(p_email);
                    command.Parameters.Add(p_pays);
                    command.Parameters.Add(p_telephone);
                    command.Parameters.Add(p_login);
                    command.Parameters.Add(p_password);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, Membre entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [Membre] SET [Nom] = @nom, [Prenom] = @prenom, [Email] = @email, [Pays] = @pays, [Telephone] = @telephone, [Login] = @login, [Password] = @password, WHERE [Id] = @id";
                    SqlParameter p_nom = new SqlParameter { ParameterName = "nom", Value = entity.Nom };
                    SqlParameter p_prenom = new SqlParameter { ParameterName = "prenom", Value = entity.Prenom };
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    SqlParameter p_email = new SqlParameter() { ParameterName = "email", Value = entity.Email };
                    SqlParameter p_pays = new SqlParameter() { ParameterName = "pays", Value = entity.Pays };
                    SqlParameter p_telephone = new SqlParameter() { ParameterName = "telephone", Value = entity.Telephone };
                    SqlParameter p_login = new SqlParameter() { ParameterName = "login", Value = entity.Login };
                    SqlParameter p_password = new SqlParameter() { ParameterName = "password", Value = entity.Password };
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_prenom);
                    command.Parameters.Add(p_id);
                    command.Parameters.Add(p_email);
                    command.Parameters.Add(p_pays);
                    command.Parameters.Add(p_telephone);
                    command.Parameters.Add(p_login);
                    command.Parameters.Add(p_password);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }

}
