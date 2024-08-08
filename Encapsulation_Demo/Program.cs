namespace Encapsulation_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Encapsulation Demo #1\n");

                //Bank bank = new Bank();
                Bank1 bank1 = new Bank1();  

                bank1.Amount = 1;
                //bank.setBalance(100);
                Console.WriteLine(bank1.Amount);

                Console.WriteLine("");
                //

                ///bank.setBalance(-122);
                bank1.Amount = -11;
                Console.WriteLine(bank1.Amount);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Bank
    {
        private int _Amount;

        public int getAmount()
        {
            return _Amount;
        }

        public void setBalance (int Amount)
        {
            if (Amount > 0)
            {
                this._Amount = Amount;
            }
            else
            {
                throw new Exception("Please pass +ve Num");
            }
        }
    }

    class Bank1
    {
        private int _Amount;
        public int Amount
        {
            get
            {
               return this._Amount;
            }
            set
            {
                if(value<0)
                {
                    throw new Exception("Pelase pass +ve value\n");
                }
                else
                {
                    this._Amount = value;
                }
            }
        }
    }
}
