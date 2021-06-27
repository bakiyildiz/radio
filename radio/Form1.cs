using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems[0].Text == "Radyo Mydonose")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/radyo_mydonose.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Pal FM")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/pal_fm.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Power FM")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/power_fm.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Number One FM")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/number_one_fm.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Metro FM")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/metro_fm.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Slow Türk")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/slow_turk.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "CNN Türk Radyo")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/cnn_turk_radyo.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Ntv Spor Radyo")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/ntv_spor_radyo.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Seymen FM")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/seymen_fm.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Kral Pop")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/kral_pop.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Radyo D")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/radyo_d.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Radyo Viva")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/radyo_viva.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Süper FM")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/super_fm.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Best FM")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/best_fm.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "PowerTürk")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/power_turk.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Show Radyo")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/show_radyo.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Radyo Müzik")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/radyo_muzik.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Joy Türk")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/joy_turk.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Baba Radyo")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/baba_radyo.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Efkar Radyo")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/efkar_radyo.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Damar FM")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/damar_fm.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Virgin Radyo")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/virgin_radyo.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Joy FM")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/joy_fm.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Pal Station")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/pal_station.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Can Radyo")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/can_radyo.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Pal Doğa Radyo")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/pal_doga_radyo.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
                else if (listView1.SelectedItems[0].Text == "Ostim Radyo")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/ostim_radyo.m3u";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    label4.Text = "Radyo - " + listView1.SelectedItems[0].Text;
                }
            }
            catch (Exception)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
            }
            catch (Exception)
            {
            }
        }

        int resim = 1;
        int durum = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath graphicpath = new GraphicsPath();
            graphicpath.StartFigure();
            graphicpath.AddArc(0, 0, 10, 10, 180, 90);
            graphicpath.AddLine(10, 0, this.Width - 10, 0);
            graphicpath.AddArc(this.Width - 10, 0, 10, 10, 270, 90);
            graphicpath.AddLine(this.Width, 10, this.Width, this.Height - 10);
            graphicpath.AddArc(this.Width - 10, this.Height - 10, 10, 10, 0, 90);
            graphicpath.AddLine(this.Width - 10, this.Height, 10, this.Height);
            graphicpath.AddArc(0, this.Height - 10, 10, 10, 90, 90);
            graphicpath.CloseFigure();
            this.Region = new Region(graphicpath);


            resim = Properties.Settings.Default.photo;
            gorsel.settings.setMode("loop", true);
            ses.Value = 10;
            resimguncelle();
        }

        void resimguncelle()
        {
            if (durum == 1)
            {
                if (resim == 1)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/playing-1.gif";
                }
                else if (resim == 2)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/playing-2.gif";
                }
                else if (resim == 3)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/playing-3.gif";
                }
                else if (resim == 4)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/playing-4.gif";
                }
                else if (resim == 5)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/playing-5.gif";
                }
                else if (resim == 6)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/playing-6.gif";
                }
                else if (resim == 7)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/playing-7.gif";
                }
                else if (resim == 8)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/playing-8.gif";
                }
                else if (resim == 9)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/playing-9.gif";
                }
            }
            else
            {
                if (resim == 1)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/stop-1.gif";
                }
                else if (resim == 2)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/stop-2.gif";
                }
                else if (resim == 3)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/stop-3.gif";
                }
                else if (resim == 4)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/stop-4.gif";
                }
                else if (resim == 5)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/stop-5.gif";
                }
                else if (resim == 6)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/stop-6.gif";
                }
                else if (resim == 7)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/stop-7.gif";
                }
                else if (resim == 8)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/stop-8.gif";
                }
                else if (resim == 9)
                {
                    gorsel.URL = "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/images/stop-9.gif";
                }
            }
        }

        private void axWindowsMediaPlayer1_StatusChange(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                label1.Text = "                                                                                                              Medya Oynatılıyor.";
                /*if (axWindowsMediaPlayer1.URL == "https://www.bakiyildiz.org/virtual-material-store/dosyalar/radio/yayin-kesik.jpg")
                {
                    label1.Text = "                                                               Medya Bulunamadı.";
                }*/
                durum = 1;
                resimguncelle();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused || axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                label1.Text = "                                                                                                               Medya Durduruldu.";
                durum = 0;
                resimguncelle();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsBuffering)
            {

                label1.Text = "                                                                                                               Medya Yükleniyor.";
                durum = 0;
                resimguncelle();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsReady)
            {

                label1.Text = "                                                                                                               Medya Bekleniyor.";
                durum = 0;
                resimguncelle();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (resim == 9)
            {
                resim = 1;
            }
            else
            {
                resim += 1;
            }
            Properties.Settings.Default.photo = resim;
            Properties.Settings.Default.Save();
            resimguncelle();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (resim == 1)
            {
                resim = 9;
            }
            else
            {
                resim -= 1;
            }
            Properties.Settings.Default.photo = resim;
            Properties.Settings.Default.Save();
            resimguncelle();
        }

        private void pic_stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        int sonses;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sonses = ses.Value;
            sesyon = "0";
            sesdegistirici.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sesyon = "1";
            sesdegistirici.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pic_resume_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pic_pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void ses_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = ses.Value * 10;
            if (ses.Value == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Radyo 1.0 - bakiyildiz.org.", "");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
            }
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        string sesyon;
        private void sesdegistirici_Tick(object sender, EventArgs e)
        {
            if (sesyon == "0")
            {
                if (ses.Value == 0)
                {
                    sesdegistirici.Enabled = false;
                }
                else
                {
                    ses.Value = ses.Value - 1;
                }
            }
            else
            {
                if (ses.Value == sonses)
                {
                    sesdegistirici.Enabled = false;
                }
                else
                {
                    ses.Value = ses.Value + 1;
                }
            }
        }

        bool kaydir;
        int farex, farey;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            kaydir = true;
            farex = Cursor.Position.X - this.Left;
            farey = Cursor.Position.Y - this.Top;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (kaydir == true)
            {
                this.Left = Cursor.Position.X - farex;
                this.Top = Cursor.Position.Y - farey;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            kaydir = false;
        }
    }
}