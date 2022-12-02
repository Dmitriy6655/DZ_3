// #19 Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.Задание должно быть выполнено в методе. 
//В методе не должно быть вывода в консоль.
// Не использовать String!
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Write("Введите число...");
bool numeral = int.TryParse(Console.ReadLine(), out int N);

if (!numeral || N <= 0 )
{
  Console.WriteLine("Значение не корректно!"); 
}

// //считаем количестов цифр в числе:
int digitCount = (int)Math.Log10(N) + 1;

// заполняем массив из метода
int[] numerals = Calculate(N, digitCount);

//Вызываем метод печати
PrintArray(numerals, digitCount);


//Создаем МЕТОД Calculate (заполняет массив цифрами числа)
int [] Calculate(int N, int digitCount)
{

int numeral = 0;


//создаем массив с длиной digitCount
int[] numeralsLocal = new int[digitCount];

for (int i = 0; i <= digitCount-1; i++)
{
  numeral = N % 10;
  N = N-numeral;
  N = N / 10;
  //заполняем массив цифрами числа (начиная с последней цифры)
  numeralsLocal[(digitCount-1) - i] = numeral;
  
  }
return numeralsLocal;
}



// СОЗДАЕМ МЕТОД печати
void PrintArray (int[] numerals, int digitCount)
{
  
   for (int n = 0; n <= (digitCount-1)/2; n++)
{
   if(numerals[(digitCount-1)-n] == numerals[n])
  {
    Console.WriteLine("Введенное число - число палиндром.");
    break;
  }
  else
  {
    Console.WriteLine("Число НЕ палиндром.");
    break;
  }
}
}
