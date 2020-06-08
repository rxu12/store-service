using System;

namespace myMicroservice
{
    public class Store
    {
        public string id { get; set; }

        public string partnerId { get; set; }

        public string name { get; set; }

        public string status { get; set; } // Should use Enum

        public DateTime openingDate { get; set; }

        public DateTime closingDate { get; set; }

        public string generalNotification { get; set; }

        public string openingNotification { get; set; }

        public string priorityNotificationText { get; set; }

        //public Address address { get; set; }

        //public GeoLocation geolocation { get; set; }
     
        //public StoreHours openingHours { get; set; }

        //public StoreHours exceptionHours { get; set; }

        //public StoreService services { get; set; }
    }
}
