using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4
            //double[][]triangles={
            //new double[]{3,3.5,2.1},
            //new double[]{21,6.55,-0.1},
            //new double[]{9,3.7,-0.1}
            //};

            //foreach(var triangle in triangles)
            //{
            //double a=triangle[0],b=triangle[1],c=triangle[2];
            //bool isRightTriangle=IsRightTriangle(a,b,c);
            //Console.WriteLine($"Стороны: {a},{b},{c} - {(isRightTriangle?"Прямоугольный":"Не прямоугольный")}");
            //}
            //}

            //static bool IsRightTriangle(double a,double b,double c)
            //{
            //double[]sides={a,b,c};
            //Array.Sort(sides);
            //return Math.Abs(Math.Pow(sides[2],2)-(Math.Pow(sides[0],2)+Math.Pow(sides[1],2)))<0.0001;

            //5
            //double[][] triangles= {
            //new double[] {3,3.5,2.1},
            //new double[] {21,6.55,-0.1},
            //new double[] {9,3.7,-0.1}
            //};

            //foreach(var triangle in triangles){
            //double a=triangle[0],b=triangle[1],c=triangle[2];
            //bool isRightTriangle=IsRightTriangle(a,b,c);
            //Console.WriteLine($"Стороны: {a}, {b}, {c} - {(isRightTriangle?"Прямоугольный":"Не прямоугольный")}");
            //}
            //}

            //static bool IsRightTriangle(double a, double b, double c){
            //double[] sides={a,b,c};
            //Array.Sort(sides);
            //return Math.Abs(Math.Pow(sides[2],2)-(Math.Pow(sides[0],2)+Math.Pow(sides[1],2)))<0.0001;

            //6
            //double[][]values={
            //new double[]{3,3.5,0.1},
            //new double[]{58,-27,-87},
            //new double[]{-8,-35,42}
            //};

            //foreach(var set in values)
            //{
            //double A=set[0],B=set[1],C=set[2];
            //ProcessNumbers(ref A,ref B,ref C);
            //Console.WriteLine($"Результат: A={A},B={B},C={C}");
            //}
            //}

            //static void ProcessNumbers(ref double A,ref double B,ref double C){
            //if(A+B+C>0){
            //A*=2;
            //B*=2;
            //C*=2;
            //}else{
            //A=0;
            //B=0;
            //C=0;
            //}

            //7
            //double[][] points={
            //new double[]{4,0,4,0},
            //new double[]{8,12,1,1},
            //new double[]{0.9,2,2,3}
            //};

            //foreach(var point in points){
            //double x0=point[0],y0=point[1],x1=point[2],y1=point[3];
            //string result=FindFarthestPoint(x0,y0,x1,y1);
            //Console.WriteLine(result);
            //}
            //}

            //static string FindFarthestPoint(double x0,double y0,double x1,double y1){
            //double distanceA=Math.Sqrt(x0*x0+y0*y0);
            //double distanceB=Math.Sqrt(x1*x1+y1*y1);

            //if(Math.Abs(distanceA-distanceB)<0.0001)
            //return "Точки A и B равноудалены от начала координат.";
            //else if(distanceA>distanceB)
            //return "Точка A наиболее удалена от начала координат.";
            //else
            //return "Точка B наиболее удалена от начала координат.";

            //8
            //double[][]triangles={
            //new double[]{3,3.5,1.1},
            //new double[]{3,6.55,6.55},
            //new double[]{0.9,0.9,0.9}
            //};

            //foreach(var triangle in triangles){
            //double a=triangle[0],b=triangle[1],c=triangle[2];
            //bool isIsosceles=IsIsosceles(a,b,c);
            //Console.WriteLine($"Стороны: {a},{b},{c} - {(isIsosceles?"Равнобедренный":"Не равнобедренный")}");
            //}
            //}

            //static bool IsIsosceles(double a,double b,double c){
            //return Math.Abs(a-b)<0.0001||Math.Abs(a-c)<0.0001||Math.Abs(b-c)<0.0001;

            //9
            //double[]prices={0.50,0.45,0.35};
            //double[]discounts={0.10,0.08,0.12};

            //Console.Write("Введите количество минут в будние дни: ");
            //int weekdays=int.Parse(Console.ReadLine());

            //Console.Write("Введите количество минут в выходные дни: ");
            //int weekends=int.Parse(Console.ReadLine());

            //for(int i=0;i<prices.Length;i++){
            //double totalCost=weekdays*prices[i]+weekends*prices[i]*(1-discounts[i]);
            //Console.WriteLine($"Стоимость у оператора {i+1}: {totalCost:F2} руб.");
            //}

            //10
            //Console.Write("Введите номер темы (1-3): ");
            //int theme=int.Parse(Console.ReadLine());

            //Console.Write("Введите номер варианта (1-3): ");
            //int variant=int.Parse(Console.ReadLine());

            //string[]themes={"Новогодние","День Рождения","День Защитника Отечества"};
            //string[]messages={"С Новым Годом!","С Днём Рождения!","С Днём Защитника Отечества!"};

            //if(theme>=1&&theme<=3&&variant>=1&&variant<=3){
            //Console.WriteLine($"Вы выбрали {themes[theme-1]} открытку, вариант {variant}: {messages[theme-1]}");
            //}else{
            //Console.WriteLine("Некорректный номер темы или варианта.");
            //}

            //11
            //double[][]values={
            //new double[]{3,3.5},
            //new double[]{5.8,2.7},
            //new double[]{-8,-3.5}
            //};

            //foreach(var set in values){
            //double a=set[0],b=set[1];
            //if((a<0&&b>0)||(a>0&&b<0)){
            //a=-a;
            //b=-b;
            //}else{
            //a=0;
            //b=0;
            //}
            //Console.WriteLine($"Результат: a={a},b={b}");
            //}

            //12
            //double[][]values={
            //new double[]{45,13,-23},
            //new double[]{-31,65,12},
            //new double[]{52,-1,-33}
            //};

            //foreach(var set in values){
            //double a=set[0],b=set[1],c=set[2];
            //double min=Math.Min(a,Math.Min(b,c));
            //Console.WriteLine($"Наименьшее число: {min}");
            //}

            //13
            //double[][]values={
            //new double[]{3.2,-7.2,-0.5},
            //new double[]{2.3,3.7,2.5},
            //new double[]{-34,23,89.5}
            //};

            //foreach(var set in values){
            //double x=set[0],y=set[1],z=set[2];
            //double average=(Math.Abs(x)+Math.Abs(y)+Math.Abs(z))/3;
            //Console.WriteLine($"Среднее арифметическое по модулю: {average:F2}");

            //if(Math.Abs(x)>average)
            //Console.WriteLine($"{x} больше среднего арифметического по модулю");

            //if(Math.Abs(y)>average)
            //Console.WriteLine($"{y} больше среднего арифметического по модулю");

            //if(Math.Abs(z)>average)
            //Console.WriteLine($"{z} больше среднего арифметического по модулю");
            //}

            //15
            //double[][]points={
            //new double[]{2.2,-6},
            //new double[]{5.3,3},
            //new double[]{-0.8,4}
            //};

            //foreach(var point in points){
            //double x=point[0],y=point[1];
            //bool isInFourthQuarter=IsInFourthQuarter(x,y);
            //Console.WriteLine($"Точка ({x},{y}) {(isInFourthQuarter?"лежит":"не лежит")} в четвёртой четверти.");
            //}
            //}

            //static bool IsInFourthQuarter(double x,double y){
            //return x>0&&y<0;

            //16
            //double[][]triangles={
            //new double[]{3,5,4},
            //new double[]{3,8,11},
            //new double[]{9,9,9}
            //};

            //foreach(var triangle in triangles){
            //double a=triangle[0],b=triangle[1],c=triangle[2];
            //double minSide=Math.Min(a,Math.Min(b,c));
            //double triangleArea=CalculateTriangleArea(a,b,c);
            //double squareArea=minSide*minSide;

            //Console.WriteLine($"Площадь треугольника: {triangleArea:F2},площадь квадрата: {squareArea:F2}");
            //Console.WriteLine($"{(triangleArea>squareArea?"Треугольник":"Квадрат")} имеет большую площадь.");
            //}
            //}

            //static double CalculateTriangleArea(double a,double b,double c){
            //double p=(a+b+c)/2;
            //return Math.Sqrt(p*(p-a)*(p-b)*(p-c));

            //17
            //double[][]points={
            //new double[]{9,2},
            //new double[]{7,-3},
            //new double[]{-0.1,4}
            //};

            //foreach(var point in points){
            //double x=point[0],y=point[1];
            //bool isInFirstQuarter=IsInFirstQuarter(x,y);
            //Console.WriteLine($"Точка ({x},{y}) {(isInFirstQuarter?"лежит":"не лежит")} в первой четверти.");
            //}
            //}

            //static bool IsInFirstQuarter(double x,double y){
            //return x>0&&y>0;

            //18
            //double[][]points={
            //new double[]{5,-4},
            //new double[]{1,-6},
            //new double[]{1,1}
            //};

            //foreach(var point in points){
            //double x=point[0],y=point[1];
            //bool isOnCurve=IsOnCurve(x,y);
            //Console.WriteLine($"Точка ({x},{y}) {(isOnCurve?"лежит":"не лежит")} на кривой.");
            //}
            //}

            //static bool IsOnCurve(double x,double y){
            //if(x<=-2)
            //return Math.Abs(y-x*x)<0.0001;
            //else
            //return Math.Abs(y-4)<0.0001;

            //19
            //double[][]coordinates={
            //new double[]{30,121},
            //new double[]{-15,50},
            //new double[]{87,223}
            //};

            //foreach(var coord in coordinates){
            //double phi=coord[0],lambda=coord[1];
            //string hemisphere=DetermineHemisphere(phi,lambda);
            //Console.WriteLine($"Точка ({phi},{lambda}) находится в {hemisphere}.");
            //}
            //}

            //static string DetermineHemisphere(double phi,double lambda){
            //string nsHemisphere=phi>=0?"северном":"южном";
            //string ewHemisphere=lambda>=0?"восточном":"западном";
            //return $"{nsHemisphere} и {ewHemisphere} полушарии";

            //20
            //double[][]triangles={
            //new double[]{3,3.5,1.5},
            //new double[]{3,6.55,6.55},
            //new double[]{0.9,0.9,0.9}
            //};

            //foreach(var triangle in triangles){
            //double a=triangle[0],b=triangle[1],c=triangle[2];
            //string triangleType=DetermineTriangleType(a,b,c);
            //Console.WriteLine($"Треугольник со сторонами {a},{b},{c} является {triangleType}.");
            //}
            //}

            //static string DetermineTriangleType(double a,double b,double c){
            //if(a==b&&b==c)
            //return "равносторонним";
            //else if(IsRightTriangle(a,b,c))
            //return "прямоугольным";
            //else
            //return "простым";
            //}

            //static bool IsRightTriangle(double a,double b,double c){
            //double[]sides={a,b,c};
            //Array.Sort(sides);
            //return Math.Abs(Math.Pow(sides[2],2)-(Math.Pow(sides[0],2)+Math.Pow(sides[1],2)))<0.0001;

            //21
            //double[][]pairs={
            //new double[]{13,3.5},
            //new double[]{5.8,-37},
            //new double[]{-8,-15}
            //};

            //foreach(var pair in pairs){
            //double a=pair[0],b=pair[1];
            //ProcessNumbers(ref a,ref b);
            //Console.WriteLine($"Результат: a={a},b={b}");
            //}
            //}

            //static void ProcessNumbers(ref double a,ref double b){
            //if((a<0&&b>0)||(a>0&&b<0)){
            //a=-a;
            //b=-b;
            //}else{
            //a=0;
            //b=0;
            //}

            //22
            //double[][]triplets={
            //new double[]{15,13,33},
            //new double[]{-38,25,12},
            //new double[]{-22,-1,33}
            //};

            //foreach(var triplet in triplets){
            //double a=triplet[0],b=triplet[1],c=triplet[2];
            //double min=Math.Min(a,Math.Min(b,c));
            //Console.WriteLine($"Наименьшее число: {min}");
            //}

            //23
            //double[][]triplets={
            //new double[]{10,34,65},
            //new double[]{76,18,55},
            //new double[]{81,75,20}
            //};

            //double target=Convert.ToInt32("1101011",2); // 107 в десятичной системе

            //foreach(var triplet in triplets){
            //double a=triplet[0],b=triplet[1],c=triplet[2];
            //Console.WriteLine($"Числа больше {target}:");
            //if(a>target)Console.WriteLine(a);
            //if(b>target)Console.WriteLine(b);
            //if(c>target)Console.WriteLine(c);
            //}

            //24
            //string[][]octalNumbers={
            //new string[]{"34","65","55"},
            //new string[]{"76","18","75"},
            //new string[]{"11","75","20"}
            //};

            //foreach(var triplet in octalNumbers){
            //int a=Convert.ToInt32(triplet[0],8);
            //int b=Convert.ToInt32(triplet[1],8);
            //int c=Convert.ToInt32(triplet[2],8);
            //int max=Math.Max(a,Math.Max(b,c));
            //Console.WriteLine($"Наибольшее число: {Convert.ToString(max,8)} в восьмеричной системе");
            //}

            //25
            //string[][]hexNumbers={
            //new string[]{"A","22","41"},
            //new string[]{"4C","F","37"},
            //new string[]{"B","4B","C"}
            //};

            //foreach(var triplet in hexNumbers){
            //int a=Convert.ToInt32(triplet[0],16);
            //int b=Convert.ToInt32(triplet[1],16);
            //int c=Convert.ToInt32(triplet[2],16);
            //int min=Math.Min(a,Math.Min(b,c));
            //Console.WriteLine($"Наименьшее число: {Convert.ToString(min,16)} в шестнадцатеричной системе");
            //}


            Console.ReadKey();
        }
    }
}