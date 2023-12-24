namespace Calculator
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Expression = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Diff = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.Summ = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.Expression);
            this.flowLayoutPanel1.Controls.Add(this.Output);
            this.flowLayoutPanel1.Controls.Add(this.CE);
            this.flowLayoutPanel1.Controls.Add(this.C);
            this.flowLayoutPanel1.Controls.Add(this.DEL);
            this.flowLayoutPanel1.Controls.Add(this.Div);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.Multi);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Controls.Add(this.Diff);
            this.flowLayoutPanel1.Controls.Add(this.button13);
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.Controls.Add(this.button15);
            this.flowLayoutPanel1.Controls.Add(this.Summ);
            this.flowLayoutPanel1.Controls.Add(this.Dot);
            this.flowLayoutPanel1.Controls.Add(this.button18);
            this.flowLayoutPanel1.Controls.Add(this.Result);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 397);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Expression
            // 
            this.Expression.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Expression.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Expression.Location = new System.Drawing.Point(1, 1);
            this.Expression.Margin = new System.Windows.Forms.Padding(1);
            this.Expression.Name = "Expression";
            this.Expression.Size = new System.Drawing.Size(341, 20);
            this.Expression.TabIndex = 0;
            this.Expression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(1, 23);
            this.Output.Margin = new System.Windows.Forms.Padding(1);
            this.Output.MinimumSize = new System.Drawing.Size(4, 40);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(341, 49);
            this.Output.TabIndex = 0;
            this.Output.Text = "0";
            this.Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CE.FlatAppearance.BorderSize = 2;
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CE.Location = new System.Drawing.Point(0, 73);
            this.CE.Margin = new System.Windows.Forms.Padding(0);
            this.CE.MinimumSize = new System.Drawing.Size(0, 40);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(86, 64);
            this.CE.TabIndex = 1;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.C.FlatAppearance.BorderSize = 2;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C.Location = new System.Drawing.Point(86, 73);
            this.C.Margin = new System.Windows.Forms.Padding(0);
            this.C.MinimumSize = new System.Drawing.Size(0, 40);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(86, 64);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // DEL
            // 
            this.DEL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DEL.FlatAppearance.BorderSize = 2;
            this.DEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DEL.Location = new System.Drawing.Point(172, 73);
            this.DEL.Margin = new System.Windows.Forms.Padding(0);
            this.DEL.MinimumSize = new System.Drawing.Size(0, 40);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(86, 64);
            this.DEL.TabIndex = 3;
            this.DEL.Text = "<";
            this.DEL.UseVisualStyleBackColor = false;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Div.FlatAppearance.BorderSize = 2;
            this.Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Div.Location = new System.Drawing.Point(258, 73);
            this.Div.Margin = new System.Windows.Forms.Padding(0);
            this.Div.MinimumSize = new System.Drawing.Size(0, 40);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(86, 64);
            this.Div.TabIndex = 4;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(0, 137);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.MinimumSize = new System.Drawing.Size(0, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 64);
            this.button5.TabIndex = 5;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(86, 137);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.MinimumSize = new System.Drawing.Size(0, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 64);
            this.button6.TabIndex = 6;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(172, 137);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.MinimumSize = new System.Drawing.Size(0, 40);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 64);
            this.button7.TabIndex = 7;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Multi
            // 
            this.Multi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Multi.FlatAppearance.BorderSize = 2;
            this.Multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multi.Location = new System.Drawing.Point(258, 137);
            this.Multi.Margin = new System.Windows.Forms.Padding(0);
            this.Multi.MinimumSize = new System.Drawing.Size(0, 40);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(86, 64);
            this.Multi.TabIndex = 8;
            this.Multi.Text = "*";
            this.Multi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Multi.UseVisualStyleBackColor = false;
            this.Multi.Click += new System.EventHandler(this.Div_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(0, 201);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.MinimumSize = new System.Drawing.Size(0, 40);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(86, 64);
            this.button9.TabIndex = 9;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(86, 201);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.MinimumSize = new System.Drawing.Size(0, 40);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(86, 64);
            this.button10.TabIndex = 10;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(172, 201);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.MinimumSize = new System.Drawing.Size(0, 40);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(86, 64);
            this.button11.TabIndex = 11;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Diff
            // 
            this.Diff.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Diff.FlatAppearance.BorderSize = 2;
            this.Diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Diff.Location = new System.Drawing.Point(258, 201);
            this.Diff.Margin = new System.Windows.Forms.Padding(0);
            this.Diff.MinimumSize = new System.Drawing.Size(0, 40);
            this.Diff.Name = "Diff";
            this.Diff.Size = new System.Drawing.Size(86, 64);
            this.Diff.TabIndex = 12;
            this.Diff.Text = "-";
            this.Diff.UseVisualStyleBackColor = false;
            this.Diff.Click += new System.EventHandler(this.Div_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button13.FlatAppearance.BorderSize = 2;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(0, 265);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.MinimumSize = new System.Drawing.Size(0, 40);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(86, 64);
            this.button13.TabIndex = 13;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button14.FlatAppearance.BorderSize = 2;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(86, 265);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.MinimumSize = new System.Drawing.Size(0, 40);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(86, 64);
            this.button14.TabIndex = 14;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button15.FlatAppearance.BorderSize = 2;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(172, 265);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.MinimumSize = new System.Drawing.Size(0, 40);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(86, 64);
            this.button15.TabIndex = 15;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Summ
            // 
            this.Summ.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Summ.FlatAppearance.BorderSize = 2;
            this.Summ.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Summ.Location = new System.Drawing.Point(258, 265);
            this.Summ.Margin = new System.Windows.Forms.Padding(0);
            this.Summ.MinimumSize = new System.Drawing.Size(0, 40);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(86, 64);
            this.Summ.TabIndex = 16;
            this.Summ.Text = "+";
            this.Summ.UseVisualStyleBackColor = false;
            this.Summ.Click += new System.EventHandler(this.Div_Click);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dot.FlatAppearance.BorderSize = 2;
            this.Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dot.Location = new System.Drawing.Point(0, 329);
            this.Dot.Margin = new System.Windows.Forms.Padding(0);
            this.Dot.MinimumSize = new System.Drawing.Size(0, 40);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(86, 64);
            this.Dot.TabIndex = 17;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button18.FlatAppearance.BorderSize = 2;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(86, 329);
            this.button18.Margin = new System.Windows.Forms.Padding(0);
            this.button18.MinimumSize = new System.Drawing.Size(0, 40);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(86, 64);
            this.button18.TabIndex = 18;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Result.FlatAppearance.BorderSize = 2;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(172, 329);
            this.Result.Margin = new System.Windows.Forms.Padding(0);
            this.Result.MinimumSize = new System.Drawing.Size(0, 40);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(172, 64);
            this.Result.TabIndex = 19;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = false;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 397);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox Expression;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button Diff;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button Summ;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button Result;
    }
}

