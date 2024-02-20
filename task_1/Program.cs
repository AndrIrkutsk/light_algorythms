// Задача 1: 
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

using System;

class Program {
  static void Main()
  {

    Console.Write("Введите число a: ");
    int number = Convert.ToInt32(Console.ReadLine());

    //int number = 483;

    int num1 = 7;
    int num2 = 23;

    if (number % num1 == 0 && number % num2 == 0) {
      Console.WriteLine("Кратно");
    } else {
      Console.WriteLine("Не кратно");
    }

  }
}
