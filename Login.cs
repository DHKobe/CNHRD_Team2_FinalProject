using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNHRD_Team2_FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //화면 중앙에 창 띄우기
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(tbID.Text == "team2" && tbPW.Text == "team2final")
            {
                MainPage mainPageForm = new MainPage();
                mainPageForm.Show();
                this.Hide();
            }
        }
    }
}
