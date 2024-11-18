namespace CarRentalManagment.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
      
        public DateTime Datein { get; set; }

        public int VehicleID { get; set; }

        public int CustomerID { get; set; }


    }
}
