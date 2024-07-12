using Programm1;
class Program
    {
        static void Main()
            {
                Handy handy1 = new Handy();
                handy1.makeHandy("phone 3", 3);

                Console.WriteLine(handy1.Name);


                /*
                Console.WriteLine("bitte eingeben: ");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 % 2 == 0)
                {
                    Console.WriteLine("deine num ist gerade");
                }
                else
                {
                    Console.WriteLine("nummer ist ungerade!");
                }

                
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("hello this is for schleife");
                }

                
                for (int i = 0; i < 5; i++)
                {
                    if (i == 2)
                    {
                        Console.WriteLine("Hello this is i 2");
                    }
                    else if (i == 3)
                    {
                        Console.WriteLine("this is i 3");
                    }
                    Console.WriteLine("hello this is for schleife");
                }
                */
                
                int[] array1 = [3,6,4,4];
                String[] stringarray = ["lol","ji"];

                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine(array1[i]);
                }

            }
    }