using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //bool A=true,B=false,C=false;

            //Console.WriteLine($"a) = {(A ||(!A && B))|| C}");
            //Console.WriteLine($"б)= {(!A && A &&(B ||C))}");
            //Console.WriteLine($"в)= {((A||(B && !C))&& A)}");

            //2
            //bool X=false,Y=true,Z=false;

            //Console.WriteLine($"a)= {(X&&!(Z||Y)) ||Z }");
            //Console.WriteLine($"б) = {(!X||(X &&(Y||Z )))} ");
            //Console.WriteLine($"в)= {(X||(Y&& !Z))}");

            ////3   а
            //int x=2,y=1;
            //Console.WriteLine($"а)= {!(x>y && y>0)&& (y>x)}");

            ////3  б
            //int x=2,y=-2;
            //Console.WriteLine($"б)= {(x>=2)|| (Math.Pow(y,2)!=5)}");

            ////4
            //int A=6;
            //Console.WriteLine($"4)= {(A%2==0) ||(A%3==0)}");

            //5
            //int A=1,B=3;
            //Console.WriteLine($"5)= {(A%2!=0)&&(B%2!=0)}");

            //6
            //bool X=false,Y=false,Z=true;

            //Console.WriteLine($"а)= {X|| (Y&& !Z)}");
            //Console.WriteLine($"б)= {!X&&Y}");
            //Console.WriteLine($"в)= {!(X &&Z ) || Y}");

            //8
            //int x=1,y=2;
            //Console.WriteLine($"а)= {(x>=0)&&(y*y==4)}");

            //int x=2,y=1;
            //Console.WriteLine($"б)= {(x*y!=0)||(y>x)}");

            //9
            //int x=1,y=2;
            //Console.WriteLine($"а)= {!(x>y&&y>0)||(y>x)}");

            //int x=2,y=1;
            //Console.WriteLine($"б)= {(x*y!=0)&&(y<x)}");

            ////10
            //bool A=true,B=false,C=true;

            //Console.WriteLine($"а)= {A|| !(A&&B) ||C}");
            //Console.WriteLine($"б)= {!A ||C&&(B || C)}");
            //Console.WriteLine($"в)= {(A || B&&!C) || A}");

            ////11
            //int x=1;y=2;

            //Console.WriteLine($"а)= {!(x>y&&y>1)&&(y>x)}");

            //12
            //int A=123;
            //Console.WriteLine($"12)= {(A>=100)&&(A<=999)}");

            //13
            //int A=40,B=46,C=44;
            //Console.WriteLine($"13)= {((A<45)&&(B>=45)&&(C>=45))||((A>=45)&&(B<45)&&(C>=45))||((A>=45)&& (B>=45)&& (C<45))}");

            //14
            //int A=30;
            //Console.WriteLine($"14)= {(A%3==0)&& (A%10==0)}");

            //15
            //int A=100;
            //Console.WriteLine($"15)= {((A>=-137) && (A<=-51)) || ((A>=55)&&(A<=123))}");

            //16
            //int X=5,Y=10,Z=15;
            //Console.WriteLine($"16)= {((X%5==0) && (Y%5!=0) &&(Z%5!= 0))||(( X%5!=0) &&(Y%5 == 0)&&(Z%5!=0))||((X%5!=0) && (Y%5!=0)&& (Z%5 ==0))}");

            //17
            //int X=81,Y=70,Z=90;
            //Console.WriteLine($"17)= {(X>80)||(Y>80)||(Z> 80)}");

            //18
            //bool A=true,B=false,C=true;
            //Console.WriteLine($"а)= {A&&!B||C}");
            //Console.WriteLine($"б)= {!(A||B)||C}");
            //Console.WriteLine($"в)= {A||!(B&&C)}");

            //20
            //double X=2;
            //Console.WriteLine($"20)= {(Math.Pow(X,2)-Math.Pow(X-3, 2))!=0}");

            //21
            //bool X=false,Y=false,Z=true;
            //Console.WriteLine($"а)= {X && !Y|| Z}");
            //Console.WriteLine($"б)= {X && !(Y||Z)}");
            //Console.WriteLine($"в)= {X|| !(Y||Z )}");

            //22
            //double x=3,y=4;
            //Console.WriteLine($"а)= {!(x<=-5&& x>= 5)}");
            //Console.WriteLine($"б)= {(y>=-3.5 && y<=8.1)&&(x!=0)}");

            //23
            //int A=1;
            //Console.WriteLine($"23)= {!((A>=-10 && A<=-1)||(A>=2&& A<=15))}");

            //24
            //int A=1234;
            //Console.WriteLine($"24)= {(A>=1000)&& (A<=9999) &&(A!=4999)} ");

            //25
            //double A=10,B=5,C=20;
            //Console.WriteLine($"25)= {(A>B) ||(A>C/5)}");

            //26
            //double x=8,y=5;
            //Console.WriteLine($"а)= {!(x<=0&&x<=5)}");
            //Console.WriteLine($"б)= {(y>0&&y<=6)&&(x>7)}");

            //27
            //double x=4;
            //Console.WriteLine($"а)= {(x>3)||(x<-1)}");








            //1
            //int A = 2, B = 3, C = 6;

            //Console.WriteLine($"а)={(A %2 == 0 && B % 2 !=0) || (A % 2 != 0 && B% 2 ==0)}");
            //Console.WriteLine($"б)={(A%3== 0) && (B % 3==0) && (C % 3 == 0)}");

            //2
            //int N = 20;
            //Console.WriteLine($"а) = {(N % 4 == 0) || (N %7==0)}");
            //Console.WriteLine($"б) = {(N % 5==0)&& (N % 10!=0)}");

            //3
            //int n = 3, m = 4, k = 5, l = 2;
            //Console.WriteLine($"3) = {(n + m > k)|| (n >k && m>l)}");

            //4
            //int N = 24;
            //Console.WriteLine($"4) = {((N %3!= 0)||(N% 9!=0)) &&((N%4 != 0) || (N % 5 == 0)|| (N%24 ==0))}");

            //5
            //int k = 1, l = 2, n = 3, m = 4;
            //Console.WriteLine($"5) = {((n <= 2) || (m*m == Math.Pow(l, 4))) && ((n > 1) || (k + l ==0))}");

            //6
            //double D = 75000;
            //Console.WriteLine($"6)Процентная ставка={((D <= 50000)?0.16 :0.18)}");

            //7
            //int N = 14;
            //Console.WriteLine($"7) = {(N %2 ==0) && (N % 7 ==0) && (N%11 != 0)&&(N % 13!= 0)} ");

            //8
            //int N = 70;
            //Console.WriteLine($"8) = {(N % 3!= 0) && (N%7 == 0) &&(N % 10 == 0)}");

            //9
            //int k = 0, l = 5, n = 2, m = 3;
            //Console.WriteLine($"9) ={((k!= 0) ||(l> m))&& ((k >=0)|| (2* l-3 * n < k * m))}");

            //10
            //int N = 56;
            //Console.WriteLine($"10) ={(N % 3!=0) &&(N % 7 == 0) &&((N % 5 !=0) ||(N% 4!=0))&& ((N %8 !=0)||(N%11 == 0))}");
        }
    }
}