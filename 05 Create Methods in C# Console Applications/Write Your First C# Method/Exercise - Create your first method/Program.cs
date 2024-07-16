Console.WriteLine("Generating random numbers:");
displayRandomNumbers();

void displayRandomNumbers() {
    Random random = new Random();
    
    for(int i = 0; i < 5; i++) {
        Console.Write($"{random.Next(0,100)} ");
    }
    Console.WriteLine();
}