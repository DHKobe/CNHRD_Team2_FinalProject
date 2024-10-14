using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNHRD_Team2_FinalProject
{
    public partial class testpage : Form
    {
        public testpage()
        {
            InitializeComponent();
        }

        public static void SelectMysql()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=team2_final;Uid=root;Pwd=team2final"))
            {
                try//예외 처리
                {
                    connection.Open();
                    string sql = "SELECT * FROM loading_process";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader table = cmd.ExecuteReader();

                    while (table.Read())
                    {
                        Debug.WriteLine("{0} {1} {2}", table["load_id"], table["count_loading"], table["pos_loading"]);
                    }
                    table.Close();

                }
                catch (Exception ex)
                {
                    Debug.WriteLine("실패");
                    Debug.WriteLine(ex.ToString());
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectMysql();
        }
    }
}
