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
        private int attemptCount = 0; //로그인 시도 횟수

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //화면 중앙에 창 띄우기
            tbPW.KeyPress += new KeyPressEventHandler(tbPW_KeyPress); //KeyPress 이벤트 연결
            lb_hint.Visible = false; //힌트 라벨 숨기기
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "team2" && tbPW.Text == "team2final")
            {
                attemptCount = 0; //로그인 성공 시 시도 횟수 초기화
                MainPage mainPageForm = new MainPage();
                mainPageForm.Show();
                this.Hide();
            }
            else
            {
                attemptCount++; //로그인 시도 횟수 증가

                if (attemptCount <= 3)
                {
                    //경고 메시지 박스 표시
                    MessageBox.Show("아이디 또는 비밀번호가 다릅니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (attemptCount >= 3)
                {
                    //3번째 시도 시 힌트 메시지 설정
                    lb_hint.Text = "힌트: team2 // team2final"; //힌트 메시지
                    lb_hint.Visible = true; //힌트 라벨 보이기
                }
            }
        }

        private void tbPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            //엔터 키가 눌렸는지 확인
            if (e.KeyChar == (char)Keys.Enter)
            {
                //로그인 버튼 클릭 이벤트 호출
                btLogin_Click(sender, e);
            }
        }
    }
}
