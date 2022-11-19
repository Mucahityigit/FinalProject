using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
