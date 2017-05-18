using System;
namespace Лабиринт
{
    class GenerateMaze
    {
        int _width;
        int _height;
        string[,] str;
        int x;
        public GenerateMaze(int width,int height)
        {
            _width = 2 * width + 1;
            _height = height;
            //Каркас
            str = CreatureCarcass(_width);
            x = 2 * _width;
        }

        public Form передаёт
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

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
        public void UpdateStr()
        {
            //Обновление строки
            for (int i = 1; i < _width - 1; i = i + 2)
                if (str[3, i] == null)
                {
                    x++;
                    str[3, i] = x.ToString();
                }
            for (int i = 0; i < _width; i++)
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
        }
        static void OutStrMaze(string[,] str, int width)
        {
            int[,] maze = new int[2, width];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 1 && j % 2 != 0)
                        Console.Write(" ");
                    else
                        Console.Write(str[i, j]);
                }
                Console.WriteLine();
            }
        }
        public string[,] BuildingBottom()
        {
            //Построение нижней части лабиринта
            
                for (int i = 1; i < _width - 3; i = i + 2)
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
        public int GetHeight()
        {
            return _height;
        }
        public string[,] GetStr()
        {
            return str;
        }
        public int GetWidth()
        {
            return _width;
        }
        public void Generation(int st)
        {
            str[1, 0] = "|";
            str[1, _width - 1] = "|";
            str[2, 0] = "|";
            str[2, _width - 1] = "|";
            //Горизонтальное изменение                    
            Random ran = new Random();
            for (int i = 1; i < _width - 3; i = i + 2)
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
            for (int i = 1; i < _width - 1; i++)
                str[2, i] = "-";
            //Вертикальное изменение
            int l = 1;
            for (int i = 3; i < _width - 1; i = i + 2)
                if ((str[1, i] != str[1, i - 2]) || (i == _width - 2))
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
                    if ((i == _width - 2) && (str[1, i] != str[1, i - 2]))
                    {
                        str[2, i] = " ";
                        str[3, i] = str[1, i];
                    }
                }      
        }
    }
}

