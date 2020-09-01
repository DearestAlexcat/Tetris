namespace Tet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new Tet.MyPanel();
            this.LINE = new System.Windows.Forms.Label();
            this.SCR = new System.Windows.Forms.Label();
            this.LVL = new System.Windows.Forms.Label();
            this.FIG = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new Tet.MyPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.BackgroundImage = global::Tet.Properties.Resources.Zona1;
            this.panel3.Controls.Add(this.LINE);
            this.panel3.Controls.Add(this.SCR);
            this.panel3.Controls.Add(this.LVL);
            this.panel3.Controls.Add(this.FIG);
            this.panel3.Controls.Add(this.User);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(250, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 501);
            this.panel3.TabIndex = 2;
            // 
            // LINE
            // 
            this.LINE.AutoSize = true;
            this.LINE.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.LINE.ForeColor = System.Drawing.Color.White;
            this.LINE.Location = new System.Drawing.Point(87, 323);
            this.LINE.Name = "LINE";
            this.LINE.Size = new System.Drawing.Size(17, 26);
            this.LINE.TabIndex = 13;
            this.LINE.Text = " ";
            // 
            // SCR
            // 
            this.SCR.AutoSize = true;
            this.SCR.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.SCR.ForeColor = System.Drawing.Color.White;
            this.SCR.Location = new System.Drawing.Point(87, 271);
            this.SCR.Name = "SCR";
            this.SCR.Size = new System.Drawing.Size(17, 26);
            this.SCR.TabIndex = 12;
            this.SCR.Text = " ";
            // 
            // LVL
            // 
            this.LVL.AutoSize = true;
            this.LVL.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.LVL.ForeColor = System.Drawing.Color.White;
            this.LVL.Location = new System.Drawing.Point(87, 216);
            this.LVL.Name = "LVL";
            this.LVL.Size = new System.Drawing.Size(17, 26);
            this.LVL.TabIndex = 11;
            this.LVL.Text = " ";
            // 
            // FIG
            // 
            this.FIG.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.FIG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FIG.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.FIG.Image = global::Tet.Properties.Resources.Zona1;
            this.FIG.Location = new System.Drawing.Point(84, 72);
            this.FIG.Name = "FIG";
            this.FIG.Size = new System.Drawing.Size(125, 125);
            this.FIG.TabIndex = 10;
            this.FIG.Paint += new System.Windows.Forms.PaintEventHandler(this.FIG_Paint);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Location = new System.Drawing.Point(87, 21);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(17, 26);
            this.User.TabIndex = 9;
            this.User.Text = " ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Player";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lines";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Next";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(87, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Help";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(87, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Restard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(87, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Tet.Properties.Resources.Zona2;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 501);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = global::Tet.Properties.Resources.Capture2;
            this.panel1.Controls.Add(this.Exit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 39);
            this.panel1.TabIndex = 0;         
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Exit1
            // 
            this.Exit1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit1.BackgroundImage = global::Tet.Properties.Resources.Exit;
            this.Exit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit1.ForeColor = System.Drawing.Color.Black;
            this.Exit1.Location = new System.Drawing.Point(459, 3);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(38, 23);
            this.Exit1.TabIndex = 0;
            this.Exit1.UseVisualStyleBackColor = false;
            this.Exit1.Click += new System.EventHandler(this.Exit1_Click);
            this.Exit1.MouseEnter += new System.EventHandler(this.Exit1_MouseEnter);
            this.Exit1.MouseLeave += new System.EventHandler(this.Exit1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(500, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MyPanel panel3;
        private MyPanel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LINE;
        private System.Windows.Forms.Label SCR;
        private System.Windows.Forms.Label LVL;
        private System.Windows.Forms.Label FIG;
        private System.Windows.Forms.Label User;
    }
}

