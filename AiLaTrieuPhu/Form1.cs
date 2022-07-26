using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AiLaTrieuPhu
{
    public partial class FmChinh : Form
    {
        public FmChinh()
        {
            InitializeComponent();
        }

        private int bang = 1, c = 0;
        int cs = 0;
        int[] MangRandom = new int[5];
        bool ok = true;

        private static Random r = new Random();

        private int i;

        private void FmChinh_Load(object sender, EventArgs e)
        {
            ptbThuaCuoc.Hide();
            lbTienThuong.Hide();
            lbYourScore.Hide();
            
        }

        private void btA_Click_1(object sender, EventArgs e)
        {
            if (ok)
            {
                ok = false;
                //đổi màu nút bấm A và label
                btA.BackColor = Color.Orange;
                lbA.BackColor = Color.Orange;

                btB.Enabled = false;
                btC.Enabled = false;
                btD.Enabled = false;

                //Bây giờ là lúc tôi đưa ra câu trả lời đúng
                C_AmThanh.batAmThanh("answer_t.wav");
                //nếu trả lời đúng thì chuyển câu
                if (String.Equals(C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i), "A"))
                {
                    tmTraLoiDung.Enabled = true;
                    tmChuyenCau.Enabled = true;
                }//ngược lại thì tìm đáp án đúng
                else
                {
                    tmTimDapAn.Enabled = true;
                }
            }
        }

        private void btB_Click(object sender, EventArgs e)
        {
            if (ok)
            {
                ok = false;
                //đổi màu nút bấm B và label
                btB.BackColor = Color.Orange;
                lbB.BackColor = Color.Orange;

                btA.Enabled = false;
                btC.Enabled = false;
                btD.Enabled = false;

                //Bây giờ là lúc tôi đưa ra câu trả lời đúng
                C_AmThanh.batAmThanh("answer_t.wav");

                //nếu trả lời đúng thì chuyển câu
                if (String.Equals(C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i), "B"))
                {
                    tmTraLoiDung.Enabled = true;
                    tmChuyenCau.Enabled = true;
                }
                //ngược lại thì tìm đáp án đúng
                else
                {
                    tmTimDapAn.Enabled = true;
                }
            }
        }

        private void btC_Click(object sender, EventArgs e)
        {
            if (ok)
            {
                ok = false;
                //đổi màu nút bấm C và label
                btC.BackColor = Color.Orange;
                lbC.BackColor = Color.Orange;

                btA.Enabled = false;
                btB.Enabled = false;
                btD.Enabled = false;

                //Bây giờ là lúc tôi đưa ra câu trả lời đúng
                C_AmThanh.batAmThanh("answer_t.wav");

                //nếu trả lời đúng thì chuyển câu
                if (String.Equals(C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i), "C"))
                {
                    tmTraLoiDung.Enabled = true;
                    tmChuyenCau.Enabled = true;
                }
                //ngược lại thì tìm đáp án đúng
                else
                {
                    tmTimDapAn.Enabled = true;
                }
            }
        }

        private void btD_Click(object sender, EventArgs e)
        {
            if (ok)
            {
                ok = false;
                //đổi màu nút bấm B và label
                btD.BackColor = Color.Orange;
                lbD.BackColor = Color.Orange;

                btA.Enabled = false;
                btB.Enabled = false;
                btC.Enabled = false;

                //Bây giờ là lúc tôi đưa ra câu trả lời đúng
                C_AmThanh.batAmThanh("answer_t.wav");

                //nếu trả lời đúng thì chuyển câu
                if (String.Equals(C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i), "D"))
                {

                    tmTraLoiDung.Enabled = true;
                    tmChuyenCau.Enabled = true;
                }
                //ngược lại thì tìm đáp án đúng
                else
                {
                    tmTimDapAn.Enabled = true;
                }
            }
        }

        private void tmTimDapAn_Tick(object sender, EventArgs e)
        {
            //nếu text của lbA trùng với đáp án trong CSDL thì đổi màu nút bấm A
            if (lbA.Text == C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i))
            {
                btA.BackColor = Color.LimeGreen;
                lbA.BackColor = Color.LimeGreen;
            }
            //nếu text của lbB trùng với đáp án trong CSDL thì đổi màu nút bấm B
            if (lbB.Text == C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i))
            {
                btB.BackColor = Color.LimeGreen;
                lbB.BackColor = Color.LimeGreen;
            }
            //nếu text của lbC trùng với đáp án trong CSDL thì đổi màu nút bấm C
            if (lbC.Text == C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i))
            {
                btC.BackColor = Color.LimeGreen;
                lbC.BackColor = Color.LimeGreen;
            }
            //nếu text của lbD trùng với đáp án trong CSDL thì đổi màu nút bấm D
            if (lbD.Text == C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i))
            {
                btD.BackColor = Color.LimeGreen;
                lbD.BackColor = Color.LimeGreen;
            }

            //bật âm thanh trả lời sai
            C_AmThanh.batAmThanh("bgmusic_answer_f1.wav");

            bt5050.Enabled = false;
            btDung.Enabled = false;

            btA.Enabled = false;
            btB.Enabled = false;
            btC.Enabled = false;
            btD.Enabled = false;

            tmTimDapAn.Enabled = false;

            tmThuaCuoc.Enabled = true;
        }

        private void tmChuyenCau_Tick(object sender, EventArgs e)
        {
            //nếu câu tăng lên bằng 16 tức người chơi trả lời hết thì dừng
            if (c == 16)
            {
                lbTienThuong.Text = "150.000.000";
                tmChuyenCau.Enabled = false; 
            }

            ok = true;

            //Cho phép lại các nút bấm
            btB.Enabled = true;
            btC.Enabled = true;
            btA.Enabled = true;
            btD.Enabled = true;

            //Chuyển lại màu nút đáp an
            btA.BackColor = Color.Blue;
            btB.BackColor = Color.Blue;
            btC.BackColor = Color.Blue;
            btD.BackColor = Color.Blue;

            //Chuyển màu nền label
            lbA.BackColor = Color.Blue;
            lbB.BackColor = Color.Blue;
            lbC.BackColor = Color.Blue;
            lbD.BackColor = Color.Blue;

            //tăng câu hỏi lên
            c++;
            lbSoCau.Text = "Câu " + c.ToString();

            //Đọc số câu hỏi
            //string cauHoi = "start_cau" + c.ToString();
            //C_AmThanh.batAmThanh(cauHoi);

            //Đọc câu hỏi và các phương án
            tmCauHoi.Enabled = true;

            #region đổi màu các mốc câu hỏi
            if (c == 1)
            {
                lb1.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

                lbTienThuong.Text = "Không";

            }

            if (c == 2)
            {
                lb2.BackColor = Color.Orange;

                lb1.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

                lbTienThuong.Text = "200.000";

            }
            if (c == 3)
            {
                lbTienThuong.Text = "400.000";
                lb3.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 4)
            {
                lbTienThuong.Text = "600.000";
                lb4.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 5)
            {
                lbTienThuong.Text = "1.000.000";
                lb5.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 6)
            {
                lbTienThuong.Text = "2.000.000";
                lb6.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 7)
            {
                lbTienThuong.Text = "3.000.000";
                lb7.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 8)
            {
                lbTienThuong.Text = "6.000.000";
                lb8.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 9)
            {
                lbTienThuong.Text = "10.000.000";
                lb9.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 10)
            {
                lbTienThuong.Text = "14.000.000";
                lb10.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 11)
            {
                lbTienThuong.Text = "22.000.000";
                lb11.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 12)
            {
                lbTienThuong.Text = "30.000.000";
                lb12.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 13)
            {
                lbTienThuong.Text = "40.000.000";
                lb13.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 14)
            {
                lbTienThuong.Text = "60.000.000";
                lb14.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 15)
            {
                lbTienThuong.Text = "80.000.000";
                lb15.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;

            }

            #endregion

            //đạt mốc 5 thì lấy dữ liệu câu hỏi bảng 2(khó dần lên)
            if (c == 6)
                bang = 2;

            //đạt mốc 10 thì lấy dữ liệu câu hỏi bảng 3(khó dần lên)
            if (c == 11)
                bang = 3;

            //lấy câu hỏi random trong bảng 1
            if (bang == 1)
            {
                do i = r.Next(1, 339);
                while (C_AmThanh.kiemTraCauHoi(i, MangRandom));

                //dùng mảng lưu lại kết quả random nếu trùng thì random lại
                MangRandom[cs] = i;
                cs++;

                if (c == 5)
                {
                    cs = 0;
                    MangRandom = new int[5];
                }

            }
            //lấy câu hỏi random trong bảng 2
            if (bang == 2)
            {
                do i = r.Next(1, 84);
                while (C_AmThanh.kiemTraCauHoi(i, MangRandom));

                //dùng mảng lưu lại kết quả random nếu trùng thì random lại
                MangRandom[cs] = i;
                cs++;
                if (c == 10)
                {
                    cs = 0;
                    MangRandom = new int[5];
                }

            }
            //lấy câu hỏi random trong bảng 3
            if (bang == 3)
            {
                do i = r.Next(1, 70);
                while (C_AmThanh.kiemTraCauHoi(i, MangRandom));

                //dùng mảng lưu lại kết quả random nếu trùng thì random lại
                MangRandom[cs] = i;
                cs++;
            }

            //Lấy dữ liệu lên câu hỏi, nếu độ dài câu hỏi vượt 50 kí tự thì cho xuống dòng
            string CauHoi = C_KetNoi.layDuLieu("SELECT CauHoi FROM tbl" + bang.ToString(), "CauHoi", i);
            if (CauHoi.Length >= 50)
            {
                lbCauHoi.Text = C_AmThanh.chenXuongDong(CauHoi, 50);
            }
            else
                lbCauHoi.Text = CauHoi;

            //Lấy dữ liệu lên các nút bấm
            btA.Text = C_AmThanh.loaiDauSao(C_KetNoi.layDuLieu("SELECT A FROM tbl" + bang.ToString(), "A", i));
            btB.Text = C_AmThanh.loaiDauSao(C_KetNoi.layDuLieu("SELECT B FROM tbl" + bang.ToString(), "B", i));
            btC.Text = C_AmThanh.loaiDauSao(C_KetNoi.layDuLieu("SELECT C FROM tbl" + bang.ToString(), "C", i));
            btD.Text = C_AmThanh.loaiDauSao(C_KetNoi.layDuLieu("SELECT D FROM tbl" + bang.ToString(), "D", i));

            tmChuyenCau.Interval = 5000;
            tmChuyenCau.Enabled = false;
        }

        private void tmTraLoiDung_Tick(object sender, EventArgs e)
        {
            //Âm thanh trả lời đúng
            C_AmThanh.batAmThanh("bgmusic_answer_t1.wav");

            //Đổi màu nền nút đáp an đúng
            if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) == "A")
            {
                btA.BackColor = Color.LimeGreen;
                lbA.BackColor = Color.LimeGreen;
            }
            if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) == "B")
            {
                btB.BackColor = Color.LimeGreen;
                lbB.BackColor = Color.LimeGreen;
            }
            if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) == "C")
            {
                btC.BackColor = Color.LimeGreen;
                lbC.BackColor = Color.LimeGreen;
            }
            if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) == "D")
            {
                btD.BackColor = Color.LimeGreen;
                lbD.BackColor = Color.LimeGreen;
            }

            tmTraLoiDung.Enabled = false;
        }

        //bấm play
        private void tmBatDau_Tick(object sender, EventArgs e)
        {
            //Hiện 4 nút chọn đáp án
            btA.Show();
            btB.Show();
            btC.Show();
            btD.Show();

            lbA.Text = "A";
            lbB.Text = "B";
            lbC.Text = "C";
            lbD.Text = "D";

            tmBatDau.Enabled = false;
        }
        //trợ giúp 50 50
        private void tm5050_Tick(object sender, EventArgs e)
        {
            int a = 0;

            while (a != 2)
            {
                if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) != lbA.Text)
                {
                    btA.Text = "";
                    btA.Enabled = false;
                    a++;
                    if (a == 2) break;
                }
                if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) != lbD.Text)
                {
                    btD.Text = "";
                    btD.Enabled = false;
                    a++;
                    if (a == 2) break;
                }
                if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) != lbB.Text)
                {
                    btB.Text = "";
                    btB.Enabled = false;
                    a++;
                    if (a == 2) break;
                }
                if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) != lbC.Text)
                {
                    btC.Text = "";
                    btC.Enabled = false;
                    a++;
                    if (a == 2) break;
                }

            }

            tm5050.Enabled = false;
        }
        ////đọc câu hỏi và các phương án trả lời
        private void tmCauHoi_Tick(object sender, EventArgs e) { }
        //{
        //    //Lấy tiêu đề âm thanh trong bảng để bật đúng âm thanh
        //    string AmThanh = C_KetNoi.layDuLieu("SELECT AmThanh FROM tbl" + bang.ToString(), "AmThanh", i);
        //    AmThanh = AmThanh.Trim();
        //    //bật nhạc
        //    C_AmThanh.batAmThanh(AmThanh);

        //    tmCauHoi.Enabled = false;
        //}

        public static FmKhoiDong fmKhoiDong = new FmKhoiDong();
        //chơi lại
        private void tmChoiLai_Tick(object sender, EventArgs e)
        {
            bang = 1;
            c = 0;

            cs = 0;
            MangRandom = new int[5];

            bt5050.Enabled = true;
            btDung.Enabled = true;

            btA.Enabled = true;
            btB.Enabled = true;
            btC.Enabled = true;
            btD.Enabled = true;

            ptbThuaCuoc.Hide();
            lbTienThuong.Hide();
            lbYourScore.Hide();

            fmKhoiDong.Show();
            fmKhoiDong.btBatDau.Show();
            this.Hide();

            tmChoiLai.Enabled = false;
        }

        //trợ giúp 50 50
        private void bt5050_Click(object sender, EventArgs e)
        {
            C_AmThanh.batAmThanh("sound_trogiup_50_50_1.wav");

            tm5050.Enabled = true;

            bt5050.Enabled = false;
        }

        //trợ giúp dừng chơi
        private void btDung_Click(object sender, EventArgs e)
        {
            bt5050.Enabled = false;
            btDung.Enabled = false;

            btA.Enabled = false;
            btB.Enabled = false;
            btC.Enabled = false;
            btD.Enabled = false;

            tmThuaCuoc.Enabled = true;
        }

        //dê chuột vào Dừng cuộc chơi
        private void btDung_MouseHover(object sender, EventArgs e)
        {
            C_AmThanh.batAmThanh("tro_giup_dung_choi1.wav");
        }

        //dê chuột vào trợ giúp 50, 50
        private void bt5050_MouseHover(object sender, EventArgs e)
        {
            C_AmThanh.batAmThanh("sound_chon_50_50_1.wav");
        }

        //sau khi thua cuộc
        private void tmThuaCuoc_Tick(object sender, EventArgs e)
        {
            C_AmThanh.batAmThanh("sound_ket_thuc1.wav");

            ptbThuaCuoc.Show();
            lbTienThuong.Show();
            lbYourScore.Show();
            

            tmChoiLai.Enabled = true;
            tmThuaCuoc.Enabled = false;
        }

        private void ptbThuaCuoc_Click(object sender, EventArgs e)
        {
            tmChoiLai.Enabled = false;
            tmChoiNgay.Enabled = true;
        }

        private void tmChoiNgay_Tick(object sender, EventArgs e)
        {

            tmChuyenCau.Interval = 100;
            tmChuyenCau.Enabled = true;

            bang = 1;
            c = 0;

            cs = 0;
            MangRandom = new int[5];

            bt5050.Enabled = true;
            btDung.Enabled = true;

            btA.Enabled = true;
            btB.Enabled = true;
            btC.Enabled = true;
            btD.Enabled = true;

            ptbThuaCuoc.Hide();
            lbTienThuong.Hide();
            lbYourScore.Hide();
            tmChoiNgay.Enabled = false;
        }

        private void FmChinh_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            C_KetNoi.dongKetNoi();
            Application.Exit();
        }


    }
}
