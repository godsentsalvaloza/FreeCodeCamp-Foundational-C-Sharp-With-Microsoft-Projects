string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal decimalValue = 0m;
decimal finalDecimal = 0m;
string stringValue = "";
foreach (string value in values)
{
    if (decimal.TryParse(value, out decimalValue))
    {
        finalDecimal += decimalValue;
    }
    else
    {
        stringValue += value;
    }

}

Console.WriteLine($"Message: {stringValue}");
Console.WriteLine($"Total: {finalDecimal}");