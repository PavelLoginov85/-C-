//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Введите первое число:  ");
// int first = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число:  ");
// int second = int.Parse(Console.ReadLine()!);
// if(first > second){
//     Console.Write($"Максимальное число {first}");
// }

// else {
//     Console.Write($"Максимальное число {second}");
// }



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите первое чило: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе чило: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье чило: ");
// int num3 = int.Parse(Console.ReadLine()!);
// if(num2 < num1 && num1 > num3){
//     Console.Write($"Максимальное число {num1}");
// }
// else if(num2 > num3 && num2 > num1){
//     Console.Write($"Максимальное число {num2}");
// }
// else if(num3 > num2 && num3 > num1){
//     Console.Write($"Максимальное число {num3}");
// }


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка(number%2==0)).

Console.Write("Введите чило: ");
int cell = int.Parse(Console.ReadLine()!);
if (cell%2 == 0){
    Console.Write($"{cell} Чётное число");
}
else{
Console.Write($"{cell} Нечётное число");
}
