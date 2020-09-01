using System;
using System.Drawing;
using System.Windows.Forms;
 
namespace Tet
{
    public partial class Form1 : Form
    {
        const byte      cell_size = 25;
        int             st, str, rand_br_color, figure, lines, score;
        bool            next;
        short           level, coefForSpeed; 
        
        System.Windows.Forms.Timer           timer;       
       
        Random          rand;
        Brush[,]        field;

        Point[]         osn;
        Point[]         buf;
        Point[]         pre_osn; 

        Color[]         br_color = { Color.FromArgb(125, 141, 175), Color.FromArgb(109, 156, 138),
                                     Color.FromArgb(153, 192, 125), Color.FromArgb(153, 120, 173),
                                     Color.FromArgb(214, 137, 92 ), Color.FromArgb(168, 135, 90 ),
                                     Color.FromArgb(199, 191, 110), Color.FromArgb(184, 124, 132) };
        GameOver        form2;
        Help            form3;

        enum Game {Play, Pausa, Exit}
        Game            game;

        bool[,] figuru =
        {
            { false, true, false, true, false, true, false, true },  //I
            { true, true, true, true, false, false, false, false},  //O
            { true, true, true, false, true, false, false, false },  //Г
            { true, true, false, true, false, true, false, false },  //-Г
            { true, false, true, true, false, true, false, false },  //S
            { false, true, true, true, true, false, false, false },  //-S
            { true, false, true, true, true, false, false, false }   //T
        };

        public Form1()
        {
            InitializeComponent();
            form2 = new GameOver();
            form2.Owner = this;
            form3 = new Help();
            form3.Owner = this;
            this.panel2.Paint += this.MyPanel2_Paint;
            this.panel3.Paint += this.MyPanel3_Paint;

            st =  (panel2.Size.Width  / cell_size);
            str = (panel2.Size.Height /   cell_size);

            ResizeRedraw = true;
            Text = "Tetris";
            
            Initialize();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerOntic);
            timer.Start();
        }

        public void TimerOntic(object sender, EventArgs e)
        {
            if (game == Game.Pausa)
                return;

            Shift(0, 1);

            for (int i = 0; i < 4; i++)
            {
                if (osn[i].Y == 0)
                {
                    timer.Stop();
                    form2.ShowDialog();               
                    game = Game.Pausa;
                    return;
                }
            }

            panel2.Invalidate();
        }

        public void ObrabotkaButton(object sender, EventArgs e)
        {
            Button but = (Button)sender;
 
            if (but.Text == Game.Play + "")
            {            
                game = Game.Play;
                timer.Start();
            }
            else if (but.Text == Game.Pausa + "")
            {
                game = Game.Pausa;
                timer.Stop();
            }
            else 
            {
                Application.Exit();
            }
        }

        #region Tetris logic
        void Initialize()
        {
            game = Game.Play;
            next = true;
            field = new Brush[str, st];
            lines = score = 0;
            level = 1;
            coefForSpeed = 10;
            rand_br_color = 0;
            rand = new Random();               
            osn = new Point[4];
            buf = new Point[4];
            pre_osn = new Point[4];
        }

        void FormFigure(Point shift, Point[] tochki, bool Random_figure = true)
        {                      
            if(Random_figure)
            {
                figure = rand.Next(0, 7);
                rand_br_color = rand.Next(0, br_color.Length);
            }
            for (int i = 0, j = 0; i < 8; i++)
            {
                if (figuru[figure, i])
                {
                    // get points
                    tochki[j].X = i % 2;
                    tochki[j].Y = i / 2;
                    // shift 
                    tochki[j].X += shift.X;
                    tochki[j].Y += shift.Y;
                    j++;
                }                
            }        
        }
        bool Shift(int dx, int dy)
        {
            int i;
            //remember the past position
            osn.CopyTo(buf, 0);
            // shift
            for (i = 0; i < 4; i++)
            {
                osn[i].X += dx;
                osn[i].Y += dy;
            }
            return isShift();
        }
        bool isShift()
        {
            int num = -1;

            // 1 - collision 
            // 0 - next
            //Checking boundaries

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    if (osn[i].X < 0 || osn[i].X >= st) num = 1;
                    else if (osn[i].Y == str) num = 0;

                    // Check occupied cells
                    else if (field[osn[i].Y, osn[i].X] != null) 
                    {
                        if(osn[i].X != buf[i].X) num = 1;
                        else num = 0;
                    }
                }
                catch
                {
                        
                }
            }


        switch (num)
        {
            case 0:
                {
                    next = true;        // enable generation of the next shape
                    buf.CopyTo(osn, 0);  
                    for (int i = 0; i < 4; i++)
                    {
                        // Save the stopped shape
                        field[buf[i].Y, buf[i].X] = new SolidBrush(br_color[rand_br_color]);
                    }
                }
                return false;
            case 1:
                {
                    // If there was a collision, then rollback
                    buf.CopyTo(osn, 0);
                }
                return true;
            default: return false;
            }
        }     

        void isLine()
        {
            int count, limit;
            limit = 0;
            int y = str - 1;
            for (int i = str - 1; i > limit; i--)
            {
                    count = 0;
                    for (int j = 0; j < st; j++)
                    {
                        try
                        {
                            if (field[i, j] != null) count++;
                            //Записываем на уровень ниже если все ячейки были заняты, иначе перезапись
                            field[y, j] = field[i, j];
                        }
                        catch (IndexOutOfRangeException)
                        {
                            field[y, j] = null;
                        }
                    }

                    if (count < st) y--;
                    else limit--;

                    if (count == st) { lines++; score += 100; }

                    if (lines == coefForSpeed)
                    {
                        int temp = 1000 - coefForSpeed * 20; //fix
                        if (temp <= 0) 
                            temp = 10;

                        timer.Interval = temp;
                        coefForSpeed += 10;
                    }
                } // end first for
        }     

        void DrawField(Graphics gr)
        {           
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < st; j++)
                {
                    if(field[i, j] != null)                        
                        gr.FillRectangle(field[i, j], new Rectangle(j * cell_size + 1, i * cell_size + 1, cell_size - 1, cell_size - 1));
                }               
            }
        }    

        void DrawFigure(Graphics gr, Point[] osn, byte cell_size, int color)
        {
            for (int i = 0; i < 4; i++)
            {
                gr.FillRectangle(new SolidBrush(br_color[color]), new Rectangle(osn[i].X * cell_size + 1, osn[i].Y * cell_size + 1, cell_size - 1, cell_size - 1));
            }        
        }

        void Rotate()
        {
            // remember the past position
            osn.CopyTo(buf, 0);

            int x, y;
                 
            Point center =  new Point(osn[2].X, osn[2].Y);
               
            for (int i = 0; i < 4; i++)
            {
                x = osn[i].Y - center.Y;
                y = osn[i].X - center.X;
                osn[i].X = center.X - x;
                osn[i].Y = center.Y + y;
            }

            isShift();
        }
    #endregion

        #region Keyboard
        const int WM_KEYDOWN = 0x100;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (game == Game.Pausa)
                return true;

            if (msg.Msg == WM_KEYDOWN)
            {
                switch (keyData)
                {
                    case Keys.Down:
                        Shift(0, 1);
                        panel2.Invalidate();
                        break;
                    case Keys.Up:
                        Rotate();
                        panel2.Invalidate();
                        break;
                    case Keys.Left:
                        Shift(-1, 0);
                        panel2.Invalidate();
                        break;
                    case Keys.Right:
                        Shift(1, 0);
                        panel2.Invalidate();
                        break;
                }
            }

            return true;
        }

        #endregion

        #region Panels
        private void MyPanel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            User.Text = "User";
            LVL.Text = level + "";
            SCR.Text = score + "";
            LINE.Text = lines + "";
            FIG.Invalidate();
        }

        private void MyPanel2_Paint(object sender, PaintEventArgs e)
        {
            if (game == Game.Pausa)
                return;

            base.OnPaint(e);
            Graphics gr = e.Graphics;

            isLine();
            if (next)
            {
                FormFigure(new Point(st / 3, 0), osn, false);     
                FormFigure(new Point(2, 1), pre_osn);               
                panel3.Invalidate();
                next = false;
            }

            DrawFigure(gr, osn, cell_size, rand_br_color);
            DrawField(gr);
        }

        private void FIG_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            DrawFigure(gr, pre_osn, 20, rand_br_color);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (this.button1.Text == "Play")
            {
                this.button1.Text = "Pausa";
                game = Game.Play;
            }
            else
            {
                this.button1.Text = "Play";
                game = Game.Pausa;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            game = Game.Pausa;
            if(form3.ShowDialog() == DialogResult.OK)
            {
                timer.Start();
                game = Game.Play;
            }
        }
        #endregion

        #region Buttons
        private void button2_Click(object sender, EventArgs e)
        {
            Initialize();
            timer.Start();
            panel2.Invalidate();
        }
        #endregion

        #region Mouse responses
            private void panel1_MouseDown(object sender, MouseEventArgs e)
            {
                //WM_NCLBUTTONDOWN == 0x00A1
                // HTCAPTION 2 (indicate that we click on the title of the form) --> IntPtr(2) 
                // IntPtr - A platform-defined type that is used to represent a pointer or handle.
                this.panel1.Capture = false;
                    Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                    this.WndProc(ref message);
            }

            protected override void OnMouseDown(MouseEventArgs e)
            {
                base.OnMouseDown(e);
            }

            private void Exit1_MouseEnter(object sender, EventArgs e)
            {
                this.Exit1.BackgroundImage = global::Tet.Properties.Resources.Exit1;
            }

            private void Exit1_MouseLeave(object sender, EventArgs e)
            {
                this.Exit1.BackgroundImage = global::Tet.Properties.Resources.Exit;
            }

            private void Exit1_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        #endregion

    }

    class MyPanel : Panel
    {
        public MyPanel()
        {
            DoubleBuffered = true;
        }
    }
}
