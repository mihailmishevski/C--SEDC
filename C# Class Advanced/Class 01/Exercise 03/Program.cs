// See https://aka.ms/new-console-template for more information

string choice;
double computerWins = 0;
double playerWins = 0;
double totalPlays = 0;

while (true)
{
Console.WriteLine("Welcome to Rock Papper Scissors\n1.Play\n2.Stats\n3.Exit");

choice = Console.ReadLine();

switch (choice)
{
    case "1":
        {
            Play();
        }
        break;

    case "2":
        {
                Console.WriteLine($"The player has won {playerWins} or {(playerWins/totalPlays) * 100}%.\nThe computer has won {computerWins} or {(computerWins/totalPlays * 100)}%.\n");
        }
        break;

    case "3":
        {
            return;
        }
        break;

    default:
        {
            Console.WriteLine("Wrong entry try again!");
        }
        break;
}

void Play()
    {
        Console.WriteLine("Choose your pick!\n1.Rock\n2.Paper\n3.Scissors");

        string choice = Console.ReadLine();

        string playerChoice = "";

        switch (choice)
        {
            case "1":
                {
                    playerChoice = "rock";
                }
                break;

            case "2":
                {
                    playerChoice = "paper";
                }
                break;

            case "3":
                {
                    playerChoice = "scissors";
                }
                break;

            default:
                {
                    Console.WriteLine("You entered a wrong value :(");
                }
                break;
        }

        bool playerChoiceBool = int.TryParse(choice, out int playerChoiceIndex);

        Random computerRandom = new Random();

        int computerIndex = computerRandom.Next(1, 4);

        string computerChoice = "";

        switch (computerIndex)
        {
            case 1:
                {
                    computerChoice = "rock";
                }
                break;

            case 2:
                {
                    computerChoice = "paper";
                }
                break;

            case 3:
                {
                    computerChoice = "scissors";
                }
                break;
        }

        Console.WriteLine($"The player chose {playerChoice}, and the computer chose {computerChoice}");

        string[,] winLoss = new string[3, 3] { 
            { "t", "w", "w" }, 
            { "l", "t", "w" },
            { "l", "l", "t" } };

        string outcome = winLoss[playerChoiceIndex - 1, computerIndex - 1];


        if(outcome == "t")
        {
            Console.WriteLine($"It's a draw!");
            totalPlays++;
            return;
        }

        if(outcome == "w")
        {
            Console.WriteLine($"Player wins!");
            playerWins++;
            totalPlays++;
            return;
        }

        if (outcome == "l")
        {
            Console.WriteLine($"Computer wins!");
            computerWins++;
            totalPlays++;
            return;
        }

  /*      if (playerChoice == "rock" && computerChoice == "rock")
        {
            Console.WriteLine($"It's a draw!");
            totalPlays++;
            return;
        }

        if (playerChoice == "rock" && computerChoice == "paper")
        {
            Console.WriteLine($"Computer wins!");
            computerWins++;
            totalPlays++;
            return;
        }

        if (playerChoice == "paper" && computerChoice == "rock")
        {
            Console.WriteLine($"Player wins!");
            playerWins++;
            totalPlays++;
            return;
        }

        if (playerChoice == "paper" && computerChoice == "paper")
        {
            Console.WriteLine($"It's a draw!");
            totalPlays++;
            return;
        }

        if (playerChoice == "paper" && computerChoice == "scissors")
        {
            Console.WriteLine($"Computer wins!");
            computerWins++;
            totalPlays++;
            return;
        }

        if (playerChoice == "scissors" && computerChoice == "paper")
        {
            Console.WriteLine($"Player wins!");
            playerWins++;
            totalPlays++;
            return;
        }

        if (playerChoice == "scissors" && computerChoice == "scissors")
        {
            Console.WriteLine($"It's a draw!");
            totalPlays++;
            return;
        }

        if (playerChoice == "scissors" && computerChoice == "rock")
        {
            Console.WriteLine($"Computer wins!");
            computerWins++;
            totalPlays++;
            return;
        }

        if (playerChoice == "rock" && computerChoice == "scissors")
        {
            Console.WriteLine($"Player wins!");
            playerWins++;
            totalPlays++;
            return;
        }*/
    }
}
