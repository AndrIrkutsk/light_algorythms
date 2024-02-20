// Задача 3: 
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

using System;

class Program {
  static void Main()
  {

    Console.Write("Введите число от 10 до 99 включительно: ");
    int a = Convert.ToInt32(Console.ReadLine());


    if (a >= 10 && a <= 99) {
      int secondNum = a % 10;
      int firstNum = (a - secondNum) / 10;

      if(secondNum > firstNum) {
        Console.WriteLine(secondNum);
      } else {
        Console.WriteLine(firstNum);
      }
    } else {
      Console.WriteLine("Число должно быть больше или равно 10 и меньше или равно 99");
    }
  }
}