// @#$!@#$@!#$Progress### << ///Mar_2024..??>> @ @#$@%#!@%!Saving??@!#$@!#$@!#$!@#$@!#$
//!!!!! don't stay at one part for more than 1 weekds...!!!!
//!!!!! proceed as you go through by commenting .. for furhter refirinement..
//..//...//..//...//..//..//..//...//
//..//..Code explanation.//..use...//.ChatGPT.//..//..//...//
//..//...//..//...//..//..//..//...//


// Environment.Exit(0); // 0 indicates successful termination


/*

using System;
namespace Myapplication
{
	class Program{
		
		static void Main(string[] args)// 
		{
			int x=16;
			int y=3;
			x%=y*2;	
			// Console.WriteLine(x%=y);
			int b= 9/18;
			Console.WriteLine(b);
			
			Console.WriteLine(x);
			Environment.Exit(0); // 0 indicates successful termination
//
			Console.WriteLine(++
			x);
			Console.WriteLine(x++);
		}


		
	}
	
	
}

*/


/*_______________________ Sololearn Codecoach Challenges__________________ */



/*______Codecoach Challenges 

#file:///D:\cNG\Cs_wbk\beecrowd.cs
		 
#file:///D:\cNG\Cs_wbk\codeforces.cs
		 
#file:///D:\cNG\Cs_wbk\onlinejudge.cs
		 
#file:///D:\cNG\Cs_wbk\ProjectEuler.cs


*/




/* _____________________  C# Getting Started  

using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    
    }
  }
}

*/

/*  _____________________  C# Syntax  



using System; //use classes from the System namespace.

namespace HelloWorld //container for classes 
{
  class Program // container for data and methods
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!"); //class of the System namespace   
      // System.Console.WriteLine("Hello World!"); //If you omit the using System
    }
  }
}

*/

/*  _____________________  C# Output (Print Text) 

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}

// write as many write line
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("I am Learning C#");
      Console.WriteLine("It is awesome!");
    }
  }
}

// matmatical operations

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(3 + 3);
    }
  }
}



// The Write Method


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Hello World! ");
      Console.Write("\n"+"I will print on the same line.");
    }
  }
}

// In this tutorial, we will only use WriteLine() as it makes it easier to read the output of code.


// */


/*  _____________________  C# Variables 


// Declaring (Creating) Variables
// 		type variableName = value;

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "John";
      Console.WriteLine(name);  
     }
  }
}

using System;

class Program
{
    static void Main()
    {
        int myNum = 15;
        Console.WriteLine(myNum);
    }
}

class Program
{
    static void Main()
    {
        int myNum = 15;
        myNum = 10;// myNum is now 10
        Console.WriteLine(myNum);
    }
}

// Constants

// The following code will not compile in C# because you cannot change the value of a constant.
// class Program
// {
//     static void Main()
//     {
//         const int myNum = 15;
//         myNum = 10; // This line will cause a compile-time error
//         Console.WriteLine(myNum);
//     }
// }


// Other Types

class Program
{
    static void Main()
    {
        int myNum = 5;
        double myFloatNum = 5.99;
        char myLetter = 'D';
        string myText = "Hello";
        bool myBoolean = true;
        Console.WriteLine(myNum);
        Console.WriteLine(myFloatNum);
        Console.WriteLine(myLetter);
        Console.WriteLine(myText);
        Console.WriteLine(myBoolean);
    }
}



// Display Variables

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "John";
      Console.WriteLine("Hello " + name);
    }
  }
}



using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string firstName = "John ";
      string lastName = "Doe";
      string fullName = firstName + lastName;
      Console.WriteLine(fullName);
    }
  }
}




using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      int y = 6;
      Console.WriteLine(x + y);
    }
  }
}



// Declare Many Variables



class Program
{
    static void Main()
    {
        int x = 5, u = 6, z = 50;
        Console.WriteLine(x + u + z);
    }
}




// C# Identifiers





using System;

namespace MyApplication
{
	class Program
	{
		static void Main()
		{
			// Good name
			int minutesPerHour = 60;
			// OK, but not so easy to understand what m actually is
			int m = 60;
			Console.WriteLine(minutesPerHour);
			Console.WriteLine(m);
		}

	}

}


// The following code will not compile in C# because you cannot change the value of a constant.
// class Program
// {
//     static void Main()
//     {
//         const int myNum = 15;
//         myNum = 10; // This line will cause a compile-time error
//         Console.WriteLine(myNum);
//     }
// }







*/


/*  _____________________  C# Data Types 

// C# Data Types
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 5;               // integer (whole number)
      double myDoubleNum = 5.99D;  // floating point number
      char myLetter = 'D';         // character
      bool myBool = true;          // boolean
      string myText = "Hello";     // string
      Console.WriteLine(myNum);
      Console.WriteLine(myDoubleNum);
      Console.WriteLine(myLetter);
      Console.WriteLine(myBool);
      Console.WriteLine(myText);
    }
  }
}

// Numbers

// 		Integer Types

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 100000;
      Console.WriteLine(myNum);
    }
  }
}

// 		Long
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      long myNum = 15000000000L;
      Console.WriteLine(myNum);
    }
  }
}

// Float Example
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      float myNum = 5.75F;
      Console.WriteLine(myNum);
    }
  }
}

// Double Example
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      double myNum = 19.99D;
      Console.WriteLine(myNum);
    }
  }
}

// Scientific Numbers

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      float f1 = 35e3F;
      double d1 = 12E4D;
      Console.WriteLine(f1);
      Console.WriteLine(d1);
    }
  }
}

// Booleans 
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      bool isCSharpFun = true;
      bool isFishTasty = false;
      Console.WriteLine(isCSharpFun);   // Outputs True
      Console.WriteLine(isFishTasty);   // Outputs False    
    }
  }
}

// Characters 

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      char myGrade = 'B';
      Console.WriteLine(myGrade);
    }
  }
}


// Strings

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string greeting = "Hello World";
      Console.WriteLine(greeting);
    }
  }
}



// */


/*  _____________________  C# Type Casting 


// Implicit Casting


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			  
		int myInt = 9;
		double myDouble = myInt;       // Automatic casting: int to double

		Console.WriteLine(myInt);      // Outputs 9
		Console.WriteLine(myDouble);   // Outputs 9

    }
  }
}




// Explicit Casting

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {

		double myDouble = 9.78;
		int myInt = (int) myDouble;    // Manual casting: double to int

		Console.WriteLine(myDouble);   // Outputs 9.78
		Console.WriteLine(myInt);      // Outputs 9
    }
  }
}




// Type Conversion Methods

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {

		int myInt = 10;
		double myDouble = 5.25;
		bool myBool = true;

		Console.WriteLine(Convert.ToString(myInt));    // convert int to string
		Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
		Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
		Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
	}
   }
}




*/



/* _______________________ C# User Input 

// Get User Input


using System;

class Program
{
    static void Main()
    {
        int x;
        Console.Write("Type a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your number is: " + x);
    }
}


// User Input and Numbers

class Program
{
    static void Main()
    {
        int x, y, sum;
        Console.Write("Type a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type another number: ");
        y = Convert.ToInt32(Console.ReadLine());
        sum = x + y;
        Console.WriteLine("Sum is: " + sum);
    }
}





*/


/*_______________________  C# Operators 

// C# Operators

using System;
namespace Myapplication;
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 100 + 50;	
			console.writeLine(x);
		}
	}
}


using System;
namespace Myapplication
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum1 = 100 + 50;        // 150 (100 + 50)
			int sum2 = sum1 + 250;      // 400 (150 + 250)
			int sum3 = sum2 + sum2; 
		}
	}
}



// Arithmetic Operators


// x + y	
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      int y = 3;
      Console.WriteLine(x + y);  
     }
  }
}
// x - y
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      int y = 3;
      Console.WriteLine(x - y);  
     }
  }
}
// x * y	
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      int y = 3;
      Console.WriteLine(x * y);  
     }
  }
}
// x / y	
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 12;
      int y = 3;
      Console.WriteLine(x / y);  
     }
  }
}
// x % y	
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      int y = 2;
      Console.WriteLine(x % y);  
     }
  }
}
// x++	
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      x++;
      Console.WriteLine(x);  
     }
  }
}
// x--
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      x--;
      Console.WriteLine(x);  
     }
  }
}

// C# Assignment Operators

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 10;
      Console.WriteLine(x);  
     }
  }
}
// The addition assignment operator (+=) adds a value to a variable:


// x = 5	           // x = 5	
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      Console.WriteLine(x);  
	  int x += 3	           // x = x + 3	
      Console.WriteLine(x);  
	  int x -= 3	           // x = x - 3	
      Console.WriteLine(x);  
	  int x *= 3	           // x = x * 3	
      Console.WriteLine(x);  
	  int x /= 3	           // x = x / 3	
      Console.WriteLine(x);  
	  int x %= 3	           // x = x % 3	
      Console.WriteLine(x);  
	  int x &= 3	           // x = x & 3	
      Console.WriteLine(x);  
	  int x |= 3	           // x = x | 3	
      Console.WriteLine(x);  
	  int x ^= 3	           // x = x ^ 3	
      Console.WriteLine(x);  
	  int x >>= 3	           // x = x >> 3	
      Console.WriteLine(x);  
	  int x <<= 3	           // x = x << 3	
      Console.WriteLine(x);  

     }
  }
}

// C# Comparison O


// x == y	
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      int y = 3;
      Console.WriteLine(x == y);  // returns False because 5 is not equal to 3
      Console.WriteLine(x != y);
      
      Console.WriteLine(x > y);
      
      Console.WriteLine(x < y);
      
      Console.WriteLine(x >= y);
      
      Console.WriteLine(x <= y);
      
     }
  }
}


// C# Logical Operators

// x < 5 &&  x < 10	
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      Console.WriteLine(x > 3 && x < 10); // returns True because 5 is greater than 3 AND 5 is less than 10
	  Console.WriteLine(x < 5 || x < 4);
	  Console.WriteLine(!(x < 5 && x < 10);
   }
  }
}




*/


/*  _____________________  C# Math 


// Math.Max(x,y)
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Math.Max(5, 10));  
	  Console.WriteLine(Math.Min(5,10));
		int x=64;
		Console.WriteLine(Math.Sqrt(x));

		Console.WriteLine(Math.Abs(x));
		double x=6.22;
		Console.WriteLine(Math.Round(x));
     }
  }
}


*/



/*  _____________________  C# Strings  


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string greeting = "Hello";
      Console.WriteLine(greeting);  
     }
  }
}

// String Length
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      Console.WriteLine("The length of the txt string is: " + txt.Length);
    }
  }
}

              
// Other Methods
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string txt = "Hello World";
      Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
      Console.WriteLine(txt.ToLower());   // Outputs "hello world"
    }
  }
}

       

// String Concatenation
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string firstName = "John ";
      string lastName = "Doe";
      string name = firstName + lastName;
      Console.WriteLine(name);
    }
  }
}
// string.Concat() method 

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string firstName = "John ";
      string lastName = "Doe";
      string name = string.Concat(firstName, lastName);
      Console.WriteLine(name);
    }
  }
}

           
          
// String Interpolation
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string firstName = "John";
      string lastName = "Doe";
      string name = $"My full name is: {firstName} {lastName}";
      Console.WriteLine(name);
    }
  }
}

        
// Access Strings
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string myString = "Hello";
      Console.WriteLine(myString[0]);
    }
  }
}

 // second character (1) in myString
       
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string myString = "Hello";
      Console.WriteLine(myString[1]);
    }
  }
}
// IndexOf() method:
              
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string myString = "Hello";
      Console.WriteLine(myString.IndexOf("e"));
    }
  }
}

             
// method  Substring()


using System;

namespace GetLastName
{
  class Program
  {
    static void Main()
    {
      // Full name
      string name = "John Doe";

      // Location of the letter D
      int charPos = name.IndexOf("D");

      // Get last name
      string lastName = name.Substring(charPos);

      // Print the result
      Console.WriteLine(lastName);
    }
  }
}

         
		
		

	   
// Special Characters

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string txt = "We are the so-called \"Vikings\" from the north.";
      Console.WriteLine(txt);
    }
  }
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string txt = "It\'s alright.";
      Console.WriteLine(txt);
    }
  }
}

              
 
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string txt = "The character \\ is called backslash.";
      Console.WriteLine(txt);
    }
  }
}



// \n	New Line	
Result Size: 294 x 650
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string txt = "Hello\nWorld!";
      Console.WriteLine(txt);
    }
  }
}

              
// \t	Tab	
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string txt = "Hello\tWorld!";
      Console.WriteLine(txt);
    }
  }
}

            
// \b	Backspace	
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string txt = "Hel\blo World!";
      Console.WriteLine(txt);
    }
  }
}

        



// Adding Numbers and Strings
// C# uses the + operator for both addition and concatenation.

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 10;
      int y = 20;
      int z = x + y;
      Console.WriteLine(z);
    }
  }
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string x = "10";
      string y = "20";
      string z = x + y;
      Console.WriteLine(z);
    }
  }
}

              



*/



/*  _____________________  C# Booleans 
C# Booleans

Boolean Values
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      bool isCSharpFun = true;
      bool isFishTasty = false;
      Console.WriteLine(isCSharpFun);   // Outputs True
      Console.WriteLine(isFishTasty);   // Outputs False    
    }
  }
}
Boolean Expression
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 10;
      int y = 9;
      Console.WriteLine(x > y); // returns True, because 10 is higher than 9
    }
  }
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9
    }
  }
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9
    }
  }
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15
    }
  }
}


*/

/*  _____________________  C# If ... Else 

// The if Statement
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      if (20 > 18) 
      {
        Console.WriteLine("20 is greater than 18");
      }    
    }
  }
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 20;
      int y = 18;
      if (x > y)
      {
        Console.WriteLine("x is greater than y");
      }
    }
  }
}


// The else Statement

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = 20;
      if (time < 18) 
      {
        Console.WriteLine("Good day.");
      } 
      else 
      {
        Console.WriteLine("Good evening.");
      }
    }
  }
}


// The else if Statement

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = 22;
      if (time < 10) 
      {
        Console.WriteLine("Good morning.");
      } 
      else if (time < 20) 
      {
        Console.WriteLine("Good day.");
      } 
      else 
      {
        Console.WriteLine("Good evening.");
      }
    }
  }
}



// Short Hand If...Else (Ternary Operator)

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = 20;
      if (time < 18) 
      {
        Console.WriteLine("Good day.");
      } 
      else 
      {
        Console.WriteLine("Good evening.");
      }
    }
  }
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = 20;
      string result = (time < 18) ? "Good day." : "Good evening.";
      Console.WriteLine(result);
    }
  }
}


*/

/*  _____________________  C# Switch 


// C# Switch Statements
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int day = 4;
      switch (day) 
      {
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
          Console.WriteLine("Thursday");
          break;
        case 5:
          Console.WriteLine("Friday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
      }    
    }
  }
}
// The break Keyword

// The default Keyword
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int day = 4;
      switch (day) 
      {
        case 6:
          Console.WriteLine("Today is Saturday.");
          break;
        case 7:
          Console.WriteLine("Today is Sunday.");
          break;
        default:
          Console.WriteLine("Looking forward to the Weekend.");
          break;
      }    
    }
  }
}

*/

/*  _____________________  C# While Loop  

// C# While Loop
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 5) 
      {
        Console.WriteLine(i);
        i++;
      }
    }
  }
}


// The Do/While Loop

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      do 
      {
        Console.WriteLine(i);
        i++;
      }
      while (i < 5);
    }
  }
}


*/


/*  _____________________  C# For Loop

// C# For Loop
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 5; i++) 
      {
        Console.WriteLine(i);
      }    
    }
  }
}
// Another Example
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i <= 10; i = i + 2)
      {
        Console.WriteLine(i);
      }    
    }
  }
}
// The foreach Loop


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      foreach (string i in cars) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}


*/


/*  _____________________  C# Break and Continue 

// C# Break
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++) 
      {
        if (i == 4) 
        {
          break;
        }
        Console.WriteLine(i);
      }    
    }
  }
}
// C# Continue
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++) 
      {
        if (i == 4) 
        {
          continue;
        }
        Console.WriteLine(i);
      }    
    }
  }
}

// Break and Continue in While Loop

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 10) 
      {
        Console.WriteLine(i);
        i++;
        if (i == 4) 
        {
          break;
        }
      }    
    }
  }
}


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 10) 
      {
        if (i == 4) 
        {
          i++;
          continue;
        }
        Console.WriteLine(i);
        i++;
      }    
    }
  }
}


*/


/*  _____________________  C# Arrays 

// Create an Array


// Access the Elements of an Array

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Console.WriteLine(cars[0]);
    }
  }
}

// Change an Array Element
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      cars[0] = "Opel";
      Console.WriteLine(cars[0]);    
    }
  }
}

// Array Length
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Console.WriteLine(cars.Length);
    }
  }
}
// Loop Through an Array
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      for (int i = 0; i < cars.Length; i++) 
      {
        Console.WriteLine(cars[i]);
      }
    }
  }
}
// The foreach Loop
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      foreach (string i in cars) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}
// Sort Arrays
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Sort a string
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Array.Sort(cars);
      foreach (string i in cars)
      {
        Console.WriteLine(i);
      }    
      
      // Sort an int
      int[] myNumbers = {5, 1, 8, 9};
      Array.Sort(myNumbers);
      foreach (int i in myNumbers)
      {
        Console.WriteLine(i);
      }
    }
  }
}


// System.Linq Namespace
using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // largest value
      Console.WriteLine(myNumbers.Min());  // smallest value
      Console.WriteLine(myNumbers.Sum());  // sum of myNumbers
    }
  }
}


// Other Ways to Create an Array


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {

	// Create an array of four elements, and add values later
	string[] cars = new string[4];

	// Create an array of four elements and add values right away 
	string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

	// Create an array of four elements without specifying the size 
	string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

	// Create an array of four elements, omitting the new keyword, and without specifying the size
	string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};


    }
  }
}



using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare an array
      string[] cars;

      // Add values, using new
      cars = new string[] {"Volvo", "BMW", "Ford"};

      // This would cause an error: cars = {"Volvo", "BMW", "Ford"};

      Console.WriteLine(cars[0]);
    }
  }
}



*/




/*  _____________________  C# Methods

// Create a Method

using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod()
    {
      Console.WriteLine("I just got executed!");
    }

    static void Main(string[] args)
    {
      MyMethod();
    }
  }
}

// Call a Method
using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod()
    {
      Console.WriteLine("I just got executed!");
    }

    static void Main(string[] args)
    {
      MyMethod();
      MyMethod();
      MyMethod();
    }
  }
}

*/



/*  _____________________  C# Method Parameters 

// Parameters and Arguments
using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string fname) 
    {
      Console.WriteLine(fname + " Refsnes");
    }

    static void Main(string[] args)
    {
      MyMethod("Liam");
      MyMethod("Jenny");
      MyMethod("Anja");
    }  
  }
}
// Default Parameter Value
using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string country = "Norway")
    {
      Console.WriteLine(country);
    }

    static void Main(string[] args)
    {
      MyMethod("Sweden");
      MyMethod("India");
      MyMethod();
      MyMethod("USA");
    }
  }
}
// Multiple Parameters
using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string fname, int age)
    {
      Console.WriteLine(fname + " is " + age);
    }

    static void Main(string[] args)
    {
      MyMethod("Liam", 5);
      MyMethod("Jenny", 8);
      MyMethod("Anja", 31);
    }
  }
}
// Return Values
using System;

namespace MyApplication
{
  class Program
  {
    static int MyMethod(int x)
    {
      return 5 + x;
    }

    static void Main(string[] args)
    {
      Console.WriteLine(MyMethod(3));
    }
  }
}


using System;

namespace MyApplication
{
  class Program
  {
    static int MyMethod(int x, int y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      Console.WriteLine(MyMethod(5, 3));
    }
  }
}


using System;

namespace MyApplication
{
  class Program
  {
    static int MyMethod(int x, int y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int z = MyMethod(5, 3);
      Console.WriteLine(z);
    }
  }
}


// Named Arguments
using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string child1, string child2, string child3)
    {
      Console.WriteLine("The youngest child is: " + child3);
    }

    static void Main(string[] args)
    {
      MyMethod(child3: "John", child1: "Liam", child2: "Liam");
    }
  }
}



*/


/*  _____________________  C# Method Overloading

// Method Overloading
using System;

namespace MyApplication
{
  class Program
  {
    static int PlusMethodInt(int x, int y)
    {
      return x + y;
    }

    static double PlusMethodDouble(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int myNum1 = PlusMethodInt(8, 5);
      double myNum2 = PlusMethodDouble(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }  
  }
}



using System;

namespace MyApplication
{
  class Program
  {
    static int PlusMethod(int x, int y)
    {
      return x + y;
    }

    static double PlusMethod(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int myNum1 = PlusMethod(8, 5);
      double myNum2 = PlusMethod(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }  
  }
}





// */



/*  _____________________  C# Classes/Objects

// Create a Class

// Create an Object
using System;

namespace MyApplication
{
  class Car
  {
    string color = "red";

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
    }
  }
}
// Multiple Objects
using System;

namespace MyApplication
{
  class Car
  {
    string color = "red";

    static void Main(string[] args)
    {
      Car myObj1 = new Car();
      Car myObj2 = new Car();
      Console.WriteLine(myObj1.color);
      Console.WriteLine(myObj2.color);
    }
  }
}
// Using Multiple Classes






using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
    }
  }
}

using System;

namespace MyApplication
{
  class Car
  {
    public string color = "red";
  }
}









// */


/*  _____________________  C# Class members

// Memmbers



using System;

namespace MyApplication
{

// The class
class MyClass
{
  // Class members
  string color = "red";        // field
  int maxSpeed = 200;          // field
  public void fullThrottle()   // method
  {
    Console.WriteLine("The car is going as fast as it can!");
  }
}

}







// Fields


using System;

namespace MyApplication
{

class Car 
{
  string color = "red";
  int maxSpeed = 200;

  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
    Console.WriteLine(myObj.maxSpeed);
  }
}

}


using System;

namespace MyApplication
{

class Car 
{
  string color;
  int maxSpeed;

  static void Main(string[] args)
  {
    Car myObj = new Car();
    myObj.color = "red";
    myObj.maxSpeed = 200;
    Console.WriteLine(myObj.color);
    Console.WriteLine(myObj.maxSpeed);
  }
}

}


using System;

namespace MyApplication
{

class Car 
{
  string model;
  string color;
  int year;

  static void Main(string[] args)
  {
    Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model);
  }
}

}



// Object Methods


using System;

namespace MyApplication
{
class Car 
{
  string color;                 // field
  int maxSpeed;                 // field
  public void fullThrottle()    // method
  {
    Console.WriteLine("The car is going as fast as it can!"); 
  }

  static void Main(string[] args)
  {
    Car myObj = new Car();
    myObj.fullThrottle();  // Call the method
  }
}


}


// Use Multiple Classes


using System;

namespace MyApplication
{
class Car 
{
  public string model;
  public string color;
  public int year;
  public void fullThrottle()
  {
    Console.WriteLine("The car is going as fast as it can!"); 
  }
}


}

using System;

namespace MyApplication
{

class Program
{
  static void Main(string[] args)
  {
    Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model);
  }
}

}


// */

/*  _____________________  C# Constructors 



// Constructor Parameters
using System;

namespace MyApplication
{
  // Create a Car class
  class Car
  {
    public string model;  // Create a field

    // Create a class constructor for the Car class
    public Car()
    {
      model = "Mustang"; // Set the initial value for model
    }

    static void Main(string[] args)
    {
      Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
      Console.WriteLine(Ford.model);  // Print the value of model
    }
  }
}

// Constructors Save Time
//filename: Car.cs
using System;

namespace MyApplication
{
  class Car
  {
    public string model;

    // Create a class constructor with a parameter
    public Car(string modelName)
    {
      model = modelName;
    }

    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang");
      Console.WriteLine(Ford.model);
    }
  }
}




using System;

namespace MyApplication
{
  class Car
  {
    public string model;
    public string color;
    public int year;

    // Create a class constructor with multiple parameters
    public Car(string modelName, string modelColor, int modelYear)
    {
      model = modelName;
      color = modelColor;
      year = modelYear;
    }

    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang", "Red", 1969);
      Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
    }
  }
}

// Constructors Save Time


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car Ford = new Car();
      Ford.model = "Mustang";
      Ford.color = "red";
      Ford.year = 1969;

      Car Opel = new Car();
      Opel.model = "Astra";
      Opel.color = "white";
      Opel.year = 2005;

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
}
using System;

namespace MyApplication
{
  class Car
  {
    public string model;
    public string color;
    public int year;
    public void fullThrottle()
    {
      Console.WriteLine("The car is going as fast as it can!"); 
    }
  }
}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang", "Red", 1969);
      Car Opel = new Car("Astra", "White", 2005);

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
}

using System;

namespace MyApplication
{
  class Car
  {
    public string model;
    public string color;
    public int year;
    
    public Car(string modelName, string modelColor, int modelYear)
    {
      model = modelName;
      color = modelColor;
      year = modelYear;
    }  
  }
}


*/



/*  _____________________  C# Acess Modifiers

// Acess Modifiers

// Private Modifier

using System;

namespace MyApplication
{
  class Car
  {
    private string model = "Mustang";

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.model);
    }
  }
}

// 


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.model);
    }
  }
}


using System;

namespace MyApplication
{
  class Car
  {
    private string model = "Mustang";
  }
}



// Public Modifier


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.model);
    }
  }
}

using System;

namespace MyApplication
{
  class Car
  {
    public string model = "Mustang";
  }
}



// Why Access Modifiers?


// */



/*  _____________________  C# Properties

// Properties and Encapsulation

using System;
namespace Myapplication
{

	class Person
	{
	  private string name; // field

	  public string Name   // property
	  {
		get { return name; }   // get method
		set { name = value; }  // set method
	  }
	}
		

}

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Person myObj = new Person();
      myObj.Name = "Liam";
      Console.WriteLine(myObj.Name);
    }
  }
}

using System;

namespace MyApplication
{
  class Person
  {
    private string name;  // field
    public string Name    // property
    {
      get { return name; }
      set { name = value; }
    }  
  }
}


// Automatic Properties (Short Hand)



using System;

namespace MyApplication
{

class Person
{
  public string Name  // property
  { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}

}

// */


/* _____________________  C# Inheritance

// Inheritance (Devied and Base Class)



Vehicle.cs
using System;

namespace MyApplication
{
  class Vehicle  // Base class
  {
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
      Console.WriteLine("Tuut, tuut!");
    }
  }
}

          

Car.cs
using System;

namespace MyApplication
{
  class Car : Vehicle  // Derived class
  {
    public string modelName = "Mustang";  // Car field
  }
}

  

Program.cs
using System;

namespace MyApplication
{
  class Program
  { 
    static void Main(string[] args)
    {
      // Create a myCar object
      Car myCar = new Car();

      // Call the honk() method (From the Vehicle class) on the myCar object
      myCar.honk();

      // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
      Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
  }
}
               


// The sealed Keyword



// */                                 


/* _____________________  C# Polymorphism

// Polymorphism and Overrriding Methods

using System;

namespace MyApplication
{
  class Animal  // Base class (parent) 
  {
    public void animalSound()
    {
      Console.WriteLine("The animal makes a sound");
    }
  }

  class Pig : Animal  // Derived class (child) 
  {
    public void animalSound()
    {
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Dog : Animal  // Derived class (child) 
  {
    public void animalSound()
    {
      Console.WriteLine("The dog says: bow wow");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Animal myAnimal = new Animal();  // Create a Animal object
      Animal myPig = new Pig();  // Create a Pig object
      Animal myDog = new Dog();  // Create a Dog object
      
      myAnimal.animalSound();
      myPig.animalSound();
      myDog.animalSound();
    }
  }
}




       
// */                                 

/* _____________________  C# Abstraction

// Abstract Classes and Methods

using System;

namespace MyApplication
{
  // Abstract class
  abstract class Animal
  {
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
      Console.WriteLine("Zzz");
    }
  }
  
  // Derived class (inherit from Animal)
  class Pig : Animal
  {
    public override void animalSound()
    {
      // The body of animalSound() is provided here
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Pig myPig = new Pig();  // Create a Pig object
      myPig.animalSound();
      myPig.sleep();
    }
  }
}

// */                                 

/* _____________________  C# Interface                 

// Interfaces
using System;

namespace MyApplication
{
  // Interface
  interface IAnimal 
  {
    void animalSound(); // interface method (does not have a body)
  }

  // Pig "implements" the IAnimal interface
  class Pig : IAnimal 
  {
    public void animalSound() 
    {
      // The body of animalSound() is provided here
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Program 
  {
    static void Main(string[] args) 
    {
      Pig myPig = new Pig();  // Create a Pig object
      myPig.animalSound();
    }
  }
}

// Multiple Interfaces

using System;

namespace MyApplication
{
  interface IFirstInterface
  {
    void myMethod(); // interface method
  }

  interface ISecondInterface
  {
    void myOtherMethod(); // interface method
  }

  // Implement multiple interfaces
  class DemoClass : IFirstInterface, ISecondInterface
  {
    public void myMethod()
    {
      Console.WriteLine("Some text..");
    }
    public void myOtherMethod()
    {
      Console.WriteLine("Some other text...");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      DemoClass myObj = new DemoClass();
      myObj.myMethod();
      myObj.myOtherMethod();
    }
  }
}
// */                                 


/*  _____________________  C# Enums

// C# Enums

using System;

namespace MyApplication
{
  enum Level
  {
    Low,
    Medium,
    High
  }
  class Program
  {
    static void Main(string[] args)
    {
      Level myVar = Level.Medium;
      Console.WriteLine(myVar);
    }
  }
}



// Enum inside a Class
using System;

namespace MyApplication
{
  class Program
  {
    enum Level
    {
      Low,
      Medium,
      High
    }
    static void Main(string[] args)
    {
      Level myVar = Level.Medium;
      Console.WriteLine(myVar);
    }
  }
}

// Enum Values


using System;

namespace MyApplication
{
  class Program
  {
    enum Months
    {
      January,    // 0
      February,   // 1
      March,      // 2
      April,      // 3
      May,        // 4
      June,       // 5
      July        // 6
    }
    static void Main(string[] args)
    {
      int myNum = (int) Months.April;
      Console.WriteLine(myNum);
    }
  }
}



using System;

namespace MyApplication
{
  class Program
  {
    enum Months
    {
      January,    // 0
      February,   // 1
      March=6,    // 6
      April,      // 7
      May,        // 8
      June,       // 9
      July        // 10
    }
    static void Main(string[] args)
    {
      int myNum = (int) Months.April;
      Console.WriteLine(myNum);
    }
  }
}


// Enum in a Switch Statement


using System;

namespace MyApplication
{
  class Program
  {
    enum Level
    {
      Low,
      Medium,
      High
    }
    static void Main(string[] args)
    {
      Level myVar = Level.Medium;
      switch(myVar) 
      {
        case Level.Low:
          Console.WriteLine("Low level");
          break;
        case Level.Medium:
          Console.WriteLine("Medium level");
          break;
        case Level.High:
          Console.WriteLine("High level");
          break;
      }    
    }
  }
}








// */                                 



/*  _____________________  C# Files

// Working With Files



       
// Write To a File and Read It

using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string writeText = "Hello World!";  // Create a text string
      File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

      string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
      Console.WriteLine(readText); // Output the content
	  string readText =File.AppendText("filename.txt");  //	Appends text at the end of an existing file
      Console.WriteLine(readText); // Output the content
	  string readText =File.Copy("filename.txt");		//Copies a file
      Console.WriteLine(readText); // Output the content
	  string readText =File.Create("filename.txt");		//Creates or overwrites a file
      Console.WriteLine(readText); // Output the content
	  string readText =File.Delete("filename.txt");		//Deletes a file
      Console.WriteLine(readText); // Output the content
	  string readText =File.Exists("filename.txt");		//Tests whether the file exists
      Console.WriteLine(readText); // Output the content
	  string readText =File.ReadAllText("filename.txt");	//Reads the contents of a file
      Console.WriteLine(readText); // Output the content
	  string readText =File.Replace("filename.txt");		//Replaces the contents of a file with the contents of another file
      Console.WriteLine(readText); // Output the content
	  string readText =File.WriteAllText("filename.txt");
      Console.WriteLine(readText); // Output the content	     

    }
  }
}

// */


/* _______________________ C# Exception

// C# Exceptions
// C# try and catch

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }    
    }
  }
}


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]);
      }
      catch (Exception e)
      {
        Console.WriteLine("Something went wrong.");
      }    
    }
  }
}



// Finally
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]);
      }
      catch (Exception e)
      {
        Console.WriteLine("Something went wrong.");
      }  
      finally
      {
        Console.WriteLine("The 'try catch' is finished.");
      }  
    }
  }
}

// The throw keyword

using System;

namespace MyApplication
{
  class Program
  {
    static void checkAge(int age)
    {
      if (age < 18)
      {
        throw new ArithmeticException("Access denied - You must be at least 18 years old.");
      }
      else
      {
        Console.WriteLine("Access granted - You are old enough!");
      }
    }

    static void Main(string[] args)
    {
      checkAge(20);
    }
  }
}


// */




// w3resource

/* C#  Basic Exercises 

1. Write a C# Sharp program to print Hello and your name in a separate line. Go to the editor



2. Write a C# Sharp program to print the sum of two numbers. Go to the editor



3. Write a C# Sharp program to print the result of dividing two numbers. Go to the editor



4. Write a C# Sharp program to print the result of the specified operations. Go to the editor



5. Write a C# Sharp program to swap two numbers. Go to the editor



6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. Go to the editor



7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. Go to the editor



8. Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor



9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor



10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. Go to the editor



11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". Go to the editor



12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}. Go to the editor



13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit. Go to the editor



14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. Go to the editor



15. Write a C# program remove specified a character from a non-empty string using index of a character. Go to the editor



16. Write a C# program to create a new string from a given string where the first and last characters will change their positions. Go to the editor



17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back. Go to the editor



18. Write a C# program to check two given integers and return true if one is negative and one is positive. Go to the editor



19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum. Go to the editor



20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number. Go to the editor



21. Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20. Go to the editor



22. Write a C# program to check if an given integer is within 20 of 100 or 200. Go to the editor



23. Write a C# program to convert a given string into lowercase. Go to the editor



24. Write a C# program to find the longest word in a string. Go to the editor



25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line. Go to the editor



26. Write a C# program to compute the sum of the first 500 prime numbers. Go to the editor



27. Write a C# program and compute the sum of the digits of an integer. Go to the editor



28. Write a C# program to reverse the words of a sentence. Go to the editor



29. Write a C# program to find the size of a specified file in bytes. Go to the editor



30. Write a C# program to convert a hexadecimal number to decimal number. Go to the editor



31. Write a C# program to multiply corresponding elements of two arrays of integers. Go to the editor



32. Write a C# program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one. Go to the editor



33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7. Go to the editor



34. Write a C# program to check if a string starts with a specified word. Go to the editor



35. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200. Go to the editor



36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10. Go to the editor



37. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP". Go to the editor



38. Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH". Go to the editor



39. Write a C# program to find the largest and lowest values from three integer values. Go to the editor



40. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same. Go to the editor



41. Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times. Go to the editor



42. Write a C# program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case. Go to the editor



43. Write a C# program to check if a given string starts with "w" and immediately followed by two "ww". Go to the editor



44. Write a C# program to create a new string of every other character (odd position) from the first position of a given string. Go to the editor



45. Write a C# program to count a specified number in a given array of integers. Go to the editor



46. Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more. Go to the editor



47. Write a C# program to compute the sum of all the elements of an array of integers. Go to the editor



48. Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more. Go to the editor



49. Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal. Go to the editor



50. Write a C# program to rotate an array (length 3) of integers in left direction. Go to the editor



51. Write a C# program to get the larger value between first and last element of an array (length 3) of integers. Go to the editor



52. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers. Go to the editor



53. Write a C# program to check if an array contains an odd number. Go to the editor



54. Write a C# program to get the century from a year. Go to the editor



55. Write a C# program to find the pair of adjacent elements that has the largest product of an given array which is equal to a given value. Go to the editor



56. Write a C# program to check if a given string is a palindrome or not. Go to the editor



57. Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers. Go to the editor



58. Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range. Go to the editor



59. Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array. Go to the editor



60. Write a C# program to calculate the sum of all the intgers of a rectangular matrix except those integers which are located below an intger of value 0. Go to the editor



61. Write a C# program to sort the integers in ascending order without moving the number -5. Go to the editor



62. Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string and also remove the parentheses within the given string. Go to the editor


*/

/* C# Basic Algorithm Exercises


1. Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum. Go to the editor



2. Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference. Go to the editor



3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30. Go to the editor



4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200. Go to the editor



5. Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged. Go to the editor



6. Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive. Go to the editor



7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string. Go to the editor



8. Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string. Go to the editor



9. Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more. Go to the editor



10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7. Go to the editor



11. Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there. Go to the editor



12. Write a C# Sharp program to check if a given string starts with 'C#' or not. Go to the editor



13. Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100. Go to the editor



14. Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive. Go to the editor



15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false. Go to the editor



16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the said range otherwise false. Go to the editor



17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string. Go to the editor



18. Write a C# Sharp program to check the largest number among three given integers. Go to the editor



19. Write a C# Sharp program to check which number nearest to the value 100 among two given integers. Return 0 if the two numbers are equal. Go to the editor



20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive. Go to the editor



21. Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, or return 0 if neither is in that range. Go to the editor



22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character. Go to the editor



23. Write a C# Sharp program to check if two given non-negative integers have the same last digit. Go to the editor



24. Write a C# Sharp program to convert the last 3 characters of a given string in upper case. If the length of the string has less than 3 then uppercase all the characters. Go to the editor



25. Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string. Go to the editor



26. Write a C# Sharp program to create a new string which is n (non-negative integer) copies of the the first 3 characters of a given string. If the length of the given string is less than 3 then return n copies of the string. Go to the editor



27. Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa". Go to the editor



28. Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a". Go to the editor



29. Write a C# Sharp program to create a new string made of every other character starting with the first from a given string. Go to the editor



30. Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd". Go to the editor



31. Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string. Do not count the end substring. Go to the editor



32. Write a C# Sharp program to check a specified number is present in a given array of integers. Go to the editor



33. Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element. Go to the editor



34. Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere. Go to the editor



35. Write a C# Sharp program to compare two given strings and return the number of the positions where they contain the same length 2 substring. Go to the editor



36. Write a C# Sharp program to create a new string from a give string where a specified character have been removed except starting and ending position of the given string. Go to the editor



37. Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string. Go to the editor



38. Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. Also count the situation where the second 5 is actually a 6. Go to the editor



39. Write a C# Sharp program to check if a triple is presents in an array of integers or not. If a value appears three times in a row in an array it is called a triple. Go to the editor



40. Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30. Go to the editor



41. Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5. Go to the editor



42. Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13. Go to the editor



43. Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both. Go to the editor



44. Write a C# Sharp program to check if a given number is within 2 of a multiple of 10. Go to the editor



45. Write a C# Sharp program to compute the sum of the two given integers. If one of the given integer value is in the range 10..20 inclusive return 18. Go to the editor



46. Write a C# Sharp program to check whether a given string starts with "F" or ends with "B". If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" If the string starts with "F" and ends with "B" return "FizzBuzz". In other cases return the original string. Go to the editor



47. Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers. Go to the editor



48. Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z. Go to the editor



49. Write a C# Sharp program to check if three given numbers are in strict increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8.However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7. Go to the editor



50. Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit. Go to the editor



51. Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others. Go to the editor



52. Write a C# Sharp program to find the larger from two given integers. However if the two integers have the same remainder when divided by 7, then the return the smaller integer. If the two integers are the same, return 0. Go to the editor



53. Write a C# Sharp program to check two given integers, each in the range 10..99. Return true if a digit appears in both numbers, such as the 3 in 13 and 33. Go to the editor



54. Write a C# Sharp program to compute the sum of two given non-negative integers x and y as long as the sum has the same number of digits as x. If the sum has more digits than x then return x without y. Go to the editor



55. Write a C# Sharp program to compute the sum of three given integers. If the two values are same return the third value. Go to the editor



56. Write a C# Sharp program to compute the sum of the three integers. If one of the values is 13 then do not count it and its right towards the sum. Go to the editor



57. Write a C# Sharp program to compute the sum of the three given integers. However, if any of the values is in the range 10..20 inclusive then that value counts as 0, except 13 and 17. Go to the editor



58. Write a C# Sharp program to check two given integers and return the value whichever value is nearest to 13 without going over. Return 0 if both numbers go over. Go to the editor



59. Write a C# Sharp program to check three given integers (small, medium and large) and return true if the difference between small and medium and the difference between medium and large is same. Go to the editor



60. Write a C# Sharp program to create a new string using two given strings s1, s2, the format of the new string will be s1s2s2s1. Go to the editor



61. Write a C# Sharp program to insert a given string into middle of the another given string of length 4. Go to the editor



62. Write a C# Sharp program to create a new string using three copies of the last two character of a given string of length atleast two. Go to the editor



63. Write a C# Sharp program to create a new string using first two characters of a given string. If the string length is less than 2 then return the original string.. Go to the editor



64. Write a C# Sharp program to create a new string of the first half of a given string of even length. Go to the editor



65. Write a C# Sharp program to create a new string without the first and last character of a given string of length atleast two. Go to the editor



66. Write a C# Sharp program to create a new string from two given string one is shorter and another is longer. The format of the new string will be long string + short string + long string. Go to the editor



67. Write a C# Sharp program to concat two given string of length atleast 1, after removing their first character. Go to the editor



68. Write a C# Sharp program to move the first two characters to the end of a given string of length at least two. Go to the editor



69. Write a C# Sharp program to move the last two characters to the start of a given string of length at least two. Go to the editor



70. Write a C# Sharp program to create a new string without the first and last character of a given string of any length. Go to the editor



71. Write a C# Sharp program to create a new string using the two middle characters of a given string of even length (at least 2).Go to the editor



72. Write a C# Sharp program to check if a given string ends with "on". Go to the editor



73. Write a C# Sharp program to create a new string using the first and last n characters from a given string of length at least n. Go to the editor



74. Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string. Go to the editor



75. Write a C# Sharp program to create a new string taking 3 characters from the middle of a given string at least 3. Go to the editor



76. Write a C# Sharp program to create a new string of length 2, using first two characters of a given string. If the given string length is less than 2 use '#' as missing characters. Go to the editor



77. Write a C# Sharp program to create a new string taking the first character from a given string and the last character from another given string. If the length of any given string is 0, use '#' as its missing character. Go to the editor



78. Write a C# Sharp program to concat two given strings (lowercase). If there are any double character in new string then omit one character. Go to the editor



79. Write a C# Sharp program to create a new string from a given string after swapping last two characters. Go to the editor



80. Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'. If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return the empty string. Go to the editor



81. Write a C# Sharp program to check whether the first two characters and last two characters of a given string are same. Go to the editor



82. Write a C# Sharp program to concat two given strings. If the given strings have different length remove the characters from the longer string. Go to the editor



83. Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string. If the length of the given string is less than 2 use the whole string. Go to the editor



84. Write a C# Sharp program to create a new string from a given string. If the two characters of the given string from its beginning and end are same return  the given string without the first two characters otherwise return the original string. Go to the editor



85. Write a C# Sharp program to create a new string from a given string without the first two characters. Keep the first character if it is "p" and keep the second character if it is "y". Go to the editor



86. Write a C# Sharp program to create a new string from a given string without the first and last character if the first or last characters are 'a' otherwise return the original given string. Go to the editor



87. Write a C# Sharp program to create a new string from a given string. If the first or first two characters is 'a', return the string without those 'a' characters otherwise return the original given string.Go to the editor



88. Write a C# Sharp program to check a given array of integers of length 1 or more and return true if 10 appears as either first or last element in the given array. Go to the editor



89. Write a C# Sharp program to check a given array of integers of length 1 or more and return true if the first element and the last element are equal in the given array. Go to the editor



90. Write a C# Sharp program to check two given arrays of integers of length 1 or more and return true if they have the same first element or they have the same last element. Go to the editor



91. Write a C# Sharp program to compute the sum of the elements of an given array of integers. Go to the editor



92. Write a C# Sharp program to rotate the elements of a given array of integers (length 4 ) in left direction and return the new array. Go to the editor



93. Write a C# Sharp program to reverse a given array of integers and length 5. Go to the editor



94. Write a C# Sharp program to find out the maximum element between the first or last element in a given array of integers ( length 4), replace all elements with maximum element. Go to the editor



95. Write a C# Sharp program to create a new array containing the middle elements from the two given arrays of integers, each length 5. Go to the editor



96. Write a C# Sharp program to create a new array taking  the first and last elements of a given array of integers and length 1 or more. Go to the editor



97. Write a C# Sharp program to check if a given array of integers and length 2, contains 15 or 20. Go to the editor



98. Write a C# Sharp program to check if a given array of integers and length 2, does not contain 15 or 20. Go to the editor



99. Write a C# Sharp program to create a new array of integers and length 1 or more. The length of the new array will be double length of the given array and all the elements are 1 except the first element which is equal to the given array. Go to the editor



100. Write a C# Sharp program to check a given array of integers and return true if the array contains 10 or 20 twice. The length of the array will be 0, 1, or 2. Go to the editor



101. Write a C# Sharp program to check a given array of integers, length 3 and create a new array. If there is a 5 in the given array immediately followed by a 7 then set 7 to 1. Go to the editor



102. Write a C# Sharp program to compute the sum of the two given arrays of integers, length 3 and find the array which has the largest sum. Go to the editor



103. Write a C# Sharp program to create an array taking two middle elements from a given array of integers of length even.Go to the editor



104. Write a C# Sharp program to create a new array from two give array of integers, each length 3.Go to the editor



105. Write a C# Sharp program to create a new array swapping the first and last elements of a given array of integers and length will be least 1. Go to the editor



106. Write a C# Sharp program to create a new array length 3 from a given array (length atleast 3) using the elements from the middle of the array. Go to the editor



107. Write a C# Sharp program to find the largest value from first, last, and middle elements of a given array of integers of odd length (atleast 1). Go to the editor



108. Write a C# Sharp program to create a new array taking the first two elements from a given array. If the length of the given array is less than 2 then return the give array. Go to the editor



109. Write a C# Sharp program to count even number of elements in a given array of integers. Go to the editor



110. Write a C# Sharp program to compute the difference between the largest and smallest values in a given array of integers and length one or more. Go to the editor



111. Write a C# Sharp program to compute the sum of values in a given array of integers except the number 17. Return 0 if the given array has no integer. Go to the editor



112. Write a C# Sharp program to compute the sum of the numbers in a given array except those numbers starting with 5 followed by atleast one 6. Return 0 if the given array has no integer. Go to the editor



113. Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere. Go to the editor



114. Write a C# Sharp program to check whether a given array of integers contains 5's and 7's. Go to the editor



115. Write a C# Sharp program to check if the sum of all 5' in the array exactly 15 in a given array of integers. Go to the editor



116. Write a C# Sharp program to check if the number of 3's is greater than the number of 5's. Go to the editor



117. Write a C# Sharp program to check if a given array of integers contains a 3 or a 5. Go to the editor



118. Write a C# Sharp program to check if a given array of integers contains no 3 or a 5. Go to the editor



119. Write a C# Sharp program to check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both. Go to the editor



120. Write a C# Sharp program to check a given array of integers and return true if the given array contains two 5's next to each other, or two  5 separated by one element. Go to the editor



121. Write a C# Sharp program to check a given array of integers and return true if there is a 3 with a 5 somewhere later in the given array. Go to the editor



122. Write a C# Sharp program to check a given array of integers and return true if the given array contains either 2 even or 2 odd values all next to each other. Go to the editor



123. Write a C# Sharp program to check a given array of integers and return true if the value 5 appears 5 times and there are no 5 next to each other. Go to the editor



124. Write a C# Sharp program to check a given array of integers and return true if every 5 that appears in the given array is next to another 5. Go to the editor



125. Write a C# Sharp program to check a given array of integers and return true if the specified number of same elements appears at the start and end of the given array. Go to the editor



126. Write a C# Sharp program to check a given array of integers and return true if the array contains three increasing adjacent numbers. Go to the editor



127. Write a C# Sharp program to shift an element in left direction and return a new array. Go to the editor



128. Write a C# Sharp program to create a new array taking the elements before the element value 5 from a given array of integers. Go to the editor



129. Write a C# Sharp program to create a new array taking the elements after the element value 5 from a given array of integers. Go to the editor



130. Write a C# Sharp program to create a new array from a given array of integers shifting all zeros to left direction. Go to the editor



131. Write a C# Sharp program to create a new array after replacing all the values 5 with 0 shifting all zeros to right direction. Go to the editor



132. Write a C# Sharp program to create new array from a given array of integers shifting all even numbers before all odd numbers. Go to the editor



133. Write a C# Sharp program to check if the value of each element is equal or greater than the value of previous element of a given array of integers. Go to the editor



134. Write a C# Sharp program to check a given array (length will be atleast 2) of integers and return true if there are two values 15, 15 next to each other. Go to the editor



135. Write a C# Sharp program to find the larger average value between the first and the second half of a given array of integers and minimum length is atleast 2. Assume that the second half begins at index (array length)/2. Go to the editor



136. Write a C# Sharp program to count the number of strings with given length in given array of strings. Go to the editor



137. Write a C# Sharp program to create a new array using the first n strings from a given array of strings. (n>=1 and <=length of the array). Go to the editor



138. Write a C# Sharp program to create a new array from a given array of strings  using all the strings whose length are matched with given string length. Go to the editor



139. Write a C# Sharp program to check a positive integer and return true if it contains a number 2. Go to the editor



140. Write a C# Sharp program to create a new array of given length using the odd numbers from a given array of positive integers. Go to the editor



141. Write a C# Sharp program to create a new list from a given list of integers where each element is multiplied by 3. Go to the editor



142. Write a C# Sharp program to create a new list from a given list of integers where each integer multiplied by itself three times. Go to the editor



143. Write a C# Sharp program to create a new list from a given list of strings where each element has "#" added at the beginning and end position. Go to the editor



144. Write a C# Sharp program to create a new list from a given list of strings where each element is replaced by 4 copies of the string concatenated together. Go to the editor



145. Write a C# Sharp program to create a new list from a given list of integers where each integer value is added to 2 and the result value is multiplied by 5. Go to the editor



146. Write a C# Sharp program to create a new list of the rightmost digits from a given list of positive integers. Go to the editor



147. Write a C# Sharp program to create a new list from a given list of strings where strings will be in upper case in new string. Go to the editor



148. Write a C# Sharp program to remove all "a" in each string in given list of strings and return the new string. Go to the editor



149. Write a C# Sharp program to create a new list from a given list of integers removing those values which are less than 4. Go to the editor



150. Write a C# Sharp program to create a new list from a given list of integers removing those values end with 7. Go to the editor



145. Write a C# Sharp program to create a new list from a given list of integers where each integer value is added to 2 and the result value is multiplied by 5. Go to the editor



146. Write a C# Sharp program to create a new list of the rightmost digits from a given list of positive integers. Go to the editor



147. Write a C# Sharp program to create a new list from a given list of strings where strings will be in upper case in new string. Go to the editor



148. Write a C# Sharp program to remove all "a" in each string in given list of strings and return the new string. Go to the editor



149. Write a C# Sharp program to create a new list from a given list of integers removing those values which are less than 4. Go to the editor



150. Write a C# Sharp program to create a new list from a given list of integers removing those values end with 7. Go to the editor


*/


/* C# Data Types Exercises 


1. Write a C# Sharp program that takes three letters as input and display them in reverse order. Go to the editor



2. Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number. Go to the editor



3. Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected. Go to the editor



4. Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation. Go to the editor



5. Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle. Go to the editor



6. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5). Go to the editor



7. Write a C# Sharp program that takes distance and time as input and displays the speed in kilometers per hour and miles per hour. Go to the editor



8. Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere. Go to the editor



9. Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol. Go to the editor



10. Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd. Go to the editor



11. Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form. Go to the editor


*/


/* C# Conditional Statement 


1. Write a C# Sharp program to accept two integers and check whether they are equal or not. Go to the editor



2. Write a C# Sharp program to check whether a given number is even or odd. Go to the editor



3. Write a C# Sharp program to check whether a given number is positive or negative. Go to the editor



4. Write a C# Sharp program to find whether a given year is a leap year or not. Go to the editor



5. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote. Go to the editor



6. Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0. Go to the editor



7. Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height. Go to the editor



8. Write a C# Sharp program to find the largest of three numbers. Go to the editor



9. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies. Go to the editor



10. Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria: Go to the editor



11. Write a C# Sharp program to calculate root of Quadratic Equation. Go to the editor



12. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division. Go to the editor



13. Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below : Go to the editor



14. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene. Go to the editor



15. Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles. Go to the editor



16. Write a C# Sharp program to check whether an alphabet is a vowel or consonant. Go to the editor



17. Write a C# Sharp program to calculate profit and loss on a transaction. Go to the editor



18. Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer. The charge are as follow : Go to the editor



19. Write a program in C# Sharp to accept a grade and declare the equivalent description : Go to the editor



20. Write a program in C# Sharp to read any day number in integer and display day name in the word. Go to the editor



21. Write a program in C# Sharp to read any digit, display in the word. Go to the editor



22. Write a program in C# Sharp to read any Month Number in integer and display Month name in the word. Go to the editor



23. Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month. Go to the editor



24. Write a program in C# Sharp which is a Menu-Driven Program to compute the area of the various geometrical shape. Go to the editor



25. Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation. Go to the editor


*/


/* C# Exception Handling
 


// https://www.w3resource.com/csharp-exercises/exception-handling/index.php


*/


/* C# For Loop 


1. Write a program in C# Sharp to display the first 10 natural numbers. Go to the editor



2. Write a C# Sharp program to find the sum of first 10 natural numbers. Go to the editor



3. Write a program in C# Sharp to display n terms of natural number and their sum.Go to the editor



4. Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average. Go to the editor



5. Write a program in C# Sharp to display the cube of the number upto given an integer. Go to the editor



6. Write a program in C# Sharp to display the multiplication table of a given integer. Go to the editor



7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n. Go to the editor



8. Write a program in C# Sharp to display the n terms of odd natural number and their sum. Go to the editor



9. Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk. Go to the editor



10. Write a program in C# Sharp to display the pattern like right angle triangle with a number. Go to the editor



11. Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row. Go to the editor



12. Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1. Go to the editor



13. Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1. Go to the editor



14. Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk. Go to the editor



15. Write a C# Sharp program to calculate the factorial of a given number. Go to the editor



16. Write a program in C# Sharp to display the n terms of even natural number and their sum. Go to the editor



17. Write a program in C# Sharp to make such a pattern like a pyramid witha number which will repeat the number in the same row. Go to the editor



18. Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........]. Go to the editor



19. Write a program in C# Sharp to display the n terms of harmonic series and their sum. Go to the editor



20. Write a program in C# Sharp to display the pattern like pyramid using an asterisk and each row contain an odd number of an asterisks. Go to the editor



21. Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...]. Go to the editor



22. Write a program in C# Sharp to print the Floyd's Triangle. Go to the editor



23. Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....]. Go to the editor



24. Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -.....]. Go to the editor



25. Write a program in C# Sharp to display the n terms of square natural number and their sum. Go to the editor



26. Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms. Go to the editor



27. Write a C# Sharp program to check whether a given number is perfect number or not. Go to the editor



28. Write a C# Sharp program to find the perfect numbers within a given range of number. Go to the editor



29. Write a C# Sharp program to check whether a given number is an Armstrong number or not. Go to the editor



30. Write a C# Sharp program to find the Armstrong number for a given range of number. Go to the editor



31. Write a program in C# Sharp to display the pattern like a diamond. Go to the editor



32. Write a C# Sharp program to determine whether a given number is prime or not. Go to the editor



33. Write a C# Sharp program to display by Pascal's triangle. Go to the editor



34. Write a program in C# Sharp to find the prime numbers within a range of numbers. Go to the editor



35. Write a program in C# Sharp to display the first n terms of Fibonacci series. Go to the editor



36. Write a program in C# Sharp to display the such a pattern for n number of rows using a number which will start with the number 1 and the first and a last number of each row will be 1. Go to the editor



37. Write a program in C# Sharp to display the number in reverse order. Go to the editor



38. Write a program in C# Sharp to check whether a number is a palindrome or not. Go to the editor



39. Write a program in C# Sharp to find the number and sum of all integer between 100 and 200 which are divisible by 9. Go to the editor



40. Write a C# Sharp Program to display the following pattern using the alphabet. Go to the editor



41. Write a program in C# Sharp to convert a decimal number into binary without using an array. Go to the editor



42. Write a program in C# Sharp to convert a binary number into a decimal number without using array, function and while loop. Go to the editor



43. Write a C# Sharp program to find HCF (Highest Common Factor) of two numbers. Go to the editor



44. Write a program in C# Sharp to find LCM of any two numbers using HCF. Go to the editor



45. Write a program in C# Sharp to find LCM of any two numbers. Go to the editor



46. Write a program in C# Sharp to convert a binary number into a decimal number using math function. Go to the editor



47. Write a C# Sharp program to check whether a number is a Strong Number or not. Go to the editor



48. Write a C# Sharp program to find Strong Numbers within a range of numbers. Go to the editor



49. Write a C# Sharp program to find out the sum of in A.P. series. Go to the editor



50. Write a program in C# Sharp to convert a decimal number into octal without using an array. Go to the editor



51. Write a program in C# Sharp to convert an octal number to decimal without using array. Go to the editor



52. Write a program in C# Sharp to find the Sum of GP series. Go to the editor



53. Write a program in C# Sharp to convert a binary number to octal. Go to the editor



54. Write a program in C# Sharp to convert an octal number into binary. Go to the editor



55. Write a program in C# Sharp to convert a decimal number to hexadecimal. . Go to the editor



56. Write a program in C# Sharp to Check Whether a Number can be Express as Sum of Two Prime Numbers. Go to the editor



57. Write a program in C# Sharp to print a string in reverse order. Go to the editor



58. Write a C#Sharp program to display alphabet pattern like A with an asterisk. Go to the editor



59. Write a C#Sharp program to display alphabet pattern like B with an asterisk. Go to the editor



60. Write a C#Sharp program to display alphabet pattern like C with an asterisk. Go to the editor



61. Write a C#Sharp program to display alphabet pattern like D with an asterisk. Go to the editor



62. Write a C#Sharp program to display alphabet pattern like E with an asterisk. Go to the editor



63. Write a C#Sharp program to display alphabet pattern like F with an asterisk. Go to the editor



64. Write a C#Sharp program to display alphabet pattern like G with an asterisk. Go to the editor



65. Write a C#Sharp program to display alphabet pattern like H with an asterisk. Go to the editor



66. Write a C#Sharp program to display alphabet pattern like I with an asterisk. Go to the editor



67. Write a C#Sharp program to display alphabet pattern like J with an asterisk. Go to the editor



68. Write a C#Sharp program to display alphabet pattern like K with an asterisk. Go to the editor



69. Write a C#Sharp program to display alphabet pattern like L with an asterisk. Go to the editor



70. Write a C#Sharp program to display alphabet pattern like M with an asterisk. Go to the editor



71. Write a C#Sharp program to display alphabet pattern like N with an asterisk. Go to the editor



72. Write a C#Sharp program to display alphabet pattern like O with an asterisk. Go to the editor



73. Write a C#Sharp program to display alphabet pattern like P with an asterisk. Go to the editor



74. Write a C#Sharp program to display alphabet pattern like Q with an asterisk. Go to the editor



75. Write a C#Sharp program to display alphabet pattern like R with an asterisk. Go to the editor



76. Write a C#Sharp program to display alphabet pattern like S with an asterisk. Go to the editor



77. Write a C#Sharp program to display alphabet pattern like T with an asterisk. Go to the editor



78. Write a C#Sharp program to display alphabet pattern like U with an asterisk. Go to the editor



79. Write a C#Sharp program to display alphabet pattern like V with an asterisk. Go to the editor



80. Write a C#Sharp program to display alphabet pattern like W with an asterisk. Go to the editor



81. Write a C#Sharp program to display alphabet pattern like X with an asterisk. Go to the editor



82. Write a C#Sharp program to display alphabet pattern like Y with an asterisk. Go to the editor



83. Write a C#Sharp program to display alphabet pattern like Z with an asterisk. Go to the editor


*/

/* C#  Array 


1. Write a program in C# Sharp to store elements in an array and print it. Go to the editor



2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order. Go to the editor



3. Write a program in C# Sharp to find the sum of all elements of the array. Go to the editor



4. Write a program in C# Sharp to copy the elements one array into another array. Go to the editor



5. Write a program in C# Sharp to count a total number of duplicate elements in an array. Go to the editor



6. Write a program in C# Sharp to print all unique elements in an array. Go to the editor



7. Write a program in C# Sharp to merge two arrays of same size sorted in ascending order. Go to the editor



8. Write a program in C# Sharp to count the frequency of each element of an array. Go to the editor



9. Write a program in C# Sharp to find maximum and minimum element in an array. Go to the editor



10. Write a programin C# Sharp to separate odd and even integers in separate arrays. Go to the editor



11. Write a program in C# Sharp to sort elements of array in ascending order. Go to the editor



12. Write a program in C# Sharp to sort elements of the array in descending order. Go to the editor



13. Write a program in C# Sharp to insert New value in the array (sorted list ). Go to the editor



14. Write a program in C# Sharp to insert New value in the array (unsorted list ). Go to the editor



15. Write a program in C# Sharp to delete an element at desired position from an array. Go to the editor



16. Write a program in C# Sharp to find the second largest element in an array. Go to the editor



17. Write a program in C# Sharp to find the second smallest element in an array. Go to the editor



18. Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix. Go to the editor



19. Write a program in C# Sharp for addition of two Matrices of same size. Go to the editor



20. Write a program in C# Sharp for subtraction of two Matrices. Go to the editor



21. Write a program in C# Sharp for multiplication of two square Matrices. Go to the editor



22. Write a program in C# Sharp to find transpose of a given matrix. Go to the editor



23. Write a program in C# Sharp to find sum of right diagonals of a matrix.Go to the editor



24. Write a program in C# Sharp to find the sum of left diagonals of a matrix. Go to the editor



25. Write a program in C# Sharp to find sum of rows an columns of a Matrix.Go to the editor



26. Write a program in C# Sharp to print or display the lower triangular of a given matrix. Go to the editor



27. Write a program in C# Sharp to print or display the upper triangular of a given matrix. Go to the editor



28. Write a program in C# Sharp to calculate determinant of a 3 x 3 matrix. Go to the editor



29. Write a program in C# Sharp to accept a matrix and determine whether it is a sparse matrix. Go to the editor



30. Write a program in C# Sharp to accept two matrices and check whether they are equal. Go to the editor



31. Write a program in C# Sharp to Check whether a Given Matrix is an Identity Matrix. Go to the editor


*/

/* C#  Searching and Sorting Algorithm 


1. Write a C# Sharp program to sort a list of elements using Shell sort. Go to the editor



2. Write a C# Sharp program to sort a list of elements using Bogosort sort. Go to the editor



3. Write a C# Sharp program to sort a list of elements using Bubble sort. Go to the editor



4. Write a C# Sharp program to sort a list of elements using Counting sort. Go to the editor



5. Write a C# Sharp program to sort a list of elements using Heap sort. Go to the editor



6. Write a C# Sharp program to sort a list of elements using Insertion sort. Go to the editor



7. Write a C# Sharp program to sort a list of elements using Merge sort. Go to the editor



8. Write a C# Sharp program to sort a list of elements using Permutation sort. Go to the editor



9. Write a C# Sharp program to sort a list of elements using Quick sort. Go to the editor



10. Write a C# Sharp program to sort a list of elements using the Radix sort algorithm. Go to the editor



11. Write a C# Sharp program to sort a list of elements using the Selection sort algorithm. Go to the editor


*/

/* C#  String 


1. Write a program in C# Sharp to input a string and print it. Go to the editor



2. Write a program in C# Sharp to find the length of a string without using library function. Go to the editor



3. Write a program in C# Sharp to separate the individual characters from a string. Go to the editor



4. Write a program in C# Sharp to print individual characters of the string in reverse order. Go to the editor



5. Write a program in C# Sharp to count the total number of words in a string. Go to the editor



6. Write a program in C# Sharp to compare two string without using string library functions. Go to the editor



7. Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string. Go to the editor



8. Write a program in C# Sharp to copy one string to another string. Go to the editor



9. Write a program in C# Sharp to count a total number of vowel or consonant in a string. Go to the editor



10. Write a program in C# Sharp to find maximum occurring character in a string. Go to the editor



11. Write a program in C# Sharp to sort a string array in ascending order. Go to the editor



12. Write a program in C# Sharp to read a string through the keyboard and sort it using bubble sort. Go to the editor



13. Write a program in C# Sharp to extract a substring from a given string without using the library function. Go to the editor



14. Write a C# Sharp program to check whether a given substring is present in the given string. Go to the editor



15. Write a program in C# Sharp to read a sentence and replace lowercase characters by uppercase and vice-versa. Go to the editor



16. Write a program in C# Sharp to check the username and password. Go to the editor



17. Write a program in C# Sharp to search the position of a substring within a string. Go to the editor



18. Write a program in C# Sharp to check whether a character is an alphabet and not and if so, go to check for the case. Go to the editor



19. Write a program in C# Sharp to find the number of times a substring appears in a given string. Go to the editor



20. Write a program in C# Sharp to insert a substring before the first occurrence of a string. Go to the editor



21. Write a C# Sharp program to compare (less than, greater than, equal to ) two substrings. Go to the editor



22. Write a C# Sharp program to compare two substrings that only differ in case. The first comparison ignores case and the second comparison considers case. Go to the editor



23. Write a C# Sharp program to compare two substrings using different cultures and ignoring the case of the substrings. Go to the editor



24. Write a C# Sharp program to compare the last names of two people. It then lists them in alphabetical order. Go to the editor



25. Write a C# Sharp program to compare four sets of words by using each member of the StringComparison enumeration. The comparisons use the conventions of the English (United States) and Sami (Upper Sweden) cultures.



26. Write C# Sharp program to demonstrate that the Compare(String, String, Boolean) method is equivalent to using ToUpper or ToLower when comparing strings. Go to the editor



27. Write a C# Sharp program to demonstrate how culture can affect a comparison. Go to the editor



28. Write a C# Sharp program to compare two strings in following three different ways produce three different results. Go to the editor



29. Write a C# Sharp program to compare three versions of the letter "I". The results are affected by the choice of culture, whether case is ignored, and whether an ordinal comparison is performed. Go to the editor



30. Write a C# Sharp program to demonstrate that CompareOrdinal and Compare use different sort orders. Go to the editor



31. Write a C# Sharp program to perform and ordinal comparison of two strings that only differ in case. Go to the editor



32. Write a C# Sharp program to compare a given string with set of strings. Go to the editor



33. Write a C# Sharp program to compare the current string instance with another string. Go to the editor



34. Write a C# Sharp program to concatenate three objects, objects with a variable and 3-element object array. Go to the editor



35. Write a C# Sharp program to concatenate a list of variable parameters. Go to the editor



36. Write a C# Sharp program to concatenate three strings and display the result. Go to the editor



37. Write a C# Sharp program to concatenate the array values of strings. Go to the editor



38. Write a C# Sharp program to determine whether the string "birds" is a substring of a familiar. Go to the editor



39. Write a C# Sharp program to creates two string objects with different values. When it calls the Copy method to assign the first value to the second string, the output indicates that the strings represent different object references although their values are now equal. On the other hand, when the first string is assigned to the second string, the two strings have identical values because they represent the same object reference. Go to the editor



40. Write a C# Sharp program to demonstrate the CopyTo method. Go to the editor


 
41. Write a C# Sharp program to indicate whether each string in an array ends with a period ("."). Go to the editor



42. Write C# Sharp program to check whether a string occurs at the end of another string. Go to the editor



43. Write a C# Sharp program to determine whether a string ends with a particular substring. Go to the editor


*/


/* C#  Function 


1. Write a program in C# Sharp to create a user define function. Go to the editor



2. Write a program in C# Sharp to create a user define function with parameters. Go to the editor



3. Write a program in C# Sharp to create a function for the sum of two numbers. Go to the editor



4. Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string. Go to the editor



5. Write a program in C# Sharp to calculate the sum of elements in an array. Go to the editor



6. Write a program in C# Sharp to create a function to swap the values of two integer numbers. Go to the editor



7. Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another. Go to the editor



8. Write a program in C# Sharp to create a function to display the n number Fibonacci sequence. Go to the editor



9. Write a program in C# Sharp to create a function to check whether a number is prime or not. Go to the editor



10. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Go to the editor



11. Write a program in C# Sharp to create a recursive function to find the factorial of a given number. Go to the editor



12. Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term. Go to the editor


*/


/* C#  Recursion 


1. Write a program in C# Sharp to print the first n natural number using recursion. Go to the editor



2. Write a program in C# Sharp to print numbers from n to 1 using recursion. Go to the editor



3. Write a program in C# Sharp to find the sum of first n natural numbers using recursion. Go to the editor



4. Write a program in C# Sharp to display the individual digits of a given number using recursion. Go to the editor



5. Write a program in C# Sharp to count the number of digits in a number using recursion. Go to the editor



6. Write a program in C to print even or odd numbers in a given range using recursion. Go to the editor



7. Write a program in C# Sharp to check whether a number is prime or not using recursion. Go to the editor



8. Write a program in C# Sharp to Check whether a given String is Palindrome or not using recursion. Go to the editor



9. Write a program in C# Sharp to find the factorial of a given number using recursion. Go to the editor



10. Write a program in C# Sharp to find the Fibonacci numbers for a n numbers of series using recursion. Go to the editor



11. Write a program in C# Sharp to generate all possible permutations of an array using recursion. Go to the editor



12. Write a program in C# Sharp to find the LCM and GCD of two numbers using recursion. Go to the editor



13. Write a program in C# Sharp to convert a decimal number to binary using recursion. Go to the editor



14. Write a program in C# Sharp to get the reverse of a string using recursion. Go to the editor



15. Write a program in C# Sharp to calculate the power of any number using recursion. Go to the editor


*/


/* C#  LINQ 


1. Write a program in C# Sharp to shows how the three parts of a query operation execute. Go to the editor



2. Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.Go to the editor



3. Write a program in C# Sharp to find the number of an array and the square of each number. Go to the editor



4. Write a program in C# Sharp to display the number and frequency of number from giving array. Go to the editor



5. Write a program in C# Sharp to display the characters and frequency of character from giving string. Go to the editor



6. Write a program in C# Sharp to display the name of the days of a week. Go to the editor



7. Write a program in C# Sharp to display numbers, multiplication of number with frequency and frequency of a number of giving array. Go to the editor



8. Write a program in C# Sharp to find the string which starts and ends with a specific character. Go to the editor



9. Write a program in C# Sharp to create a list of numbers and display the numbers greater than 80 as output. Go to the editor



10. Write a program in C# Sharp to Accept the members of a list through the keyboard and display the members more than a specific value. Go to the editor



11. Write a program in C# Sharp to display the top n-th records. Go to the editor



12. Write a program in C# Sharp to find the uppercase words in a string. Go to the editor



13. Write a program in C# Sharp to convert a string array to a string. Go to the editor



14. Write a program in C# Sharp to find the n-th Maximum grade point achieved by the students from the list of students. Go to the editor



15. Write a program in C# Program to Count File Extensions and Group it using LINQ. Go to the editor



16. Write a program in C# Sharp to Calculate Size of File using LINQ. Go to the editor



17. Write a program in C# Sharp to Remove Items from List using remove function by passing the object. Go to the editor



18. Write a program in C# Sharp to Remove Items from List by creating an object internally by filtering. Go to the editor



19. Write a program in C# Sharp to Remove Items from List by passing filters. Go to the editor



20. Find the number and its square of an array which is more than 20. Go to the editor



21. Write a program in C# Sharp to remove a range of items from a list by passing the start index and number of elements to remove. Go to the editor



22. Write a program in C# Sharp to find the strings for a specific minimum length. Go to the editor



23. Write a program in C# Sharp to generate a Cartesian Product of two sets. Go to the editor



24. Write a program in C# Sharp to generate a Cartesian Product of three sets. Go to the editor



25. Write a program in C# Sharp to generate an Inner Join between two data sets. Go to the editor



26. Write a program in C# Sharp to generate a Left Join between two data sets. Go to the editor



27. Write a program in C# Sharp to generate a Right Outer Join between two data sets. Go to the editor


28. Write a program in C# Sharp to display the list of items in the array according to the length of the string then by name in ascending order. Go to the editor



29. Write a program in C# Sharp to split a collection of strings into some groups. Go to the editor



30. Write a program in C# Sharp to arrange the distinct elements in the list in ascending order. Go to the editor


*/


/* C#  STRUCTURE 


1. Write a program in C# Sharp to declare a simple structure. Go to the editor



2. Write a program in C# Sharp to declare a simple structure and use of static fields inside a struct. Go to the editor



3. Write a program in C# Sharp to create a nested struct to store two data for an employee in an array. Go to the editor



4. Write a program in C# Sharp to create a structure and Assign the Value and call it. Go to the editor



5. Write a program in C# Sharp to show what happen when a struct and a class instance is passed to a method. Go to the editor



6. Write a program in C# Sharp to declares a struct with a property, a method, and a private field. Go to the editor



7. Write a program in C# Sharp to demonstrates struct initialization using both default and parameterized constructors. Go to the editor



8. Write a program in C# Sharp to demonstrates struct initialization without using the new operator. Go to the editor



9. Write a program in C# Sharp to insert the information of two books. Go to the editor



10. Write a program in C# Sharp to implement a method that returns a structure including calling the method and using its value. Go to the editor



*/


/* C#  DateTime 


1. Write a C# Sharp program to extract the Date property and display the DateTime value in the formatted output. Go to the editor



2. Write a C# Sharp program to display the Day properties (year, month, day, hour, minute, second, millisecond etc.). Go to the editor



3. Write a C# Sharp program to get the day of the week for a specified date. Go to the editor



4. Write a C# Sharp program to display the number of days of the year between two specified years. Go to the editor



5. Write a C# Sharp program to get a DateTime value that represents the current date and time on the local computer. Go to the editor



6. Write a C# Sharp program to display the number of ticks that have elapsed since the beginning of the twenty-first century and to instantiate a TimeSpan object using the Ticks property. Go to the editor



7. Write a C# Sharp program to get the time of day from a given array of date time values. Go to the editor



8. Write a C# Sharp program to retrieve the current date. Go to the editor



9. Write a C# Sharp program to calculate what day of the week is 40 days from this moment. Go to the editor



10. Write a C# Sharp program to determine the day of the week 40 days after the current date. Go to the editor



11. Write a C# Sharp program to add a number of whole and fractional values to a date and time. Go to the editor



12. Write C# Sharp Program to add one millisecond and 2.5 milliseconds to a given date value and display each new value and the difference between it and the original value. Go to the editor



13. Write a C# Sharp Program to add 30 seconds and the number of seconds in one day to a DateTime value. Go to the editor



14. Write a C# Sharp program to add specified number of months (between zero and fifteen months) to the last day of August, 2016. Go to the editor



15. Write a C# Sharp program to display the date of past and future fifteen years of a specified date. Go to the editor



16. Write a C# Sharp program that compares two dates. Go to the editor



17. Write a C# Sharp Program to create a date one year previously and the date one year in the future compare to the current date. Go to the editor



18. Write a C# Sharp program to compare the current date with a given date. Go to the editor



19. Write a C# Sharp program to get the number of days of the specified month and year. Go to the editor



20. Write a C# Sharp program to compare DateTime objects. Go to the editor



21. Write a C# Sharp program to convert the specified string representation of a date and time to its DateTime equivalent using the specified array of formats, culture-specific format information, and style. Go to the editor



22. Write a C# Sharp program which shows that when a time that falls within this range is converted to a long integer value and is then restored and the original value is adjusted to become a valid time. Go to the editor



23. Write a C# Sharp program to convert the specified Windows file time to an equivalent UTC time. Go to the editor



24. Write a C# Sharp program to display the string representation of a date using all possible standard date and time formats in the computer's current culture (en-US.). Go to the editor



25. Write a C# Sharp program to display the string representation of a date using the long date format. Go to the editor



26. Write a C# Sharp program to display the string representations of a date using the short date format specified for the ja-JP culture. Go to the editor



27. Write a C# Sharp program to determine the type of a particular object. Go to the editor



28. Write a C# Sharp program to find the leap years between 1994 and 2014. Go to the editor



29. Write a C# Sharp program to convert the specified string representation of a date and time to its DateTime equivalent using the specified array of formats, culture-specific format information, and style. Go to the editor



30. Write a C# Sharp program to get the difference between two dates in days. Go to the editor



31. Write a C# Sharp program to convert the value of the current DateTime object to local time. Go to the editor



32. Write a C# Sharp program to convert the value of the current DateTime object to its equivalent long date string representation. Go to the editor



33. Write a C# Sharp program to convert the value of the current DateTime object to its equivalent long time string representation. Go to the editor



34. Write a C# Sharp program to convert the value of the current DateTime object to its equivalent short date string representation. Go to the editor



35. Write a C# Sharp program to convert the value of the current DateTime object to its equivalent short time string representation. Go to the editor



36. Write a C# Sharp program to convert the value of the current DateTime object to its equivalent string representation using the formatting conventions of the current culture. Go to the editor



37. Write a C# Sharp program to display the string representation of a date and time using CultureInfo objects that represent five different cultures. Go to the editor



38. Write a C# Sharp program to use these three format strings to display a date and time value by using the conventions of the en-CA and sv-FI cultures. Go to the editor



39. Write a C# Sharp program to use each of the standard date time format strings to display the string representation of a date and time for four different cultures. Go to the editor



40. Write a C# Sharp program to convert the value of the current DateTime object to Coordinated Universal Time (UTC). Go to the editor



41. Write a C# Sharp program to convert the specified string representation of a date and time to its DateTime equivalent. Go to the editor



42. Write a C# Sharp program to convert the specified string representation of a date and time to its DateTime equivalent using the specified format, culture-specific format information, and style. Go to the editor



43. Write a program in C# Sharp to check whether the given year, month and day are the current or not. Go to the editor



44. Write a program in C# Sharp to compute what day was yesterday. Go to the editor



45. Write a program in C# Sharp to compute what day will be tomorrow. Go to the editor



46. Write a program in C# Sharp to get the first day of the current year and first of a year against a given date. Go to the editor



47. Write a program in C# Sharp to get the last day of the current year against a given date. Go to the editor



48. Write a program in C# Sharp to get the number of days of a given month for a year. Go to the editor



49. Write a program in C# Sharp to get the day and month name of current date. Go to the editor



50. Write a program in C# Sharp to print the name of the first three letters of month of a year starting form current date. Go to the editor



51. Write a program in C# Sharp to print the name of month in full starting from current date. Go to the editor



52. Write a program in C# Sharp to find the first day of a week against a given date. Go to the editor



53. Write a program in C# Sharp to find the last day of a week against a given date. Go to the editor



54. Write a program in C# Sharp to find the first day of the month against a given date. Go to the editor



55. Write a program in C# Sharp to find the last day of a month against a given date. Go to the editor



56. Write a program in C# Sharp to find the First day of next month against a given date. Go to the editor



57. Write a program in C# Sharp to find the day for a particular date. Go to the editor



*/


/* C#  File Handling 

1. Write a program in C# Sharp to create a blank file in the disk newly. Go to the editor



2. Write a program in C# Sharp to remove a file from the disk. Go to the editor



3. Write a program in C# Sharp to create a blank file in the disk if the same file already exists. Go to the editor



4. Write a program in C# Sharp to create a file and add some text. Go to the editor



5. Write a program in C# Sharp to create a file with text and read the file. Go to the editor



6. Write a program in C# Sharp to create a file and write an array of strings to the file. Go to the editor



7. Write a program in C# Sharp to create and write some line of text into a file which does not contain a given string in a line. Go to the editor



8. Write a program in C# Sharp to append some text to an existing file. Go to the editor



9. Write a program in C# Sharp to create and copy the file to another name and display the content. Go to the editor



10. Write a program in C# Sharp to create a file and move the file into the same directory to another name. Go to the editor



11. Write a program in C# Sharp to read the first line from a file. Go to the editor



12. Write a program in C# Sharp to create and read the last line of a file. Go to the editor



13. Write a program in C# Sharp to read a specific line from a file. Go to the editor



14. Write a program in C# Sharp to create and read last n number of lines of a file. Go to the editor



15. Write a program in C# Sharp to count the number of lines in a file. Go to the editor


*/



