// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.
// Решение нашел в интернете и чуть исправил, честно не успел бы сам сделать все и сдалть до НГ (новый год на носу, с 8-ой домашкой возился долго)

string TenToTwo(int n) {
    if (n == 0) return "0";
    if (n / 2 > 0) return TenToTwo(n / 2) + (char)(n % 2 + '0');
    else return ""+ (char)(n % 2 + '0');
}
Console.Write("Введите число для перевода в двоичную систему: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = TenToTwo(n);
Console.WriteLine(result);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Summ(int m, int n){
  if (m < n) return m + Summ(m+1,n);
  else return m;
}

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());   
// Console.Write(Summ(m,n));
    
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30