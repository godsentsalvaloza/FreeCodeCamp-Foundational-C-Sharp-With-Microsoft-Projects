/*
double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;
try
{
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
catch {
    Console.WriteLine("An exception has been catched");
}
Console.WriteLine("Exit program");
*/

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    WriteMessage();
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}