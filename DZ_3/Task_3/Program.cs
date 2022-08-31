Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = new int [N];

int i = 0;
int num = 1;
Console.Write ("Получен массив кубов чисел от 1 до " + N*N + " : ");
while (i < N)
{
    array [i] = num * num * num;
    Console.Write (array [i] + " ");
    num ++;
    i ++;
}
