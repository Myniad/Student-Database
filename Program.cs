
using System.Xml.Linq;

bool runProgram = true;

while (runProgram)
{
    string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };

    string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };

    string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };


    Console.Write("Welcome! Which student would you like to learn more about? Enter a number 1-9: ");

    int studentNum = int.Parse(Console.ReadLine());
    int machineNum = studentNum - 1;


    while (studentNum < 1 || studentNum > 9)
    {
        Console.WriteLine("Please enter a number 1-9");
        studentNum = int.Parse(Console.ReadLine());
        machineNum = studentNum;
    }

    string townOrFood = "";
    Console.WriteLine($"Student {studentNum} is {names[machineNum]}. What would you like to know? Enter hometown or favorite food: ");
    townOrFood = Console.ReadLine().ToLower().Trim();

    while (townOrFood != "hometown" && townOrFood != "favorite food")
    {

        Console.WriteLine("That category does not exist. Please try again. Enter hometon or favorite food: ");
        townOrFood = Console.ReadLine().ToLower().Trim();
    }
    

    if (townOrFood == "hometown")
    {
        Console.WriteLine($"{names[machineNum]} is from {towns[machineNum]}");
        
    }
    else if (townOrFood == "favorite food")
    {
        Console.WriteLine($"{names[machineNum]} likes {foods[machineNum]}");
       
    }
  
    while (true)
    {
        Console.WriteLine("Would you like to learn about another student? y/n");
        string choice = Console.ReadLine().Trim().ToLower();

        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice == "n")
        {
            runProgram = false;
            break;
        }
    }
}
    

