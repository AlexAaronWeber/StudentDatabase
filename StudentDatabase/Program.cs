//-----------------------MAIN-----------------------

//Arrays
string[] names = { "Justin", "Lucas", "Aaliyah", "Jon", "Tarik", "Alex", "Josh"};
string[] favFoods = { "Baja Blast", "Sushi", "Chicken Wings", "Bacon", "Tacos", "Spaghetti", "Nalesniki" };
string[] homeTowns = { "Wtoming", "Lousiville", "Manchester", "Toledo", "Queens", "Ferndale", "Cali"};

Console.WriteLine("Welcome to our Student Portal! Let's learn about the students.");


bool looping = true; 
while (looping)
{
    int indexSearch = 0;
    while (true) { 
        Console.WriteLine($"Which student do you want to learn about? 1-{names.Length}: ");
        for (int i = 0; i < names.Length; i++)
        {
         Console.WriteLine($"{i+1}. {names[i]}");
        }
        string studentName = Console.ReadLine();
        if (names.Contains(studentName)) 
        {
            indexSearch = Array.IndexOf(names, studentName) +1;
            break;
        }
        
        else if (indexSearch >= 1 && indexSearch <= names.Length)
        {
            indexSearch = int.Parse(Console.ReadLine());
            break;
        }
        else
        {
            Console.WriteLine("That was not valid");
        }
    }

        Console.WriteLine($"Student {indexSearch} is {names[indexSearch - 1]}");

        while (true)
        {
            Console.Write("Which category would you like to know? Enter 'Hometown' or 'Favorite Food' ");
            string categorySearch = Console.ReadLine().Trim().ToLower();
            if (categorySearch == "hometown" || categorySearch.Contains("home") || categorySearch.Contains("town"))
            {
                Console.WriteLine($"{names[indexSearch - 1]}'s hometown is {homeTowns[indexSearch - 1]}");
                break;
            }
            else if (categorySearch == "favorite food" || categorySearch.Contains("favorite") || categorySearch.Contains("food"))
            {
                Console.WriteLine($"{names[indexSearch - 1]}'s favorite food is {favFoods[indexSearch - 1]}");
                break;
            }
            else
            {
                Console.WriteLine("Did you spell that right?");
            }
        }


        while (true)
        {
            Console.Write("Would you like to learn about another student? Enter yes/no: ");
            string loopchoice = Console.ReadLine().ToLower().Trim();
            if (loopchoice == "y" || loopchoice == "yes")
            {
                looping = true;
                break;
            }
            else if (loopchoice == "n" || loopchoice == "no")
            {
                looping = false;
                break;
            }
            else
            {
                Console.WriteLine("That was not an option");
            }
        }
    }
    
    //string student = FindInArray(names, indexSearch); --dont really need a method to do this
    //string hometown = FindInArray(homeTowns, indexSearch);
    //string favFood = FindInArray(favFoods, indexSearch);
    
    //while (true)
    //{
    //    Console.Write("How do you want to search? Enter: number, name, or list to see a roster ");
    //    string searchMethod = Console.ReadLine().Trim().ToLower();
    //    if (searchMethod == "number")
    //    {
    //        Console.Write("Enter a number 1-7: ");
    //        int indexSearch = int.Parse(Console.ReadLine()) - 1;
    //        string student = names[indexSearch];
    //        string hometown = homeTowns[indexSearch];
    //        string favFood = favFoods[indexSearch];

    //        Console.WriteLine($"Student {indexSearch} is {student}");

    //        //method for home/food
    //        break;
    //    }
    //    else if (searchMethod == "name")
    //    {
    //        string nameSearch = Console.ReadLine();
    //        InfoSearch 

    //        //method for home/food
    //        break;
    //    }
    //    else if (searchMethod == "list")
    //    {
    //        DisplayAll(names);
    //        //method for home/food

    //    }
    //}



//---------------------METHODS----------------------

//this method is not really necessary
static string FindInArray (string[] array, int index)
{
    return array[index - 1];
}

//displayall
static void DisplayAll (string[] values)
{
    foreach (string value in values)
    {
        Console.WriteLine(value);
    }
}

//search choice
//static string[] InfoSearch (string choice)
//{
//    while (true)
//    {
//        Console.Write("Which category would you like to know? Enter 'Hometown' or 'Favorite Food' ");
//        choice = Console.ReadLine().Trim().ToLower();
//        if (choice == "hometown" || choice.Contains("home") || choice.Contains("town"))
//        {
//            Console.WriteLine($"'s hometown is ");
//            break;
//        }
//        else if (choice == "favorite food" || choice.Contains("favorite") || choice.Contains("food"))
//        {
//            Console.WriteLine($"'s favorite food is ");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Did you spell that right?");
//        }
//    }
//    return string[];
//}



