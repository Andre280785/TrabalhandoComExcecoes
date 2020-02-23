using System;
using TrabalhandoComExcecoes.Entities;

namespace TrabalhandoComExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIN = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIN)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIN, checkOut);
                Console.WriteLine(reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIN = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIN < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be dates");
                }
                else if (checkOut <= checkIN)
                {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }
                else
                {
                    reservation.UpdateDates(checkIN, checkOut);
                    Console.WriteLine(reservation);
                }
            }
        }
    }
}
