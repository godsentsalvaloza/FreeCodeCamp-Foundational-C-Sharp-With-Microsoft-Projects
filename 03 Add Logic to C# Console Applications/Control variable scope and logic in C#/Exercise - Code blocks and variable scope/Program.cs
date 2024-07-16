/* bool flag = true;
if (flag) {
    int value = 10;
    Console.WriteLine ($"Inside of the code block: {value}");
}
*/

bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}


Console.WriteLine($"Outside the code block: {value}");