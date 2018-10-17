using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string[,] CreatureCarcass(int width)
        {
            //Создание каркаса двух строк

            string[,] str = new string[4, width];
            for (int i = 0; i < width; i++)
                str[0, i] = "-";
            int x = 0;
            for (int i = 1; i < width - 1; i = i + 2)
                if (str[1, i] == null)
                {
                    x++;
                    str[1, i] = x.ToString();
                }
            for (int i = 0; i < width; i++)
            {
                str[2, i] = "-";
                if (i % 2 == 0)
                    str[3, i] = "|";
                else
                {
                    x++;
                    str[3, i] = x.ToString();
                }
            }
                return str;
        }
        static void OutBottom(int width)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write("-1");
            }
            Console.WriteLine();
        }
            static string[,] ChangeHorizontally(string[,] str, int width)
        {
            //Изменение по горизонтали
            
            return str;
        }
        
        static void OutStrMaze(string[,] str, int width)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (str[i,j]=="-" || str[i,j]=="|")
                        Console.Write("-1");
                    else
                        Console.Write(" 0");
                }
                Console.WriteLine();
            }
        }
        static string[,] UpdateStr(string[,] str, int width, int x)
        {
            //Обновление строки
            for (int i = 1; i < width - 1; i = i + 2)
                if (str[3, i] == null)
                {
                    x++;
                    str[3, i] = x.ToString();
                }
            for (int i = 0; i < width; i++)
            {
                str[0, i] = str[2, i];
                str[1, i] = str[3, i];
                str[2, i] = "-";
                if (i % 2 == 0)
                    str[3, i] = "|";
                else
                {
                    x++;
                    str[3, i] = x.ToString();
                }
            }
            return str;
        }
        static string[,] BuildingBottom(string[,] str, int width)
        {
            //Построение нижней части лабиринта

            for (int i = 1; i < width - 3; i = i + 2)
                if (str[1, i] != str[1, i + 2])
                {
                    if (Convert.ToInt32(str[1, i + 2]) <= Convert.ToInt32(str[1, i]))
                        str[1, i] = str[1, i + 2];
                    else
                        str[1, i + 2] = str[1, i];
                    str[1, i + 1] = " ";
                }
            return str;
        }

        static void Main(string[] args)
        {
            int _width = Convert.ToInt32(Console.ReadLine());
            int _height = Convert.ToInt32(Console.ReadLine());
            int width = 2 * _width + 1;
            int height = _height;
            //Каркас
            string[,] str = CreatureCarcass(width);
            int x = 2*_width;

            int st = 1;
            while (st <= height)
            {

                str[1, 0] = "|";
                str[1, width - 1] = "|";
                str[2, 0] = "|";
                str[2, width - 1] = "|";
                //Горизонтальное изменение           
                Random ran = new Random();
                for (int i = 1; i < width - 3; i = i + 2)
                    if (str[1, i] != str[1, i + 2])
                    {
                        int b = ran.Next(0, 2 * st + 1);
                        if (b % 2 == 0)
                        {
                            str[1, i + 2] = str[1, i];
                            str[1, i + 1] = " ";
                        }
                        else
                            str[1, i + 1] = "|";
                    }
                for (int i = 1; i < width - 1; i++)
                    str[2, i] = "-";
                //Вертикальное изменение
              
                int l = 1;
                for (int i = 3; i < width - 1; i = i + 2)
                    if ((str[1, i] != str[1, i - 2]) || (i == width - 2))
                    {
                        int ch2 = 0;
                        for (int j = l; j <= i - 2; j = j + 2)
                        {
                            if (l == i - 2)
                            {
                                ch2++;
                                str[2, i - 2] = " ";
                                str[3, i - 2] = str[1, i - 2];
                                break;
                            }
                            int b = ran.Next(0, st + 1);
                            if (b % 2 != 0)
                            {
                                ch2++;
                                str[3, j] = str[1, j];
                                str[2, j] = " ";
                            }
                        }
                        if (ch2 == 0)
                        {
                            int b = ran.Next((l - 1) / 2, (i - 2 - 1) / 2);
                            str[3, 2 * b + 1] = str[1, 2 * b + 1];
                            str[2, 2 * b + 1] = " ";
                        }
                        l = i;
                        if ((i == width - 2) && (str[1, i] != str[1, i - 2]))
                        {
                            str[2, i] = " ";
                            str[3, i] = str[1, i];
                        }
                    }

                //Вывод

                OutStrMaze(str, width);
                //Удаление
                str = UpdateStr(str, width, x);
                x = Convert.ToInt32(str[3, width - 2]);
                st++;//Шаг
                //Нижняя шапка
                if (st == height)
                    str = BuildingBottom(str, width);
                
            }
            OutBottom(width);
        }
    }
}
