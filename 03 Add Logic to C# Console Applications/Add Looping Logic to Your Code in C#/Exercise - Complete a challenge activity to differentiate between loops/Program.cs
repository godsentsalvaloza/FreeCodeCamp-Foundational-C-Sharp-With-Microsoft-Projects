// CODE PROJECT 1

/*
int readResult;
Boolean validEntry = false;

Console.WriteLine("Enter an integer between 5 and 10:");
do
{
    readResult = Convert.ToInt32(Console.ReadLine());
    if (readResult >= 5 && readResult <= 10)
    {
        Console.WriteLine($"Your input value ({readResult}) has been accepted.");
        validEntry = true;
        continue;
    }
    else
    {
        Console.WriteLine($"You entered {readResult}. Please enter a number between 5 and 10");
    }

} while (validEntry == false);
*/

// CODE PROJECT 2

/* 
Console.Clear();
string? readResult = "";
Boolean validEntry = false;

Console.WriteLine("Enter your role (Administrator, Manager, or User)");
do 
{
    readResult = Convert.ToString(Console.ReadLine().Trim().ToLower()); 
    if(readResult == "administrator") {
        validEntry = true;
        Console.WriteLine($"Your input value (Administrator) has been accepted");
    } else if (readResult == "manager") {
        validEntry = true;
        Console.WriteLine($"Your input value (Manager) has been accepted");
    } else if (readResult == "user") {
        validEntry = true;
        Console.WriteLine($"Your input value (User) has been accepted");
    } else {
        Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
} while (validEntry == false);
*/

// CODE PROJECT 3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {


        mySentence = myString.Remove(periodLocation);


        myString = myString.Substring(periodLocation + 1);


        myString = myString.TrimStart();


        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}