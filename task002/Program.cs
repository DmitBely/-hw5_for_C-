// Написать программу масштабирования фигуры Тут для тех кто далеко улетел, 
// чтобы задавались вершины фигуры списком (одной строкой) 
// например: "(0,0) (2,0) (2,2) (0,2)" коэффициент масштабирования k задавался 
// отдельно - 2 или 4 или 0.5 В результате показать координаты, которые получатся. 
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"


int[] zeros = new int[8];

void ZeroFill(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите следующее значение координат");
        arr[i] = int.Parse(Console.ReadLine());
        PrintArray(zeros);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
    Console.WriteLine(" ");
}

void PrintArrayWritten(int[] arr)
{
    Console.WriteLine($"Введена фигура - ({arr[0]}, {arr[1]}) ({arr[2]}, {arr[3]}) ({arr[4]}, {arr[5]}) ({arr[6]}, {arr[7]})");
}



PrintArray(zeros);
ZeroFill(zeros);
PrintArrayWritten(zeros);