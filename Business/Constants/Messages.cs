using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandsListed = "Markalar Listelendi";

        public static string CarAdded = "Araba Eklendi";
        public static string CarUpdate = "Araba Güncellendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarsListed = "Arabalar Listelendi";
        public static string CarNotFound = "Araç bulunamadı";
        public static string CarExists= "Araç zaten veritabanında var.";
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorsListed = "Renkler Listelendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UsersListed = "Kullanıcılar Listelendi";


        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomersListed = "Müşteriler Listelendi";
       
        public static string RentalAdded = "Kiralama İşlemi Başarılı";
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string RentalDeleted = "Kiralama işlemi silindi";
        public static string RentalUpdatedReturnDate = "Araç Teslim Alındı.";
        public static string RentalUpdatedReturnDateError = "Araç Zaten Teslim Alınmış.";

        public static string CarImageAdded = "Araç görseli eklendi";
        public static string CarImageUpdated = "Araç görseli güncellendi";
        public static string CarImageDeleted = "Araç görseli silindi";
        public static string CarImageNotFound = "Görsel bulunamadı";
        public static string CarImageExists = "Görsel kaydı veritabanında var";
        public static string MaxCarImageCountLimit = "Bir aracın en fazla 5 görseli olabilir";
        public static string CarImageListed = "Görsel(ler) listelendi";
        public static string RentalExists = "Kiralama kaydı veritabanında var";
        
    }
}
