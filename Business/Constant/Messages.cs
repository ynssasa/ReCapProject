using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constant
{
    public static class Messages
    {

        public static string CarAdded = "Araba eklendi";
        public static string RentalNotAdded = "Araba eklenemedi";
        public static string CarsListed = "Arabalar  Listelendi ";
        public static string CarDeleted = "Araba Silindi";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string CarImageDeleted="Bilinmeyen";
        public static string CarImageUpdated="Bilinmeyen";
        public static string CarImagesLimitExceeded = "Bilinmeyen";
        public static string FailAddedImageLimit="Resim limit hatası";
        public static string DeletedOperation = "Bilinmeyen";
        public static string ListOperation = "Bilinmeyen";
        public static string UpdatedOperation = "Bilinmeyen";
        public static string AuthorizationDenied = "Bilinmeyen";
        public static string UserRegistered = "Bilinmeyen";
        public static string UserNotFound = "Bilinmeyen";
        public static string PasswordError = "Bilinmeyen";
        public static string SuccessfulLogin = "Bilinmeyen";
        public static string UserAlreadyExists = "Bilinmeyen";
        public static string AccessTokenCreated = "Bilinmeyen";
    }
}
