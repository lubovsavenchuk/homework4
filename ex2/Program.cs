// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа

Console.WriteLine("Input any number: ");
int x = Convert.ToInt32(Console.ReadLine());
int c;
//извлечение цифр числа
while(x!=0)
{
   c = x % 10;
   Console.WriteLine(c + " ");
   x = x / 10;
}
// проверка на делитель и нахождение их суммы

if(x % c == 0)
{
   sum = sum + c;
   Console.WriteLine(sum);
}

