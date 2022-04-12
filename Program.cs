Console.Write("введите 1 число :");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2 число :");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 3 число :");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
{
    System.Console.WriteLine($"number max {+number1}");
}
else if(number2 > number3)
{
    System.Console.WriteLine($"number max {+number2}");
}
else
{
    System.Console.WriteLine($"number max {+number3}");
}
    


        


