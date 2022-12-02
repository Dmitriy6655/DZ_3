// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе 
//и метод должен вернуть массив чисел.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number_IN = int.Parse(Console.ReadLine());

//создаем МАССИВ:
int[] Array =  CubeTable(number_IN);

//вызываем МЕТОД печати массива:
//Console.WriteLine("Array равно:");
PrintArray(Array);

//Создаем МЕТОД для возведения в 3 степень.

int [] CubeTable (int number_IN )
{
    int count = 0;
    //int num = number_IN;
    int number_cube = 1; 
    

//определяем количество чисел возведенных в 3 степень от 1 до  number_IN:
     for(int r = 1; r <= number_IN; r++)
    {
        number_cube = r * r * r;
        count++;
                     
    }
     
     //создаем локальный массив для заполения числами
     int [] local_array = new int[count];
     
     //заполняем массив числами
        
        for(int q = 1; q <= count; q++)
        {           
            
            local_array[q-1] = q *q *q; 
                     
        }
    
return local_array;
}

void PrintArray (int[] Array)
{
   
    for (int s = 0; s <= Array.Length; s++)
    {
        Console.WriteLine($"{Array[s]} ");
            
    }
    
Console.WriteLine();

}