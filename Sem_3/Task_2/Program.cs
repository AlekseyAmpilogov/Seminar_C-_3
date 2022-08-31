Console.Write("Введите количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

int index = 0;
while (index < N)
{
    array [index] = new Random().Next(1, 11); // заполнение элементов массива от 1 до 10
    Console.Write (array [index] + " "); // выводит элементы массива на экран
    index++;
}
int sum = 0; // создаем переменную и присваиваем ей значение 0
for (int i=0; i < N; i++)
{
    sum += array [i]; // суммирование с накоплением
}
double mean = (double)sum / N;
Console.WriteLine();
Console.WriteLine("Среднеарифметическое значение данного массива: " + mean);