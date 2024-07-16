/* bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}


bool flag = true;
if (flag)
    Console.WriteLine(flag);


bool flag = true;
if (flag) Console.WriteLine(flag);


// Not recommended
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

*/

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");