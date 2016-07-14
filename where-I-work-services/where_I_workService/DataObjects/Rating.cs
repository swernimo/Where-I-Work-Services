using Microsoft.Azure.Mobile.Server;

namespace where_I_workService.DataObjects
{
    public class Rating : EntityData
    {
        public decimal NoiseLevel { get; set; }
        public bool HasFreeWifi { get; set; }
        public decimal WifiRating { get; set; }
        public decimal ValueForMoney { get; set; }
        public decimal Seating { get; set; }
        public decimal Parking { get; set; }
        public decimal PowerOutlets { get; set; }
        public bool WouldWorkThereAgain { get; set; }
        public bool HasLoyaltyProgram { get; set; }
        public string WifiPassword { get; set; } //TODO: this needs to be encrypted at rest and at transit
    }
}
