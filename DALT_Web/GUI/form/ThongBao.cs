using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.form
{
    public partial class ThongBao: Form
    {
        private string tb;
        public ThongBao( string mess)
        {
            tb = mess;
            InitializeComponent();
            lb_thongBao.Text = tb;

            t_in.Interval = 1000; 
            t_in.Tick += t_in_Tick;
            t_in.Start();
            

            t_out.Interval = 50; 
            t_out.Tick += t_out_Tick;

        }

        private void ThongBao_Load(object sender, EventArgs e)
        {

        }

        private void t_in_Tick(object sender, EventArgs e)
        {
            t_in.Stop();
            t_out.Start();
        }

        private void t_out_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0) 
            {
                this.Opacity -= 0.05;
            }
            else
            {
                t_out.Stop();
                this.Close();
            }
        }

       
    }
}
