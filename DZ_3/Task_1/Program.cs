Console.Write ("Дано пятизначное число: ");
// int num = 12321; // проверка!
int num = new Random().Next(10000, 100000);
Console.WriteLine (num);
int num1 = (num /10000) % 10; //1 число
int num2 = (num /1000) % 10; //2 число
int num4 = (num / 10) % 10; // 4 число
int num5 = num % 10; // 5 число

if ((num1 == num5) && (num2 == num4))
{
    Console.WriteLine ("Число является палиндромом!");
}
else
{
    Console.WriteLine ("Число не является палиндромом!");
}

