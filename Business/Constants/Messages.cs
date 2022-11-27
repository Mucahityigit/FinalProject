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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductAddedError = "Ürün eklenemedi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Bakım zamanı.";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string CategoriesListed = "Kategoriye Göre Listelendi.";
        public static string ProductCountOfCategoryError  = "Kategorideki ürün sayısı limitini açtınız";
        public static string ProductNameAlreadyExist = "Böyle bir isimde ürün zaten var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Yetkiniz yok";
        public static string PasswordError = "Token Oluşturuldu.";
    }
}
