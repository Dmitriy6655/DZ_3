// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве. 
// Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль.
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату Х точки А");
double Ax = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А");
double Ay = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А");
double Az = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B");
double Bx = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
double By = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B");
double Bz = double.Parse(Console.ReadLine());



//Обращаемся к методу для получения результата его(метода) обработки.
double Distance =  DistanceBetweenPoints(Ax, Ay, Az, Bx, By, Bz);

Console.WriteLine("Расстояние между точками А и В в 3х мерном пространстве равно:");
Console.WriteLine(Distance);


//Создаем метод который принимает введенные значения, обрабатывает их и возвращает рез-т.
double DistanceBetweenPoints(double Ax, double Ay, 
                            double Az, double Bx, 
                            double By, double Bz )
    {
   
    double sum = Math.Pow((Bx-Ax),2) + Math.Pow((By-Ay),2) + Math.Pow((Bz-Az),2);
    
    double distance = Math.Pow(sum, 0.5);
   
    return distance;

   }