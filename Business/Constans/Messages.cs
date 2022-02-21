using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Constans
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda daha sonra deneyiniz";

        public static string CarUpdate = "Araba güncellendi";
        public static string CarDelete = "Araba silindi";
        public static string CarAddedd = "Araba eklendi";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";


        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marak Güncellendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string RentalAdded = "Kiralama kaydı eklendi";
        public static string RentalInvalid = "Kiralama geçersiz";

        public static string RemovedMessage { get; internal set; }
        public static string AddedMessage { get; internal set; }
        public static string UpdatedMessage { get; internal set; }
    }
}
