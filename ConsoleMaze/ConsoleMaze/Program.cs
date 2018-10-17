using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleMaze
{
    class Program
    {
        static void Out(string[,] str, int n)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 1 && j % 2 != 0)
                        Console.Write(" ");
                    else
                        Console.Write(str[i, j]);
                }            
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string text = @"D:\VS\Курсовая работа\Лабиринт\input.txt";
            StreamWriter sw = new StreamWriter(text);
            //Каркас
            int k = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            n = 2 * n + 1;
            string[,] str = new string[4, n];
            for (int i = 0; i < n ; i++)
                str[0, i] = "-";
            
            int x = 0;
            
            for (int i = 1; i < n - 1; i = i + 2)
                if (str[1, i] == null)
                {
                    x++;
                    str[1, i] = x.ToString();
                }
            for (int i = 0; i < n; i++)
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
            int st = 1;
            while (st <= k)
            {                 
                
                str[1, 0] = "|";
                str[1, n - 1] = "|";
                str[2, 0] = "|";
                str[2, n - 1] = "|";
                //Горизонтально
                Random ran = new Random();
                for (int i = 1; i < n - 3; i = i + 2)
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
                for (int i = 1; i < n - 1; i++)
                    str[2, i] = "-";                     
                //Вертикально
                int l = 1;
                for (int i=3; i<n-1; i=i+2)                
                    if ((str[1,i]!=str[1,i-2])||(i==n-2))
                    {
                        int ch2 = 0;
                        for (int j=l; j<=i-2;j=j+2)
                        {
                            if (l==i-2)
                            {
                                ch2 ++;
                                str[2, i - 2] = " ";
                                str[3, i - 2] = str[1, i - 2];
                                break;
                            }
                            int b = ran.Next(0,  st + 1);
                            if (b % 2 != 0)
                            {
                                ch2++;
                                str[3, j] = str[1, j];
                                str[2, j] = " ";
                            }                            
                        }
                        if (ch2==0)
                        {
                            int b = ran.Next((l-1)/2,(i-2-1)/2);
                            str[3, 2*b+1] = str[1, 2*b+1];
                            str[2, 2*b+1] = " ";
                        }                        
                        l = i;   
                        if ((i==n-2) && (str[1, i] != str[1, i - 2]))
                        {
                            str[2, i] = " ";
                            str[3, i] = str[1, i];
                        }                       
                    }                    
                Out(str, n);

                for (int i=0; i<2;i++) //запись в файл
                {
                    for (int j=0; j<n; j++)
                        if (i == 1 && j % 2 != 0)
                            sw.Write(" ");
                        else
                            sw.Write(str[i, j]);
                    sw.WriteLine();
                }

                //Удаление 
                for (int i = 1; i < n - 1; i = i + 2)
                    if (str[3, i] == null)
                    {
                        x++;
                        str[3, i] = x.ToString();
                    }                                                
                for (int i = 0; i < n; i++)
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
                st++;
                // Нижняя шапка
                if (st==k)
                    for (int i = 1; i < n - 3; i = i + 2)
                        if (str[1, i] != str[1, i + 2])
                        {
                            if (Convert.ToInt32(str[1, i + 2]) <= Convert.ToInt32(str[1, i]))
                                str[1, i] = str[1, i + 2];
                            else
                                str[1, i + 2] = str[1, i];
                            str[1, i + 1] = " ";                                                      
                        }                   
            }
            for (int i = 0; i < n; i++)
            {

                Console.Write("-");
                sw.Write("-");//запись в файл
            }
            sw.Close();
            
            Console.WriteLine();

            //создание массива для поиска и его заполнение
            int[,] maze = new int[n, n];
            StreamReader sr = new StreamReader(text);//чтение из файла
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (sr.Read() == ' ')
                        maze[i, j] = 0;
                    else
                        maze[i, j] = -1;
                sr.ReadLine();
            }
            maze[0, 0] = -1;
            maze[0, n - 1] = -1;
            for (int i=0; i<n;i++)
            {
                for (int j = 0; j < n; j++)
                    if (maze[i, j] >= 0)
                        Console.Write(" " + maze[i, j]);
                    else
                        Console.Write(maze[i, j]);
                Console.WriteLine();                                        
            }
            sr.Close();
            //Поиск
            int iB = Convert.ToInt32(Console.ReadLine());
            int jB = Convert.ToInt32(Console.ReadLine());
            int iE = Convert.ToInt32(Console.ReadLine());
            int jE = Convert.ToInt32(Console.ReadLine());

            maze[iB, jB] = 1;
            List<int[]> spisok = new List<int[]>();
            int[] koord = new int[2];
            koord[0] = iB;
            koord[1] = jB;
            spisok.Add(koord);
            while (maze[iE,jE]==0)
            {
                koord = spisok[0];
                if (maze[koord[0]-1,koord[1]]==0 || maze[koord[0] - 1, koord[1]]> maze[koord[0], koord[1]]+1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0] - 1;
                    newkoord[1] = koord[1];
                    spisok.Add(newkoord);
                    maze[koord[0] - 1, koord[1]] = maze[koord[0], koord[1]] + 1;
                }
                if (maze[koord[0] + 1, koord[1]] == 0 || maze[koord[0] + 1, koord[1]] > maze[koord[0], koord[1]]+1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0] + 1;
                    newkoord[1] = koord[1];
                    spisok.Add(newkoord);
                    maze[koord[0] + 1, koord[1]] = maze[koord[0], koord[1]] + 1;
                }
                if (maze[koord[0] , koord[1]-1] == 0 || maze[koord[0], koord[1]-1] > maze[koord[0], koord[1]]+1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0];
                    newkoord[1] = koord[1]-1;
                    spisok.Add(newkoord);
                    maze[koord[0] , koord[1]-1] = maze[koord[0], koord[1]] + 1;
                }
                if (maze[koord[0] , koord[1]+1] == 0 || maze[koord[0] , koord[1]+1] > maze[koord[0], koord[1]]+1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0] ;
                    newkoord[1] = koord[1]+1;
                    spisok.Add(newkoord);
                    maze[koord[0] , koord[1]+1] = maze[koord[0], koord[1]] + 1;
                }
                spisok.RemoveAt(0);
            }

            //Проверка
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (maze[i, j] >= 0)
                        Console.Write(" " + maze[i, j]);
                    else
                        Console.Write(maze[i, j]);
                Console.WriteLine();
            }
            //Проверка окончена

            //Выдать решение

        }
    }
}
