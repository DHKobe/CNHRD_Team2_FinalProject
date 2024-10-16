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
    public partial class MainPage : Form
    {
        private string[] images;
        private int currentIndex = 0;
        private Timer imageSwitchTimer;
        public MainPage()
        {
            InitializeComponent();
            LoadImages();
            combobox_init();

            //Timer 설정
            imageSwitchTimer = new Timer();
            imageSwitchTimer.Interval = 3000; //3초 간격 부여
            imageSwitchTimer.Tick += ImageSwitchTimer_Tick;
            imageSwitchTimer.Start();

            //초기 이미지 설정
            pb_mainimage.Image = Image.FromFile(images[currentIndex]);

            //로고 클릭 이벤트핸들러
            pb_logo.Click += Pb_logo_Click;

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
            bt_login.Click += Bt_login_Click;
        }

        private void combobox_init()
        {
            cb_monitoring.Items.Add("모니터링");
            cb_productionlist.Items.Add("생산목록");
            cb_operation.Items.Add("가동현황");
            cb_operation.Items.Add("비가동현황");
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

        private void LoadImages()
        {
            string basePath = System.Environment.CurrentDirectory + @"\picture_rss\";
            images = new string[]
            {
                basePath + "main1.jpg",
                basePath + "main2.jpg",
                basePath + "main3.jpg",
                basePath + "main4.jpg",
                basePath + "main5.jpg"
            };

            // 이미지 로드 확인
            foreach (var image in images)
            {
                if (!System.IO.File.Exists(image))
                {
                    throw new Exception($"Image not found: {image}");
                }
            }

        }
        private void ImageSwitchTimer_Tick(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % images.Length; //메인화면 이미지 변경루틴
            pb_mainimage.Image = Image.FromFile(images[currentIndex]);
        }

        private void Pb_logo_Click(object sender, EventArgs e)
        {
            this.Hide(); //현재 폼 닫기
            MainPage newMainPage = new MainPage(); //새 인스턴스 생성
            newMainPage.Show(); //새로운 메인 폼 보여주기

            /*this.Show(); // 메인 페이지를 다시 보이게 함
            this.BringToFront(); // 메인 페이지를 최상위로 가져옴
            */
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
                this.Hide(); //현재 창 숨기기
            }
            //생산목록 항목 선택시
            else if (comboBox.SelectedItem.ToString() == "생산목록")
            {
                //생산목록 폼 열기
                ProductionList productionListForm = new ProductionList();
                productionListForm.Show();
                this.Hide(); //현재 창 숨기기
            }
            //가동분석 항목 선택시
            else if(comboBox.SelectedItem.ToString() == "가동현황")
            {
                //가동현황 폼 열기
                CurrentOperation currentOperationForm = new CurrentOperation();
                currentOperationForm.Show();
                this.Hide(); //현재 창 숨기기
            }
            else if(comboBox.SelectedItem.ToString() == "비가동현황"){ 
                //비가동현황 폼 열기
                OperationDowntime operationDowntime = new OperationDowntime();
                operationDowntime.Show();
                this.Hide(); //현재 창 숨기기
            }
            else if(comboBox.SelectedItem.ToString() == "직원관리"){ 
                //직원관리 폼 열기
                Employees employeesForm = new Employees();
                employeesForm.Show();
                this.Hide();
            }
        }

        private void Bt_login_Click(object sender, EventArgs e) { 
        
            //로그인 폼 열기
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
