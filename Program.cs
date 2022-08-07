// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.WriteLine("Введите число А ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
int max = A;
if (A>B){
    Console.Write("Большее число А = ");
    Console.WriteLine(A);
    Console.Write("Меньшее число B = ");
    Console.WriteLine(B);    
}
else {
    Console.Write("Большее число B = ");
    Console.WriteLine(B);
    Console.Write("Меньшее число A = ");
    Console.WriteLine(A);
}