using System.Xml.Linq;

namespace Constructor_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Types: ");
            Console.WriteLine("1. Default / Parameter-less Construstor\n2. Parameterized\n3. Copy\n" +
                "4. Static\n5. Private");

            //Default User-Defined Construstor
            Console.WriteLine("\n*****Default User-Defined Construstor*****");
            EmployeeDefaultUserDefined emp_1 = new EmployeeDefaultUserDefined();
            emp_1.display();
            

            //Default System-Defined Construstor
            Console.WriteLine("\n*****Default System-Defined Construstor*****");
            EmployeeDefaultSystemdefined employeeDefaultSystemdefined = new EmployeeDefaultSystemdefined(); 
            employeeDefaultSystemdefined.display();


            //Parameterized Construstor
            Console.WriteLine("\n*****-Parameterized Construstor*****");
            EmployeeParameterized employeeParameterized = new EmployeeParameterized(100,"JamesSimth","Male",102.8);
            employeeParameterized.display();

            EmployeeParameterized employeeParameterized1 = new EmployeeParameterized(102, "Irene", "Female", 1032.23);
            employeeParameterized1.display();


            //Copy Constructor
            Console.WriteLine("\n*****Copy Construstor*****");
            Empl_CopyConstructor copyConstructor = new Empl_CopyConstructor(100, "JamesSimth", "Male", true);
            copyConstructor.display();

            //Passing a object directly into Copy Constructor
            Empl_CopyConstructor copyConstructor_1 = new Empl_CopyConstructor(copyConstructor);
            copyConstructor_1.display();


            //Static Constructor
            Console.WriteLine("\n*****Static Construstor*****");
            Emp_static_constructor emp_Static_Constructor = new Emp_static_constructor();
            emp_Static_Constructor.display();

            Console.ReadKey();
        }
    }

    internal class EmployeeDefaultUserDefined
    {
        int empID;
        string empName, empGender;
        bool empAttd;

        internal EmployeeDefaultUserDefined()
        {
            empID = 10;
            empName = "Jones";
            empGender = "Male";
            empAttd = true;
        }

        internal void display()
        {
            Console.WriteLine("EmpName: {0}\nEmpGender=> Default User Defined Construstor is called\n",empName,empGender);
        }
    }  //Default User-Defined Construstor

    internal class EmployeeDefaultSystemdefined
    {
        int emppID;
        string emppName;
        string emppGender;
        double emppSalary;

        internal void display()
        {
            Console.WriteLine("EmpName: {0}\nEmppSalary: {1}\n=> Default System Defined Construstor is called\n", emppName,emppSalary);
        }
    } //Default System-Defined Construstor

    internal class EmployeeParameterized
    {
        int emID;
        string emName;
        string emGender;
        double emSalary;

        internal EmployeeParameterized(int emID, string emName, string emGender, double emSalary)
        {
            this.emID = emID;
            this.emName = emName;
            this.emGender = emGender;
            this.emSalary = emSalary;
        }

        internal void display()
        {
            Console.WriteLine("EmName: {0}\nEmSalary: {1}\nEnmGender = {2}\nEmId = {3}\n=> Parameterized Construstor is called\n", emName, emSalary, emGender, emID);
        }
    } //Parameterized Construstor

    internal class Empl_CopyConstructor
    {
        int eID;
        string eName;
        string eGender;
        bool eAtted;

        //Constructor can be overloaded

        internal Empl_CopyConstructor(int ID, string Name, string Gender, bool Att)
        {
            this.eID=ID;
            this.eName=Name;
            this.eGender=Gender;
            this.eAtted = Att;
        } //This is a Paramaterized Constructor

        internal Empl_CopyConstructor(Empl_CopyConstructor empl_Copy)
        {
            this.eID=empl_Copy.eID;
            this.eName =empl_Copy.eName;
            this.eGender =empl_Copy.eGender;
            this.eAtted=empl_Copy.eAtted;
        }

        internal void display()
        {
            Console.WriteLine("EName = {0}\nEAttendance = {1}\nEnGender = {2}\nEId = {3}\n=> Copy Construstor is called\n", eName, eAtted, eGender, eID);
        }
    } //Copy Constructor

    internal class Emp_static_constructor
    {
        static int empID;
        static string empName;
        int j = 0; //non-static

        static Emp_static_constructor()
        {
            empID = 100;
            empName = "SimthJone";

            Console.WriteLine("EmpID: {0}\n EmpName: {1}\n=>Static Constructor is called\n*********************************\n");
        }

        internal Emp_static_constructor()
        {
            Console.WriteLine("This is a non-static constructor\n");
        }

        internal void display()
        {
            Console.WriteLine("Just for printing and checking\n");
        }
    } //Static Constructor

}
