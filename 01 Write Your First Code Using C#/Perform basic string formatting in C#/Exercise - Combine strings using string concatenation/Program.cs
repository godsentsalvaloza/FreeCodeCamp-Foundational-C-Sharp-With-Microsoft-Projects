// String concatenation

/*
string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

// Avoidig intermediate variables
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");
*/


// String interpolation
/*
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);
*/

// using multiple variables 
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

// avoid intermediate variables
Console.WriteLine($"{updateText} {version}");

// combining verbatim literals and string interoplaton
string projectName = "First-Project";
Console.WriteLine($@"C:\Output{projectName}\Data");

