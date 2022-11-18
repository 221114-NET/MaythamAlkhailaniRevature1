//First I'm goint to set some variables Like: bool to control the while loop.
//Second I'm goint to set the random number generator for decepticon choices.
//Third I'm goint to set the the while loop.
//Fourth I'm goint to create a Welcoming message.
//Fifth I'm goint to create a nested while loop to control the choices.
//Sixth I'm goint to print the choices. 
//Seventh I'm goint to read user input.
//Eighth I'm goint to compare the user input agains the choices.
//Nineth I 'm goint to create switches for each choice and print the results.
//Finally I'm goint to ask the user weather he/she likes to play again. Based on the 
//answer the while loop will either close the game or conntine. 



namespace rps;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        bool play = true;
        String player;
        String decepticon;
        String playAgainAnswer;
        int count;
        int count1;


        while (play)
        {

            player = "";
            decepticon = "";
            playAgainAnswer = "";
            count = 0;
            count1 = 0;

            System.Console.WriteLine("Welcome to ROCK PAPER SCISSORS AGAINST DECEPTICONS");

            while(player !="ROCK" && player !="PAPER" && player !="SCISSORS"){
                 System.Console.WriteLine("Choose: ROCK, PAPER, SCISSORS: ");
                 player = System.Console.ReadLine().ToUpper();

               
            }



            switch (rand.Next(1,4))
            {
                case 1:
                    decepticon = "ROCK";
                    break;
                case 2:
                    decepticon = "PAPER";
                    break;
                case 3:
                    decepticon = "SCISSORS";
                    break;
                
            }
           

           System.Console.WriteLine("player: " + player);
           System.Console.WriteLine("decepticon " + decepticon);
            //System.Console.WriteLine(player);

            switch (player){
                case "ROCK":
                    if (decepticon == "ROCK") {
                        System.Console.WriteLine("It's tie!");
                        count1 += 1;
                        count += 1;
                        
                   } else if (decepticon == "PAPER"){
                        System.Console.WriteLine("You lose! Decepticons are rulling Planet Earth now!");
                        count1 += 1; 
                   } else 
                        System.Console.WriteLine("You Won the decepticons!");
                        count += 1;
                break;

                case "PAPER":
                    if (decepticon == "ROCK") {
                        System.Console.WriteLine("You WON!");
                        count += 1;
                       
                   } else if (decepticon == "PAPER"){
                        System.Console.WriteLine("It's tie. You lived to fight another day");
                        count1 += 1;
                        count += 1;
                    } else 
                        System.Console.WriteLine("You lose! Decepticons are rulling Planet Earth now!");
                        count1 += 1;
                break;

                case "SCISSORS":
                    if (decepticon == "ROCK") {
                        System.Console.WriteLine("Planet Earth may need to find another fighter better than you!");
                            count1 += 1;
                   } else if (decepticon == "PAPER"){
                        System.Console.WriteLine("You won!!!");
                        count += 1;
                    }  
                    else 
                        System.Console.WriteLine("it's tie!");
                        count1 += 1;
                        count += 1;
                break;



            }
           System.Console.WriteLine("Do you want to play again? (Y/N)"); 
           playAgainAnswer = System.Console.ReadLine().ToUpper();

           if (playAgainAnswer == "Y")
           {
                     play = true;
           }         
           else
            {
                     play = false;
            }
        }

         count = 0;
         count1 = 0;
        System.Console.WriteLine("You won " + count + " times!");
        System.Console.WriteLine("Decepticons won " + count1 + " times");
        System.Console.WriteLine("Thanks for playing!");

        System.Console.ReadKey();

    }
}
