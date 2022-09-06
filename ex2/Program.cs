// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа

Console.WriteLine("Input any number: ");
int x = Convert.ToInt32(Console.ReadLine());
int c;
int sum = 0;

while(x!=0)
{
   c = x % 10;
   Console.Write(c + " ");
   x = x / 10;

   if(x % c == 0)
   {
      sum = sum + c;
   }
   
}
Console.Write("Сумма равна: " + sum);



