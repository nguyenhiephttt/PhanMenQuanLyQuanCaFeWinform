using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // gõ thêm vào dòng này 

// chạy file .wav 

namespace QUANCAFFE
{
    public partial class HenGioTatMay : Form
    {
        public HenGioTatMay()
        {
            InitializeComponent();
        }

        private void nudGiay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nudGiay = sender as NumericUpDown;
            if (nudGiay.Value >= 60)
            {
                nudPhut.Value += 1;
                nudGiay.Value = 0;
            }
        }

        private void nudPhut_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown phut = sender as NumericUpDown;
            if (phut.Value >= 60)
            {
                nudGio.Value += 1;
                phut.Value = 0;
            }
        }

        void Shutdown(string command)
        {
            System.Diagnostics.Process.Start("shutdown", command);
        }
        private void HenGioTatMay_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shutdown("-a");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shutdown("-r -t "+60);

        }

        private void btnShutDow_Click(object sender, EventArgs e)
        {
            //while (true)
            //{
                int gio = DateTime.Now.Hour;
                int phut = DateTime.Now.Minute;
                int giay = DateTime.Now.Second;
            //System.Diagnostics.Process.Start("a.mid");
            SoundPlayer sound = new SoundPlayer("ALitll Lovechangmi.mp3");
            sound.LoadAsync();
            sound.Play();
            //if (gio == nudGio.Value && phut == nudPhut.Value
            //    )
            //{
            SoundPlayer simpleSound = new SoundPlayer(@"ALitlleLovechangmi.mp3");
                    simpleSound.Play();
                    //MessageBox.Show("Hello Bui ngoc danh, Bay gio la "+gio+" gio "+ phut + " phut "+giay+ " giay");
              //  }
           // }
            
          

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //lay gio hien tai

    }
}
