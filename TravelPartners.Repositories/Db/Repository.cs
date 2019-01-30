using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using TravelPartners.Repositories.Entities;

namespace TravelPartners.Repositories.Db
{
    public sealed class Repository : IRepository
    {
        private readonly string _connectionString;

        public Repository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region Methods

        public void CreateUser(UserEntity user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute("Users_Create", user, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<UserEntity> GetUsers()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<UserEntity>("Users_GetAll", commandType: CommandType.StoredProcedure);
            }
        }

        public UserEntity GetUserById(Guid userId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.QuerySingleOrDefault<UserEntity>("Users_GetById", new {userId},
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateUser(UserEntity user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute("Users_Update", user, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteUser(Guid userId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute("Users_Delete", new {userId}, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion Methods
    }
}
