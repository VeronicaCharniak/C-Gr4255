const int X1 = 0;
const int Y1 = 1;
const int X2 = 0;
const int Y2 = 1;
const int X3 = 0;
const int Y3 = 1;
const int coef = 0;
const int con = 1;
const int Line1 = 1;
const int Line2 = 2;
const int Line3 = 3;

//Вызов метода для записи чисел
double[] LineData1 = LineData(Line1);
double[] LineData2 = LineData(Line2);
double[] LineData3 = LineData(Line3);

if (IntersectLines(LineData1, LineData2,LineData3))
{
    double[] coord1 = FindCoord(LineData1, LineData2);
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData1[coef]}*X+{LineData1[con]} /n Y= {LineData2[coef]}*X+{LineData2[con]}");
    Console.WriteLine($"Имеет координаты ({coord1[X1]}, {coord1[Y1]})");
    double[] coord2 = FindCoord(LineData2, LineData3);
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData2[coef]}*X+{LineData2[con]} /n Y= {LineData3[coef]}*X+{LineData3[con]}");
    Console.WriteLine($"Имеет координаты ({coord2[X2]}, {coord2[Y2]})");
    double[] coord3 = FindCoord(LineData3, LineData1);
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData1[coef]}*X+{LineData1[con]} /n Y= {LineData3[coef]}*X+{LineData3[con]}");
    Console.WriteLine($"Имеет координаты ({coord3[X3]}, {coord3[Y3]})");
    Console.WriteLine($"Площадь треугольника = {SqeaTriangle(coord1,coord2,coord3)}");
}

double SqeaTriangle(double[] co1, double[] co2, double[] co3)
{
    double d1 = (co2[X2] - co1[X1])*(co3[Y3]-co1[Y1]) ;
    double d2 =  (co3[X3] - co1[X1])*(co2[Y2]-co1[Y1]);
    Console.WriteLine(d1);
    Console.WriteLine(d2);
    Console.WriteLine((0.5) * (Math.Abs(d1-d2)));
    return ((0.5) * (Math.Abs(d1-d2)));
}


//Ввод числа
double ReadMSG(string msg)
{
    Console.Write(msg);
    string row = Console.ReadLine();
    double res = Convert.ToDouble(row);
    return res;
}

//Данные в пямую
double[] LineData(int NumOfLines)
{
    double[] LineData = new double[3];
    LineData[coef] = ReadMSG($"Введите k для {NumOfLines} прямой: ");
    LineData[con] = ReadMSG($"Введите b для {NumOfLines} прямой: ");
    return LineData;
}

double[] FindCoord(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[0] = (lineData1[1] - lineData2[1]) / (lineData2[0] - lineData1[0]);
    coord[1] = lineData1[0] * coord[0] + lineData1[1];
    return coord;
}

// //Поиск координат
// double[] FindCoords1(double[] LineData1, double[] LineData2)
// {
//     double[] coord1 = new double[2];
//     coord1[X1] = (LineData1[con] - LineData2[con]) / (LineData2[coef] - LineData1[coef]);
//     coord1[Y1] = LineData1[coef] * coord1[X1] + LineData1[con];
//     return coord1;
// }

// double[] FindCoords2(double[] LineData2, double[] LineData3)
// {
//     double[] coord2 = new double[2];
//     coord2[X2] = (LineData2[con] - LineData3[con]) / (LineData3[coef] - LineData2[coef]);
//     coord2[Y2] = LineData1[coef] * coord2[X2] + LineData1[con];
//     return coord2;
// }

// double[] FindCoords3(double[] LineData1, double[] LineData3)
// {
//     double[] coord3 = new double[2];
//     coord3[X3] = (LineData3[con] - LineData1[con]) / (LineData1[coef] - LineData3[coef]);
//     coord3[Y3] = LineData1[coef] * coord3[X3] + LineData1[con];
//     return coord3;
// }

bool IntersectLines(double[] LineData1, double[] LineData2, double[] LineData3)
{
    if (!(LineData1[coef] == LineData2[coef] && LineData1[coef] == LineData3[coef]))
    {
        if (!(LineData1[con] == LineData2[con] && LineData1[con] == LineData3[con]))
        {
            Console.WriteLine("Прямые пересекаются");
            return true;
        }
        else
        {
            Console.WriteLine("Прямые не пересекаются");
            return false;
        }
    }
    return true;
}