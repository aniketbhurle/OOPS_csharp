namespace Abstraction_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction Abstract Method !!\n");

            IBankServices bankServices = Bankfact.SelectBank("SBI");

            bankServices.CheckBalanace();
            bankServices.BankTransfer();
            bankServices.Validate();
            bankServices.WithdrawMoney();


            Console.ReadKey();
        }
    }

    public abstract class IBankServices
    {
        public abstract void Validate();
        public abstract void WithdrawMoney();
        public abstract void CheckBalanace();
        public abstract void BankTransfer();
        public abstract void MiniStatement();
    }

    public class SBI : IBankServices
    {
        public override void Validate()
        { Console.WriteLine("SBI Bank - Validate");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank - Withdraw Money");
        }
        public override void CheckBalanace()
        {
            Console.WriteLine("SBI Bank - Check Balance");
        }
        public override void BankTransfer()
        {
            Console.WriteLine("SBI Bank - Bank Transfer");
        }
        public override void MiniStatement()
        {
            Console.WriteLine("SBI Bank - Mini Statement");
        }
    }

    public class Bankfact
    {
        public static IBankServices SelectBank(string BNK)
        {
            IBankServices banksel = null;
            if(BNK == "SBI")
            {
                banksel = new SBI();
            }

            return banksel;
        }
    }
}
