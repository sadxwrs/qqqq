using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.Write("Введите a:");
            //double a=double.Parse(Console.ReadLine());
            //Console.Write("Введите b: ");
            //double b=double.Parse(Console.ReadLine());
            //Console.Write("Введите c: ");
            //double c=double.Parse(Console.ReadLine());

            //SolveQuadraticEquation(a,b,c);
            //}

            //static void SolveQuadraticEquation(double a,double b,double c)
            //{
            //double discriminant=b*b-4*a*c;

            //if(discriminant>0){
            //double x1=(-b+Math.Sqrt(discriminant))/(2*a);
            //double x2=(-b-Math.Sqrt(discriminant))/(2*a);
            //Console.WriteLine($"Корни уравнения: x1={x1:F4},x2={x2:F4}");
            //}else if(discriminant==0){
            //double x=-b/(2*a);
            //Console.WriteLine($"Уравнение имеет один корень: x={x:F4}");
            //}else{
            //Console.WriteLine("Уравнение не имеет вещественных корней.");
            //}

            //2
            //Console.Write("Введите двузначное число: ");
            //int number=int.Parse(Console.ReadLine());

            //Console.Write("Введите цифру a: ");
            //int a=int.Parse(Console.ReadLine());

            //bool containsFive=ContainsDigit(number,5);
            //bool containsA=ContainsDigit(number,a);

            //Console.WriteLine(containsFive?"Цифра 5 входит в число.":"Цифра 5 не входит в число.");
            //Console.WriteLine(containsA?$"Цифра {a} входит в число.":$"Цифра {a} не входит в число.");
            //}

            //static bool ContainsDigit(int number,int digit)
            //{
            //return number.ToString().Contains(digit.ToString());

            //3
            //Console.Write("Введите двузначное число:");
            //int number=int.Parse(Console.ReadLine());

            //bool containsThreeAndSeven=ContainsDigits(number,new int[]{3,7});
            //bool containsFourEightNine=ContainsDigits(number,new int[]{4,8,9});

            //Console.WriteLine(containsThreeAndSeven?"Цифры 3 и 7 входят в число.":"Цифры 3 и 7 не входят в число.");
            //Console.WriteLine(containsFourEightNine?"Цифра 4, 8 или 9 входит в число.":"Цифр 4, 8 или 9 нет в числе.");
            //}

            //static bool ContainsDigits(int number,int[]digits)
            //{
            //string numberStr=number.ToString();
            //foreach(int digit in digits){
            //if(!numberStr.Contains(digit.ToString()))
            //return false;
            //}
            //return true;

            //4
            //Console.Write("Введите число от 1 до 99:");
            //int number=int.Parse(Console.ReadLine());

            //string kopecksForm=GetKopecksForm(number);
            //Console.WriteLine($"{number}{kopecksForm}");
            //}

            //static string GetKopecksForm(int number)
            //{
            //int lastDigit=number%10;
            //int lastTwoDigits=number%100;

            //if(lastTwoDigits>=11&&lastTwoDigits<=19)
            //return"копеек";
            //else if(lastDigit==1)
            //return"копейка";
            //else if(lastDigit>=2&&lastDigit<=4)
            //return"копейки";
            //else
            //return"копеек";

            //5
            //Console.Write("Введите четырёхзначное число: ");
            //int number=int.Parse(Console.ReadLine());

            //bool isPalindrome=IsPalindrome(number);
            //Console.WriteLine(isPalindrome?"Число является палиндромом.":"Число не является палиндромом.");
            //}

            //static bool IsPalindrome(int number)
            //{
            //string numberStr=number.ToString();
            //return numberStr[0]==numberStr[3]&&numberStr[1]==numberStr[2];

            //6
            //Console.Write("Введите шестизначное число:");
            //int number=int.Parse(Console.ReadLine());

            //bool isLucky=IsLuckyNumber(number);
            //Console.WriteLine(isLucky?"Число является счастливым.":"Число не является счастливым.");
            //}

            //static bool IsLuckyNumber(int number)
            //{
            //string numberStr=number.ToString();
            //int firstSum=numberStr[0]+numberStr[1]+numberStr[2];
            //int secondSum=numberStr[3]+numberStr[4]+numberStr[5];

            //return firstSum==secondSum;

            //7
            //Console.Write("Введите число от 1 до 365: ");
            //int dayNumber=int.Parse(Console.ReadLine());

            //string dayOfWeek=GetDayOfWeek(dayNumber);
            //Console.WriteLine($"День недели:{dayOfWeek}");
            //}

            //static string GetDayOfWeek(int dayNumber)
            //{
            //string[]daysOfWeek={"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
            //return daysOfWeek[(dayNumber-1)%7];

            //8
            //Console.Write("Введите угол α в градусах:");
            //double alpha=double.Parse(Console.ReadLine())*Math.PI/180;
            //Console.Write("Введите начальную скорость v0: ");
            //double v0=double.Parse(Console.ReadLine());
            //Console.Write("Введите расстояние R: ");
            //double R=double.Parse(Console.ReadLine());
            //Console.Write("Введите высоту цели h:");
            //double h=double.Parse(Console.ReadLine());

            //bool isHit=IsTargetHit(alpha,v0,R,h);
            //Console.WriteLine(isHit?"Снаряд попадёт в цель.":"Снаряд не попадёт в цель.");
            //}

            //static bool IsTargetHit(double alpha,double v0,double R,double h)
            //{
            //double t=R/(v0*Math.Cos(alpha));
            //double y=v0*t*Math.Sin(alpha)-9.8*t*t/2;
            //return Math.Abs(y-h)<0.1;

            //9
            //Console.Write("Введите трёхзначное число: ");
            //int number=int.Parse(Console.ReadLine());

            //bool isSumTwoDigit=IsSumTwoDigit(number);
            //bool isProductThreeDigit=IsProductThreeDigit(number);

            //Console.WriteLine(isSumTwoDigit?"Сумма цифр является двузначным числом.":"Сумма цифр не является двузначным числом.");
            //Console.WriteLine(isProductThreeDigit?"Произведение цифр является трёхзначным числом.":"Произведение цифр не является трёхзначным числом.");
            //}

            //static bool IsSumTwoDigit(int number)
            //{
            //int sum=number/100+(number/10)%10+number%10;
            //return sum>=10&&sum<=99;

            //static bool IsProductThreeDigit(int number)
            //{
            //int product=(number/100)*((number/10)%10)*(number%10);
            //return product>=100&&product<=999;

            //10
            //Console.Write("Введите трёхзначное число:");
            //int number=int.Parse(Console.ReadLine());
            //Console.Write("Введите число b: ");
            //int b=int.Parse(Console.ReadLine());

            //bool isProductGreaterThanB=IsProductGreaterThanB(number,b);
            //bool isSumMultipleOfThree=IsSumMultipleOfThree(number);

            //Console.WriteLine(isProductGreaterThanB?"Произведение цифр больше числа b.":"Произведение цифр не больше числа b.");
            //Console.WriteLine(isSumMultipleOfThree?"Сумма цифр кратна трём.":"Сумма цифр не кратна трём.");
            //}

            //static bool IsProductGreaterThanB(int number,int b)
            //{
            //int product=(number/100)*((number/10)%10)*(number%10);
            //return product>b;

            //static bool IsSumMultipleOfThree(int number)
            //{
            //int sum=number/100+(number/10)%10+number%10;
            //return sum%3==0;

            //11
            //Console.Write("Введите трёхзначное число: ");
            //int number=int.Parse(Console.ReadLine());

            //bool allDigitsSame=AllDigitsSame(number);
            //bool hasSameDigits=HasSameDigits(number);

            //Console.WriteLine(allDigitsSame?"Все цифры одинаковые.":"Не все цифры одинаковые.");
            //Console.WriteLine(hasSameDigits?"Есть одинаковые цифры.":"Нет одинаковых цифр.");
            //}

            //static bool AllDigitsSame(int number)
            //{
            //int firstDigit=number/100;
            //int secondDigit=(number/10)%10;
            //int thirdDigit=number%10;
            //return firstDigit==secondDigit&&secondDigit==thirdDigit;

            //static bool HasSameDigits(int number)
            //{
            //int firstDigit=number/100;
            //int secondDigit=(number/10)%10;
            //int thirdDigit=number%10;
            //return firstDigit==secondDigit||firstDigit==thirdDigit||secondDigit==thirdDigit;

            //12
            //Console.Write("Введите координату x: ");
            //double x=double.Parse(Console.ReadLine());
            //Console.Write("Введите координату y:");
            //double y=double.Parse(Console.ReadLine());

            //bool isInArea=IsInArea(x,y);
            //Console.WriteLine(isInArea?"Точка лежит в области.":"Точка не лежит в области.");
            //}

            //static bool IsInArea(double x,double y)
            //{
            //return y<=2&&y>=2-Math.Pow(x,2);

            //13
            //Console.WriteLine("Введите координаты точки A1:");
            //double x1=double.Parse(Console.ReadLine());
            //double y1=double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите координаты точки A2:");
            //double x2=double.Parse(Console.ReadLine());
            //double y2=double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите координаты точки A3:");
            //double x3=double.Parse(Console.ReadLine());
            //double y3=double.Parse(Console.ReadLine());

            //bool canDrawPerpendicular=CanDrawPerpendicular(x1,y1,x2,y2,x3,y3);
            //Console.WriteLine(canDrawPerpendicular?"Можно провести перпендикулярную прямую через точку A3.":"Нельзя провести перпендикулярную прямую через точку A3.");
            //}

            //static bool CanDrawPerpendicular(double x1,double y1,double x2,double y2,double x3,double y3)
            //{
            //if((x1==x2)&&(y1==y2))
            //return false;

            //if(x1==x2)
            //return y3!=y1;

            //if(y1==y2)
            //return x3!=x1;

            //double k=(y2-y1)/(x2-x1);

            //return true;

            //14
            //Console.Write("Введите средний балл по диплому (от 3 до 5):");
            //double averageGrade=double.Parse(Console.ReadLine());

            //Console.Write("Введите стаж работы по специальности (в годах):");
            //int experience=int.Parse(Console.ReadLine());

            //double rating=CalculateRating(averageGrade,experience);
            //Console.WriteLine($"Рейтинг:{rating:F2}");

            //if(rating>=45)
            //Console.WriteLine("Вы приняты в магистратуру.");
            //else
            //Console.WriteLine("Вы не прошли по конкурсу.");
            //}

            //static double CalculateRating(double averageGrade,int experience)
            //{
            //double coefficient;
            //if(experience<2)
            //coefficient=1;
            //else if(experience<=5)
            //coefficient=1+0.1*experience;
            //else if(experience<=16)
            //coefficient=1.5;
            //else
            //coefficient=1.6;

            //return averageGrade*coefficient;

            //15
            //Console.WriteLine("Введите координаты трёх вершин прямоугольника:");
            //Console.Write("x1:");
            //int x1=int.Parse(Console.ReadLine());
            //Console.Write("y1: ");
            //int y1=int.Parse(Console.ReadLine());

            //Console.Write("x2: ");
            //int x2=int.Parse(Console.ReadLine());
            //Console.Write("y2:");
            //int y2=int.Parse(Console.ReadLine());

            //Console.Write("x3: ");
            //int x3=int.Parse(Console.ReadLine());
            //Console.Write("y3:");
            //int y3=int.Parse(Console.ReadLine());

            //FindFourthVertex(x1,y1,x2,y2,x3,y3);
            //}

            //static void FindFourthVertex(int x1,int y1,int x2,int y2,int x3,int y3)
            //{
            //int x4,y4;

            //if(x1==x2)
            //x4=x3;
            //else if(x1==x3)
            //x4=x2;
            //else
            //x4=x1;

            //if(y1==y2)
            //y4=y3;
            //else if(y1==y3)
            //y4=y2;
            //else
            //y4=y1;

            //Console.WriteLine($"Координаты четвёртой вершины:({x4},{y4})");

            //16
            //Console.Write("Введите четырёхзначное число:");
            //int number=int.Parse(Console.ReadLine());

            //bool isSumEqual=IsSumEqual(number);
            //bool isSumMultipleOfSeven=IsSumMultipleOfSeven(number);

            //Console.WriteLine(isSumEqual?"Сумма двух первых цифр равна сумме двух последних.":"Сумма двух первых цифр не равна сумме двух последних.");
            //Console.WriteLine(isSumMultipleOfSeven?"Сумма цифр кратна 7.":"Сумма цифр не кратна 7.");
            //}

            //static bool IsSumEqual(int number)
            //{
            //int firstDigit=number/1000;
            //int secondDigit=(number/100)%10;
            //int thirdDigit=(number/10)%10;
            //int fourthDigit=number%10;

            //return(firstDigit+secondDigit)==(thirdDigit+fourthDigit);

            //static bool IsSumMultipleOfSeven(int number)
            //{
            //int firstDigit=number/1000;
            //int secondDigit=(number/100)%10;
            //int thirdDigit=(number/10)%10;
            //int fourthDigit=number%10;

            //int sum=firstDigit+secondDigit+thirdDigit+fourthDigit;
            //return sum%7==0;

            //17
            //Console.Write("Введите четырёхзначное число: ");
            //int number=int.Parse(Console.ReadLine());

            //Console.Write("Введите число a:");
            //int a=int.Parse(Console.ReadLine());

            //bool isProductMultipleOfThree=IsProductMultipleOfThree(number);
            //bool isAMultipleOfProduct=IsAMultipleOfProduct(number,a);

            //Console.WriteLine(isProductMultipleOfThree?"Произведение цифр кратно трём.":"Произведение цифр не кратно трём.");
            //Console.WriteLine(isAMultipleOfProduct?$"Число {a} кратно произведению цифр.":$"Число {a} не кратно произведению цифр.");
            //}

            //static bool IsProductMultipleOfThree(int number)
            //{
            //int firstDigit=number/1000;
            //int secondDigit=(number/100)%10;
            //int thirdDigit=(number/10)%10;
            //int fourthDigit=number%10;

            //int product=firstDigit*secondDigit*thirdDigit*fourthDigit;
            //return product%3==0;

            //static bool IsAMultipleOfProduct(int number,int a)
            //{
            //int firstDigit=number/1000;
            //int secondDigit=(number/100)%10;
            //int thirdDigit=(number/10)%10;
            //int fourthDigit=number%10;

            //int product=firstDigit*secondDigit*thirdDigit*fourthDigit;
            //return product!=0&&a%product==0;

            //18
            //Console.Write("Введите сторону a первого прямоугольника:");
            //double a=double.Parse(Console.ReadLine());
            //Console.Write("Введите сторону b первого прямоугольника: ");
            //double b=double.Parse(Console.ReadLine());

            //Console.Write("Введите сторону c второго прямоугольника:");
            //double c=double.Parse(Console.ReadLine());
            //Console.Write("Введите сторону d второго прямоугольника:");
            //double d=double.Parse(Console.ReadLine());

            //bool canFit=CanFit(a,b,c,d);
            //Console.WriteLine(canFit?"Прямоугольник со сторонами a, b помещается в прямоугольник со сторонами c, d.":"Прямоугольник со сторонами a, b не помещается в прямоугольник со сторонами c, d.");
            //}

            //static bool CanFit(double a,double b,double c,double d)
            //{
            //return(a<=c&&b<=d)||(a<=d&&b<=c);

            //19
            //Console.Write("Введите размер a кирпича:");
            //double a=double.Parse(Console.ReadLine());
            //Console.Write("Введите размер b кирпича: ");
            //double b=double.Parse(Console.ReadLine());
            //Console.Write("Введите размер c кирпича: ");
            //double c=double.Parse(Console.ReadLine());

            //Console.Write("Введите размер x отверстия:");
            //double x=double.Parse(Console.ReadLine());
            //Console.Write("Введите размер y отверстия: ");
            //double y=double.Parse(Console.ReadLine());

            //bool canFit=CanFit(a,b,c,x,y);
            //Console.WriteLine(canFit?"Кирпич пройдет в отверстие.":"Кирпич не пройдет в отверстие.");
            //}

            //static bool CanFit(double a,double b,double c,double x,double y)
            //{
            //return(a<=x&&b<=y)||(a<=y&&b<=x)||(a<=x&&c<=y)||(a<=y&&c<=x)||(b<=x&&c<=y)||(b<=y&&c<=x);

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
}
    }
}