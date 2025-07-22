using System.Diagnostics.SymbolStore;
using System.Security.Cryptography;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Step 1: Use Comments
        /* Ryan Benson 
        IT-1050 - Lab 1 */

        //Step 2: Basic Output
        Console.WriteLine("Ryan Benson");
        Console.WriteLine("IT-1050");

        //Step 3: Declare and Use Variables
        int Num = 87;
        string Language = "I don't have one??";
        double Experience = 0.0D;
        bool myBool = false;

        Console.WriteLine("My favorite number is " + Num + ", because my favorite car came out that year");
        Console.WriteLine("My favorite programming language is..." + Language);
        Console.WriteLine("The number of programs I've written before this is " + Experience);
        Console.WriteLine("Do I have programming experience? " + myBool);

        //Step 4: Use Constants
        const string school = "Tri-C";
        Console.WriteLine(school);

        //Step 5: Type Casting
        double mydouble = 9.78D;
        int myint = (int)mydouble;
        bool mybool = true;
        Console.WriteLine("double: " + mydouble);
        Console.WriteLine("int: " + myint);
        Console.WriteLine(Convert.ToString(myint));
        Console.WriteLine(Convert.ToString(mybool));

        //Step 6: User Input and Type Conversion
        Console.WriteLine("Enter Username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Username is: " + username);
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Welcome " + username + ", You look great for " + age + "!!");

        //Step 7: Arithmetic Operators
        int num1 = 10;
        int num2 = 15;
        Console.WriteLine(num1 + 10);
        Console.WriteLine(num2 + 10);
        Console.WriteLine(num1 - 2);
        Console.WriteLine(num2 - 2);
        Console.WriteLine(num1 * 3);
        Console.WriteLine(num2 * 3);
        Console.WriteLine(num1 / 2);
        Console.WriteLine(num2 / 2);
        Console.WriteLine(num1 % 2);
        Console.WriteLine(num2 % 2);

        //Step 8: Floating Point Precision
        float myfloat = 1.123456789F;
        double myDouble = 1.123456789D;
        Console.WriteLine(myfloat);
        Console.WriteLine(myDouble);

        //Step 9: Increment and Decrement
        int myvar = 10;
        myvar++;
        Console.WriteLine(myvar);
        myvar--;
        Console.WriteLine(myvar);
        








        


    }
}
