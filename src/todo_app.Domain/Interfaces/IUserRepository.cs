using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_app.Domain.Entities;

namespace todo_app.Domain.Interfaces
{
    /// <summary>
    /// Represents data access logic for managing User entity
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Adds a new user object to database
        /// </summary>
        /// <param name="user">
        /// user object to add to database
        /// </param>
        /// <returns>
        /// Returns user object after adding it to database
        /// </returns>
        Task<User> AddUser(User user);
        /// <summary>
        /// Updates existing user object in database
        /// </summary>
        /// <param name="user">
        /// user object with changed property
        /// </param>
        /// <returns>
        /// Returns user object after changing it in database
        /// </returns>
        Task<User> UpdateUser(User user);


    }
}
