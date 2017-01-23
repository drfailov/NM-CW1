namespace Rozrah_1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxMethod = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxMatrix = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDo = new System.Windows.Forms.Button();
            this.buttonRandomizer = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.checkBoxMusic = new System.Windows.Forms.CheckBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.checkBoxCarette = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleTextBox.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.consoleTextBox.Location = new System.Drawing.Point(0, 0);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.Size = new System.Drawing.Size(924, 475);
            this.consoleTextBox.TabIndex = 3;
            this.consoleTextBox.Text = "Вітаємо Вас в високоінтелектуальній системі по мотивам триллера \"Чисельні методи\"" +
    ".";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 154);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxMethod);
            this.groupBox2.Location = new System.Drawing.Point(235, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 140);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оберіть метод";
            // 
            // listBoxMethod
            // 
            this.listBoxMethod.FormattingEnabled = true;
            this.listBoxMethod.Location = new System.Drawing.Point(6, 19);
            this.listBoxMethod.Name = "listBoxMethod";
            this.listBoxMethod.ScrollAlwaysVisible = true;
            this.listBoxMethod.Size = new System.Drawing.Size(261, 108);
            this.listBoxMethod.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxMatrix);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 140);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оберіть матрицю";
            // 
            // listBoxMatrix
            // 
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.Location = new System.Drawing.Point(6, 19);
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.ScrollAlwaysVisible = true;
            this.listBoxMatrix.Size = new System.Drawing.Size(196, 108);
            this.listBoxMatrix.TabIndex = 18;
            this.listBoxMatrix.SelectedIndexChanged += new System.EventHandler(this.listBoxMatrix_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDo);
            this.panel2.Controls.Add(this.buttonRandomizer);
            this.panel2.Controls.Add(this.buttonGraph);
            this.panel2.Controls.Add(this.buttonRandom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(732, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 154);
            this.panel2.TabIndex = 17;
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(20, 12);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(132, 104);
            this.buttonDo.TabIndex = 21;
            this.buttonDo.Text = "Зробити все";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // buttonRandomizer
            // 
            this.buttonRandomizer.Location = new System.Drawing.Point(158, 86);
            this.buttonRandomizer.Name = "buttonRandomizer";
            this.buttonRandomizer.Size = new System.Drawing.Size(178, 30);
            this.buttonRandomizer.TabIndex = 16;
            this.buttonRandomizer.Text = "Генератор випадкових чисел";
            this.buttonRandomizer.UseVisualStyleBackColor = true;
            this.buttonRandomizer.Click += new System.EventHandler(this.buttonRandomizer_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Location = new System.Drawing.Point(160, 12);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(178, 31);
            this.buttonGraph.TabIndex = 8;
            this.buttonGraph.Text = "Генератор графіків?!";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(160, 49);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(178, 31);
            this.buttonRandom.TabIndex = 15;
            this.buttonRandom.Text = "Генератор випадкових матриць";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(6, 75);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(47, 23);
            this.buttonPlus.TabIndex = 19;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(59, 75);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(47, 23);
            this.buttonMinus.TabIndex = 18;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // checkBoxMusic
            // 
            this.checkBoxMusic.AutoSize = true;
            this.checkBoxMusic.Checked = true;
            this.checkBoxMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMusic.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBoxMusic.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxMusic.Location = new System.Drawing.Point(860, 0);
            this.checkBoxMusic.Name = "checkBoxMusic";
            this.checkBoxMusic.Size = new System.Drawing.Size(64, 33);
            this.checkBoxMusic.TabIndex = 14;
            this.checkBoxMusic.Text = "Музика";
            this.checkBoxMusic.UseVisualStyleBackColor = true;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Checked = true;
            this.checkBoxAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAll.Location = new System.Drawing.Point(6, 52);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(152, 17);
            this.checkBoxAll.TabIndex = 11;
            this.checkBoxAll.Text = "Виводити всі розрахунки";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxCarette
            // 
            this.checkBoxCarette.AutoSize = true;
            this.checkBoxCarette.Checked = true;
            this.checkBoxCarette.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCarette.Location = new System.Drawing.Point(6, 29);
            this.checkBoxCarette.Name = "checkBoxCarette";
            this.checkBoxCarette.Size = new System.Drawing.Size(110, 17);
            this.checkBoxCarette.TabIndex = 10;
            this.checkBoxCarette.Text = "Зсувати каретку";
            this.checkBoxCarette.UseVisualStyleBackColor = true;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 11);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(160, 13);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Час виконання операції: 0 мс.";
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.Checked = true;
            this.checkBoxLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLog.Location = new System.Drawing.Point(6, 6);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(76, 17);
            this.checkBoxLog.TabIndex = 5;
            this.checkBoxLog.Text = "Вести лог";
            this.checkBoxLog.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(6, 104);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 32);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистити лог";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.consoleTextBox);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1082, 508);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelTime);
            this.panel5.Controls.Add(this.checkBoxMusic);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 475);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(924, 33);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonMinus);
            this.panel4.Controls.Add(this.buttonPlus);
            this.panel4.Controls.Add(this.checkBoxLog);
            this.panel4.Controls.Add(this.checkBoxCarette);
            this.panel4.Controls.Add(this.checkBoxAll);
            this.panel4.Controls.Add(this.buttonClear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(924, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 508);
            this.panel4.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 662);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Система ХАОС-3 для виклику демонів (ВІДТЕПЕР БІЛЬШЕ ДЕМОНІВ!!!)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxLog;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.CheckBox checkBoxCarette;
        private System.Windows.Forms.CheckBox checkBoxMusic;
        private System.Windows.Forms.Button buttonRandomizer;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBoxMatrix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxMethod;
        private System.Windows.Forms.Button buttonDo;
    }
}

