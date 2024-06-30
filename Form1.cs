using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace SimpleClock
{
    public partial class Form1 : Form
    {
        private Timer timer; // 用於更新時間顯示和檢查鬧鐘的計時器
        private WaveOutEvent waveOut; // 用於播放音效的 WaveOut 物件
        private AudioFileReader audioFileReader; // 用於讀取音效文件的 AudioFileReader 物件

        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes(); // 初始化小時和分鐘的 ComboBox
            InitializeTimer(); // 初始化計時器
            InitializeNAudio(); // 初始化 NAudio 用於播放鬧鐘音效
        }

        // 初始化小時和分鐘的 ComboBox
        private void InitializeComboBoxes()
        {
            // 設置小時 ComboBox
            for (int i = 0; i < 24; i++)
            {
                HourComboBox1.Items.Add(i.ToString("D2"));
                HourComboBox2.Items.Add(i.ToString("D2"));
                HourComboBox3.Items.Add(i.ToString("D2"));
                HourComboBox4.Items.Add(i.ToString("D2"));
                HourComboBox5.Items.Add(i.ToString("D2"));
            }

            // 設置分鐘 ComboBox
            for (int i = 0; i < 60; i++)
            {
                MinuteComboBox1.Items.Add(i.ToString("D2"));
                MinuteComboBox2.Items.Add(i.ToString("D2"));
                MinuteComboBox3.Items.Add(i.ToString("D2"));
                MinuteComboBox4.Items.Add(i.ToString("D2"));
                MinuteComboBox5.Items.Add(i.ToString("D2"));
            }

            // 設置預設選項
            HourComboBox1.SelectedIndex = 0;
            HourComboBox2.SelectedIndex = 0;
            HourComboBox3.SelectedIndex = 0;
            HourComboBox4.SelectedIndex = 0;
            HourComboBox5.SelectedIndex = 0;

            MinuteComboBox1.SelectedIndex = 0;
            MinuteComboBox2.SelectedIndex = 0;
            MinuteComboBox3.SelectedIndex = 0;
            MinuteComboBox4.SelectedIndex = 0;
            MinuteComboBox5.SelectedIndex = 0;
        }

        // 初始化計時器
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 設置計時器間隔為1秒
            timer.Tick += Timer_Tick; // 註冊計時器的 Tick 事件處理函數
            timer.Start(); // 啟動計時器
        }

        // 初始化 NAudio
        private void InitializeNAudio()
        {
            waveOut = new WaveOutEvent(); // 初始化 WaveOut 物件
            audioFileReader = new AudioFileReader("alarm_sound.mp3"); // 初始化 AudioFileReader 物件並加載音效文件
            waveOut.Init(audioFileReader); // 初始化 WaveOut 物件以播放音效文件
        }

        // 計時器的 Tick 事件處理函數
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now; // 獲取當前時間
            txtTime.Text = now.ToString("HH:mm:ss"); // 更新顯示當前時間的 TextBox

            CheckAlarms(now); // 檢查是否有鬧鐘時間到
        }

        // 檢查鬧鐘時間
        private void CheckAlarms(DateTime now)
        {
            // 收集所有設定的鬧鐘時間
            string[] alarmTimes = new string[]
            {
                $"{HourComboBox1.SelectedItem}:{MinuteComboBox1.SelectedItem}",
                $"{HourComboBox2.SelectedItem}:{MinuteComboBox2.SelectedItem}",
                $"{HourComboBox3.SelectedItem}:{MinuteComboBox3.SelectedItem}",
                $"{HourComboBox4.SelectedItem}:{MinuteComboBox4.SelectedItem}",
                $"{HourComboBox5.SelectedItem}:{MinuteComboBox5.SelectedItem}"
            };

            // 如果當前時間與任一鬧鐘時間匹配，則播放音效
            if (alarmTimes.Contains(now.ToString("HH:mm")))
            {
                waveOut.Play();
            }
        }

        // 開始鬧鐘的按鈕點擊事件處理函數
        private void StartAlarmButton_Click(object sender, EventArgs e)
        {
            timer.Start(); // 開始計時器
        }

        // 停止鬧鐘的按鈕點擊事件處理函數
        private void StopAlarmButton_Click(object sender, EventArgs e)
        {
            timer.Stop(); // 停止計時器
            waveOut.Stop(); // 停止播放音效
        }
    }
}
