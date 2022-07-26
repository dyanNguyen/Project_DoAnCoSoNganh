using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.IO;
using System.Reflection;
using WMPLib;
namespace AiLaTrieuPhu
{
    class C_AmThanh
    {
        //private static WMPLib.WindowsMediaPlayer sound = new WMPLib.WindowsMediaPlayer();
        //private static WMPLib.WindowsMediaPlayer player;
        //bật âm thanh
        public static void batAmThanh(string ten)
        {
            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Audio\"+ten+ ".mp3");
            //player = new WindowsMediaPlayer();
            //FileInfo fileInfo = new FileInfo(path);
            //player.URL = fileInfo.Name;
            //player.controls.play();
            ////sound.URL = @"Audio\" + ten + ".mp3";
            ////sound.controls.play();

            //thêm đường dẫn thư mục Audio
            SoundPlayer Sound = new SoundPlayer(soundLocation: @"C:\Users\ASUS\DoAnCoSoNganh\AiLaTrieuPhu\Resources\Audio\" + ten );
            Sound.Play();
        }

        //chèn kí tự xuống dòng vào một xâu
        public static string chenXuongDong(string chen, int viTri)
        {
            while (true)
            {
                if (string.Equals(chen[viTri].ToString(), " "))
                    break;
                else
                {
                    if (string.Equals(chen[viTri].ToString(), "?"))
                        return chen;
                    else
                        viTri++;
                }
            }
            return chen = chen.Insert(viTri, "\n");
        }

        //Loại bỏ kí tự *** trong đáp án
        public static string loaiDauSao(string s)
        {
            if (s[s.Length - 1].ToString() == "*")
            {
                s = s.Substring(0, s.Length - 3);

            }

            return s;
        }

        //Kiểm tra câu hỏi có bị trùng không nếu trùng trả về true ngược lại false
        public static bool kiemTraCauHoi(int t, int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (t == a[i])
                    return true;
            }

            return false;
        }
    }
}
