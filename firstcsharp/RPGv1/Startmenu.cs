namespace RPG1{
    class Startmenu {
        public int Show(){ //seperate menu from choice getting mechanism

            Console.WriteLine("Welcome to RPG1!");
            Console.WriteLine("----------------------\n");

            Console.WriteLine("Please choose an option:\n");
            Console.WriteLine("(1) Play game");
            Console.WriteLine("(2) Quit game\n");


            Console.WriteLine("Enter a choice: ");
            int choice = int.Parse(Console.ReadLine());

            return choice;
            
        }
    }
}