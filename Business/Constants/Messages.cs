using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Added.";
        public static string NotAdded = "Could not be added.";
        public static string Deleted = "Deleted.";
        public static string Updated = "Updated.";
        public static string Listed = "Listed.";
        internal static string CarImageAdded = "Car image added.";
        internal static string CarImageDeleted = "Car image deleted.";
        internal static string CarImageLimitExceded = "Car image limit exceded.";
        internal static string CarImageUpdated = "Car image updated";
        internal static string CarImagesListed = "Car images listed";
        internal static string UserNotFound = "User not found.";
        internal static string PasswordError = "Password Error.";
        internal static string SuccessfulLogin = "Successful Login.";
        internal static string UserAlreadyExists = "User already exists.";
        internal static string UserRegistered = "User registered.";
        internal static string AccessTokenCreated = "Access token created.";
        internal static string AuthorizationDenied = "Authorization denied";
    }
}
