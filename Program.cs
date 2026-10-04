using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace مروة_سعيد_علي_باحشوان
{
    public class LibraryBook
    {
        public string Tital;
        public string AoutherName;
        private bool IsBorrowed;
        public LibraryBook(string tital, string aoutherName,bool isBorrowed)
        {
            Tital = tital;
            AoutherName = aoutherName;
            IsBorrowed = isBorrowed;
        }

        public void BorrowBook()
        {
            if (IsBorrowed)
            {
              IsBorrowed = false;
            }
            else
            {
               Console.WriteLine("Book is already borrowed");
            }
        }
        public void ReternBook()
        {
         if (!IsBorrowed)
            {
                IsBorrowed = true;
            }
         else
            {
                Console.WriteLine("Book is already available");
            }
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine($"The Name of Book:{Tital} The Aouth:{AoutherName} The State of Book{IsBorrowed}");
        }

    }

    public class parking
    {
        public string Brand;
        public string Color;
        private bool IsParked;

        public void ParkCar()
        {
            if (IsParked)
            {
                Console.WriteLine("Car Parked succefully");
            }
            else
            {
                Console.WriteLine("car is already parked");
            }
        }
    }







    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("Be Happy","Ahmed",false);
           book1.ReternBook();
            book1.DisplayBookInfo();
            LibraryBook book2 = new LibraryBook("m", "saad", false);
            book2.BorrowBook();
            book2.DisplayBookInfo();

            parking parking1 = new parking();
            parking1.ParkCar();
           




        }
    }
}
