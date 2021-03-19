using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String gender;
            int age;

            Console.WriteLine("Please enter your gender: ");
            gender = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());

            if(age > 17){
                Console.WriteLine(gender + " is an adult");
            }else{
                Console.WriteLine(gender + " is not an adult");
            }

        }
    }
}
