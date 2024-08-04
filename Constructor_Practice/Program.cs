namespace Constructor_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor_Practice_Csharp");

            ExplicitlyConstructor explicitlyConstructor = new ExplicitlyConstructor();

            Test test = new Test(); //This in the last is making a call to constructor


            Console.ReadKey();
        }
    }

    class ExplicitlyConstructor
    {
        public ExplicitlyConstructor()
        {
            Console.WriteLine("\nThis is an Explicitly Constructor or this is Called ");
        }
        

        //We cannot create a function or method name same as class or constructor name

        /*public void ExplicitlyConstructor(int a, int b)
        {

        }
        */

    }


    class Test
    {
        int a;
        string s;
        bool b;
    }


}
