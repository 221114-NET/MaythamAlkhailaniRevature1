using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Timers;
using System.Collections;
using System;

namespace pokemonApp;


//First will make classes available for Charmander, Charmeleon and Charizard.
//Implementations of the OOP class.
//Implementations of the Interface.
//Will create workflow where users can race Pokemons and if user wins, the Pokemon 
//will be captured.
//Implementation of taken user input.
//Implementation of if statements. 
//Implementation of []
//Implementation of random number generator.
//Implementation of loops.
//If user capture all pokemons, then user will unlock the money wallet.
//Creation of the user wallet.
//Creation of the abalilities to exchange pokemons for money.




public class Program : Functions
{
    static void Main(string[] args)
    {
        //Object instantiation
        Pokemon charizard = new Pokemon("charmander");
        Pokemon squirtle = new Pokemon("squirtle");

        System.Console.WriteLine("Hello welcome to Pokemon GO!");
        string userAnswer= "";
        

        while(!userAnswer.Equals("Y") && !userAnswer.Equals("N")){
                System.Console.WriteLine("To Start Please Enter (Y or N): ");  
                userAnswer = Console.ReadLine().ToUpper();
        }
            
        if (userAnswer.Equals("N")){
            System.Console.WriteLine("Thanks for stopping by, see you later");
        }

        else
             System.Console.WriteLine("Welcome to  Pokemon GO");

        countDown();
        Thread.Sleep(200);

        System.Console.WriteLine(@"
    ""
        
                                   ,'\
    _.----.        ____         ,'  _\   ___    ___     ____
_,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
\      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
 \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
   \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
    \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
     \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
      \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
       \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
        \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                `'                            '-._|
        
                    ");



Random rand = new Random();
Charmeleon charmeleon = new Charmeleon();
Pokemon pokemons = new Pokemon();
bool playGame = false;



while (!playGame){

                 System.Console.WriteLine("Choose: Hunt, Scan, Follow: ");
                 string user = System.Console.ReadLine().ToUpper();

                 string [] pokiValues = new string[3];
                 pokiValues [0] = "Runining";
                 pokiValues [1] = "Eatting";
                 pokiValues [2] = "Sleeping";
                 
                 int pok= rand.Next(1,4);

              

                 if (user == "Hunt" || pok == 1){
                    System.Console.WriteLine("The pokemon is eatting! You can hunt it or leave it alone");
                    System.Console.WriteLine("Hunt / Leave it alone: " );
                    string huntAnswer  = Console.ReadLine();
                    if (huntAnswer == "Hunt"){

                        isCaptured();
                        
                    }

                 }

                 else if (user == "Scan" || pok == 2){
                    System.Console.WriteLine("The pokemon is Sleeping.");
                    System.Console.WriteLine("You could have captured it, but you chose not to Hunt it.");
                 }

                 else if (user == "Follow" || pok == 3){
                    System.Console.WriteLine("The pokemon is Runining, you can not capture it");
                 }



         

           System.Console.WriteLine("player: " + user);
           System.Console.WriteLine("Pokemons " + pok);


}

    }




    // Random number generator for deciding if the user will capture the Pokemon or not. 

    public static void  countDown()
        {
            for (int i = 10; i>=0; i--)
            {
                System.Console.WriteLine("Time: " + i);
                Thread.Sleep(1000);
            }
                     System.Console.WriteLine("LET'S GO!");

        }

    }





class Pokemon 
{
    private string name;
    public string type;
    int hitpoints;

    public int dexNumber {get; set;}
    int weight;
    int level;
    public Pokemon()
    {

    }

    public Pokemon(string name)
    {
        this.name = name;
    }
    public Pokemon(string pokename, string type, int hp, int dex, int wt, int lvl)
    {   
        name = pokename;
        this.type = type;
        hitpoints = hp;
        dexNumber = dex;
        weight = wt;
        level = lvl;
    }

    public void IsPokemon()
    {
        Console.WriteLine($"My name is {name}. I'm a {type} I am a pokemon.");
    }

    public static void Sound()
    {
        Console.WriteLine("*pokemon noises*");
    }

    public override string ToString()
    {
        return $"My name is {name}, number {dexNumber}. I'm a {type} I am a pokemon.";
    }

    public static implicit operator Pokemon(int v)
    {
        throw new NotImplementedException();
    }
}

