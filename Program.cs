//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число:  ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:  ");
int second = int.Parse(Console.ReadLine()!);
if(first > second){
    Console.Write($"Максимальное число {first}");
}

else {
    Console.Write($"Максимальное число {second}");
}
