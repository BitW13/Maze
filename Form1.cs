using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Лабиринт
{

    public partial class Form : System.Windows.Forms.Form
    {
        DataGridView data;

        public Form()
        {
            InitializeComponent();                  
        }
        static void OutSet(string[,] str, int width,DataGridView data,int st)
        {
            for (int i = 0; i < 2; i++)            
                for (int j = 0; j < width; j++)
                {
                    if (str[i, j] == "-" || str[i, j] == "|")
                    {
                        if (2 * st - 2 + i == 0 || j == 0 || j == width - 1)
                            data.Rows[2 * st - 2 + i].Cells[j].Style.BackColor = Color.DarkRed;
                        else
                            data.Rows[2 * st - 2 + i].Cells[j].Style.BackColor = Color.Red;
                        data.Rows[2 * st - 2 + i].Cells[j].ReadOnly = true;
                        data.Rows[2 * st - 2 + i].Cells[j].ToolTipText = "-1";
                    }
                    else
                    {
                        if (i % 2 == 0 || j % 2 == 0)
                        {
                            data.Rows[2 * st - 2 + i].Cells[j].Style.BackColor = Color.Aquamarine;
                            data.Rows[2 * st - 2 + i].Cells[j].ReadOnly = true;
                        }
                        else
                        {
                            data.Rows[2 * st - 2 + i].Cells[j].Style.BackColor = Color.Aqua;
                            data.Rows[2 * st - 2 + i].Cells[j].ReadOnly = false;
                        }
                        data.Rows[2 * st - 2 + i].Cells[j].ToolTipText = "0";
                    }
                }            
        }
        static void OutSetFile(string[,] str, int width, int st, StreamWriter sw)
        {

            for (int i = 0; i < 2; i++) //запись в файл
            {
                for (int j = 0; j < width; j++)
                    if (i == 1 && j % 2 != 0)
                        sw.Write(" ");
                    else
                        sw.Write(str[i, j]);
                sw.WriteLine();
            }
        }
        static void OutBottom(int width, int height, DataGridView data)
        {
            for(int i=0; i<width;i++)
            {
                
                data.Rows[2*height].Cells[i].Style.BackColor = Color.DarkRed;
                data.Rows[2 * height].Cells[i].ToolTipText = "-1";
            }
        }
        static void OutBottomFile(int width, StreamWriter sw)
        {
            for (int i = 0; i < width; i++)
            {

                Console.Write("-");
                sw.Write("-");//запись в файл
            }
        }
        static void OutMaze(int width,int height,DataGridView data)
        {            
            GenerateMaze maze = new GenerateMaze(width, height);
            int st = 1;
            while (st <= height)
            {
                maze.Generation(st);
                OutSet(maze.GetStr(), maze.GetWidth(), data,st);
                //Удаление
                maze.UpdateStr();
                st++;//Шаг
                     //Нижняя шапка
                if (st == height)
                    maze.BuildingBottom();                             
            }
            //Последняя строка   
            OutBottom(maze.GetWidth(), maze.GetHeight(), data);
        }
        static void OutMazeFile(int width, int height)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.InitialDirectory = "c:\\";
            file.Filter = "txt files (*.txt)|*.txt";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            
            GenerateMaze maze = new GenerateMaze(width, height);
           ;
            if (file.ShowDialog() == DialogResult.OK)
            {
                Stream stm = file.OpenFile();
                StreamWriter sw = new StreamWriter(stm);
                try
                {
                    int st = 1;
                    while (st <= height)
                    {
                        maze.Generation(st);
                        OutSetFile(maze.GetStr(), maze.GetWidth(), st,sw);
                        //Удаление
                        maze.UpdateStr();
                        st++;//Шаг
                             //Нижняя шапка
                        if (st == height)
                            maze.BuildingBottom();
                    }
                    //Последняя строка   
                    OutBottomFile(maze.GetWidth(), sw);
                    sw.Close();
                    stm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
           
        }
        private void generate_Click(object sender, EventArgs e)
        {           
            if (heightMaze.Text == "" || widthMaze.Text == "")
                MessageBox.Show("Введите размерность лабиринта.");
            else
            {
                int width = -1;
                int height = -1;
                int error = 0;
                try
                {
                    width = Convert.ToInt32(widthMaze.Text);
                    height = Convert.ToInt32(heightMaze.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Размерность лабиринта может быть только положительным числом.Пожалуйста, введите правильно размерность лабиринта.");
                    widthMaze.Clear();
                    heightMaze.Clear();
                    error = 1;
                }
                if (error == 0)                
                    if (width <= 0 || height <= 0)
                        MessageBox.Show("Размерность лабиринта может быть только положительным числом.Пожалуйста, введите правильно размерность лабиринта.");
                    else
                    {
                        Controls.Add(data);
                        try
                        {
                            data = Maze;
                            data.ColumnCount = 1;
                            data.RowCount = 1;
                            data.ColumnCount = 2 * width + 1;
                            data.RowCount = 2 * height + 1;
                        }
                        catch (InvalidOperationException)
                        {
                            MessageBox.Show("Лабиринт слишком большой. Попробуйте сохранить его в файл.");
                            widthMaze.Clear();
                            heightMaze.Clear();
                            error = 1;

                        }
                        if (error == 0)
                        {
                            data.Size = new Size(525, 380);
                            OutMaze(width, height, data);
                            data.RowHeadersWidth = 4;
                            data.ColumnHeadersHeight = 4;
                            flowLayoutPanel3.Visible = true;
                            flowLayoutPanel4.Visible = true;
                            flowLayoutPanel5.Visible = true;
                            flowLayoutPanel6.Visible = true;
                            solutionSearch.Visible = true;
                            save.Visible = true;
                        }
                    }
                        
            }
        }
        private void solutionSearch_Click(object sender, EventArgs e)
        {
            if (beginX.Text == "" || beginY.Text == "")
                MessageBox.Show("Введите координаты входа в лабиринт.");
            else
            if (endX.Text == "" || endY.Text == "")
                MessageBox.Show("Введите координаты выхода из лабиринта.");
            else
            {
                int beginx = -1;
                int beginy = -1;
                int endx = -1;
                int endy = -1;
                int error = 0;
                try
                {
                    beginx = Convert.ToInt32(beginX.Text);
                    beginy = Convert.ToInt32(beginY.Text);
                    endx = Convert.ToInt32(endX.Text);
                    endy = Convert.ToInt32(endY.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Координаты входа и выхода могут быть только положительными числами.Пожалуйста, введите координаты правильно.");
                    beginX.Clear();
                    beginY.Clear();
                    endX.Clear();
                    endY.Clear();
                    error = 1;
                }
                if (error == 0)
                    if (beginx <= 0 || beginy <= 0 || endx <= 0 || endy <= 0)
                    {
                        MessageBox.Show("Координаты входа и выхода могут быть только положительными числами.Пожалуйста, введите координаты правильно.");
                        beginX.Clear();
                        beginY.Clear();
                        endX.Clear();
                        endY.Clear();
                    }
                    else
                    if (beginx > Convert.ToInt32(widthMaze.Text) || beginy > Convert.ToInt32(heightMaze.Text) || endx > Convert.ToInt32(widthMaze.Text) || endy > Convert.ToInt32(heightMaze.Text))
                    {
                        MessageBox.Show("Координаты входа и выхода не могут превышать значения размерности лабиринта.Пожалуйста, введите координаты правильно.");
                        beginX.Clear();
                        beginY.Clear();
                        endX.Clear();
                        endY.Clear();
                    }
                    else
                    {               
                        SolutionMaze solmaze = new SolutionMaze(beginx, beginy, endx, endy, data);
                        solmaze.SeachSolution();
                        solmaze.ShowSolution();
                        data = solmaze.GetData();
                        flowLayoutPanel3.Visible = false;
                        flowLayoutPanel4.Visible = false;
                        flowLayoutPanel5.Visible = false;
                        flowLayoutPanel6.Visible = false;
                        solutionSearch.Visible = false;
                    }
            }

        }

        private void Maze_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (Maze.ColumnCount % 2 != 0)
                Maze.Columns[Maze.ColumnCount - 1].Width = 5;
            else
                Maze.Columns[Maze.ColumnCount - 1].Width = 25;
        }

        private void Maze_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < Maze.RowCount; i++)
                if (i % 2 == 0)
                    Maze.Rows[i].Height = 5;
                else
                    Maze.Rows[i].Height = 25;
        }        

        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Maze.Size = new Size(this.Size.Width - 275, this.Size.Height - 120);
            flowLayoutPanel7.Location = new Point(247, this.Size.Height - 100);
        }

        private void generateAndSave_Click(object sender, EventArgs e)
        {
            if (heightMaze.Text == "" || widthMaze.Text == "")
                MessageBox.Show("Введите размерность лабиринта.");
            else
            {
                int width = -1;
                int height = -1;
                int error = 0;
                try
                {
                    width = Convert.ToInt32(widthMaze.Text);
                    height = Convert.ToInt32(heightMaze.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Размерность лабиринта может быть только положительным числом.Пожалуйста, введите правильно размерность лабиринта.");
                    widthMaze.Clear();
                    heightMaze.Clear();
                    error = 1;
                }
                if (error == 0)
                    if (width <= 0 || height <= 0)
                        MessageBox.Show("Размерность лабиринта может быть только положительным числом.Пожалуйста, введите правильно размерность лабиринта.");
                    else
                        OutMazeFile(width, height);
            }
        }
        public void SaveData(int width, int height)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.InitialDirectory = "c:\\";
            file.Filter = "txt files (*.txt)|*.txt";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                Stream stm = file.OpenFile();
                StreamWriter sw = new StreamWriter(stm);
                try
                {
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (data.Rows[i].Cells[j].Style.BackColor == Color.DarkRed || data.Rows[i].Cells[j].Style.BackColor == Color.Red)
                                sw.Write("#");
                            if (data.Rows[i].Cells[j].Style.BackColor == Color.Aquamarine || data.Rows[i].Cells[j].Style.BackColor == Color.Aqua)
                                sw.Write(" ");
                            if (data.Rows[i].Cells[j].Style.BackColor == Color.Indigo)
                                sw.Write("+");
                        }
                        sw.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                sw.Close();
                stm.Close();
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            int width = 2 * Convert.ToInt32(widthMaze.Text) + 1;
            int height = 2 * Convert.ToInt32(heightMaze.Text) + 1;
            SaveData(width, height);
        }
    }
}
