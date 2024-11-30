namespace Domain
{
    public class Flight
    {

        public int RemainingNumberOfSeats { get; set; }

        public Flight(int seatCapacity)
        {
            RemainingNumberOfSeats = seatCapacity; // I pass the seatCapacity to the Remaining number of seats
        }
        // We can make the method return object ? means nullable that means if it doesnt return the object it is still fine
        public object? Book(string passengerEmail, int bookedSeats)
        {
            // Avoid the Overbooking the Flight
            // Remember the Booking


            if (this.RemainingNumberOfSeats < bookedSeats)
            {
                return new OverbookingError();
            }
            RemainingNumberOfSeats -= bookedSeats; // I decrease the remaining number of seats by the booked seats

            // if there is enough seats seats on the plane for the amount booked return null
            return null;
            
        }



    }
}
