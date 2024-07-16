Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;
int damage = 0;
string winner = "";

Console.Clear();
 while (heroHealth > 0 && monsterHealth > 0)
{
    
    if (heroHealth > 0 && monsterHealth > 0)
    {
        damage = random.Next(0, 11);
        monsterHealth -= damage;
        Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health");
        winner = "Hero";
    }
    
    if (heroHealth > 0 && monsterHealth > 0)
    {
        damage = random.Next(0, 11);
        heroHealth -= damage;
        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health");
        winner = "Monster";
    }
}
Console.WriteLine($"{winner} wins!");