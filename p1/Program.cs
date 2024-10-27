
void Again(ref int r,bool ot)
{
    bool b = false;
    while (!b)
    {
        Console.WriteLine("Введите ЧИСЛО ещё раз");
        string tor = Console.ReadLine();
        b=int.TryParse(tor, out r);
        if (ot && r < 1) b = false;
    }
}
List<int> MakeOtvet(int[,] ma)
{
    List<int> li = new List<int>();
    for (int i = 0; i < ma.GetLength(0); i++)
    {
        bool ca = true;//Вводим n
        for (int j = 0; j < ma.GetLength(1); j++)
        {
            if (ma[i, j] >= 0) ca = false;//Проверка на отрицательность значения
            Console.Write(ma[i, j] + " ");//Вывод элемента массива
        }
        if (ca) li.Add(i);//Если отрицательный, добавляем номер столбца
        Console.WriteLine();
    }
    return li;
}
Console.WriteLine("Введите ширину массива");
int n;
if (!int.TryParse(Console.ReadLine(),out n)||n<1) Again(ref n,true);//Вводим n
Console.WriteLine("Введите длину массива");
int m;
if (!int.TryParse(Console.ReadLine(), out m)||m<1) Again(ref m, true);//Вводим m
int[,] mas = new int[n,m];
for (int i = 0;i<mas.GetLength(0);i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.WriteLine("Введите Элемент массива ["+(i+1)+","+(j+1)+"]");
        if (!int.TryParse(Console.ReadLine(), out mas[i,j])) Again(ref mas[i, j],false);//Вводим элементы массива
    }
}
Console.WriteLine("Ваш массив:");
List<int> otr = MakeOtvet(mas);//Вывод массива и создание списка номеров отрицательных столбцов
Console.WriteLine("Номер столбца только с отрицательными значениями:");
foreach (int i in otr) Console.Write((i+1)+" ");//Выводим номера отрицательных столбцов