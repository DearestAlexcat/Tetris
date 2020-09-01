using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tet
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = global::Tet.Properties.Resources.Exit1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = global::Tet.Properties.Resources.Exit;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            //WM_NCLBUTTONDOWN == 0x00A1
            // HTCAPTION 2 (указываем что кликаем по заголовку формы) --> IntPtr(2) 
            // IntPtr - Определяемый платформой тип, который используется для представления указателя или дескриптора.
            this.panel1.Capture = false;
            Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref message);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        
    }
}
