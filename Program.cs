//start main
using System.Runtime.CompilerServices;

DisplayMenu();
string userInput = "";
while (userInput != "5"){ 
    DisplayMenu(); //displays menu after first loop
    userInput = GetEnjoymentLevel(); // prompts user enjoyment level
    RouteEm(userInput);
}
//end main

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Welcome to The College Football Intro!\nWhat is your preferred level of enjoyment?\n"); //menu line 1
    System.Console.WriteLine("1. Boring\n2. Average\n3. Fun\n4. Epic\n5. Exit College Football Intro\n"); //menu line 2
}

static string GetEnjoymentLevel(){
    return Console.ReadLine(); //get user input from console
}

static void RouteEm(string userInput){
    string enjoymentLevel = "";
    switch (userInput){
        case "1":
            enjoymentLevel = "Boring";
            break;
        case "2":
            enjoymentLevel = "Average";
            break;
        case "3":
            enjoymentLevel = "Fun";
            break;
        case "4":
            enjoymentLevel = "Epic";
            break;
        case "5":
            SayBye();
            return;
        default:
            DisplayErrorMessage();
            return;
    }

    string stadium = GetStadiumRecommendation(enjoymentLevel); //call GetStadiumRecommendation, add paramater(enjoymentLevel) = stadium
    string game = GetGameRecommendation(stadium); //call GetGameRecommendation, add paramater(stadium) = game
    DisplayStadiumDetails(stadium, game); //call DisplayStadiumDetails, add stadium and game variables
}

static string GetStadiumRecommendation(string enjoymentLevel){ //define GetStadiumRecommendation and return a string (stadium)
    switch (enjoymentLevel){
        case "Boring":
            return "Neyland Stadium";
        case "Average":
            return "Jordan-Hare Stadium";
        case "Fun":
            return "Tiger Stadium";
        case "Epic":
            return "Saban Field at Bryant-Denny Stadium";
        default:
            return "n/a";
    }
}

static string GetGameRecommendation(string stadium){ //define GetGameRecommendation and return a string (game)
    switch (stadium){
        case "Neyland Stadium":
            return "Tennessee vs. Kent State";
        case "Jordan-Hare Stadium":
            return "Auburn vs. Kentucky";
        case "Tiger Stadium":
            return "LSU vs. Alabama";
        case "Saban Field at Bryant-Denny Stadium":
            return "Alabama vs. Auburn... The Iron Bowl";
        default:
            return "n/a";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    System.Console.WriteLine($"\nYou need to go to {stadium} for {game}!\n"); //display final message to user
    Pause();
}

static void SayBye(){
    System.Console.WriteLine("\nGoodbye!\n"); //display Goodbye! on exit
    Pause();
}

static void DisplayErrorMessage(){
    System.Console.WriteLine("Invalid Menu Selection"); //display error message with incorrect input
    Pause();
}

static void Pause(){
    System.Console.WriteLine("Press any key to continue"); //prompt user for new keystroke
    Console.ReadKey();
}