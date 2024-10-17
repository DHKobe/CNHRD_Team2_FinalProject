using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types;

namespace CNHRD_Team2_FinalProject
{
    public partial class Monitoring : Form
    {
        public Monitoring()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //화면 중앙에 창 띄우기
            combobox_init();

            //이벤트 핸들러(콤보박스 입력 차단)
            cb_monitoring.KeyPress += ComboBox_KeyPress;
            cb_productionlist.KeyPress += ComboBox_KeyPress;
            cb_operation.KeyPress += ComboBox_KeyPress;
            cb_employees.KeyPress += ComboBox_KeyPress;

            //클릭 이벤트 핸들러 추가
            cb_monitoring.Click += ComboBox_Click;
            cb_productionlist.Click += ComboBox_Click;
            cb_operation.Click += ComboBox_Click;
            cb_employees.Click += ComboBox_Click;

            //SelectedIndexChanged 이벤트 핸들러 추가
            cb_monitoring.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cb_productionlist.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cb_operation.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cb_employees.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            //로그인 버튼 클릭 이벤트 핸들러 추가
            bt_logout.Click += Bt_logout_Click;

            //로고 버튼 클릭 이벤트핸들러 추가
            pb_logo.Click += Pb_logo_Click;
        }

        private void combobox_init()
        {
            cb_monitoring.Items.Add("모니터링");
            cb_productionlist.Items.Add("생산목록");
            cb_operation.Items.Add("가동현황");
            cb_operation.Items.Add("발생이벤트");
            cb_employees.Items.Add("직원관리");
        }

        //콤보박스 입력차단 이벤트 함수
        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBox_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            comboBox.DroppedDown = true; //드롭다운 열기
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            //모니터링 항목이 선택시
            if (comboBox.SelectedItem.ToString() == "모니터링")
            {
                //Monitoring 폼 열기
                Monitoring monitoringForm = new Monitoring();
                monitoringForm.Show(); //모니터링폼 열기
                this.Close(); //현재 창 숨기기
            }
            //생산목록 항목 선택시
            else if (comboBox.SelectedItem.ToString() == "생산목록")
            {
                //생산목록 폼 열기
                ProductionList productionListForm = new ProductionList();
                productionListForm.Show();
                this.Close(); //현재 창 숨기기
            }
            //가동분석 항목 선택시
            else if (comboBox.SelectedItem.ToString() == "가동현황")
            {
                //가동현황 폼 열기
                CurrentOperation currentOperationForm = new CurrentOperation();
                currentOperationForm.Show();
                this.Close(); //현재 창 숨기기
            }
            else if (comboBox.SelectedItem.ToString() == "발생이벤트")
            {
                //발생이벤트 폼 열기
                OperationDowntime operationDowntime = new OperationDowntime();
                operationDowntime.Show();
                this.Close(); //현재 창 숨기기
            }
            else if (comboBox.SelectedItem.ToString() == "직원관리")
            {
                //직원관리 폼 열기
                Employees employeesForm = new Employees();
                employeesForm.Show();
                this.Close();
            }
        }

        private void Bt_logout_Click(object sender, EventArgs e)
        {

            //로그인 폼 열기
            Login loginForm = new Login();
            loginForm.Show();
            this.Close(); //현재 창 숨기기
        }
        private void Pb_logo_Click(object sender, EventArgs e)
        { 
            //현재 폼을 닫고 새로운 MainPage를 시작
            this.Close(); //현재 모니터링 폼 닫기
            MainPage mainPage = new MainPage(); //새 인스턴스 생성
            mainPage.Show(); //새로운 메인 폼 보여주기
        }
    }
}
