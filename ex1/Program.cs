// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Input number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int B = Convert.ToInt32(Console.ReadLine());
int number = A;
if (B != 0)
{
   for(int i = 1; i < B; i++)
   {
      number *= A;
   }
   Console.WriteLine(number);
}
else
{
   number = 1;
   Console.WriteLine(number);
}
   