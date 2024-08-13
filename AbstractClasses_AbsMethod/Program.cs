namespace AbstractClasses_AbsMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Class and Abstract Methods !!\n");

            //AbsParent is an abstract class and cannot be intanceciated i.e. we cannot create an instance of any abstract class
            //AbsParent absParent = new AbsParent();

            AbsChild absChild = new AbsChild();

            Console.WriteLine($"Type of the Abstract Class: {absChild.GetType()}\n");

            Console.WriteLine($"Add: {absChild.Add(1,2)}\n");

            Console.WriteLine($"Sub: {absChild.Sub(45,2)}\n");

            Console.WriteLine($"Sub: {absChild.Sub(21,46)}\n");

            Console.WriteLine($"Mul: {absChild.Mul(2,3)}\n");

            Console.WriteLine($"Div: {absChild.Div(1,34)}\n");

             

            Console.ReadKey();
        }
    }


    //Abstract Class
    internal abstract class AbsParent
    {
        internal abstract int Add(int i, int j);
        internal abstract int Sub(int i, int j);

        internal int Mul(int i, int j)
        {
            return i * j;
        }

        internal int Div(int i, int j)
        {
            return i / j;
        }
    } //Abstract class

    //Abstract Child Class inheriting Abstract Class
    internal class AbsChild : AbsParent   
    {
        internal override int Add(int i, int j) //implementing the abstract methods in concerte class 
        { 
            return i + j; 
        }

        internal override int Sub(int i, int j)
        {
            return (i > j) ? (i - j) : (j - i);
        } //implementing the abstract methods in concerte class
    } // Concrete Child class
}
