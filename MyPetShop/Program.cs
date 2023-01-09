using MyPetShop;

class Program
{
    private static void Main(string[] args)
    {
        //Dog myDog = new Dog("Buster", 2, "German Shepherd");
        //Cat myCat = new Cat("Whiskers", 1);

        //myDog.MakesNoise();
        //myCat.MakesNoise();

        Boolean continueLoop = true;

        while (continueLoop)
        {
            Console.WriteLine("Welcome to Chadrak's Pet Shop! \nWould you like to list a new pet? (y/n)");
            string? invokeCreatePet = Console.ReadLine().ToLower();

            if (invokeCreatePet.Equals("y"))
            {
                Console.WriteLine("\nEnter name:");
                string? name = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("Enter age:");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Enter breed:");
                string? breed = Console.ReadLine();
                Console.WriteLine("\n");

                Pet newPet = new Pet(name, age, breed);

                Console.WriteLine("\nNew pet listing added!");
                Console.WriteLine($"Description: {newPet.Description}");

                // New pet created, loop ends
                continueLoop= false;
            }
            else if (invokeCreatePet.Equals("n"))
            {
                Console.WriteLine("\nNo new pet has been listed! \nClosing application...");

                // User chose to not continue, loop ends
                continueLoop = false;
            }
            else
            {
                // User input is invalid, loop will continue until they create a listing or choose not to
                Console.WriteLine("\nInvalid input. Please select Yes (y) or No (n).");
            }
        }
    }
}