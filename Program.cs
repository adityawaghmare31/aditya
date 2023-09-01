namespace EmployeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome");
            int Is_FULL_TIME = 1;
            Random random = new Random();   
            int empCheck=random.Next(0,2);
            if(empCheck==Is_FULL_TIME) {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }
            
        }
    }
}