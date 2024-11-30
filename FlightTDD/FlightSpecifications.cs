using Domain;
using Xunit;
using FluentAssertions;



namespace FlightTDD
{
    public class FlightSpecifications
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            //Given
            var flight = new Flight(seatCapacity: 3); // Create object with the seat capacity of 3
            //When
            flight.Book("Aurimas@Baniukevicius.com", 1); // Book a flight for email address and book 1 seat
            //Then
            flight.RemainingNumberOfSeats.Should().Be(2); // Fluent Assertion code to replace if statement that would 
                                                              // Take the property of RemainingNumberOfSeats and say that it should be 2 after the method ran
        }

        [Fact]
        public void Avoids_overbooking()
        {
            

            //Given
            var flight = new Flight(seatCapacity: 3);
            //When
            var error = flight.Book("Test@testing.com", 4);
            //Then
            error.Should().BeOfType<OverbookingError>(); // variable error should be of type OverbookingError


        }

        [Fact]
        public void Books_Flights_Succesfully()
        {
            //Given
            Flight flight = new Flight(seatCapacity: 3);
            //When
            var error = flight.Book("test@testing.com", 1);
            //Then
            error.Should().BeNull(); // variable error should come back null 
        }
    }
}