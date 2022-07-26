using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace AiLaTrieuPhu
{
    public partial class FmKhoiDong : Form
    {
        public static FmChinh fmChinh = new FmChinh();

        public FmKhoiDong()
        {
            InitializeComponent();
        }

        private void FmKhoiDong_Load(object sender, EventArgs e)
        {
            //SoundPlayer Sound = new SoundPlayer(@"D:\dacsn\AiLaTrieuPhu\AiLaTrieuPhu\Resources\Audio\mo_dau_game1.wav");
            //Sound.Play();
            //btSanSang.Hide();
            //btBatDau.Show();

            C_AmThanh.batAmThanh("mo_dau_game1.wav");
            btBatDau.Show();
            btSanSang.Hide();
        }

        private void tmBatDauChoi_Tick(object sender, EventArgs e)
        {
            //ẩn from khởi động
            this.Hide();
            //hiện from chính để chơi
            fmChinh.Show();
            tmBatDauChoi.Enabled = false;
        }

        private void FmKhoiDong_FormClosed(object sender, FormClosedEventArgs e)
        {
            C_KetNoi.dongKetNoi();
            Application.Exit();
        }

        private void btBatDau_Click(object sender, EventArgs e)
        {
            //Bật nhạc
            C_AmThanh.batAmThanh("san_sang_choi_chua1.wav");
            btSanSang.Show();
            btBatDau.Hide();
            C_KetNoi.ketNoi();
        }

        private void btSanSang_Click(object sender, EventArgs e)
        {
            //bật nhạc
            C_AmThanh.batAmThanh("nguoi_choi_ss1.wav");

            btSanSang.Hide();

            fmChinh.tmBatDau.Enabled = true;
            //chuyển câu hỏi đến
            fmChinh.tmChuyenCau.Enabled = true;

            tmBatDauChoi.Enabled = true;
        }

        private void ptbKhoiDong_Click(object sender, EventArgs e)
        {

        }


    }
}
