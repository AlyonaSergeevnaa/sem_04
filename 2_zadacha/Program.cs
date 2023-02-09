// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

System.Console.WriteLine("vvedite chislo: ");
int i = Convert.ToInt32(Console.ReadLine());
int result = 0;     

while (i>0)
{
    int B=i%10;
    i=i/10;
    result +=B;

}
System.Console.WriteLine("summa = " + result);



 
 