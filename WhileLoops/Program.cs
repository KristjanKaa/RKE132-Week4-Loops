
Random rnd = new Random();
int cpurandom;

bool loopActive = true; //bool -true/false

while(loopActive)
{
    cpurandom = rnd.Next(1, 4);
    //Console.WriteLine($"Mcpu has generated {cpurandom}.");

    Console.WriteLine("Make a guess. Enter a number 1-3");
    int useNumber = Int32.Parse(Console.ReadLine());

    if(useNumber == cpurandom)

    { Console.WriteLine("Congratulations, You won!");
        //loopActive = false;
        break;
    }
    else
    { 
            Console.WriteLine("Sorry. Try again!");
        }
    }
Console.WriteLine("Have a nice day!");