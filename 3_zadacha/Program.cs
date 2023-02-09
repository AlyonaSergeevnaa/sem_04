// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] GetArrayRand (int size, int leftrange, int rightrange)
{
    int [] arr_rand = new int [size];
    Random rand = new Random();
     
    for (int i =0; i<size; i++)
       arr_rand[i] = rand.Next ( leftrange, rightrange+1 );
    return arr_rand;
}


void PrintTask29(int[] a)
{
   System.Console.WriteLine("["+string.Join(", ",a) +"]");
}

int[] array = GetArrayRand(12,0,100);
PrintTask29(array);