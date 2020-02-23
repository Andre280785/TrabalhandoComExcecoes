using System;

namespace TrabalhandoComExcecoes.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIN { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIN, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIN = checkIN;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIN);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIN, DateTime checkOut)
        {
            CheckIN = checkIN;
            CheckOut = checkOut;
        }
        public override string ToString()
        {
            return "Reservation Room "
                + RoomNumber
                + ", check-in: "
                + CheckIN.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + $", {Duration()} nights."
                ;

        }
    }
}
