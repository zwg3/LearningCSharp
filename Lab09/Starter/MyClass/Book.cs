
using System.Runtime.CompilerServices;

namespace MyClass
{
    class Book : Item
    {
        private string Author;
        private string Title;
        private string Publisher;
        private int Pages;
        private int Year;
        private bool returnSrok;


        private static double Price = 9;

        public Book (string author, string title, string publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool taken) : base (invNumber, taken)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        static Book()
        {
            Price = 9;
        }

        public static void SetPrice(double price) 
        { 
            Book.Price = price;
        }

        public override void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3}стр.\n Стоимость аренды: {4}", Author, Title, Year, Pages, Book.Price);
            base.Show();
        }

        public double PriceBook(int s)
        {
            return s * Price;
        }

        public void ReturnSrok()
        {
            returnSrok = true;
        }

        public override void Return()
        {
            if(returnSrok)
            {
                Taken = true;
            }
            else
            {
                Taken = false;
            }
        }
    }
}
