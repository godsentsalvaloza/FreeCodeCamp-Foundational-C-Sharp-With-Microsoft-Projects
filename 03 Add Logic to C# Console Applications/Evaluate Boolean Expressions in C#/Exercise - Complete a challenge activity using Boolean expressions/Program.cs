string permission = "Admin|Manager";
int level = 55;


if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin User");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user");
    }
}
else if (permission.Contains("Manager"))
{
    if (level > 20)
    {
        Console.WriteLine("Contact an Admin for access");
    }
    else
    {
        Console.WriteLine("You do not have a sufficient privilages");
    }
}
else
{
    Console.WriteLine("You do not have a sufficient privilages");
}