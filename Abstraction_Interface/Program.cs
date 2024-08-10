namespace Abstraction_Interface
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\nAbstraction Example - Small Bank Ex - INTERFACE\n");

			Console.WriteLine("Welcome to Bank - Axis\n");

			IBankServices bank1 = Bankfactory.BankSelect("Axis");

			bank1.BankTransfer();
			bank1.CheckBalanace();
			bank1.WithdrawMoney();
			bank1.ValidateCard();






			Console.ReadKey();
		}
	}

	interface IBankServices
	{
		void ValidateCard();
		void WithdrawMoney();
		void CheckBalanace();
		void BankTransfer();
		void MiniStatement();
	}

	class Bankfactory
	{
		public static IBankServices BankSelect(string BankType)
		{
			IBankServices bankServices = null;
			if (BankType == "Axis")
			{
				bankServices = new AXISB();
			}

			return bankServices;
		
		}
	}

	class AXISB : IBankServices
	{
		public void ValidateCard() {
			Console.WriteLine("\nAxis Bank Validate Card");
		}
		public void WithdrawMoney() {
			Console.WriteLine("\nAxis Bank Validate Card");

		}
		public void CheckBalanace() {
			Console.WriteLine("\nAxis Bank Validate Card");
		}
		public void BankTransfer() { Console.WriteLine("\nAxis Bank Validate Card"); 
		}
		public void MiniStatement() {
			Console.WriteLine("\nAxis Bank Validate Card");
		}

	}
}
