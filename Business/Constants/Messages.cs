using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BookAdded = "Book has been added";
        public static string BookDeleted = "Book has been deleted";
        public static string BookUpdated = "Book has been updated";

        public static string AuthorAdded = "Author has been added";
        public static string AuthorDeleted = "Author has been deleted";
        public static string AuthorUpdated = "Author has been updated";

        public static string PublisherAdded = "Publisher has been added";
        public static string PublisherDeleted = "Publisher has been deleted";
        public static string PublisherUpdater = "Publisher has been updated";
        
        public static string BookTypeAdded = "Book type has been added";
        public static string BookTypeDeleted = "Book type has been deleted";
        public static string BookTypeUpdated = "Book type has been updated";
        
        public static string UserAdded = "User has been added";
        public static string UserDeleted = "User has been deleted";
        public static string UserUpdated = "User has been updated";
        
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Wrong password";
        public static string SuccessfulLogin = "Successful login";

        public static string UserAlreadyExists = "User already exists";
        public static string UserRegistered = "User successfully registered";
        public static string AccessTokenCreated = "Access token has been created";
        public static string UserCannotBeRegistered = "User cannot be registered";
    }
}
