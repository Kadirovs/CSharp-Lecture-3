double totalPrice = CalculateTotalPrice(5,10.5);
Console.WriteLine($"Total: {totalPrice}");
double CalculateTotalPrice(int quantity, double pricePerItem){
	return quantity * pricePerItem;
}


void SayGoodMorning()
{
	Console.WriteLine("Good morning!");
}
void SayGoogAfternon(){
	Console.WriteLine("Good afternoon!");
}
void SayGoodEvening(){
	Console.WriteLine("Good evening!"); 
}

string timeOfDaay = "afternoon";

switch(timeOfDaay){
	case "morning":
	SayGoodMorning();
	break;

	case "afternoon":
	SayGoogAfternon();
	break;

	case "evening":
	SayGoodEvening();
	break;

	default:
	Console.WriteLine("Hello!");
	break;
}


/*double Add(double a, double b){
	return a + b;
}
double Subtract(double a, double b){
	return a-b;
}
double Multiply(double a, double b){
	return a*b;
}
double Divide(double a, double b){
	if(b==0){
		Console.WriteLine("Error");
		return double.NaN;
	}
	return a/b;
}

double num1 = int.Parse(Console.ReadLine());
double num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Addition:" + Add(num1,num2));
Console.WriteLine("Subtraction:" + Subtract(num1,num2));
Console.WriteLine("Multiplication:" + Multiply(num1,num2));
Console.WriteLine("Division:" + Divide(num1,num2));

Console.WriteLine("Division by zero" + Divide(num1,0));*/



/*char CheckGrade(int grade){
	if(grade>=90 && grade<=100){
		return 'A';
	}
	else if(grade>=80 && grade<90){
		return 'B';
	}
	else if(grade>=70 && grade<80){
		return 'C';
	}
	else if(grade>=60 && grade<70){
		return 'D';
	}
	else if(grade>=0 & grade<60){
		return 'F';
	}
	else{
		return 'E';
	}
}

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckGrade(number));*/



  
    
   
    
/*using System;

class Program
{
    static void Main()
    {
        
        string input = Console.ReadLine(); 
        string[] inputArray = input.Split(' ');

 
        int[] numbers = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            numbers[i] = Convert.ToInt32(inputArray[i].Trim()); 
        }

        int sum = CalculateSum(numbers); 
        
        Console.WriteLine(sum);
    }

  
    static int CalculateSum(int[] numbers)
    {
        int sum = 0; 
        foreach (int number in numbers)
        {
            sum += number; 
        }
        return sum; 
    }
}
*/

/*using System;

class Program
{
    static void Main()
    {
        
        string input = Console.ReadLine(); 
        string[] inputArray = input.Split(' '); 

        int[] numbers = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            numbers[i] = Convert.ToInt32(inputArray[i].Trim()); 
        }

        
        int max = FindMax(numbers); 
        
        Console.WriteLine(max); 
    }

    static int FindMax(int[] numbers)
    {
        int max = numbers[0]; 
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number; 
            }
        }
        return max; 
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
       
        int number = Convert.ToInt32(Console.ReadLine());
        
        bool isPrime = IsPrime(number);
        
        
        if (isPrime)
        {
            Console.WriteLine("True"); 
        }
        else
        {
            Console.WriteLine("False"); 
        }
    }

 
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false; 
        }

        
        for (int i = 2; i * i < number; i++)
        {
            if (number % i == 0) 
            {
                return false;
            }
        }

        return true; 
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
      
        string input = Console.ReadLine();

        string reversed = ReverseString(input);
        
        Console.WriteLine(reversed);
    }

    static string ReverseString(string input)
    {
        string reversed = ""; 
        for (int i = input.Length - 1; i >= 0; i--) 
        {
            reversed += input[i];
        }
        return reversed; 
    }
}*/


/*using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int sum = CalculateFactorial(number);
        Console.WriteLine(sum);
    }

    static int CalculateFactorial(int a)
    {
        int factorial = 1;
        for (int i = 1; i <= a; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}*/
/*public class Student
{
    public string FirstName;
    public string LastName;
    public int Age;
    public double [] Grades;

    public string GetFullName(){
        return $"{LastName} {FirstName}";
    }
    public double GetAverageGrade(){
        double sum = 0;
        foreach(var grade in Grades){
            sum+=grade;
        }
        return sum/Grades.Length;
    }
}*/









