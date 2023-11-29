namespace MyClass
{
    class Magazine : Item, Ipubs
    {


        private string Volume;
        private int Number;
        private string Title;
        private int Year;

        public bool IfSubs { get; set; }        
        public void Subs()
        {
            Console.WriteLine("Подписка на журнал \"{0}\": {1}.", Title, IfSubs);

        }

        public Magazine(string volume, int number, string title, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.Volume = volume;
            this.Number = number;
            this.Title = title;
            this.Year = year;
        }

        public Magazine() { }

        public override void  Show()
        {
            Console.WriteLine("\nЖурнал:\n Том: {0}\n Номер: {1}\nНазвание: {2}\n Год выпуска: {3}", Volume, Number, Title, Year);
            base.Show();
        }

        public override void Return()
        {
            Taken = true;
        }
    }    
}
