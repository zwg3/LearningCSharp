
namespace MyClass
{
    abstract class Item
    {
        protected long InvNumber; // инвентарный номер — целое число
        protected bool Taken;    // хранит состояние объекта - взят ли на руки

        public Item(long invNumber, bool taken)
        {
            this.InvNumber = invNumber;
            this.Taken = taken;
        }

        public Item()
        {
            this.Taken = true;
        }

        public bool IsAvailable()    // истина, если этот предмет имеется в библиотеке
        {
            if (Taken == true)
                return true;
            else
                return false;
        }

        public long GetInvNumber()   // инвентарный номер  
        {
            return InvNumber;
        }


        private void Take()      // операция "взять"
        {
            Taken = false;
        }

        abstract public void Return();    // операция "вернуть"


        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }


        public virtual void Show()
        {
            Console.WriteLine("Состояние хранения:\n Инвентарный номер: {0}\n Наличие: {1}", InvNumber, Taken);
        }

    }
}

