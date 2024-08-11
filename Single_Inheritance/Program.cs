namespace Single_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Inheritance - Single and multi-level inheritance");

            //There are two types of Inheritance - Single and Multiple

            //Single consist of - Single & Multilevel
            //Multiple consist of - Hybrid & Multiple & Hierarchial
            Cuboid cuboid = new Cuboid(2,3,4);
            Console.WriteLine(":: Single Inheritance ::\n");

            Console.WriteLine($"\nVolume is : {cuboid.Vol()}\n");
            Console.WriteLine($"Area of Cuboid : {cuboid.Area(2,3)}");
            Console.WriteLine($"\nPerimeter of Cuboid : {cuboid.Perimeter(2,3)}\n");


            
            Console.ReadKey();
        }
    }

    //Parent Class
    internal class Rectange
    {
        internal int length;
        internal int breadth;
        internal int Area( int length, int breadth)
        {
            return length*breadth;
        }

        internal int Perimeter(int length, int breadth)
        {
            return (2*(length + breadth));
        }
    }

    //Child Class
    internal class Cuboid : Rectange
    {
        internal int height;
        internal Cuboid(int l, int b, int h)
        {
            length = l;
            breadth = b;
            height = h;
        }

        internal int Vol()
        { 
            return length*breadth*height;
        }
    }
     
    internal class Cuboid2 : Rectange //, Cuboid
    {
        //We cannot have multiple base classes.
    }
}
