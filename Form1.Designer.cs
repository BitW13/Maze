namespace Лабиринт
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.heightMaze = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.widthMaze = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.beginX = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.beginY = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.endX = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.endY = new System.Windows.Forms.TextBox();
            this.solutionSearch = new System.Windows.Forms.Button();
            this.Maze = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.generateAndSave = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maze)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.tableLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.79079F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.20921F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.generate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.solutionSearch, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.18367F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.heightMaze);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(112, 99);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота лабиринта : ";
            // 
            // heightMaze
            // 
            this.heightMaze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightMaze.Location = new System.Drawing.Point(3, 43);
            this.heightMaze.Name = "heightMaze";
            this.heightMaze.Size = new System.Drawing.Size(100, 20);
            this.heightMaze.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.widthMaze);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(121, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(115, 99);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ширина лабиринта : ";
            // 
            // widthMaze
            // 
            this.widthMaze.Location = new System.Drawing.Point(3, 43);
            this.widthMaze.Name = "widthMaze";
            this.widthMaze.Size = new System.Drawing.Size(100, 20);
            this.widthMaze.TabIndex = 1;
            // 
            // generate
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.generate, 2);
            this.generate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generate.Location = new System.Drawing.Point(3, 108);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(233, 67);
            this.generate.TabIndex = 2;
            this.generate.Text = "Сгенерировать лабиринт";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.beginX);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 181);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(112, 96);
            this.flowLayoutPanel3.TabIndex = 3;
            this.flowLayoutPanel3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "Координата X входа в лабиринт : ";
            // 
            // beginX
            // 
            this.beginX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beginX.Location = new System.Drawing.Point(3, 63);
            this.beginX.Name = "beginX";
            this.beginX.Size = new System.Drawing.Size(100, 20);
            this.beginX.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.beginY);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(121, 181);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(115, 96);
            this.flowLayoutPanel4.TabIndex = 4;
            this.flowLayoutPanel4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 60);
            this.label4.TabIndex = 0;
            this.label4.Text = "Координата Y входа в лабиринт : ";
            // 
            // beginY
            // 
            this.beginY.Location = new System.Drawing.Point(3, 63);
            this.beginY.Name = "beginY";
            this.beginY.Size = new System.Drawing.Size(100, 20);
            this.beginY.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.endX);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 283);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(112, 98);
            this.flowLayoutPanel5.TabIndex = 5;
            this.flowLayoutPanel5.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 60);
            this.label5.TabIndex = 0;
            this.label5.Text = "Координата X выхода из лабиринта : ";
            // 
            // endX
            // 
            this.endX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endX.Location = new System.Drawing.Point(3, 63);
            this.endX.Name = "endX";
            this.endX.Size = new System.Drawing.Size(100, 20);
            this.endX.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label6);
            this.flowLayoutPanel6.Controls.Add(this.endY);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(121, 283);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(115, 98);
            this.flowLayoutPanel6.TabIndex = 6;
            this.flowLayoutPanel6.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 60);
            this.label6.TabIndex = 0;
            this.label6.Text = "Координата Y  выхода из лабиринта : ";
            // 
            // endY
            // 
            this.endY.Location = new System.Drawing.Point(3, 63);
            this.endY.Name = "endY";
            this.endY.Size = new System.Drawing.Size(100, 20);
            this.endY.TabIndex = 1;
            // 
            // solutionSearch
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.solutionSearch, 2);
            this.solutionSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solutionSearch.Location = new System.Drawing.Point(3, 387);
            this.solutionSearch.Name = "solutionSearch";
            this.solutionSearch.Size = new System.Drawing.Size(233, 72);
            this.solutionSearch.TabIndex = 7;
            this.solutionSearch.Text = "Показать решение";
            this.solutionSearch.UseVisualStyleBackColor = true;
            this.solutionSearch.Visible = false;
            this.solutionSearch.Click += new System.EventHandler(this.solutionSearch_Click);
            // 
            // Maze
            // 
            this.Maze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Maze.Location = new System.Drawing.Point(244, 0);
            this.Maze.Name = "Maze";
            this.Maze.Size = new System.Drawing.Size(240, 150);
            this.Maze.TabIndex = 1;
            this.Maze.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.Maze_ColumnAdded);
            this.Maze.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Maze_RowsAdded);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.generateAndSave);
            this.flowLayoutPanel7.Controls.Add(this.save);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(247, 400);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(237, 62);
            this.flowLayoutPanel7.TabIndex = 2;
            // 
            // generateAndSave
            // 
            this.generateAndSave.Location = new System.Drawing.Point(3, 3);
            this.generateAndSave.Name = "generateAndSave";
            this.generateAndSave.Size = new System.Drawing.Size(100, 50);
            this.generateAndSave.TabIndex = 1;
            this.generateAndSave.Text = "Сгенерировать и сохранить";
            this.generateAndSave.UseVisualStyleBackColor = true;
            this.generateAndSave.Click += new System.EventHandler(this.generateAndSave_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(109, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 50);
            this.save.TabIndex = 0;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this.Maze);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Лабиринт";
            this.SizeChanged += new System.EventHandler(this.Form_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maze)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heightMaze;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox widthMaze;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox beginX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox beginY;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox endY;
        private System.Windows.Forms.Button solutionSearch;
        private System.Windows.Forms.DataGridView Maze;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button generateAndSave;
        private System.Windows.Forms.Button save;
    }
}

