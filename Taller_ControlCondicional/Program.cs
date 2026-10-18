
string CheckNumber(int number)
{
    if (number > 0)
    {
        return "El número es positivo";
    }
    else if (number < 0)
    {
        return "El número es negativo";
    }
    else
    {
        return "El número es cero";
    }
}

Console.WriteLine(CheckNumber(5));
Console.WriteLine(CheckNumber(-3));
Console.WriteLine(CheckNumber(0));