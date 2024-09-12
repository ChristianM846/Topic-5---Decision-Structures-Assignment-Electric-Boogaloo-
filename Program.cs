namespace Topic_5___Decision_Structures_Assignment__Electric_Boogaloo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Which program would you like to run?");
                Console.WriteLine();
                Console.WriteLine("1 - Compass Bearings");
                Console.WriteLine("2 - Parking Garage Cost");
                Console.WriteLine("3 - Hurricane");
                Console.WriteLine();
                Console.WriteLine("Input the number corresponding:");

                while (!Int32.TryParse(Console.ReadLine().Trim(), out choice) || choice != 1 && choice != 2 && choice != 3)
                {
                    Console.WriteLine("That is not a valid input. Please input the number of the program you wish to run.");
                }

                if (choice == 1)
                {
                    CompassBearings();
                }
                else if (choice == 2)
                {
                    ParkingGarage();
                }
                else if(choice == 3)
                {
                    Hurricane();
                }




            }





        }

        public static void CompassBearings()
        {
            double enteredAngle, actualAngel;


        }

        public static void ParkingGarage()
        {

        }

        public static void Hurricane()
        {

        }













    }
}
