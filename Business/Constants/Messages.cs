﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandAdded = "Brand is Added";
        public static string BrandUpdated = "Brand is Updated";
        public static string BrandDeleted = "Brand is Deleted";
        public static string BrandNameInvalid = "The brand you want to add already exists.Enter a different brand.";
        
        public static string CarAdded = "Car is Added";
        public static string CarDeleted = "Car is Deleted";
        public static string CarUpdated = "Car is Updated";
        public static string CarNameInvalid = "The car you want to add already exists.";
        public static string CarsListed = "Cars Listed";

        public static string ColorAdded = "Color is Added";
        public static string ColorUpdated = "Color is Updated";
        public static string ColorDeleted = "Color is Deleted";
        public static string ColorNameInvalid = "The color you want to add already exists. Please enter a different color.";
        public static string ColorsListed = "Colors Listed";

        public static string CustomerAdded = "Customer is Added";
        public static string CustomerUpdated = "Customer is Updated";
        public static string CustomerDeleted = "Customer is Deleted";
        public static string CustomerNameInvalid = "The customer you want to add already exists.";
        public static string CustomersListed = "Customers Listed";

        public static string RentalAdded = "Rental Process is Successful";
        public static string RentalUpdated = "Rental is Updated";
        public static string RentalDeleted = "Rental is Deleted";
        public static string RentalReturned = "Rental is Returned";
        public static string RentalNameInvalid = "Before the vehicle can be rented, it must be delivered.";
        public static string RentalDateInvalid = "The rental does not exist.";
        public static string RentalBusy = "Rental is already in use.";
        public static string RentalRecordsInvalid = "Rental records doesn't exists.";
        public static string RentalsListed = "Rentals Listed";

        public static string UserAdded = "User is Added";        
        public static string UserUpdated = "User is Updated";       
        public static string UserDeleted = "User is Deleted";       
        public static string UserNameInvalid = "The User you want to add already exists.";      
        public static string UsersListed = "Users Listed";
        
        public static string CarImageAdded = "Car Image is Added";
        public static string CarImageDeleted = "Car Image is Deleted";
        public static string CarImageUpdated = "Car Image is Updated";
        public static string CarImageInvalid = "Car Image you want to add has invalid extension.";
        public static string CarImageAddingLimit = "You can not add more images.";
        
        public static string AuthorizationDenied = "Kimlik Doğrulanamadı!";
        public static string UserRegistered = "Kayıt Başarılı.";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Hatalı Şifre Girdiniz";
        public static string SuccessfulLogin = "Giriş Başarılı!";
        public static string UserAlreadyExists = "Kullanıcı Zaten Var";
        public static string AccessTokenCreated = "Token Oluşturuldu.";
    }
}
