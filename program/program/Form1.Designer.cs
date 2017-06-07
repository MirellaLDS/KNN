namespace program
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClassify = new System.Windows.Forms.Button();
            this.txtQtdItens = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(652, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFile.Enabled = false;
            this.txtFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtFile.Location = new System.Drawing.Point(234, 23);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(412, 20);
            this.txtFile.TabIndex = 10;
            this.txtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Path to classify Customer\'s file";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.OldLace;
            this.txtNumber.Location = new System.Drawing.Point(235, 68);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 13;
            this.txtNumber.Text = "3";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number of k nearest neighbors";
            // 
            // btnClassify
            // 
            this.btnClassify.Location = new System.Drawing.Point(652, 68);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(75, 23);
            this.btnClassify.TabIndex = 14;
            this.btnClassify.Text = "Classify";
            this.btnClassify.UseVisualStyleBackColor = true;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // txtQtdItens
            // 
            this.txtQtdItens.BackColor = System.Drawing.Color.OldLace;
            this.txtQtdItens.Location = new System.Drawing.Point(235, 109);
            this.txtQtdItens.Name = "txtQtdItens";
            this.txtQtdItens.Size = new System.Drawing.Size(100, 20);
            this.txtQtdItens.TabIndex = 16;
            this.txtQtdItens.Text = "105";
            this.txtQtdItens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Number of training itens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(488, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(342, 248);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "D";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(652, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Proximos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.name,
            this.age,
            this.gender,
            this.income,
            this.ncard});
            this.dataGrid.Location = new System.Drawing.Point(23, 310);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(836, 229);
            this.dataGrid.TabIndex = 25;
            // 
            // order
            // 
            this.order.HeaderText = "Index";
            this.order.Name = "order";
            // 
            // name
            // 
            this.name.HeaderText = "A";
            this.name.Name = "name";
            // 
            // age
            // 
            this.age.HeaderText = "B";
            this.age.Name = "age";
            // 
            // gender
            // 
            this.gender.HeaderText = "C";
            this.gender.Name = "gender";
            // 
            // income
            // 
            this.income.HeaderText = "D";
            this.income.Name = "income";
            // 
            // ncard
            // 
            this.ncard.HeaderText = "Class";
            this.ncard.Name = "ncard";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Classificação: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdItens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClassify);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.TextBox txtQtdItens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn income;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

