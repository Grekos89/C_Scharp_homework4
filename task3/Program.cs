// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] newArr = RandomArray(8);
PrintArray(newArr);

int[] RandomArray(int length)
{
     int[]arr = new int[length];
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(0,100);
     }
     return arr;
}

void PrintArray(int[] arr)
{
    
    foreach(int item in arr)
    {
        System.Console.Write($"{item}, ");
    } 
}
