﻿//Console.WriteLine($"\n");
//int Exponentiation(int numberA, int numberB){
//  int result = 1;
//  for(int i=1; i <= numberB; i++){
//    result = result * numberA;
//  }
//    return result;
//}
//  Console.Write("Введите число A: ");
//  int numberA = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите число B: ");
//  int numberB = Convert.ToInt32(Console.ReadLine());
//  int exponentiation = Exponentiation(numberA, numberB);
//  Console.WriteLine("Ответ: " + exponentiation);


//Console.WriteLine($"\n");
//Console.Write("Введите число N: ");
//int numberN = Convert.ToInt32(Console.ReadLine());
//  int SumNumber(int numberN){
//   
//    int counter = Convert.ToString(numberN).Length;
//   int advance = 0;
//    int result = 0;
//    for (int i = 0; i < counter; i++){
//      advance = numberN - numberN % 10;
//      result = result + (numberN - advance);
//      numberN = numberN / 10;
//   }
//   return result;
//  }
//int sumNumber = SumNumber(numberN);
//Console.WriteLine("Сумма цифр в числе: " + sumNumber);

//int [] numbers = new int[8];
//Console.Write("[");
//for (int i = 0; i < numbers.Length; i++)
// {
//    numbers [i] = new Random().Next(0, 11);
//    Console.Write(" " + Method (i) + ",");
// }
//Console.Write("]");
//int Method (int a)
//{
//    return numbers[a];
//}