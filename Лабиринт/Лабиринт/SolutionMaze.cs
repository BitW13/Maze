using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Лабиринт
{    
    class SolutionMaze
    {
        //класс для отображения решения лабиринта.
        int _beginx;//Х координата входа в лабиринт(в ячейках).
        int _beginy;//Y координата входа в лабиринт(в ячейках).
        int _endx;//X координата выхода из лабиринта(в ячейках).
        int _endy;//Y координата выхода из лабиринта(в ячейках).
        DataGridView _data;//таблица лабиринта.
        public SolutionMaze(int beginx, int beginy, int endx, int endy, DataGridView data)
        {
            _beginx = 2*beginx-1;
            _beginy = 2*beginy-1;
            _endx = 2*endx-1;
            _endy = 2*endy-1;
            _data = data;
        }

        public Form решает
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public DataGridView GetData()
        {
            ///<summary>
            ///возвращает таблицу лабиринта.
            /// </summary>
            return _data;
        }
        public void SeachSolution()
        {
            ///<summary>
            ///Производит поиск решения.
            /// </summary>
            _data.Rows[_beginy].Cells[_beginx].ToolTipText = "1";
            List<int[]> spisok = new List<int[]>();
            int[] koord = new int[2];
            koord[0] = _beginy;
            koord[1] = _beginx;
            spisok.Add(koord);
            while (_data.Rows[_endy].Cells[_endx].ToolTipText == "0")
            {
                koord = spisok[0];
                int col00 = Convert.ToInt32(_data.Rows[koord[0]].Cells[koord[1]].ToolTipText);
                int colch = Convert.ToInt32(_data.Rows[koord[0] - 1].Cells[koord[1]].ToolTipText);
                if (colch==0 ||colch>col00+1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0] - 1 ;
                    newkoord[1] = koord[1];
                    spisok.Add(newkoord);
                    colch =col00 + 1;
                    _data.Rows[koord[0] - 1].Cells[koord[1]].ToolTipText = colch.ToString();
                }                
                colch = Convert.ToInt32(_data.Rows[koord[0] + 1].Cells[koord[1]].ToolTipText);
                if (colch == 0 ||colch>col00+1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0] + 1 ;
                    newkoord[1] = koord[1];
                    spisok.Add(newkoord);
                    colch =col00 + 1;
                    _data.Rows[koord[0] + 1].Cells[koord[1]].ToolTipText = colch.ToString();
                }
                colch = Convert.ToInt32(_data.Rows[koord[0]].Cells[koord[1] - 1].ToolTipText);
                if (colch == 0 ||colch>col00 + 1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0];
                    newkoord[1] = koord[1] - 1;
                    spisok.Add(newkoord);
                    colch =col00 + 1;
                    _data.Rows[koord[0]].Cells[koord[1] - 1].ToolTipText = colch.ToString();
                }
                colch = Convert.ToInt32(_data.Rows[koord[0]].Cells[koord[1] + 1].ToolTipText);
                if (colch== 0 ||colch>col00 + 1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0];
                    newkoord[1] = koord[1] + 1;
                    spisok.Add(newkoord);
                    colch = col00 + 1;
                    _data.Rows[koord[0]].Cells[koord[1] + 1].ToolTipText = colch.ToString();
                }
                spisok.RemoveAt(0);
            }         
        }
        public void ShowSolution()
        {
            ///<summary>
            ///Показывает решение.
            /// </summary>
            List<int[]> spisok = new List<int[]>();
            int[] koord = new int[2];
            koord[0] = _endy;
            koord[1] = _endx;
            spisok.Add(koord);
            while(_data.Rows[_beginy].Cells[_beginx].ToolTipText == "1")
            {
                koord = spisok[0];
                int col00 = Convert.ToInt32(_data.Rows[koord[0]].Cells[koord[1]].ToolTipText);
                int colch = Convert.ToInt32(_data.Rows[koord[0] - 1].Cells[koord[1]].ToolTipText);
                if (col00-colch==1 && colch!=-1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0] - 1;
                    newkoord[1] = koord[1];
                    spisok.Add(newkoord);
                    col00 = 0;
                    _data.Rows[koord[0]].Cells[koord[1]].ToolTipText = col00.ToString();
                    _data.Rows[koord[0]].Cells[koord[1]].Style.BackColor = System.Drawing.Color.Indigo;
                }
                colch= Convert.ToInt32(_data.Rows[koord[0] + 1].Cells[koord[1]].ToolTipText);
                if (col00-colch==1 && colch != -1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0] + 1;
                    newkoord[1] = koord[1];
                    spisok.Add(newkoord);
                    col00 = 0;
                    _data.Rows[koord[0]].Cells[koord[1]].ToolTipText = col00.ToString();
                    _data.Rows[koord[0]].Cells[koord[1]].Style.BackColor = System.Drawing.Color.Indigo;
                }
                colch = Convert.ToInt32(_data.Rows[koord[0]].Cells[koord[1] - 1].ToolTipText);
                if(col00-colch==1 && colch != -1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0];
                    newkoord[1] = koord[1]-1;
                    spisok.Add(newkoord);
                    col00 = 0;
                    _data.Rows[koord[0]].Cells[koord[1]].ToolTipText = col00.ToString();
                    _data.Rows[koord[0]].Cells[koord[1]].Style.BackColor = System.Drawing.Color.Indigo;
                }
                colch = Convert.ToInt32(_data.Rows[koord[0]].Cells[koord[1] + 1].ToolTipText);
                if (col00-colch==1 && colch != -1)
                {
                    int[] newkoord = new int[2];
                    newkoord[0] = koord[0];
                    newkoord[1] = koord[1] + 1;
                    spisok.Add(newkoord);
                    col00 = 0;
                    _data.Rows[koord[0]].Cells[koord[1]].ToolTipText = col00.ToString();
                    _data.Rows[koord[0]].Cells[koord[1]].Style.BackColor = System.Drawing.Color.Indigo;
                }
                spisok.RemoveAt(0);
            }
        }
    }
}
