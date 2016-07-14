using Microsoft.Azure.Mobile.Server;

namespace where_I_workService.DataObjects
{
    public class Business : EntityData
    {
        public string BusinessName { get; set; }
        public string Category { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsFavorite { get; set; }
        public string Website { get; set; }
        public Address Address { get; set; }
        public Rating Rating { get; set; }
    }
}