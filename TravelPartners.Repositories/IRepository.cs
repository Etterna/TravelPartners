using System;
using System.Collections.Generic;
using TravelPartners.Repositories.Entities;

namespace TravelPartners.Repositories
{
    public interface IRepository
    {
        /// <summary>
        /// Creates a user
        /// </summary>
        /// <param name="user">Model of user for create</param>
        void CreateUser(UserEntity user);

        /// <summary>
        /// Gets all users
        /// </summary>
        /// <returns>List of users</returns>
        IEnumerable<UserEntity> GetUsers();

        /// <summary>
        /// Gets user by id
        /// </summary>
        /// <param name="userId">ID of user</param>
        /// <returns>Requested user</returns>
        UserEntity GetUserById(Guid userId);

        /// <summary>
        /// Updates user
        /// </summary>
        /// <param name="user">user to updates</param>
        void UpdateUser(UserEntity user);

        /// <summary>
        /// Deletes user
        /// </summary>
        /// <param name="userId">User ID of user to delete</param>
        void DeleteUser(Guid userId);
    }
}
