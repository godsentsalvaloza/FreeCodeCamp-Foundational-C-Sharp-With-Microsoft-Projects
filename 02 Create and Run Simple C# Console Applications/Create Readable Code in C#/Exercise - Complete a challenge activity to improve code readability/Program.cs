/* This code checks how many times a character appeard in a string and reverses the sequence of the text. */
string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);

int x = 0;

foreach (char character in charMessage)
{ 
    if (character == 'o') 
    { 
        x++; 
    } 
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");