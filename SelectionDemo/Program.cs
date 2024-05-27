namespace SelectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18) {
                Console.WriteLine(" You and an adult");

                if (age < 18)
                {
                    Console.WriteLine("You are a teenager");
                }

                if (age <= 0) {
                    Console.WriteLine("Invalid age");
                    }

            }
        }
    }
}
