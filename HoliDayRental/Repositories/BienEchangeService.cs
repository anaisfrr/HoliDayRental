using HoliDayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using HoliDayRental.DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HoliDayRental.DAL.Repositories
{
    public class BienEchangeService : ServiceBase, IBienEchangeRepository<BienEchange>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [BienEchange] WHERE [idBien] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

            public BienEchange Get(int id)
        {
                using (SqlConnection connection = new SqlConnection(_connString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                    command.CommandText = "SELECT [idBien],[titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[isEnabled],[DisabledDate],[Latitude],[Longitude],[idMembre],[Datecreation] FROM [BienEchange] WHERE [Id] = @id";
                        SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                        command.Parameters.Add(p_id);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read()) return Mapper.ToBienEchange(reader);
                        return null;
                    }
                }
            }

        public IEnumerable<BienEchange> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idBien],[titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[isEnabled],[DisabledDate],[Latitude],[Longitude],[idMembre],[Datecreation] FROM [BienEchange]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToBienEchange(reader);
                }
            }
        }

        public IEnumerable<BienEchange> GetByMembreId(int membre_id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idBien],[titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[isEnabled],[DisabledDate],[Latitude],[Longitude],[idMembre],[Datecreation] FROM [Membre] WHERE [Membre_Id=@membre";
                    SqlParameter p_membre = new SqlParameter("membre", membre_id);
                    command.Parameters.Add(p_membre);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToBienEchange(reader);
                }
            }
        }

        public int Insert(BienEchange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [BienEchange]( [titre],[DescCourte],[DescLong],[NombrePerson],[Pays],[Ville],[Rue],[Numero],[CodePostal],[Photo],[AssuranceObligatoire],[isEnabled],[DisabledDate],[Latitude],[Longitude],[idMembre],[Datecreation]) OUTPUT [inserted].[Id] VALUES (@titre, @descCourte, @descLong, @nombrePerson, @pays, @ville, @rue, @numero, @codePostal, @photo, @assuranceObligatoire, @isEnabled, @disabledDate, @latitude, @longitude, @idMembre, @dateCreation)";
                    SqlParameter p_titre = new SqlParameter("titre", entity.titre);
                    command.Parameters.Add(p_titre);
                    SqlParameter p_descCourte = new SqlParameter("descCourte", entity.DescCourte);
                    command.Parameters.Add(p_descCourte);
                    SqlParameter p_descLong = new SqlParameter("descLong", entity.DescLong);
                    command.Parameters.Add(p_descLong);
                    SqlParameter p_nombrePerson = new SqlParameter("nombrePerson", entity.NombrePerson);
                    command.Parameters.Add(p_nombrePerson);
                    SqlParameter p_pays = new SqlParameter("pays", entity.Pays);
                    command.Parameters.Add(p_pays);
                    SqlParameter p_ville = new SqlParameter("ville", entity.Ville);
                    command.Parameters.Add(p_ville);
                    SqlParameter p_rue = new SqlParameter("rue", entity.Rue);
                    command.Parameters.Add(p_rue);
                    SqlParameter p_numero = new SqlParameter("numero", entity.Numero);
                    command.Parameters.Add(p_numero);
                    SqlParameter p_codePostal = new SqlParameter("codePostal", entity.CodePostal);
                    command.Parameters.Add(p_codePostal);
                    SqlParameter p_photo = new SqlParameter("photo", entity.Photo);
                    command.Parameters.Add(p_photo);
                    SqlParameter p_assuranceObligatoire = new SqlParameter("assuranceObligatoire", entity.AssuranceObligatoire);
                    command.Parameters.Add(p_assuranceObligatoire);
                    SqlParameter p_isEnabled = new SqlParameter("isEnabled", entity.isEnabled);
                    command.Parameters.Add(p_isEnabled);
                    SqlParameter p_disabledDate = new SqlParameter("disabledDate", entity.DisabledDate);
                    command.Parameters.Add(p_disabledDate);
                    SqlParameter p_latitude = new SqlParameter("latitude", entity.Latitude);
                    command.Parameters.Add(p_latitude);
                    SqlParameter p_longitude = new SqlParameter("longitude", entity.Longitude);
                    command.Parameters.Add(p_longitude);
                    SqlParameter p_idMembre = new SqlParameter("idMembre", entity.idMembre);
                    command.Parameters.Add(p_idMembre);
                    SqlParameter p_dateCreation = new SqlParameter("dateCreation", entity.DateCreation);
                    command.Parameters.Add(p_dateCreation);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, BienEchange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [BienEchange] SET [titre] = @titre, [DescCourte] = @descCourte, [DescLong] = @descLong, [NombrePerson] = @nombrePerson, [Pays] = @pays, [Ville] = @ville, [Rue] = @rue, [Numero] = @numero, [CodePostal] = @codePostal, [Photo] = @photo, [AssuranceObligatoire] = @assuranceObligatoire, [isEnabled] = @isEnabled, [DisabledDate] = @disabledDate, [Latitude] = @latitude, [Longitude] = @longitude, [idMembre] = @idMembre, [DateCreation] = @dateCreation WHERE [idBien] = @id";
                    SqlParameter p_titre = new SqlParameter { ParameterName = "titre", Value = entity.titre };
                    SqlParameter p_descCourte = new SqlParameter { ParameterName = "descCourte", Value = entity.DescCourte };
                    SqlParameter p_descLong = new SqlParameter() { ParameterName = "descLong", Value = entity.DescLong };
                    SqlParameter p_nombrePerson = new SqlParameter() { ParameterName = "nombrePerson", Value = entity.NombrePerson };
                    SqlParameter p_pays = new SqlParameter() { ParameterName = "ville", Value = entity.Ville };
                    SqlParameter p_ville = new SqlParameter() { ParameterName = "descLong", Value = entity.DescLong };
                    SqlParameter p_rue = new SqlParameter() { ParameterName = "rue", Value = entity.Rue };
                    SqlParameter p_numero = new SqlParameter() { ParameterName = "numero", Value = entity.Numero };
                    SqlParameter p_codePostal = new SqlParameter() { ParameterName = "codePostal", Value = entity.CodePostal };
                    SqlParameter p_photo = new SqlParameter() { ParameterName = "photo", Value = entity.Photo };
                    SqlParameter p_assuranceObligatoire = new SqlParameter() { ParameterName = "assuranceObligatoire", Value = entity.AssuranceObligatoire };
                    SqlParameter p_isEnabled = new SqlParameter() { ParameterName = "isEnabled", Value = entity.isEnabled };
                    SqlParameter p_disabledDate = new SqlParameter() { ParameterName = "disabledDate", Value = entity.DisabledDate };
                    SqlParameter p_latitude = new SqlParameter() { ParameterName = "latitude", Value = entity.Latitude };
                    SqlParameter p_longitude = new SqlParameter() { ParameterName = "longitude", Value = entity.Longitude };
                    SqlParameter p_idMembre = new SqlParameter() { ParameterName = "idMembre", Value = entity.idMembre };
                    SqlParameter p_dateCreation = new SqlParameter() { ParameterName = "dateCreation", Value = entity.DateCreation };
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_titre);
                    command.Parameters.Add(p_descCourte);
                    command.Parameters.Add(p_descLong);
                    command.Parameters.Add(p_nombrePerson);
                    command.Parameters.Add(p_pays);
                    command.Parameters.Add(p_ville);
                    command.Parameters.Add(p_rue);
                    command.Parameters.Add(p_numero);
                    command.Parameters.Add(p_codePostal);
                    command.Parameters.Add(p_photo);
                    command.Parameters.Add(p_assuranceObligatoire);
                    command.Parameters.Add(p_isEnabled);
                    command.Parameters.Add(p_disabledDate);
                    command.Parameters.Add(p_latitude);
                    command.Parameters.Add(p_longitude);
                    command.Parameters.Add(p_idMembre);
                    command.Parameters.Add(p_dateCreation);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
