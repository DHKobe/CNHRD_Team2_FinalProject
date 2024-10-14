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
    public partial class MainPage : Form
    {
        private string[] images;
        private int currentIndex = 0;
        private Timer imageSwitchTimer;

        public MainPage()
        {
            InitializeComponent();
            LoadImages();

            // Timer 설정
            imageSwitchTimer = new Timer();
            imageSwitchTimer.Interval = 3000; // 3초 간격
            imageSwitchTimer.Tick += ImageSwitchTimer_Tick;
            imageSwitchTimer.Start();

            // 초기 이미지 설정
            pb_mainimage.Image = Image.FromFile(images[currentIndex]);
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
            currentIndex = (currentIndex + 1) % images.Length; // 이미지 순환
            pb_mainimage.Image = Image.FromFile(images[currentIndex]);
        }
    }
}
