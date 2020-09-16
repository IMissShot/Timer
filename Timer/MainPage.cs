using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Timer
{
    public partial class MainPage : Form
    {
        #region  ****** Goble vriable  ******
        static System.Windows.Forms.Timer myTimer1 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType1 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType1 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat1 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer2 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType2 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType2 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat2 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer3 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType3 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType3 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat3 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer4 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType4 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType4 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat4 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer5 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType5 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType5 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat5 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer6 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType6 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType6 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat6 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer7 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType7 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType7 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat7 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer8 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType8 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType8 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat8 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer9 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType9 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType9 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat9 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer10 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType10 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType10 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat10 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer11 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType11 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType11 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat11 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer12 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType12 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType12 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat12 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer13 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType13 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType13 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat13 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer14 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType14 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType14 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat14 = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer myTimer15 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRunType15 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerOneRunType15 = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerRepeat15 = new System.Windows.Forms.Timer();



        int Mytime1,Mytime2, Mytime3, Mytime4, Mytime5, Mytime6, Mytime7, Mytime8,Mytime9, Mytime10, Mytime11,
            Mytime12, Mytime13, Mytime14, Mytime15= 0;
        bool check = false;
        string type;
        int TimerNo;
        //  string path;
      //  string folderPath;
        FileHelper fileHelper = new FileHelper();
        ReadFile rf = new ReadFile();
        #endregion

        public MainPage()
        {
            InitializeComponent();
            CheckFolder();
            starting();
           
        
            

        }

        private void CheckFolder()
        {
            string path = @"..\ConfigFolder";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //if not found folder create folder
           
        }

       

        #region Start Page
        public void starting() 
        {
            
            cb_time_p1.Text = "--Select Time--";
            cb_repeat_p1.Text = "--Select Repeat--";
            rb_one_p1.Checked = true;
            rb_time_p1.Checked = true;     //time
            panel_date_p1.Enabled = false;
            status_on_p1.Visible = false;
            StatusOff(1);

            tp_p1.Format = DateTimePickerFormat.Time;
            tp_p1.ShowUpDown = true;
            panel_repeat_p1.Enabled = false;

            cb_time_p2.Text = "--Select Time--";
            cb_repeat_p2.Text = "--Select Repeat--";
            rb_one_p2.Checked = true;
            rb_time_p2.Checked = true;     //time
            panel_date_p2.Enabled = false;
            status_on_p2.Visible = false;
            StatusOff(2);

            tp_p2.Format = DateTimePickerFormat.Time;
            tp_p2.ShowUpDown = true;
            panel_repeat_p2.Enabled = false;

            cb_time_p3.Text = "--Select Time--";
            cb_repeat_p3.Text = "--Select Repeat--";
            rb_one_p3.Checked = true;
            rb_time_p3.Checked = true;     //time
            panel_date_p3.Enabled = false;
            status_on_p3.Visible = false;
            StatusOff(3);

            tp_p3.Format = DateTimePickerFormat.Time;
            tp_p3.ShowUpDown = true;
            panel_repeat_p3.Enabled = false;

            cb_time_p4.Text = "--Select Time--";
            cb_repeat_p4.Text = "--Select Repeat--";
            rb_one_p4.Checked = true;
            rb_time_p4.Checked = true;     //time
            panel_date_p4.Enabled = false;
            status_on_p4.Visible = false;
            StatusOff(4);

            tp_p4.Format = DateTimePickerFormat.Time;
            tp_p4.ShowUpDown = true;
            panel_repeat_p4.Enabled = false;

            cb_time_p5.Text = "--Select Time--";
            cb_repeat_p5.Text = "--Select Repeat--";
            rb_one_p5.Checked = true;
            rb_time_p5.Checked = true;     //time
            panel_date_p5.Enabled = false;
            status_on_p5.Visible = false;
            StatusOff(5);

            tp_p5.Format = DateTimePickerFormat.Time;
            tp_p5.ShowUpDown = true;
            panel_repeat_p5.Enabled = false;

            cb_time_p6.Text = "--Select Time--";
            cb_repeat_p6.Text = "--Select Repeat--";
            rb_one_p6.Checked = true;
            rb_time_p6.Checked = true;     //time
            panel_date_p6.Enabled = false;
            status_on_p6.Visible = false;
            StatusOff(6);

            tp_p6.Format = DateTimePickerFormat.Time;
            tp_p6.ShowUpDown = true;
            panel_repeat_p6.Enabled = false;

            cb_time_p7.Text = "--Select Time--";
            cb_repeat_p7.Text = "--Select Repeat--";
            rb_one_p7.Checked = true;
            rb_time_p7.Checked = true;     //time
            panel_date_p7.Enabled = false;
            status_on_p7.Visible = false;
            StatusOff(7);

            tp_p7.Format = DateTimePickerFormat.Time;
            tp_p7.ShowUpDown = true;
            panel_repeat_p7.Enabled = false;

            cb_time_p8.Text = "--Select Time--";
            cb_repeat_p8.Text = "--Select Repeat--";
            rb_one_p8.Checked = true;
            rb_time_p8.Checked = true;     //time
            panel_date_p8.Enabled = false;
            status_on_p8.Visible = false;
            StatusOff(8);

            tp_p8.Format = DateTimePickerFormat.Time;
            tp_p8.ShowUpDown = true;
            panel_repeat_p8.Enabled = false;

            cb_time_p9.Text = "--Select Time--";
            cb_repeat_p9.Text = "--Select Repeat--";
            rb_one_p9.Checked = true;
            rb_time_p9.Checked = true;     //time
            panel_date_p9.Enabled = false;
            status_on_p9.Visible = false;
            StatusOff(9);

            tp_p9.Format = DateTimePickerFormat.Time;
            tp_p9.ShowUpDown = true;
            panel_repeat_p9.Enabled = false;

            cb_time_p10.Text = "--Select Time--";
            cb_repeat_p10.Text = "--Select Repeat--";
            rb_one_p10.Checked = true;
            rb_time_p10.Checked = true;     //time
            panel_date_p10.Enabled = false;
            status_on_p10.Visible = false;
            StatusOff(10);

            tp_p10.Format = DateTimePickerFormat.Time;
            tp_p10.ShowUpDown = true;
            panel_repeat_p10.Enabled = false;

            cb_time_p11.Text = "--Select Time--";
            cb_repeat_p11.Text = "--Select Repeat--";
            rb_one_p11.Checked = true;
            rb_time_p11.Checked = true;     //time
            panel_date_p11.Enabled = false;
            status_on_p11.Visible = false;
            StatusOff(11);

            tp_p11.Format = DateTimePickerFormat.Time;
            tp_p11.ShowUpDown = true;
            panel_repeat_p11.Enabled = false;

            cb_time_p12.Text = "--Select Time--";
            cb_repeat_p12.Text = "--Select Repeat--";
            rb_one_p12.Checked = true;
            rb_time_p12.Checked = true;     //time
            panel_date_p12.Enabled = false;
            status_on_p12.Visible = false;
            StatusOff(12);

            tp_p12.Format = DateTimePickerFormat.Time;
            tp_p12.ShowUpDown = true;
            panel_repeat_p12.Enabled = false;

            cb_time_p13.Text = "--Select Time--";
            cb_repeat_p13.Text = "--Select Repeat--";
            rb_one_p13.Checked = true;
            rb_time_p13.Checked = true;     //time
            panel_date_p13.Enabled = false;
            status_on_p13.Visible = false;
            StatusOff(13);

            tp_p13.Format = DateTimePickerFormat.Time;
            tp_p13.ShowUpDown = true;
            panel_repeat_p13.Enabled = false;

            cb_time_p14.Text = "--Select Time--";
            cb_repeat_p14.Text = "--Select Repeat--";
            rb_one_p14.Checked = true;
            rb_time_p14.Checked = true;     //time
            panel_date_p14.Enabled = false;
            status_on_p14.Visible = false;
            StatusOff(14);

            tp_p14.Format = DateTimePickerFormat.Time;
            tp_p14.ShowUpDown = true;
            panel_repeat_p14.Enabled = false;

            cb_time_p15.Text = "--Select Time--";
            cb_repeat_p15.Text = "--Select Repeat--";
            rb_one_p15.Checked = true;
            rb_time_p15.Checked = true;     //time
            panel_date_p15.Enabled = false;
            status_on_p15.Visible = false;
            StatusOff(15);

            tp_p15.Format = DateTimePickerFormat.Time;
            tp_p15.ShowUpDown = true;
            panel_repeat_p15.Enabled = false;
        }
        #endregion

        #region Main Function
        public int Settime(int time,int timerNo)
        {
           
            if (time == 0 || time < 0)
            {
                time = 1;
            }
            int TotalTime = 0;
            switch (timerNo) 
            {
                case 1:
                    myTimer1 = new System.Windows.Forms.Timer();
                    myTimer1.Interval = (time * 60 * 1000);                   
                    myTimer1.Tick += new EventHandler(function1);
                    myTimer1.Start();
                    TotalTime = time ;
                    break;
                case 2:
                    myTimer2 = new System.Windows.Forms.Timer();
                    myTimer2.Interval = (time * 60 * 1000); 
                    myTimer2.Tick += new EventHandler(function2);
                    myTimer2.Start();
                    TotalTime = time;
                    break;
                case 3:
                    myTimer3 = new System.Windows.Forms.Timer();
                    myTimer3.Interval = (time * 60 * 1000); 
                    myTimer3.Tick += new EventHandler(function3);
                    myTimer3.Start();
                    TotalTime = time;
                    break;
                case 4:
                    myTimer4 = new System.Windows.Forms.Timer();
                    myTimer4.Interval = (time * 60 * 1000); 
                    myTimer4.Tick += new EventHandler(function4);
                    myTimer4.Start();
                    TotalTime = time;
                    break;
                case 5:
                    myTimer5 = new System.Windows.Forms.Timer();
                    myTimer5.Interval = (time * 60 * 1000); 
                    myTimer5.Tick += new EventHandler(function5);
                    myTimer5.Start();
                    TotalTime = time;
                    break;
                case 6:
                    myTimer6 = new System.Windows.Forms.Timer();
                    myTimer6.Interval = (time * 60 * 1000);
                    myTimer6.Tick += new EventHandler(function6);
                    myTimer6.Start();
                    TotalTime = time;
                    break;
                case 7:
                    myTimer7 = new System.Windows.Forms.Timer();
                    myTimer7.Interval = (time * 60 * 1000);
                    myTimer7.Tick += new EventHandler(function7);
                    myTimer7.Start();
                    TotalTime = time;
                    break;
                case 8:
                    myTimer8 = new System.Windows.Forms.Timer();
                    myTimer8.Interval = (time * 60 * 1000);
                    myTimer8.Tick += new EventHandler(function8);
                    myTimer8.Start();
                    TotalTime = time;
                    break;
                case 9:
                    myTimer9 = new System.Windows.Forms.Timer();
                    myTimer9.Interval = (time * 60 * 1000);
                    myTimer9.Tick += new EventHandler(function9);
                    myTimer9.Start();
                    TotalTime = time;
                    break;
                case 10:
                    myTimer10 = new System.Windows.Forms.Timer();
                    myTimer10.Interval = (time * 60 * 1000);
                    myTimer10.Tick += new EventHandler(function10);
                    myTimer10.Start();
                    TotalTime = time;
                    break;
                case 11:
                    myTimer11 = new System.Windows.Forms.Timer();
                    myTimer11.Interval = (time * 60 * 1000);
                    myTimer11.Tick += new EventHandler(function11);
                    myTimer11.Start();
                    TotalTime = time;
                    break;
                case 12:
                    myTimer12 = new System.Windows.Forms.Timer();
                    myTimer12.Interval = (time * 60 * 1000);
                    myTimer12.Tick += new EventHandler(function12);
                    myTimer12.Start();
                    TotalTime = time;
                    break;
                case 13:
                    myTimer13 = new System.Windows.Forms.Timer();
                    myTimer13.Interval = (time * 60 * 1000);
                    myTimer13.Tick += new EventHandler(function13);
                    myTimer13.Start();
                    TotalTime = time;
                    break;
                case 14:
                    myTimer14 = new System.Windows.Forms.Timer();
                    myTimer14.Interval = (time * 60 * 1000);
                    myTimer14.Tick += new EventHandler(function14);
                    myTimer14.Start();
                    TotalTime = time;
                    break;
                case 15:
                    myTimer15 = new System.Windows.Forms.Timer();
                    myTimer15.Interval = (time * 60 * 1000);
                    myTimer15.Tick += new EventHandler(function15);
                    myTimer9.Start();
                    TotalTime = time;
                    break;
            }

            return TotalTime;
            
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
          //  fileHelper.writelog(path, "Defult");
            MessageBox.Show("The form will now be closed.", "Time Elapsed");          
            myTimer1.Stop();
            

        }
        public int dateConfig(int timerNo)
        {
           
            DateTime date2 = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
            int TotalTime = 0;

            switch (timerNo) 
            {
                case 1:
                    DateTime date1_1 = Convert.ToDateTime(dateTimePicker1.Value.ToString("dd-MM-yyyy")+" "+tp_p1.Text);
                    TimeSpan ts1 =  date1_1 - date2;
                    Mytime1 = int.Parse(ts1.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts1.TotalMinutes.ToString()), timerNo);
                    break;
                case 2:
                    DateTime date1_2 = Convert.ToDateTime(dp_p2.Value.ToString("dd-MM-yyyy") + " " + tp_p2.Text);
                    TimeSpan ts2 = date1_2 - date2;
                    Mytime2 = int.Parse(ts2.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts2.TotalMinutes.ToString()), timerNo);
                    break;
                case 3:
                    DateTime date1_3 = Convert.ToDateTime(dp_p3.Value.ToString("dd-MM-yyyy") + " " + tp_p3.Text);
                    TimeSpan ts3 =  date1_3 - date2;
                    Mytime3 = int.Parse(ts3.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts3.TotalMinutes.ToString()), timerNo);
                    break;
                case 4:
                    DateTime date1_4 = Convert.ToDateTime(dp_p4.Value.ToString("dd-MM-yyyy") + " " + tp_p4.Text);
                    TimeSpan ts4 = date1_4 - date2;
                    Mytime4 = int.Parse(ts4.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts4.TotalMinutes.ToString()), timerNo);
                    break;
                case 5:
                    DateTime date1_5 = Convert.ToDateTime(dp_p5.Value.ToString("dd-MM-yyyy") + " " + tp_p5.Text);
                    TimeSpan ts5 =  date1_5 - date2;
                    Mytime5 = int.Parse(ts5.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts5.TotalMinutes.ToString()), timerNo);
                    break;
                case 6:
                    DateTime date1_6 = Convert.ToDateTime(dp_p6.Value.ToString("dd-MM-yyyy") + " " + tp_p6.Text);
                    TimeSpan ts6 = date1_6 - date2;
                    Mytime6 = int.Parse(ts6.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts6.TotalMinutes.ToString()), timerNo);
                    break;
                case 7:
                    DateTime date1_7 = Convert.ToDateTime(dp_p7.Value.ToString("dd-MM-yyyy") + " " + tp_p7.Text);
                    TimeSpan ts7 = date1_7 - date2;
                    Mytime7 = int.Parse(ts7.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts7.TotalMinutes.ToString()), timerNo);
                    break;
                case 8:
                    DateTime date1_8 = Convert.ToDateTime(dp_p8.Value.ToString("dd-MM-yyyy") + " " + tp_p8.Text);
                    TimeSpan ts8 = date1_8 - date2;
                    Mytime8 = int.Parse(ts8.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts8.TotalMinutes.ToString()), timerNo);
                    break;
                case 9:
                    DateTime date1_9 = Convert.ToDateTime(dp_p9.Value.ToString("dd-MM-yyyy") + " " + tp_p9.Text);
                    TimeSpan ts9 = date1_9 - date2;
                    Mytime9 = int.Parse(ts9.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts9.TotalMinutes.ToString()), timerNo);
                    break;
                case 10:
                    DateTime date1_10 = Convert.ToDateTime(dp_p10.Value.ToString("dd-MM-yyyy") + " " + tp_p10.Text);
                    TimeSpan ts10 = date1_10 - date2;
                    Mytime10 = int.Parse(ts10.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts10.TotalMinutes.ToString()), timerNo);
                    break;
                case 11:
                    DateTime date1_11 = Convert.ToDateTime(dp_p11.Value.ToString("dd-MM-yyyy") + " " + tp_p11.Text);
                    TimeSpan ts11 = date1_11 - date2;
                    Mytime11 = int.Parse(ts11.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts11.TotalMinutes.ToString()), timerNo);
                    break;
                case 12:
                    DateTime date1_12 = Convert.ToDateTime(dp_p12.Value.ToString("dd-MM-yyyy") + " " + tp_p12.Text);
                    TimeSpan ts12 = date1_12 - date2;
                    Mytime12 = int.Parse(ts12.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts12.TotalMinutes.ToString()), timerNo);
                    break;
                case 13:
                    DateTime date1_13 = Convert.ToDateTime(dp_p13.Value.ToString("dd-MM-yyyy") + " " + tp_p13.Text);
                    TimeSpan ts13 = date1_13 - date2;
                    Mytime13 = int.Parse(ts13.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts13.TotalMinutes.ToString()), timerNo);
                    break;
                case 14:
                    DateTime date1_14 = Convert.ToDateTime(dp_p14.Value.ToString("dd-MM-yyyy") + " " + tp_p14.Text);
                    TimeSpan ts14 = date1_14 - date2;
                    Mytime14 = int.Parse(ts14.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts14.TotalMinutes.ToString()), timerNo);
                    break;
                case 15:
                    DateTime date1_15 = Convert.ToDateTime(dp_p15.Value.ToString("dd-MM-yyyy") + " " + tp_p15.Text);
                    TimeSpan ts15 = date1_15 - date2;
                    Mytime15 = int.Parse(ts15.TotalMinutes.ToString());
                    TotalTime = Settime(int.Parse(ts15.TotalMinutes.ToString()), timerNo);
                    break;
            }
            return TotalTime;
            
        }

        public int timeConfig(int timerNo)
        {
            int TotalTime = 0;
            switch (timerNo) 
            {
                case 1:
                    if (cb_time_p1.Text== "--Select Time--") 
                    {
                        StatusOff(1);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin1 = (cb_time_p1.Text).Split(' ');
                        Mytime1 = int.Parse(selectedMin1[0]);
                        TotalTime = Settime(int.Parse(selectedMin1[0]), timerNo);
                    }
                   
                    break;
                case 2:
                    if (cb_time_p2.Text == "--Select Time--")
                    {
                        StatusOff(2);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin2 = (cb_time_p2.Text).Split(' ');
                        Mytime2 = int.Parse(selectedMin2[0]);
                        TotalTime = Settime(int.Parse(selectedMin2[0]), timerNo);
                    }
                    break;
                case 3:
                    if (cb_time_p3.Text == "--Select Time--")
                    {
                        StatusOff(3);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin3 = (cb_time_p3.Text).Split(' ');
                        Mytime3 = int.Parse(selectedMin3[0]);
                        TotalTime = Settime(int.Parse(selectedMin3[0]), timerNo);
                    }
                    break;
                case 4:
                    if (cb_time_p4.Text == "--Select Time--")
                    {
                        StatusOff(4);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin4 = (cb_time_p4.Text).Split(' ');
                        Mytime4 = int.Parse(selectedMin4[0]);
                        TotalTime = Settime(int.Parse(selectedMin4[0]), timerNo);
                    }
                    break;
                case 5:
                    if (cb_time_p5.Text == "--Select Time--")
                    {
                        StatusOff(5);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin5 = (cb_time_p5.Text).Split(' ');
                        Mytime5 = int.Parse(selectedMin5[0]);
                        TotalTime = Settime(int.Parse(selectedMin5[0]), timerNo);
                    }
                    break;
                case 6:
                    if (cb_time_p6.Text == "--Select Time--")
                    {
                        StatusOff(6);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin6 = (cb_time_p6.Text).Split(' ');
                        Mytime6 = int.Parse(selectedMin6[0]);
                        TotalTime = Settime(int.Parse(selectedMin6[0]), timerNo);
                    }
                    break;
                case 7:
                    if (cb_time_p7.Text == "--Select Time--")
                    {
                        StatusOff(7);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin7 = (cb_time_p7.Text).Split(' ');
                        Mytime7 = int.Parse(selectedMin7[0]);
                        TotalTime = Settime(int.Parse(selectedMin7[0]), timerNo);
                    }
                    break;
                case 8:
                    if (cb_time_p8.Text == "--Select Time--")
                    {
                        StatusOff(8);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin8 = (cb_time_p8.Text).Split(' ');
                        Mytime8 = int.Parse(selectedMin8[0]);
                        TotalTime = Settime(int.Parse(selectedMin8[0]), timerNo);
                    }
                    break;
                case 9:
                    if (cb_time_p9.Text == "--Select Time--")
                    {
                        StatusOff(9);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin9 = (cb_time_p9.Text).Split(' ');
                        Mytime9 = int.Parse(selectedMin9[0]);
                        TotalTime = Settime(int.Parse(selectedMin9[0]), timerNo);
                    }
                    break;
                case 10:
                    if (cb_time_p10.Text == "--Select Time--")
                    {
                        StatusOff(10);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin10 = (cb_time_p10.Text).Split(' ');
                        Mytime10 = int.Parse(selectedMin10[0]);
                        TotalTime = Settime(int.Parse(selectedMin10[0]), timerNo);
                    }
                    break;
                case 11:
                    if (cb_time_p11.Text == "--Select Time--")
                    {
                        StatusOff(11);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin11 = (cb_time_p11.Text).Split(' ');
                        Mytime11 = int.Parse(selectedMin11[0]);
                        TotalTime = Settime(int.Parse(selectedMin11[0]), timerNo);
                    }
                    break;
                case 12:
                    if (cb_time_p12.Text == "--Select Time--")
                    {
                        StatusOff(12);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin12 = (cb_time_p12.Text).Split(' ');
                        Mytime12 = int.Parse(selectedMin12[0]);
                        TotalTime = Settime(int.Parse(selectedMin12[0]), timerNo);
                    }
                    break;
                case 13:
                    if (cb_time_p13.Text == "--Select Time--")
                    {
                        StatusOff(13);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin13 = (cb_time_p13.Text).Split(' ');
                        Mytime13 = int.Parse(selectedMin13[0]);
                        TotalTime = Settime(int.Parse(selectedMin13[0]), timerNo);
                    }
                    break;
                case 14:
                    if (cb_time_p14.Text == "--Select Time--")
                    {
                        StatusOff(14);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin14 = (cb_time_p14.Text).Split(' ');
                        Mytime14 = int.Parse(selectedMin14[0]);
                        TotalTime = Settime(int.Parse(selectedMin14[0]), timerNo);
                    }
                    break;
                case 15:
                    if (cb_time_p15.Text == "--Select Time--")
                    {
                        StatusOff(15);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        string[] selectedMin15 = (cb_time_p15.Text).Split(' ');
                        Mytime15 = int.Parse(selectedMin15[0]);
                        TotalTime = Settime(int.Parse(selectedMin15[0]), timerNo);
                    }
                    break;
            }

            return TotalTime;


        }

        public void Repeat(int timerNo)
        {
            int time1 = 0;
            int time2 = 0;
            int time3 = 0;
            int time4 = 0;
            int time5 = 0;
            int time6 = 0;
            int time7 = 0;
            int time8 = 0;
            int time9 = 0;
            int time10 = 0;
            int time11 = 0;
            int time12 = 0;
            int time13 = 0;
            int time14 = 0;
            int time15 = 0;


            switch (timerNo) 
            {
                case 1:
                    string selected = cb_repeat_p1.Text;
                    switch (selected)
                    {
                        case "Every 1 min":time1 = 1;break;
                        case "Every 5 min": time1 = 5; break;
                        case "Every 15 min": time1 = 15; break;
                        case "Every 30 min": time1 = 30; break;
                        case "Every 45 min": time1 = 45; break;
                        case "Every 1 hour": time1 = 60; break;
                        case "Every 6 hour": time1 = 360; break;
                        case "Every 12 hour": time1 = 720; break;
                        default: time1 = 0; break;
                    }
                        if (time1!=0) 
                        {
                            myTimerRepeat1 = new System.Windows.Forms.Timer();
                            myTimerRepeat1.Interval = (time1 * 60 * 1000); 
                            myTimerRepeat1.Tick += new EventHandler(function1);
                            myTimerRepeat1.Start();
                        }
                        else                        
                        {
                            MessageBox.Show("Plase select Repeat Time !!!","----------Exception----------");
                          StatusOff(1);
                        }
                           
                    break;
                case 2:
                    string selected2 = cb_repeat_p2.Text;
                    switch (selected2)
                    {
                        case "Every 1 min": time2 = 1; break;
                        case "Every 5 min": time2 = 5; break;
                        case "Every 15 min": time2 = 15; break;
                        case "Every 30 min": time2 = 30; break;
                        case "Every 45 min": time2 = 45; break;
                        case "Every 1 hour": time2 = 60; break;
                        case "Every 6 hour": time2 = 360; break;
                        case "Every 12 hour": time2 = 720; break;
                        default: time2 = 0; break;
                    }
                        if (time2 != 0)
                        {
                            myTimerRepeat2 = new System.Windows.Forms.Timer();
                            myTimerRepeat2.Interval = (time2 * 60 * 1000); 
                            myTimerRepeat2.Tick += new EventHandler(function2);
                            myTimerRepeat2.Start();
                        }
                        else
                        {
                             MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                             StatusOff(2);
                        }
                   
                    break;
                case 3:
                    string selected3 = cb_repeat_p3.Text;
                    switch (selected3)
                    {
                        case "Every 1 min": time3 = 1; break;
                        case "Every 5 min": time3= 5; break;
                        case "Every 15 min": time3 = 15; break;
                        case "Every 30 min": time3 = 30; break;
                        case "Every 45 min": time3 = 45; break;
                        case "Every 1 hour": time3 = 60; break;
                        case "Every 6 hour": time3 = 360; break;
                        case "Every 12 hour": time3 = 720; break;
                        default: time3 = 0; break;
                    }
                            if (time3 != 0)
                            {
                                myTimerRepeat3 = new System.Windows.Forms.Timer();
                                myTimerRepeat3.Interval = (time3 * 60 * 1000); 
                                myTimerRepeat3.Tick += new EventHandler(function3);
                                myTimerRepeat3.Start();
                             }
                            else
                            {
                                  MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                                  StatusOff(3);
                             }
                   
                    break;
                case 4:
                    string selected4 = cb_repeat_p4.Text;
                    switch (selected4)
                    {
                        case "Every 1 min": time4= 1; break;
                        case "Every 5 min": time4 = 5; break;
                        case "Every 15 min": time4 = 15; break;
                        case "Every 30 min": time4 = 30; break;
                        case "Every 45 min": time4 = 45; break;
                        case "Every 1 hour": time4 = 60; break;
                        case "Every 6 hour": time4 = 360; break;
                        case "Every 12 hour": time4 = 720; break;
                        default: time4 = 0; break;
                    }
                        if (time4 != 0)
                        {
                                myTimerRepeat4 = new System.Windows.Forms.Timer();
                                myTimerRepeat4.Interval = (time4 * 60 * 1000); 
                                myTimerRepeat4.Tick += new EventHandler(function4);
                                myTimerRepeat4.Start();
                        }
                        else
                        {
                                MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                           StatusOff(4);
                         }
                    
                    break;
                case 5:
                    string selected5 = cb_repeat_p5.Text;
                    switch (selected5)
                    {
                        case "Every 1 min": time5 = 1; break;
                        case "Every 5 min": time5= 5; break;
                        case "Every 15 min": time5 = 15; break;
                        case "Every 30 min": time5 = 30; break;
                        case "Every 45 min": time5 = 45; break;
                        case "Every 1 hour": time5 = 60; break;
                        case "Every 6 hour": time5 = 360; break;
                        case "Every 12 hour": time5 = 720; break;
                        default: time5 = 0; break;
                    }
                        if (time5 != 0)
                        {
                            myTimerRepeat5 = new System.Windows.Forms.Timer();
                            myTimerRepeat5.Interval = (time5 * 60 * 1000); 
                            myTimerRepeat5.Tick += new EventHandler(function5);
                            myTimerRepeat5.Start();
                        }
                        else
                        {
                             MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                            StatusOff(5);
                        }
                   
                    break;
                case 6:
                    string selected6 = cb_repeat_p6.Text;
                    switch (selected6)
                    {
                        case "Every 1 min": time6 = 1; break;
                        case "Every 5 min": time6= 5; break;
                        case "Every 15 min": time6 = 15; break;
                        case "Every 30 min": time6 = 30; break;
                        case "Every 45 min": time6 = 45; break;
                        case "Every 1 hour": time6 = 60; break;
                        case "Every 6 hour": time6 = 360; break;
                        case "Every 12 hour": time6 = 720; break;
                        default: time6 = 0; break;
                    }
                    if (time6 != 0)
                    {
                        myTimerRepeat6 = new System.Windows.Forms.Timer();
                        myTimerRepeat6.Interval = (time6 * 60 * 1000);
                        myTimerRepeat6.Tick += new EventHandler(function6);
                        myTimerRepeat6.Start();
                    }
                    else
                    {
                        MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                        StatusOff(6);
                    }

                    break;
                case 7:
                    string selected7 = cb_repeat_p7.Text;
                    switch (selected7)
                    {
                        case "Every 1 min": time7 = 1; break;
                        case "Every 5 min": time7= 5; break;
                        case "Every 15 min": time7 = 15; break;
                        case "Every 30 min": time7 = 30; break;
                        case "Every 45 min": time7 = 45; break;
                        case "Every 1 hour": time7 = 60; break;
                        case "Every 6 hour": time7 = 360; break;
                        case "Every 12 hour": time7 = 720; break;
                        default: time7 = 0; break;
                    }
                    if (time7 != 0)
                    {
                        myTimerRepeat7 = new System.Windows.Forms.Timer();
                        myTimerRepeat7.Interval = (time7 * 60 * 1000);
                        myTimerRepeat7.Tick += new EventHandler(function7);
                        myTimerRepeat7.Start();
                    }
                    else
                    {
                        MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                        StatusOff(7);
                    }

                    break;
                case 8:
                    string selected8 = cb_repeat_p8.Text;
                    switch (selected8)
                    {
                        case "Every 1 min": time8 = 1; break;
                        case "Every 5 min": time8 = 5; break;
                        case "Every 15 min": time8 = 15; break;
                        case "Every 30 min": time8= 30; break;
                        case "Every 45 min": time8 = 45; break;
                        case "Every 1 hour": time8 = 60; break;
                        case "Every 6 hour": time8 = 360; break;
                        case "Every 12 hour": time8 = 720; break;
                        default: time8 = 0; break;
                    }
                    if (time8 != 0)
                    {
                        myTimerRepeat8 = new System.Windows.Forms.Timer();
                        myTimerRepeat8.Interval = (time8 * 60 * 1000);
                        myTimerRepeat8.Tick += new EventHandler(function8);
                        myTimerRepeat8.Start();
                    }
                    else
                    {
                        MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                        StatusOff(8);
                    }

                    break;
                case 9:
                    string selected9 = cb_repeat_p9.Text;
                    switch (selected9)
                    {
                        case "Every 1 min": time9 = 1; break;
                        case "Every 5 min": time9 = 5; break;
                        case "Every 15 min": time9 = 15; break;
                        case "Every 30 min": time9 = 30; break;
                        case "Every 45 min": time9 = 45; break;
                        case "Every 1 hour": time9 = 60; break;
                        case "Every 6 hour": time9 = 360; break;
                        case "Every 12 hour": time9 = 720; break;
                        default: time9 = 0; break;
                    }
                    if (time9 != 0)
                    {
                        myTimerRepeat9 = new System.Windows.Forms.Timer();
                        myTimerRepeat9.Interval = (time9 * 60 * 1000);
                        myTimerRepeat9.Tick += new EventHandler(function9);
                        myTimerRepeat9.Start();
                    }
                    else
                    {
                        MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                        StatusOff(9);
                    }

                    break;

                case 10:
                    string selected10 = cb_repeat_p10.Text;
                    switch (selected10)
                    {
                        case "Every 1 min": time10 = 1; break;
                        case "Every 5 min": time10 = 5; break;
                        case "Every 15 min": time10 = 15; break;
                        case "Every 30 min": time10 = 30; break;
                        case "Every 45 min": time10 = 45; break;
                        case "Every 1 hour": time10 = 60; break;
                        case "Every 6 hour": time10 = 360; break;
                        case "Every 12 hour": time10 = 720; break;
                        default: time10 = 0; break;
                    }
                    if (time10 != 0)
                    {
                        myTimerRepeat10 = new System.Windows.Forms.Timer();
                        myTimerRepeat10.Interval = (time10 * 60 * 1000);
                        myTimerRepeat10.Tick += new EventHandler(function10);
                        myTimerRepeat10.Start();
                    }
                    else
                    {
                        MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                        StatusOff(10);
                    }

                    break;

                case 11:
                    string selected11 = cb_repeat_p11.Text;
                    switch (selected11)
                    {
                        case "Every 1 min": time11 = 1; break;
                        case "Every 5 min": time11 = 5; break;
                        case "Every 15 min": time11 = 15; break;
                        case "Every 30 min": time11 = 30; break;
                        case "Every 45 min": time11 = 45; break;
                        case "Every 1 hour": time11 = 60; break;
                        case "Every 6 hour": time11 = 360; break;
                        case "Every 12 hour": time11 = 720; break;
                        default: time11 = 0; break;
                    }
                    if (time11 != 0)
                    {
                        myTimerRepeat11 = new System.Windows.Forms.Timer();
                        myTimerRepeat11.Interval = (time11 * 60 * 1000);
                        myTimerRepeat11.Tick += new EventHandler(function11);
                        myTimerRepeat11.Start();
                    }
                    else
                    {
                        MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                        StatusOff(11);
                    }

                    break;

                case 12:
                    string selected12 = cb_repeat_p12.Text;
                    switch (selected12)
                    {
                        case "Every 1 min": time12 = 1; break;
                        case "Every 5 min": time12 = 5; break;
                        case "Every 15 min": time12 = 15; break;
                        case "Every 30 min": time12 = 30; break;
                        case "Every 45 min": time12 = 45; break;
                        case "Every 1 hour": time12 = 60; break;
                        case "Every 6 hour": time12 = 360; break;
                        case "Every 12 hour": time12 = 720; break;
                        default: time12 = 0; break;
                    }
                    if (time12 != 0)
                    {
                        myTimerRepeat12 = new System.Windows.Forms.Timer();
                        myTimerRepeat12.Interval = (time12 * 60 * 1000);
                        myTimerRepeat12.Tick += new EventHandler(function12);
                        myTimerRepeat12.Start();
                    }
                    else
                    {
                        MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                        StatusOff(12);
                    }

                    break;

                case 13:
                    string selected13 = cb_repeat_p13.Text;
                    switch (selected13)
                    {
                        case "Every 1 min": time13 = 1; break;
                        case "Every 5 min": time13 = 5; break;
                        case "Every 15 min": time13 = 15; break;
                        case "Every 30 min": time13 = 30; break;
                        case "Every 45 min": time13 = 45; break;
                        case "Every 1 hour": time13 = 60; break;
                        case "Every 6 hour": time13 = 360; break;
                        case "Every 12 hour": time13 = 720; break;
                        default: time13 = 0; break;
                    }
                    if (time13 != 0)
                    {
                        myTimerRepeat13 = new System.Windows.Forms.Timer();
                        myTimerRepeat13.Interval = (time13 * 60 * 1000);
                        myTimerRepeat13.Tick += new EventHandler(function13);
                        myTimerRepeat13.Start();
                    }
                    else
                    {
                        MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                        StatusOff(13);
                    }

                    break;

                case 14:
                    string selected14 = chb_repeat_p14.Text;
                    switch (selected14)
                    {
                        case "Every 1 min": time14 = 1; break;
                        case "Every 5 min": time14 = 5; break;
                        case "Every 15 min": time14 = 15; break;
                        case "Every 30 min": time14 = 30; break;
                        case "Every 45 min": time14 = 45; break;
                        case "Every 1 hour": time14 = 60; break;
                        case "Every 6 hour": time14 = 360; break;
                        case "Every 12 hour": time14 = 720; break;
                        default: time14 = 0; break;
                    }
                    if (time14 != 0)
                    {
                        myTimerRepeat14 = new System.Windows.Forms.Timer();
                        myTimerRepeat14.Interval = (time14 * 60 * 1000);
                        myTimerRepeat14.Tick += new EventHandler(function14);
                        myTimerRepeat14.Start();
                    }
                    else
                    {
                        MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                        StatusOff(14);
                    }

                    break;

                case 15:
                    string selected15 = chb_repeat_p15.Text;
                    switch (selected15)
                    {
                        case "Every 1 min": time15 = 1; break;
                        case "Every 5 min": time15 = 5; break;
                        case "Every 15 min": time15 = 15; break;
                        case "Every 30 min": time15 = 30; break;
                        case "Every 45 min": time15 = 45; break;
                        case "Every 1 hour": time15 = 60; break;
                        case "Every 6 hour": time15 = 360; break;
                        case "Every 12 hour": time15 = 720; break;
                        default: time15 = 0; break;
                    }
                    if (time15 != 0)
                    {
                        myTimerRepeat15 = new System.Windows.Forms.Timer();
                        myTimerRepeat15.Interval = (time15 * 60 * 1000);
                        myTimerRepeat15.Tick += new EventHandler(function15);
                        myTimerRepeat15.Start();
                    }
                    else
                    {
                        MessageBox.Show("Plase select Repeat Time !!!", "----------Exception----------");
                        StatusOff(15);
                    }

                    break;


            }

           
           
        }

        public string RunType(int TimerNo)
        {
            string type = "";


            switch (TimerNo) 
            {
                case 1:
                    if (rb_one_p1.Checked)
                    {
                        type = rb_one_p1.Text;
                    }
                    else if (rb_daily_p1.Checked)
                    {
                        type = rb_daily_p1.Text;
                    }
                    else if (rb_week_p1.Checked)
                    {
                        type = rb_week_p1.Text;
                    }
                    else if (rb_month_p1.Checked)
                    {
                        type = rb_month_p1.Text;
                    }
                    break;
                case 2:
                    ////// 2 ///////
                    if (rb_one_p2.Checked)
                    {
                        type = rb_one_p2.Text;
                    }
                    else if (rb_daily_p2.Checked)
                    {
                        type = rb_daily_p2.Text;
                    }
                    else if (rb_week_p2.Checked)
                    {
                        type = rb_week_p2.Text;
                    }
                    else if (rb_month_p2.Checked)
                    {
                        type = rb_month_p2.Text;
                    }
                    break;
                case 3:
                    ///// 3 //////
                    if (rb_one_p3.Checked)
                    {
                        type = rb_one_p3.Text;
                    }
                    else if (rb_daliy_p3.Checked)
                    {
                        type = rb_daliy_p3.Text;
                    }
                    else if (rb_week_p3.Checked)
                    {
                        type = rb_week_p3.Text;
                    }
                    else if (rb_month_p3.Checked)
                    {
                        type = rb_month_p3.Text;
                    }
                    break;
                case 4:
                    /////  4   ///////
                    if (rb_one_p4.Checked)
                    {
                        type = rb_one_p4.Text;
                    }
                    else if (rb_daily_p4.Checked)
                    {
                        type = rb_daily_p4.Text;
                    }
                    else if (rb_week_p4.Checked)
                    {
                        type = rb_week_p4.Text;
                    }
                    else if (rb_month_p4.Checked)
                    {
                        type = rb_month_p4.Text;
                    }
                    break;
                case 5:
                    /////  5   ///////
                    if (rb_one_p5.Checked)
                    {
                        type = rb_one_p5.Text;
                    }
                    else if (rb_daily_p5.Checked)
                    {
                        type = rb_daily_p5.Text;
                    }
                    else if (rb_week_p5.Checked)
                    {
                        type = rb_week_p5.Text;
                    }
                    else if (rb_month_p5.Checked)
                    {
                        type = rb_month_p5.Text;
                    }
                    break;
                case 6:
                    /////  6   ///////
                    if (rb_one_p6.Checked)
                    {
                        type = rb_one_p6.Text;
                    }
                    else if (rb_daily_p6.Checked)
                    {
                        type = rb_daily_p6.Text;
                    }
                    else if (rb_week_p6.Checked)
                    {
                        type = rb_week_p6.Text;
                    }
                    else if (rb_month_p6.Checked)
                    {
                        type = rb_month_p6.Text;
                    }
                    break;
                case 7:
                    /////  7   ///////
                    if (rb_one_p7.Checked)
                    {
                        type = rb_one_p7.Text;
                    }
                    else if (rb_daily_p7.Checked)
                    {
                        type = rb_daily_p7.Text;
                    }
                    else if (rb_week_p7.Checked)
                    {
                        type = rb_week_p7.Text;
                    }
                    else if (rb_month_p7.Checked)
                    {
                        type = rb_month_p7.Text;
                    }
                    break;
                case 8:
                    /////  8   ///////
                    if (rb_one_p8.Checked)
                    {
                        type = rb_one_p8.Text;
                    }
                    else if (rb_daily_p8.Checked)
                    {
                        type = rb_daily_p8.Text;
                    }
                    else if (rb_week_p8.Checked)
                    {
                        type = rb_week_p8.Text;
                    }
                    else if (rb_month_p8.Checked)
                    {
                        type = rb_month_p8.Text;
                    }
                    break;
                case 9:
                    /////  9   ///////
                    if (rb_one_p9.Checked)
                    {
                        type = rb_one_p9.Text;
                    }
                    else if (rb_daily_p9.Checked)
                    {
                        type = rb_daily_p9.Text;
                    }
                    else if (rb_week_p9.Checked)
                    {
                        type = rb_week_p9.Text;
                    }
                    else if (rb_month_p9.Checked)
                    {
                        type = rb_month_p9.Text;
                    }
                    break;

                case 10:
                    /////  10   ///////
                    if (rb_one_p10.Checked)
                    {
                        type = rb_one_p10.Text;
                    }
                    else if (rb_daily_p10.Checked)
                    {
                        type = rb_daily_p10.Text;
                    }
                    else if (rb_week_p10.Checked)
                    {
                        type = rb_week_p10.Text;
                    }
                    else if (rb_month_p10.Checked)
                    {
                        type = rb_month_p10.Text;
                    }
                    break;

                case 11:
                    /////  11   ///////
                    if (rb_one_p11.Checked)
                    {
                        type = rb_one_p11.Text;
                    }
                    else if (rb_daily_p11.Checked)
                    {
                        type = rb_daily_p11.Text;
                    }
                    else if (rb_week_p11.Checked)
                    {
                        type = rb_week_p11.Text;
                    }
                    else if (rb_month_p11.Checked)
                    {
                        type = rb_month_p11.Text;
                    }
                    break;

                case 12:
                    /////  12   ///////
                    if (rb_one_p12.Checked)
                    {
                        type = rb_one_p12.Text;
                    }
                    else if (rb_daily_p12.Checked)
                    {
                        type = rb_daily_p12.Text;
                    }
                    else if (rb_week_p12.Checked)
                    {
                        type = rb_week_p12.Text;
                    }
                    else if (rb_month_p12.Checked)
                    {
                        type = rb_month_p12.Text;
                    }
                    break;

                case 13:
                    /////  13   ///////
                    if (rb_one_p13.Checked)
                    {
                        type = rb_one_p13.Text;
                    }
                    else if (rb_daily_p13.Checked)
                    {
                        type = rb_daily_p13.Text;
                    }
                    else if (rb_week_p13.Checked)
                    {
                        type = rb_week_p13.Text;
                    }
                    else if (rb_month_p13.Checked)
                    {
                        type = rb_month_p13.Text;
                    }
                    break;

                case 14:
                    /////  14   ///////
                    if (rb_one_p14.Checked)
                    {
                        type = rb_one_p14.Text;
                    }
                    else if (rb_daily_p14.Checked)
                    {
                        type = rb_daily_p14.Text;
                    }
                    else if (rb_week_p14.Checked)
                    {
                        type = rb_week_p14.Text;
                    }
                    else if (rb_month_p14.Checked)
                    {
                        type = rb_month_p14.Text;
                    }
                    break;

                case 15:
                    /////  15   ///////
                    if (rb_one_p15.Checked)
                    {
                        type = rb_one_p15.Text;
                    }
                    else if (rb_daily_p15.Checked)
                    {
                        type = rb_daily_p15.Text;
                    }
                    else if (rb_week_p15.Checked)
                    {
                        type = rb_week_p15.Text;
                    }
                    else if (rb_month_p15.Checked)
                    {
                        type = rb_month_p15.Text;
                    }
                    break;
            }
            
         
            return type;
        }

        public void OneRunTime(string type, int TimerNo, int TotalTime) 
        {
            int time = 0;
            if (type == "Daily")
            {
                time = 1440 + TotalTime;
            }
            else if (type == "Weekly")
            {
                time = 10080 + TotalTime;
            }
            else if (type == "Monthly")
            {
                time = 43200 + TotalTime;
            }

            if (time != 0)
            {
                switch (TimerNo)
                {
                    case 1:

                        myTimerOneRunType1 = new System.Windows.Forms.Timer();
                        myTimerOneRunType1.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType1.Tick += new EventHandler(function1ForOneTime);
                        myTimerOneRunType1.Start();
                      
                        break;
                    case 2:
                        myTimerOneRunType2 = new System.Windows.Forms.Timer();
                        myTimerOneRunType2.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType2.Tick += new EventHandler(function2ForOneTime);
                        myTimerOneRunType2.Start();
                     //   myTimerOneRunType2.Stop();
                        break;
                    case 3:
                        myTimerOneRunType3 = new System.Windows.Forms.Timer();
                        myTimerOneRunType3.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType3.Tick += new EventHandler(function3ForOneTime);
                        myTimerOneRunType3.Start();
                      //  myTimerOneRunType3.Stop();
                        break;
                    case 4:
                        myTimerOneRunType4 = new System.Windows.Forms.Timer();
                        myTimerOneRunType4.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType4.Tick += new EventHandler(function4ForOneTime);
                        myTimerOneRunType4.Start();
                      //  myTimerOneRunType4.Stop();
                        break;
                    case 5:
                        myTimerOneRunType5 = new System.Windows.Forms.Timer();
                        myTimerOneRunType5.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType5.Tick += new EventHandler(function5ForOneTime);
                        myTimerOneRunType5.Start();
                      //  myTimerOneRunType5.Stop();
                        break;
                    case 6:
                        myTimerOneRunType6 = new System.Windows.Forms.Timer();
                        myTimerOneRunType6.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType6.Tick += new EventHandler(function6ForOneTime);
                        myTimerOneRunType6.Start();
                     //   myTimerOneRunType6.Stop();
                        break;
                    case 7:
                        myTimerOneRunType7 = new System.Windows.Forms.Timer();
                        myTimerOneRunType7.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType7.Tick += new EventHandler(function7ForOneTime);
                        myTimerOneRunType7.Start();
                      //  myTimerOneRunType7.Stop();
                        break;
                    case 8:
                        myTimerOneRunType8 = new System.Windows.Forms.Timer();
                        myTimerOneRunType8.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType8.Tick += new EventHandler(function8ForOneTime);
                        myTimerOneRunType8.Start();
                      //  myTimerOneRunType8.Stop();
                        break;
                    case 9:
                        myTimerOneRunType9 = new System.Windows.Forms.Timer();
                        myTimerOneRunType9.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType9.Tick += new EventHandler(function9ForOneTime);
                        myTimerOneRunType9.Start();
                      //  myTimerOneRunType9.Stop();
                        break;
                    case 10:
                        myTimerOneRunType10 = new System.Windows.Forms.Timer();
                        myTimerOneRunType10.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType10.Tick += new EventHandler(function10ForOneTime);
                        myTimerOneRunType10.Start();
                      //  myTimerOneRunType10.Stop();
                        break;
                    case 11:
                        myTimerOneRunType11 = new System.Windows.Forms.Timer();
                        myTimerOneRunType11.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType11.Tick += new EventHandler(function11ForOneTime);
                        myTimerOneRunType11.Start();
                      //  myTimerOneRunType11.Stop();
                        break;
                    case 12:
                        myTimerOneRunType12 = new System.Windows.Forms.Timer();
                        myTimerOneRunType12.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType12.Tick += new EventHandler(function12ForOneTime);
                        myTimerOneRunType12.Start();
                      //  myTimerOneRunType12.Stop();
                        break;
                    case 13:
                        myTimerOneRunType13 = new System.Windows.Forms.Timer();
                        myTimerOneRunType13.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType13.Tick += new EventHandler(function13ForOneTime);
                        myTimerOneRunType13.Start();
                     //   myTimerOneRunType13.Stop();
                        break;
                    case 14:
                        myTimerOneRunType14 = new System.Windows.Forms.Timer();
                        myTimerOneRunType14.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType14.Tick += new EventHandler(function14ForOneTime);
                        myTimerOneRunType14.Start();
                     //   myTimerOneRunType14.Stop();
                        break;
                    case 15:
                        myTimerOneRunType15 = new System.Windows.Forms.Timer();
                        myTimerOneRunType15.Interval = (time * 60 * 1000); //  mins
                        myTimerOneRunType15.Tick += new EventHandler(function15ForOneTime);
                        myTimerOneRunType15.Start();
                      //  myTimerOneRunType15.Stop();
                        break;
                }

            }
        }
      

       public void runtime(string type,int TimerNo,int TotalTime)
       {
            int time = 0;
            if (type == "Daily")
            {
                time = 1440 ;
            }
            else if (type == "Weekly")
            {
                time = 10080 ;
            }
            else if (type == "Monthly")
            {
                time = 43200 ;
            }


            if (time != 0)
            {
                switch (TimerNo) 
                {
                    case 1:
                        
                        myTimerRunType1 = new System.Windows.Forms.Timer();
                        myTimerRunType1.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType1.Tick += new EventHandler(function1);
                        myTimerRunType1.Start();
                        break;
                    case 2:
                        myTimerRunType2 = new System.Windows.Forms.Timer();
                        myTimerRunType2.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType2.Tick += new EventHandler(function2);
                        myTimerRunType2.Start();
                        break;
                    case 3:
                        myTimerRunType3 = new System.Windows.Forms.Timer();
                        myTimerRunType3.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType3.Tick += new EventHandler(function3);
                        myTimerRunType3.Start();
                        break;
                    case 4:
                        myTimerRunType4 = new System.Windows.Forms.Timer();
                        myTimerRunType4.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType4.Tick += new EventHandler(function4);
                        myTimerRunType4.Start();
                        break;
                    case 5:
                        myTimerRunType5 = new System.Windows.Forms.Timer();
                        myTimerRunType5.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType5.Tick += new EventHandler(function5);
                        myTimerRunType5.Start();
                        break;
                    case 6:
                        myTimerRunType6 = new System.Windows.Forms.Timer();
                        myTimerRunType6.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType6.Tick += new EventHandler(function6);
                        myTimerRunType6.Start();
                        break;
                    case 7:
                        myTimerRunType7 = new System.Windows.Forms.Timer();
                        myTimerRunType7.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType7.Tick += new EventHandler(function7);
                        myTimerRunType7.Start();
                        break;
                    case 8:
                        myTimerRunType8 = new System.Windows.Forms.Timer();
                        myTimerRunType8.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType8.Tick += new EventHandler(function8);
                        myTimerRunType8.Start();
                        break;
                    case 9:
                        myTimerRunType9 = new System.Windows.Forms.Timer();
                        myTimerRunType9.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType9.Tick += new EventHandler(function9);
                        myTimerRunType9.Start();
                        break;
                    case 10:
                        myTimerRunType10 = new System.Windows.Forms.Timer();
                        myTimerRunType10.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType10.Tick += new EventHandler(function10);
                        myTimerRunType10.Start();
                        break;
                    case 11:
                        myTimerRunType11 = new System.Windows.Forms.Timer();
                        myTimerRunType11.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType11.Tick += new EventHandler(function11);
                        myTimerRunType11.Start();
                        break;
                    case 12:
                        myTimerRunType12 = new System.Windows.Forms.Timer();
                        myTimerRunType12.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType12.Tick += new EventHandler(function12);
                        myTimerRunType12.Start();
                        break;
                    case 13:
                        myTimerRunType13 = new System.Windows.Forms.Timer();
                        myTimerRunType13.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType13.Tick += new EventHandler(function13);
                        myTimerRunType13.Start();
                        break;
                    case 14:
                        myTimerRunType14 = new System.Windows.Forms.Timer();
                        myTimerRunType14.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType14.Tick += new EventHandler(function14);
                        myTimerRunType14.Start();
                        break;
                    case 15:
                        myTimerRunType15 = new System.Windows.Forms.Timer();
                        myTimerRunType15.Interval = (time * 60 * 1000); //  mins
                        myTimerRunType15.Tick += new EventHandler(function15);
                        myTimerRunType15.Start();
                        break;
                }
               
            }
           
        }

       

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void bt_settime_p1_Click(object sender, EventArgs e)
        {
            StatusOn(1);
            type = RunType(1);
            int TotalTime = 0;
           
                if (rb_time_p1.Checked)
                {
                    if (cb_time_p1.Text == "--Select Time--")
                    {
                        StatusOff(1);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else
                    {
                        timeConfig(1);
                    }
                }
                else if (rb_date_p1.Checked)
                {
                      TotalTime = dateConfig(1);
                }

                 OneRunTime(type, 1, TotalTime);
               
              
            

            if (chb_repeat_p1.Checked) 
            {
                Repeat(1);
            }
        }


     

        public void StatusOn(int TimerNo) 
        {
            switch (TimerNo) 
            {
                case 1:
                    status_on_p1.Visible = true;
                    status_off_p1.Visible = false;
                    break;
                case 2:
                    status_on_p2.Visible = true;
                    status_off_p2.Visible = false;
                    break;
                case 3:
                    status_on_p3.Visible = true;
                    status_off_p3.Visible = false;
                    break;
                case 4:
                    status_on_p4.Visible = true;
                    status_off_p4.Visible = false;
                    break;
                case 5:
                    status_on_p5.Visible = true;
                    status_off_p5.Visible = false;
                    break;
                case 6:
                    status_on_p6.Visible = true;
                    status_off_p6.Visible = false;
                    break;
                case 7:
                    status_on_p7.Visible = true;
                    status_off_p7.Visible = false;
                    break;
                case 8:
                    status_on_p8.Visible = true;
                    status_off_p8.Visible = false;
                    break;
                case 9:
                    status_on_p9.Visible = true;
                    status_off_p9.Visible = false;
                    break;
                case 10:
                    status_on_p10.Visible = true;
                    status_off_p10.Visible = false;
                    break;
                case 11:
                    status_on_p11.Visible = true;
                    status_off_p11.Visible = false;
                    break;
                case 12:
                    status_on_p12.Visible = true;
                    status_off_p12.Visible = false;
                    break;
                case 13:
                    status_on_p13.Visible = true;
                    status_off_p13.Visible = false;
                    break;
                case 14:
                    status_on_p14.Visible = true;
                    status_off_p14.Visible = false;
                    break;
                case 15:
                    status_on_p15.Visible = true;
                    status_off_p15.Visible = false;
                    break;
            }
            
        }

        public void StatusOff(int TimerNo) 
        {
            switch (TimerNo)
            {
                case 1:
                    status_on_p1.Visible = false;
                    status_off_p1.Visible = true;
                    break;
                case 2:
                    status_on_p2.Visible = false;
                    status_off_p2.Visible = true;
                    break;
                case 3:
                    status_on_p3.Visible = false;
                    status_off_p3.Visible = true;
                    break;
                case 4:
                    status_on_p4.Visible = false;
                    status_off_p4.Visible = true;
                    break;
                case 5:
                    status_on_p5.Visible = false;
                    status_off_p5.Visible = true;
                    break;
                case 6:
                    status_on_p6.Visible = false;
                    status_off_p6.Visible = true;
                    break;
                case 7:
                    status_on_p7.Visible = false;
                    status_off_p7.Visible = true;
                    break;
                case 8:
                    status_on_p8.Visible = false;
                    status_off_p8.Visible = true;
                    break;
                case 9:
                    status_on_p9.Visible = false;
                    status_off_p9.Visible = true;
                    break;
                case 10:
                    status_on_p10.Visible = false;
                    status_off_p10.Visible = true;
                    break;
                case 11:
                    status_on_p11.Visible = false;
                    status_off_p11.Visible = true;
                    break;
                case 12:
                    status_on_p12.Visible = false;
                    status_off_p12.Visible = true;
                    break;
                case 13:
                    status_on_p13.Visible = false;
                    status_off_p13.Visible = true;
                    break;
                case 14:
                    status_on_p14.Visible = false;
                    status_off_p14.Visible = true;
                    break;
                case 15:
                    status_on_p15.Visible = false;
                    status_off_p15.Visible = true;
                    break;
            }
           
        }

        private void bt_end_p1_Click(object sender, EventArgs e)
        {
            StatusOff(1);
            myTimer1.Stop();
            myTimerRepeat1.Stop();
            myTimerRunType1.Stop();
        }

        private void rb_time_p2_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p2.Enabled = false;
            panel_time_p2.Enabled = true;
        }

        private void rb_date_p2_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p2.Enabled = true;
            panel_time_p2.Enabled = false;
        }

        private void rb_time_p3_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p3.Enabled = false;
            panel_time_p3.Enabled = true;
        }

        private void rb_date_p3_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p3.Enabled = true;
            panel_time_p3.Enabled = false;
        }

        private void rb_time_p4_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p4.Enabled = false;
            panel_time_p4.Enabled = true;
        }

        private void rb_date_p4_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p4.Enabled = true;
            panel_time_p4.Enabled = false;
        }

        private void rb_time_p5_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p5.Enabled = false;
            panel_time_p5.Enabled = true;
        }

        private void rb_date_p5_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p5.Enabled = true;
            panel_time_p5.Enabled = false;
        }

        private void rb_time_p6_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p6.Enabled = false;
            panel_time_p6.Enabled = true;
        }

        private void rb_date_p6_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p6.Enabled = true;
            panel_time_p6.Enabled = false;
        }
        private void rb_time_p7_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p7.Enabled = false;
            panel_time_p7.Enabled = true;
        }

        private void rb_date_p7_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p7.Enabled = true;
            panel_time_p7.Enabled = false;
        }

        private void rb_time_p8_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p8.Enabled = false;
            panel_time_p8.Enabled = true;
        }

        private void rb_date_p8_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p8.Enabled = true;
            panel_time_p8.Enabled = false;
        }

        private void rb_time_p9_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p9.Enabled = false;
            panel_time_p9.Enabled = true;
        }

        private void rb_date_p9_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p9.Enabled = true;
            panel_time_p9.Enabled = false;
        }

        private void rb_time_p10_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p10.Enabled = false;
            panel_time_p10.Enabled = true;
        }

        private void rb_date_p10_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p10.Enabled = true;
            panel_time_p10.Enabled = false;
        }

        private void rb_time_p11_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p11.Enabled = false;
            panel_time_p11.Enabled = true;
        }

        private void rb_date_p11_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p11.Enabled = true;
            panel_time_p11.Enabled = false;
        }

        private void rb_time_p12_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p12.Enabled = false;
            panel_time_p12.Enabled = true;
        }

        private void rb_date_p12_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p12.Enabled = true;
            panel_time_p12.Enabled = false;
        }

        private void rb_time_p13_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p13.Enabled = false;
            panel_time_p13.Enabled = true;
        }

        private void rb_date_p13_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p13.Enabled = true;
            panel_time_p13.Enabled = false;
        }

        private void rb_time_p14_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p14.Enabled = false;
            panel_time_p14.Enabled = true;
        }

        private void rb_date_p14_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p14.Enabled = true;
            panel_time_p14.Enabled = false;
        }

        private void rb_time_p15_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p15.Enabled = false;
            panel_time_p15.Enabled = true;
        }

        private void rb_date_p15_CheckedChanged(object sender, EventArgs e)
        {
            panel_date_p15.Enabled = true;
            panel_time_p15.Enabled = false;
        }

        private void bt_time_p3_Click(object sender, EventArgs e)
        {
            type = RunType(3);
            StatusOn(3);
            int TotalTime = 0;

            if (rb_time_p3.Checked)
                {

                        if (cb_time_p3.Text == "--Select Time--")
                        {
                            StatusOff(3);
                            MessageBox.Show("Plase select time !!!!");
                        }
                        else
                        {
                        TotalTime = timeConfig(3);
                        }
                }
                else if (rb_date_p3.Checked)
                {
                TotalTime = dateConfig(3);
                }
            OneRunTime(type, 3, TotalTime);

            if (chb_repeat_p3.Checked)
            {
                Repeat(3);
            }
        }

        private void bt_end_p3_Click(object sender, EventArgs e)
        {
            StatusOff(3);
            myTimer3.Stop();
            myTimerRepeat3.Stop();
            myTimerRunType3.Stop();
        }

        private void bt_time_p4_Click(object sender, EventArgs e)
        {
            type = RunType(4);
            StatusOn(4);
            int TotalTime = 0;
            if (rb_time_p4.Checked)
                {
                        if (cb_time_p4.Text == "--Select Time--")
                        {
                            StatusOff(4);
                            MessageBox.Show("Plase select time !!!!");
                        }
                        else
                        {
                             TotalTime = timeConfig(4);
                        }
                }
                else if (rb_date_p4.Checked)
                {
                         TotalTime = dateConfig(4);
                }

            OneRunTime(type, 4, TotalTime);

            if (chb_repeat_p4.Checked)
            {
                Repeat(4);
            }
           
        }

        private void bt_end_p4_Click(object sender, EventArgs e)
        {
            StatusOff(4);
            myTimer4.Stop();
            myTimerRepeat4.Stop();
            myTimerRunType4.Stop();
        }

        private void bt_time_p5_Click(object sender, EventArgs e)
        {
            type = RunType(5);
            StatusOn(5);
            int TotalTime = 0;


            if (rb_time_p5.Checked)
                {
                    if (cb_time_p5.Text == "--Select Time--")
                    {
                        StatusOff(5);
                        MessageBox.Show("Plase select time !!!!");
                    }
                    else 
                    {
                    TotalTime = timeConfig(5);
                    }
                        
                }
                else if (rb_date_p5.Checked)
                {
                TotalTime = dateConfig(5);
                }

            OneRunTime(type, 5, TotalTime);


            if (chb_repeat_p5.Checked)
            {
                Repeat(5);
            }
        }

        private void bt_end_p5_Click(object sender, EventArgs e)
        {
            StatusOff(5);
            myTimer5.Stop();
            myTimerRepeat5.Stop();
            myTimerRunType5.Stop();
        }

        private void bt_time_p6_Click(object sender, EventArgs e)
        {
            StatusOn(6);
            type = RunType(6);
            int TotalTime = 0;

            if (rb_time_p6.Checked)
            {
                if (cb_time_p6.Text == "--Select Time--")
                {
                    StatusOff(6);
                    MessageBox.Show("Plase select time !!!!");
                }
                else
                {
                    TotalTime = timeConfig(6);
                }
            }
            else if (rb_date_p6.Checked)
            {
                TotalTime = dateConfig(6);
            }

            OneRunTime(type, 6, TotalTime);


            if (chb_repeat_p6.Checked)
            {
                Repeat(6);
            }
        }

        private void bt_end_p6_Click(object sender, EventArgs e)
        {
            StatusOff(6);
            myTimer6.Stop();
            myTimerRepeat6.Stop();
            myTimerRunType6.Stop();
        }

        private void bt_time_p7_Click(object sender, EventArgs e)
        {
            type = RunType(7);
            StatusOn(7);
            int TotalTime = 0;


            if (rb_time_p7.Checked)
            {
                if (cb_time_p7.Text == "--Select Time--")
                {
                    StatusOff(7);
                    MessageBox.Show("Plase select time !!!!");
                }
                else
                {
                    TotalTime = timeConfig(7);
                }

            }
            else if (rb_date_p7.Checked)
            {
                TotalTime = dateConfig(7);
            }

            OneRunTime(type, 7, TotalTime);

            if (chb_repeat_p7.Checked)
            {
                Repeat(7);
            }
        }

        private void bt_end_p7_Click(object sender, EventArgs e)
        {
            StatusOff(7);
            myTimer7.Stop();
            myTimerRepeat7.Stop();
            myTimerRunType7.Stop();
        }

        private void bt_time_p8_Click(object sender, EventArgs e)
        {
            type = RunType(8);
            StatusOn(8);
            int TotalTime = 0;


            if (rb_time_p8.Checked)
            {
                if (cb_time_p8.Text == "--Select Time--")
                {
                    StatusOff(8);
                    MessageBox.Show("Plase select time !!!!");
                }
                else
                {
                    TotalTime = timeConfig(8);
                }

            }
            else if (rb_date_p8.Checked)
            {
                TotalTime = dateConfig(8);
            }

            OneRunTime(type, 8, TotalTime);

            if (chb_repeat_p8.Checked)
            {
                Repeat(8);
            }
        }

        private void bt_end_p8_Click(object sender, EventArgs e)
        {
            StatusOff(8);
            myTimer8.Stop();
            myTimerRepeat8.Stop();
            myTimerRunType8.Stop();
        }

        private void bt_time_p9_Click(object sender, EventArgs e)
        {
            type = RunType(9);
            StatusOn(9);
            int TotalTime = 0;


            if (rb_time_p9.Checked)
            {
                if (cb_time_p9.Text == "--Select Time--")
                {
                    StatusOff(9);
                    MessageBox.Show("Plase select time !!!!");
                }
                else
                {
                    TotalTime = timeConfig(9);
                }

            }
            else if (rb_date_p9.Checked)
            {
                TotalTime = dateConfig(9);
            }

            OneRunTime(type, 9, TotalTime);

            if (chb_repeat_p9.Checked)
            {
                Repeat(9);
            }
        }

        private void bt_end_p9_Click(object sender, EventArgs e)
        {
            StatusOff(9);
            myTimer9.Stop();
            myTimerRepeat9.Stop();
            myTimerRunType9.Stop();
        }

        private void bt_time_p10_Click(object sender, EventArgs e)
        {
            type = RunType(10);
            StatusOn(10);
            int TotalTime = 0;


            if (rb_time_p10.Checked)
            {
                if (cb_time_p10.Text == "--Select Time--")
                {
                    StatusOff(10);
                    MessageBox.Show("Plase select time !!!!");
                }
                else
                {
                    TotalTime = timeConfig(10);
                }

            }
            else if (rb_date_p10.Checked)
            {
                TotalTime = dateConfig(10);
            }

            OneRunTime(type, 10, TotalTime);

            if (chb_repeat_p10.Checked)
            {
                Repeat(10);
            }
        }

        private void bt_end_p10_Click(object sender, EventArgs e)
        {
            StatusOff(10);
            myTimer10.Stop();
            myTimerRepeat10.Stop();
            myTimerRunType10.Stop();
        }

        private void bt_time_p11_Click(object sender, EventArgs e)
        {
            type = RunType(11);
            StatusOn(11);
            int TotalTime = 0;


            if (rb_time_p11.Checked)
            {
                if (cb_time_p11.Text == "--Select Time--")
                {
                    StatusOff(11);
                    MessageBox.Show("Plase select time !!!!");
                }
                else
                {
                    TotalTime = timeConfig(11);
                }

            }
            else if (rb_date_p11.Checked)
            {
                TotalTime = dateConfig(11);
            }
            OneRunTime(type, 11, TotalTime);

            if (chb_repeat_p11.Checked)
            {
                Repeat(11);
            }
        }

        private void bt_end_p11_Click(object sender, EventArgs e)
        {
            StatusOff(11);
            myTimer11.Stop();
            myTimerRepeat11.Stop();
            myTimerRunType11.Stop();
        }

        private void bt_time_p12_Click(object sender, EventArgs e)
        {
            type = RunType(12);
            StatusOn(12);
            int TotalTime = 0;


            if (rb_time_p12.Checked)
            {
                if (cb_time_p12.Text == "--Select Time--")
                {
                    StatusOff(12);
                    MessageBox.Show("Plase select time !!!!");
                }
                else
                {
                    TotalTime = timeConfig(12);
                }

            }
            else if (rb_date_p12.Checked)
            {
                TotalTime = dateConfig(12);
            }

            OneRunTime(type, 12, TotalTime);

            if (chb_repeat_p12.Checked)
            {
                Repeat(12);
            }
        }

        private void bt_end_p12_Click(object sender, EventArgs e)
        {
            StatusOff(12);
            myTimer12.Stop();
            myTimerRepeat12.Stop();
            myTimerRunType12.Stop();
        }
        private void bt_time_p13_Click(object sender, EventArgs e)
        {
            type = RunType(13);
            StatusOn(13);
            int TotalTime = 0;


            if (rb_time_p13.Checked)
            {
                if (cb_time_p13.Text == "--Select Time--")
                {
                    StatusOff(13);
                    MessageBox.Show("Plase select time !!!!");
                }
                else
                {
                    TotalTime = timeConfig(13);
                }

            }
            else if (rb_date_p13.Checked)
            {
                TotalTime = dateConfig(13);
            }

            OneRunTime(type, 13, TotalTime);

            if (chb_repeat_p13.Checked)
            {
                Repeat(13);
            }
        }

        private void bt_end_p13_Click(object sender, EventArgs e)
        {
            StatusOff(13);
            myTimer13.Stop();
            myTimerRepeat13.Stop();
            myTimerRunType13.Stop();
        }
        private void bt_time_p14_Click(object sender, EventArgs e)
        {
            type = RunType(14);
            StatusOn(94);
            int TotalTime = 0;


            if (rb_time_p14.Checked)
            {
                if (cb_time_p14.Text == "--Select Time--")
                {
                    StatusOff(14);
                    MessageBox.Show("Plase select time !!!!");
                }
                else
                {
                    TotalTime = timeConfig(14);
                }

            }
            else if (rb_date_p14.Checked)
            {
                TotalTime = dateConfig(14);
            }

            OneRunTime(type, 14, TotalTime);

            if (chb_repeat_p14.Checked)
            {
                Repeat(14);
            }
        }

        private void bt_end_p14_Click(object sender, EventArgs e)
        {
            StatusOff(14);
            myTimer14.Stop();
            myTimerRepeat14.Stop();
            myTimerRunType14.Stop();
        }
        private void bt_time_p15_Click(object sender, EventArgs e)
        {
            type = RunType(15);
            StatusOn(15);
            int TotalTime = 0;


            if (rb_time_p15.Checked)
            {
                if (cb_time_p15.Text == "--Select Time--")
                {
                    StatusOff(15);
                    MessageBox.Show("Plase select time !!!!");
                }
                else
                {
                    TotalTime = timeConfig(15);
                }

            }
            else if (rb_date_p15.Checked)
            {
                TotalTime = dateConfig(15);
            }

            OneRunTime(type, 15, TotalTime);

            if (chb_repeat_p15.Checked)
            {
                Repeat(15);
            }
        }

        private void bt_end_p15_Click(object sender, EventArgs e)
        {
            StatusOff(15);
            myTimer15.Stop();
            myTimerRepeat15.Stop();
            myTimerRunType15.Stop();
        }
        private void chb_repeat_p1_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p1.Checked) 
            {
                panel_repeat_p1.Enabled = true;
            }
            else 
            {
                panel_repeat_p1.Enabled = false;
            }
           
        }
        private void chb_repeat_p2_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p2.Checked)
            {
                panel_repeat_p2.Enabled = true;
            }
            else
            {
                panel_repeat_p2.Enabled = false;
            }

        }
        private void chb_repeat_p3_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p3.Checked)
            {
                panel_repeat_p3.Enabled = true;
            }
            else
            {
                panel_repeat_p3.Enabled = false;
            }

        }
        private void chb_repeat_p4_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p4.Checked)
            {
                panel_repeat_p4.Enabled = true;
            }
            else
            {
                panel_repeat_p4.Enabled = false;
            }

        }
        private void chb_repeat_p5_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p5.Checked)
            {
                panel_repeat_p5.Enabled = true;
            }
            else
            {
                panel_repeat_p5.Enabled = false;
            }

        }
        private void chb_repeat_p6_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p6.Checked)
            {
                panel_repeat_p6.Enabled = true;
            }
            else
            {
                panel_repeat_p6.Enabled = false;
            }

        }
        private void chb_repeat_p7_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p7.Checked)
            {
                panel_repeat_p7.Enabled = true;
            }
            else
            {
                panel_repeat_p7.Enabled = false;
            }

        }
        private void chb_repeat_p8_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p8.Checked)
            {
                panel_repeat_p8.Enabled = true;
            }
            else
            {
                panel_repeat_p8.Enabled = false;
            }

        }

        private void chb_repeat_p9_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p9.Checked)
            {
                panel_repeat_p9.Enabled = true;
            }
            else
            {
                panel_repeat_p9.Enabled = false;
            }

        }

        private void chb_repeat_p10_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p10.Checked)
            {
                panel_repeat_p10.Enabled = true;
            }
            else
            {
                panel_repeat_p10.Enabled = false;
            }

        }
        private void chb_repeat_p11_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p11.Checked)
            {
                panel_repeat_p11.Enabled = true;
            }
            else
            {
                panel_repeat_p11.Enabled = false;
            }

        }
        private void chb_repeat_p12_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p12.Checked)
            {
                panel_repeat_p12.Enabled = true;
            }
            else
            {
                panel_repeat_p12.Enabled = false;
            }

        }
        private void chb_repeat_p13_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p13.Checked)
            {
                panel_repeat_p13.Enabled = true;
            }
            else
            {
                panel_repeat_p13.Enabled = false;
            }

        }
        private void chb_repeat_p14_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p14.Checked)
            {
                panel_repeat_p14.Enabled = true;
            }
            else
            {
                panel_repeat_p14.Enabled = false;
            }

        }
        private void chb_repeat_p15_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_repeat_p15.Checked)
            {
                panel_repeat_p15.Enabled = true;
            }
            else
            {
                panel_repeat_p15.Enabled = false;
            }

        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            panel_date_p1.Enabled = false;
            panel_time_p1.Enabled = true;
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            panel_date_p1.Enabled = true;
            panel_time_p1.Enabled = false;
        }

        private void bt_settime_p2_Click(object sender, EventArgs e)
        {
            StatusOn(2);
            type = RunType(2);
            int TotalTime = 0;


                if (rb_time_p2.Checked)
                {
                if (cb_time_p2.Text == "--Select Time--")
                {
                    StatusOff(2);
                    MessageBox.Show("Plase select time !!!!");
                }
                else
                {
                    TotalTime = timeConfig(2);
                }
            }
                else if (rb_date_p2.Checked)
                {
                TotalTime = dateConfig(2);
                }

            OneRunTime(type, 2, TotalTime);

            if (chb_repeat_p2.Checked)
            {
                Repeat(2);
            }
        }

        private void bt_end_p2_Click(object sender, EventArgs e)
        {
            StatusOff(2);
            myTimer2.Stop();
            myTimerRepeat2.Stop();
            myTimerRunType2.Stop();
        }





        #endregion

        #region Function Config Event      


        private void function1ForOneTime(object sender, EventArgs e)
        {
            string filepath1 = "";
            string folderPath1 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath1 = fileHelper.CreateFolder(date);

                filepath1 = fileHelper.CreateFile(folderPath1, "ImportExtrat");

                string valueNode = rf.getdatanode("ImportExtrat", filepath1);
                fileHelper.writelog(filepath1, "ImportExtrat", "-------Now start-----------");
                //code here
                var url1 = valueNode;

                var uri = new Uri(url1);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);
                //  fileHelper.writelog(filepath1, "ImportExtrat", "-------End -----------");
                fileHelper.writelog(filepath1, "ImportExtrat", "-------End -----------");
                //
                myTimer1.Stop();
                myTimerOneRunType1.Stop();
                int time =  ForGetDateOrTime(1);
                type = RunType(1);
                runtime(type,1,time);
            }
            catch (Exception ex)
            {              
                myTimer1.Stop();
            }

        }

        private void function2ForOneTime(object sender, EventArgs e)
        {

            string filepath2 = "";
            string folderPath2 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath2 = fileHelper.CreateFolder(date);
                filepath2 = fileHelper.CreateFile(folderPath2, "ConvertOA");

                // filepath2 = checkDateLog();
                string valueNode = rf.getdatanode("ConvertOA", filepath2);
                fileHelper.writelog(folderPath2, "ConvertOA", "-------Now start-----------");
                //code here

                var url2 = valueNode;
                var uri = new Uri(url2);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                //
                myTimer2.Stop();
                myTimerOneRunType2.Stop();
                fileHelper.writelog(filepath2, "ConvertOA", "-------end -----------");
                int time = ForGetDateOrTime(2);
                type = RunType(2);
                runtime(type, 2, time);
            }
            catch (Exception ex)
            {
                //   response2.Close();
                fileHelper.writelog(filepath2, "ConvertOA", "Exception ------ " + ex.ToString());
                myTimer2.Stop();
            }

        }

        private void function3ForOneTime(object sender, EventArgs e)
        {


            string filepath3 = "";
            string folderPath3 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath3 = fileHelper.CreateFolder(date);
                filepath3 = fileHelper.CreateFile(folderPath3, "ImportAction");

                string valueNode = rf.getdatanode("ImportAction", filepath3);
                fileHelper.writelog(filepath3, "ImportAction", "-------Now start-----------");
                //code here

                var url3 = valueNode;
                var uri = new Uri(url3);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer3.Stop();
                myTimerOneRunType3.Stop();
                fileHelper.writelog(filepath3, "ImportAction", "-------End -----------");
                int time = ForGetDateOrTime(3);
                type = RunType(3);
                runtime(type, 3, time);
            }
            catch (Exception ex)
            {
                //  response3.Close();
                fileHelper.writelog(filepath3, "ImportAction", "Exception ------ " + ex.ToString());
                myTimer3.Stop();
            }

        }

        private void function4ForOneTime(object sender, EventArgs e)
        {


            string filepath4 = "";
            string folderPath4 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath4 = fileHelper.CreateFolder(date);
                filepath4 = fileHelper.CreateFile(folderPath4, "SLA-Delete");

                string valueNode = rf.getdatanode("SLA-Delete", filepath4);
                fileHelper.writelog(filepath4, "SLA-Delete", "-------Now start-----------");
                //code here

                var url4 = valueNode;
                var uri = new Uri(url4);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer4.Stop();
                myTimerOneRunType4.Stop();
                fileHelper.writelog(filepath4, "SLA-Delete", "-------End -----------");
                int time = ForGetDateOrTime(4);
                type = RunType(4);
                runtime(type, 4, time);
            }
            catch (Exception ex)
            {
                //  response4.Close();
                fileHelper.writelog(filepath4, "SLA-Delete", "Exception ------ " + ex.ToString());
                myTimer4.Stop();
            }

        }

        private void function5ForOneTime(object sender, EventArgs e)
        {


            string filepath5 = "";
            string folderPath5 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath5 = fileHelper.CreateFolder(date);
                filepath5 = fileHelper.CreateFile(folderPath5, "SLA-Update");

                string valueNode = rf.getdatanode("SLA-Update", filepath5);
                fileHelper.writelog(filepath5, "SLA-Update", "-------Now start-----------");
                //code here

                var url5 = valueNode;
                var uri = new Uri(url5);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer5.Stop();
                myTimerOneRunType5.Stop();
                fileHelper.writelog(filepath5, "SLA-Update", "-------end -----------");
                int time = ForGetDateOrTime(5);
                type = RunType(5);
                runtime(type, 5, time);
            }
            catch (Exception ex)
            {
                // response5.Close();
                fileHelper.writelog(filepath5, "SLA-Update", "Exception ------ " + ex.ToString());
                myTimer5.Stop();
            }

        }

        private void function6ForOneTime(object sender, EventArgs e)
        {


            string filepath6 = "";
            string folderPath6 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath6 = fileHelper.CreateFolder(date);
                filepath6 = fileHelper.CreateFile(folderPath6, "Update1P");


                string valueNode = rf.getdatanode("Update1P", filepath6);
                fileHelper.writelog(folderPath6, "Update1P", "-------Now start-----------");
                //code here

                var url6 = valueNode;
                var uri = new Uri(url6);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer6.Stop();
                myTimerOneRunType6.Stop();
                fileHelper.writelog(filepath6, "Update1P", "-------End -----------");
                int time = ForGetDateOrTime(6);
                type = RunType(6);
                runtime(type, 6, time);
            }
            catch (Exception ex)
            {
                //  response6.Close();
                fileHelper.writelog(filepath6, "Update1P", "Exception ------ " + ex.ToString());
                myTimer6.Stop();
            }

        }

        private void function7ForOneTime(object sender, EventArgs e)
        {


            string filepath7 = "";
            string folderPath7 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath7 = fileHelper.CreateFolder(date);
                filepath7 = fileHelper.CreateFile(folderPath7, "ConvertZip");


                string valueNode = rf.getdatanode("ConvertZip", filepath7);
                fileHelper.writelog(filepath7, "ConvertZip", "-------Now start-----------");
                //code here

                var url7 = valueNode;


                var uri = new Uri(url7);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer7.Stop();
                myTimerOneRunType7.Stop();
                fileHelper.writelog(filepath7, "ConvertZip", "-------End-----------");
                int time = ForGetDateOrTime(7);
                type = RunType(7);
                runtime(type, 7, time);
            }
            catch (Exception ex)
            {
                //  response7.Close();
                fileHelper.writelog(filepath7, "ConvertZip", "Exception ------ " + ex.ToString());
                myTimer7.Stop();
            }

        }

        private void function8ForOneTime(object sender, EventArgs e)
        {


            string filepath8 = "";
            string folderPath8 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath8 = fileHelper.CreateFolder(date);
                filepath8 = fileHelper.CreateFile(folderPath8, "ExportSentMail");

                string valueNode = rf.getdatanode("ExportSentMail", filepath8);
                fileHelper.writelog(filepath8, "ExportSentMail", "-------Now start-----------");
                //code here

                var url8 = valueNode;
                var uri = new Uri(url8);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer8.Stop();
                myTimerOneRunType8.Stop();
                fileHelper.writelog(filepath8, "ExportSentMail", "-------End-----------");
                int time = ForGetDateOrTime(8);
                type = RunType(8);
                runtime(type, 8, time);
            }
            catch (Exception ex)
            {
                fileHelper.writelog(filepath8, "ExportSentMail", "Exception ------ " + ex.ToString());
                // response8.Close();
                //
                myTimer8.Stop();

            }

        }
        private void function9ForOneTime(object sender, EventArgs e)
        {


            string filepath9 = "";
            string folderPath9 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath9 = fileHelper.CreateFolder(date);
                filepath9 = fileHelper.CreateFile(folderPath9, "OAReport");

                string valueNode = rf.getdatanode("OAReport", filepath9);
                fileHelper.writelog(filepath9, "OAReport", "-------Now start-----------");
                //code here          
                var url9 = valueNode;
                var uri = new Uri(url9);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer9.Stop();
                myTimerOneRunType9.Stop();
                fileHelper.writelog(filepath9, "OAReport", "-------end-----------");
                int time = ForGetDateOrTime(9);
                type = RunType(9);
                runtime(type, 9, time);
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath9, "OAReport", "Exception ------ " + ex.ToString());
                //
                myTimer9.Stop();
            }

        }

        private void function10ForOneTime(object sender, EventArgs e)
        {


            string filepath10 = "";
            string folderPath10 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath10 = fileHelper.CreateFolder(date);
                filepath10 = fileHelper.CreateFile(folderPath10, "BUReport");

                string valueNode = rf.getdatanode("BUReport", filepath10);
                fileHelper.writelog(filepath10, "BUReport", "-------Now start-----------");
                //code here          
                var url10 = valueNode;
                var uri = new Uri(url10);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer10.Stop();
                myTimerOneRunType10.Stop();
                fileHelper.writelog(filepath10, "BUReport", "-------end-----------");
                int time = ForGetDateOrTime(10);
                type = RunType(10);
                runtime(type, 10, time);
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath10, "BUReport", "Exception ------ " + ex.ToString());
                //
                myTimer10.Stop();
            }

        }
        private void function11ForOneTime(object sender, EventArgs e)
        {


            string filepath11 = "";
            string folderPath11 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath11 = fileHelper.CreateFolder(date);
                filepath11 = fileHelper.CreateFile(folderPath11, "BOTReport");

                string valueNode = rf.getdatanode("BOTReport", filepath11);
                fileHelper.writelog(filepath11, "BOTReport", "-------Now start-----------");
                //code here          
                var url11 = valueNode;
                var uri = new Uri(url11);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer11.Stop();
                myTimerOneRunType11.Stop();
                fileHelper.writelog(filepath11, "BOTReport", "-------end-----------");
                int time = ForGetDateOrTime(11);
                type = RunType(11);
                runtime(type, 11, time);
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath11, "BOTReport", "Exception ------ " + ex.ToString());
                //
                myTimer10.Stop();
            }

        }
        /* private void function11ForOneTime(object sender, EventArgs e)
         {


             string filepath11 = "";
             string folderPath11 = "";
             try
             {
                 string date = DateTime.Now.ToString("dd-MM-yyyy");
                 folderPath11 = fileHelper.CreateFolder(date);
                 filepath11 = fileHelper.CreateFile(folderPath11, "BOTReport");

                 string valueNode = rf.getdatanode("BOTReport", filepath11);
                 fileHelper.writelog(filepath11, "BOTReport", "-------Now start-----------");
                 //code here          
                 var url11 = valueNode;
                 var uri = new Uri(url11);
                 var webClient = new System.Net.WebClient();
                 webClient.DownloadStringAsync(uri);

                 myTimer11.Stop();
                 myTimerOneRunType11.Stop();
                 fileHelper.writelog(filepath11, "BOTReport", "-------end-----------");
                 int time = ForGetDateOrTime(11);
                 type = RunType(11);
                 runtime(type, 11, time);
             }
             catch (Exception ex)
             {

                 // response9.Close();
                 fileHelper.writelog(filepath11, "BOTReport", "Exception ------ " + ex.ToString());
                 //
                 myTimer11.Stop();
             }

         }*/
        private void function12ForOneTime(object sender, EventArgs e)
        {


            string filepath12 = "";
            string folderPath12 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath12 = fileHelper.CreateFolder(date);
                filepath12 = fileHelper.CreateFile(folderPath12, "UpdateCase");

                string valueNode = rf.getdatanode("UpdateCase", filepath12);
                fileHelper.writelog(filepath12, "UpdateCase", "-------Now start-----------");
                //code here          
                var url12 = valueNode;
                var uri = new Uri(url12);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer12.Stop();
                myTimerOneRunType12.Stop();
                fileHelper.writelog(filepath12, "UpdateCase", "-------end-----------");
                int time = ForGetDateOrTime(12);
                type = RunType(12);
                runtime(type, 12, time);
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath12, "UpdateCase", "Exception ------ " + ex.ToString());
                //
                myTimer12.Stop();
            }

        }
        private void function13ForOneTime(object sender, EventArgs e)
        {


            string filepath13 = "";
            string folderPath13 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath13 = fileHelper.CreateFolder(date);
                filepath13 = fileHelper.CreateFile(folderPath13, "temp1");

                string valueNode = rf.getdatanode("temp1", filepath13);
                fileHelper.writelog(filepath13, "temp1", "-------Now start-----------");
                //code here          
                var url13 = valueNode;
                var uri = new Uri(url13);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer13.Stop();
                myTimerOneRunType13.Stop();
                fileHelper.writelog(filepath13, "temp1", "-------end-----------");
                int time = ForGetDateOrTime(13);
                type = RunType(13);
                runtime(type, 13, time);
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath13, "Function13", "Exception ------ " + ex.ToString());
                //
                myTimer13.Stop();
            }

        }
        private void function14ForOneTime(object sender, EventArgs e)
        {


            string filepath14 = "";
            string folderPath14 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath14 = fileHelper.CreateFolder(date);
                filepath14 = fileHelper.CreateFile(folderPath14, "temp2");

                string valueNode = rf.getdatanode("temp2", filepath14);
                fileHelper.writelog(filepath14, "temp2", "-------Now start-----------");
                //code here          
                var url14 = valueNode;
                var uri = new Uri(url14);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer14.Stop();
                myTimerOneRunType14.Stop();
                fileHelper.writelog(filepath14, "temp2", "-------end-----------");
                int time = ForGetDateOrTime(14);
                type = RunType(14);
                runtime(type, 14, time);
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath14, "temp2", "Exception ------ " + ex.ToString());
                //
                myTimer14.Stop();
            }

        }
        private void function15ForOneTime(object sender, EventArgs e)
        {


            string filepath15 = "";
            string folderPath15 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath15 = fileHelper.CreateFolder(date);
                filepath15 = fileHelper.CreateFile(folderPath15, "temp3");

                string valueNode = rf.getdatanode("temp3", filepath15);
                fileHelper.writelog(filepath15, "temp3", "-------Now start-----------");
                //code here          
                var url15 = valueNode;
                var uri = new Uri(url15);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer15.Stop();
                myTimerOneRunType15.Stop();
                fileHelper.writelog(filepath15, "temp3", "-------end-----------");
                int time = ForGetDateOrTime(15);
                type = RunType(15);
                runtime(type, 15, time);
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath15, "temp3", "Exception ------ " + ex.ToString());
                //
                myTimer15.Stop();
            }

        }

        private int ForGetDateOrTime(int timerNo)
        {
            DateTime date2 = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
            int ResultTime = 0;

            switch (timerNo)
            {
                case 1:
                    if (dateTimePicker1.Value!=null && tp_p1.Text!=null) 
                    {
                        DateTime date1_1 = Convert.ToDateTime(dateTimePicker1.Value.ToString("dd-MM-yyyy") + " " + tp_p1.Text);
                        TimeSpan ts1 = date1_1 - date2;
                        Mytime1 = int.Parse(ts1.TotalMinutes.ToString());
                    } 
                    else if (cb_time_p1.Text != "--Select Time--") 
                    {
                        string[] selectedMin1 = (cb_time_p1.Text).Split(' ');
                        Mytime1 = int.Parse(selectedMin1[0]);
                       
                    }
                    ResultTime = Mytime1;


                    break;
                case 2:
                    if (dp_p2.Value!=null && tp_p2.Text != null) 
                    {
                        DateTime date1_2 = Convert.ToDateTime(dp_p2.Value.ToString("dd-MM-yyyy") + " " + tp_p2.Text);
                        TimeSpan ts2 = date1_2 - date2;
                        Mytime2 = int.Parse(ts2.TotalMinutes.ToString());
                    }   
                    else if (cb_time_p2.Text != "--Select Time--") 
                    {
                        string[] selectedMin2 = (cb_time_p2.Text).Split(' ');
                        Mytime2 = int.Parse(selectedMin2[0]);
                      
                    }
                    ResultTime = Mytime2;

                    break;
                case 3:
                    if (dp_p3.Value != null && tp_p3.Text != null) 
                    {
                        DateTime date1_3 = Convert.ToDateTime(dp_p3.Value.ToString("dd-MM-yyyy") + " " + tp_p3.Text);
                        TimeSpan ts3 = date1_3 - date2;
                        Mytime3 = int.Parse(ts3.TotalMinutes.ToString());
                    }   
                    else if (cb_time_p3.Text != "--Select Time--")
                    {
                        string[] selectedMin3 = (cb_time_p3.Text).Split(' ');
                        Mytime3 = int.Parse(selectedMin3[0]);
                       
                    }
                    ResultTime = Mytime3;

                    break;
                case 4:
                    if (dp_p4.Value != null && tp_p4.Text != null) 
                    {
                        DateTime date1_4 = Convert.ToDateTime(dp_p4.Value.ToString("dd-MM-yyyy") + " " + tp_p4.Text);
                        TimeSpan ts4 = date1_4 - date2;
                        Mytime4 = int.Parse(ts4.TotalMinutes.ToString());
                    } 
                    else if (cb_time_p4.Text != "--Select Time--") 
                    {
                        string[] selectedMin4 = (cb_time_p4.Text).Split(' ');
                        Mytime4 = int.Parse(selectedMin4[0]);
                      
                    }
                    ResultTime = Mytime4;

                    break;
                case 5:
                    if (dp_p5.Value != null && tp_p5.Text != null) 
                    {
                        DateTime date1_5 = Convert.ToDateTime(dp_p5.Value.ToString("dd-MM-yyyy") + " " + tp_p5.Text);
                        TimeSpan ts5 = date1_5 - date2;
                        Mytime5 = int.Parse(ts5.TotalMinutes.ToString());
                    }   
                    else if (cb_time_p5.Text != "--Select Time--") 
                    {
                        string[] selectedMin5 = (cb_time_p5.Text).Split(' ');
                        Mytime5 = int.Parse(selectedMin5[0]);
                       
                    }
                    ResultTime = Mytime5;

                    break;
                case 6:
                    if (dp_p6.Value != null && tp_p6.Text != null) 
                    {
                        DateTime date1_6 = Convert.ToDateTime(dp_p6.Value.ToString("dd-MM-yyyy") + " " + tp_p6.Text);
                        TimeSpan ts6 = date1_6 - date2;
                        Mytime6 = int.Parse(ts6.TotalMinutes.ToString());
                    }  
                    else if (cb_time_p6.Text != "--Select Time--") 
                    {
                        string[] selectedMin6 = (cb_time_p6.Text).Split(' ');
                        Mytime6 = int.Parse(selectedMin6[0]);
                      
                    }
                    ResultTime = Mytime6;

                    break;
                case 7:
                    if (dp_p7.Value != null && tp_p7.Text != null) 
                    {
                        DateTime date1_7 = Convert.ToDateTime(dp_p7.Value.ToString("dd-MM-yyyy") + " " + tp_p7.Text);
                        TimeSpan ts7 = date1_7 - date2;
                        Mytime7 = int.Parse(ts7.TotalMinutes.ToString());
                    } 
                    else if (cb_time_p7.Text != "--Select Time--") 
                    {
                        string[] selectedMin7 = (cb_time_p7.Text).Split(' ');
                        Mytime7 = int.Parse(selectedMin7[0]);
                      
                    }
                    ResultTime = Mytime7;

                    break;
                case 8:
                    if (dp_p8.Value != null && tp_p8.Text != null) 
                    {
                        DateTime date1_8 = Convert.ToDateTime(dp_p8.Value.ToString("dd-MM-yyyy") + " " + tp_p8.Text);
                        TimeSpan ts8 = date1_8 - date2;
                        Mytime8 = int.Parse(ts8.TotalMinutes.ToString());
                    }   
                    else if (cb_time_p8.Text != "--Select Time--") 
                    {
                        string[] selectedMin8 = (cb_time_p8.Text).Split(' ');
                        Mytime8 = int.Parse(selectedMin8[0]);
                      
                    }
                    ResultTime = Mytime8;


                    break;
                case 9:
                    if (dp_p9.Value != null && tp_p9.Text != null) 
                    {
                        DateTime date1_9 = Convert.ToDateTime(dp_p9.Value.ToString("dd-MM-yyyy") + " " + tp_p9.Text);
                        TimeSpan ts9 = date1_9 - date2;
                        Mytime9 = int.Parse(ts9.TotalMinutes.ToString());
                    }
                    else if(cb_time_p9.Text != "--Select Time--")
                    {
                        string[] selectedMin9 = (cb_time_p9.Text).Split(' ');
                        Mytime9 = int.Parse(selectedMin9[0]);
                       
                    }
                    ResultTime = Mytime9;

                    break;
                case 10:
                    if (dp_p10.Value != null && tp_p10.Text != null) 
                    {
                        DateTime date1_10 = Convert.ToDateTime(dp_p10.Value.ToString("dd-MM-yyyy") + " " + tp_p10.Text);
                        TimeSpan ts10 = date1_10 - date2;
                        Mytime10 = int.Parse(ts10.TotalMinutes.ToString());
                    }  
                    else if (cb_time_p10.Text != "--Select Time--") 
                    {
                        string[] selectedMin10 = (cb_time_p10.Text).Split(' ');
                        Mytime10 = int.Parse(selectedMin10[0]);
                      
                    }
                    ResultTime = Mytime10;

                    break;
                case 11:
                    if (dp_p11.Value != null && tp_p11.Text != null) 
                    {
                        DateTime date1_11 = Convert.ToDateTime(dp_p11.Value.ToString("dd-MM-yyyy") + " " + tp_p11.Text);
                        TimeSpan ts11 = date1_11 - date2;
                        Mytime11 = int.Parse(ts11.TotalMinutes.ToString());
                    }  
                    else if (cb_time_p11.Text != "--Select Time--") 
                    {
                        string[] selectedMin11 = (cb_time_p11.Text).Split(' ');
                        Mytime11 = int.Parse(selectedMin11[0]);
                       
                    }
                    ResultTime = Mytime11;

                    break;
                case 12:
                    if (dp_p12.Value != null && tp_p12.Text != null) 
                    {
                        DateTime date1_12 = Convert.ToDateTime(dp_p12.Value.ToString("dd-MM-yyyy") + " " + tp_p12.Text);
                        TimeSpan ts12 = date1_12 - date2;
                        Mytime12 = int.Parse(ts12.TotalMinutes.ToString());
                    }   
                    else if (cb_time_p12.Text != "--Select Time--") 
                    {
                        string[] selectedMin12 = (cb_time_p12.Text).Split(' ');
                        Mytime12 = int.Parse(selectedMin12[0]);
                       
                    }
                    ResultTime = Mytime12;

                    break;
                case 13:
                    if (dp_p13.Value != null && tp_p13.Text != null) 
                    {
                        DateTime date1_13 = Convert.ToDateTime(dp_p13.Value.ToString("dd-MM-yyyy") + " " + tp_p13.Text);
                        TimeSpan ts13 = date1_13 - date2;
                        Mytime13 = int.Parse(ts13.TotalMinutes.ToString());
                    }   
                    else if (cb_time_p13.Text != "--Select Time--") 
                    {
                        string[] selectedMin13 = (cb_time_p13.Text).Split(' ');
                        Mytime13 = int.Parse(selectedMin13[0]);
                       
                    }
                    ResultTime = Mytime13;

                    break;
                case 14:
                    if (dp_p14.Value != null && tp_p14.Text != null) 
                    {
                        DateTime date1_14 = Convert.ToDateTime(dp_p14.Value.ToString("dd-MM-yyyy") + " " + tp_p14.Text);
                        TimeSpan ts14 = date1_14 - date2;
                        Mytime14 = int.Parse(ts14.TotalMinutes.ToString());
                    }   
                    else if (cb_time_p14.Text != "--Select Time--") 
                    {
                        string[] selectedMin14 = (cb_time_p14.Text).Split(' ');
                        Mytime14 = int.Parse(selectedMin14[0]);
                       
                    }
                    ResultTime = Mytime14;

                    break;
                case 15:

                    if (dp_p15.Value != null && tp_p15.Text != null) 
                    {
                        DateTime date1_15 = Convert.ToDateTime(dp_p15.Value.ToString("dd-MM-yyyy") + " " + tp_p15.Text);
                        TimeSpan ts15 = date1_15 - date2;
                        Mytime15 = int.Parse(ts15.TotalMinutes.ToString());
                    }  
                    else if (cb_time_p15.Text != "--Select Time--") 
                    {
                        string[] selectedMin15 = (cb_time_p15.Text).Split(' ');
                        Mytime15 = int.Parse(selectedMin15[0]);
                        
                    }
                    ResultTime = Mytime15;

                    break;
            }
            return ResultTime;
        }

        private void function1(object sender, EventArgs e)
        {
            string filepath1 = "";
            string folderPath1 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath1 = fileHelper.CreateFolder(date);

                filepath1 = fileHelper.CreateFile(folderPath1,"ImportExtrat");

                string valueNode = rf.getdatanode("ImportExtrat", filepath1);
                fileHelper.writelog(filepath1, "ImportExtrat", "-------Now start-----------");
                //code here
                var url1 = valueNode;              
             
                var uri = new Uri(url1);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);
              //  fileHelper.writelog(filepath1, "ImportExtrat", "-------End -----------");
                fileHelper.writelog(filepath1, "ImportExtrat", "-------End -----------");
                //
                myTimer1.Stop();
            }
            catch (Exception ex)
            {
              //  response1.Close();
              //  fileHelper.writelog(filepath1, "ImportExtrat", "Exception ------ " + ex.ToString());
                myTimer1.Stop();
            }
           
        }

      

        private void rb_tim(object sender, EventArgs e)
        {

        }

        /* private void function2(object sender, EventArgs e)
         {

             string filepath2 = "";
             string folderPath2 = "";
             try
             {
                 string date = DateTime.Now.ToString("dd-MM-yyyy");
                 folderPath2 = fileHelper.CreateFolder(date);
                 filepath2 = fileHelper.CreateFile(folderPath2,"ConvertOA");

                 // filepath2 = checkDateLog();
                 string valueNode = rf.getdatanode("ConvertOA", filepath2);
                 fileHelper.writelog(folderPath2, "ConvertOA", "-------Now start-----------");
                 //code here

                 var url2 = valueNode;
                 var uri = new Uri(url2);
                 var webClient = new System.Net.WebClient();
                 webClient.DownloadStringAsync(uri);

                 //
                 myTimer2.Stop();
                 fileHelper.writelog(filepath2, "ConvertOA", "-------end -----------");
             }
             catch (Exception ex)
             {
              //   response2.Close();
                 fileHelper.writelog(filepath2, "ConvertOA", "Exception ------ " + ex.ToString());
                 myTimer2.Stop();
             }

         }       */

        private void function2(object sender, EventArgs e)
        {

            string filepath2 = "";
            string folderPath2 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath2 = fileHelper.CreateFolder(date);
                filepath2 = fileHelper.CreateFile(folderPath2, "ConvertOA");

                string valueNode = rf.getdatanode("ConvertOA", filepath2);
                fileHelper.writelog(filepath2, "ConvertOA", "-------Now start-----------");
                //code here

                var url2 = valueNode;
                var uri = new Uri(url2);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer2.Stop();
                fileHelper.writelog(filepath2, "ConvertOA", "-------End -----------");
            }
            catch (Exception ex)
            {
                //  response3.Close();
                fileHelper.writelog(filepath2, "ConvertOA", "Exception ------ " + ex.ToString());
                myTimer2.Stop();
            }

        }

        private void function3(object sender, EventArgs e)
        {


            string filepath3 = "";
            string folderPath3 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath3 = fileHelper.CreateFolder(date);
                filepath3 = fileHelper.CreateFile(folderPath3,"ImportAction");

                string valueNode = rf.getdatanode("ImportAction", filepath3);
                fileHelper.writelog(filepath3, "ImportAction", "-------Now start-----------");
                //code here

                var url3 = valueNode;
                var uri = new Uri(url3);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);
               
                myTimer3.Stop();
                fileHelper.writelog(filepath3, "ImportAction", "-------End -----------");
            }
            catch (Exception ex)
            {
              //  response3.Close();
                fileHelper.writelog(filepath3, "ImportAction", "Exception ------ " + ex.ToString());
                myTimer3.Stop();
            }
           
        }

        private void function4(object sender, EventArgs e)
        {


            string filepath4 = "";
            string folderPath4 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath4 = fileHelper.CreateFolder(date);
                filepath4 = fileHelper.CreateFile(folderPath4, "SLA-Delete");

                string valueNode = rf.getdatanode("SLA-Delete", filepath4);
                fileHelper.writelog(filepath4, "SLA-Delete", "-------Now start-----------");
                //code here

                var url4 = valueNode;
                var uri = new Uri(url4);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);
              
                myTimer4.Stop();
                fileHelper.writelog(filepath4, "SLA-Delete", "-------End -----------");
            }
            catch (Exception ex)
            {
              //  response4.Close();
                fileHelper.writelog(filepath4, "SLA-Delete", "Exception ------ " + ex.ToString());
                myTimer4.Stop();
            }
            
        }

        private void function5(object sender, EventArgs e)
        {


            string filepath5 = "";
            string folderPath5 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath5 = fileHelper.CreateFolder(date);
                filepath5 = fileHelper.CreateFile(folderPath5, "SLA-Update");

                string valueNode = rf.getdatanode("SLA-Update", filepath5);
                fileHelper.writelog(filepath5, "SLA-Update", "-------Now start-----------");
                //code here

                var url5 = valueNode;
                var uri = new Uri(url5);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);
               
                myTimer5.Stop();
                fileHelper.writelog(filepath5, "SLA-Update", "-------end -----------");
            }
            catch (Exception ex)
            {
               // response5.Close();
                fileHelper.writelog(filepath5, "SLA-Update", "Exception ------ " + ex.ToString());
                myTimer5.Stop();
            }
          
        }

        private  void function6(object sender, EventArgs e)
        {

            string filepath6 = "";
            string folderPath6 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath6 = fileHelper.CreateFolder(date);
                filepath6 = fileHelper.CreateFile(folderPath6, "Update1P");


                string valueNode = rf.getdatanode("Update1P", filepath6);
                fileHelper.writelog(filepath6, "Update1P", "-------Now start-----------");
                //code here

                var url6 = valueNode;


                var uri = new Uri(url6);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer6.Stop();
                fileHelper.writelog(filepath6, "Update1P", "-------End-----------");
            }
            catch (Exception ex)
            {
              
                fileHelper.writelog(filepath6, "Update1P", "Exception ------ " + ex.ToString());
                myTimer6.Stop();
            }
          
        }

        private void function7(object sender, EventArgs e)
        {


            string filepath7 = "";
            string folderPath7 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath7 = fileHelper.CreateFolder(date);
                filepath7 = fileHelper.CreateFile(folderPath7, "ConvertZip");


                string valueNode = rf.getdatanode("ConvertZip", filepath7);
                fileHelper.writelog(filepath7, "ConvertZip", "-------Now start-----------");
                //code here

                var url7 =  valueNode;

              
                var uri = new Uri(url7);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer7.Stop();
                fileHelper.writelog(filepath7, "ConvertZip", "-------End-----------");
            }
            catch (Exception ex)
            {
              //  response7.Close();
                fileHelper.writelog(filepath7, "ConvertZip", "Exception ------ " + ex.ToString());
                myTimer7.Stop();
            }
          
        }

        private void function8(object sender, EventArgs e)
        {


            string filepath8 = "";
            string folderPath8 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath8 = fileHelper.CreateFolder(date);
                filepath8 = fileHelper.CreateFile(folderPath8, "ExportSentMail");

                string valueNode = rf.getdatanode("ExportSentMail", filepath8);
                fileHelper.writelog(filepath8, "ExportSentMail", "-------Now start-----------");
                //code here

                var url8 = valueNode;
                var uri = new Uri(url8);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);
               
                myTimer8.Stop();
                fileHelper.writelog(filepath8, "ExportSentMail", "-------End-----------");
            }
            catch (Exception ex)
            {
                fileHelper.writelog(filepath8, "ExportSentMail", "Exception ------ "+ex.ToString());
               // response8.Close();
                //
                myTimer8.Stop();
               
            }
           
        }
        private void function9(object sender, EventArgs e)
        {


            string filepath9 = "";
            string folderPath9 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath9 = fileHelper.CreateFolder(date);
                filepath9 = fileHelper.CreateFile(folderPath9, "OAReport");

                string valueNode = rf.getdatanode("OAReport", filepath9);
                fileHelper.writelog(filepath9, "OAReport", "-------Now start-----------");
                //code here          
                var url9 =  valueNode;
                var uri = new Uri(url9);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);
                
                myTimer9.Stop();
                fileHelper.writelog(filepath9, "OAReport", "-------end-----------");
            }
            catch (Exception ex) 
            {

               // response9.Close();
                fileHelper.writelog(filepath9, "OAReport", "Exception ------ " + ex.ToString());
                //
                myTimer9.Stop();
            }
          
        }

        private void function10(object sender, EventArgs e)
        {


            string filepath10 = "";
            string folderPath10 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath10 = fileHelper.CreateFolder(date);
                filepath10 = fileHelper.CreateFile(folderPath10, "BUReport");

                string valueNode = rf.getdatanode("BUReport", filepath10);
                fileHelper.writelog(filepath10, "BUReport", "-------Now start-----------");
                //code here          
                var url10 = valueNode;
                var uri = new Uri(url10);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer10.Stop();
                fileHelper.writelog(filepath10, "BUReport", "-------end-----------");
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath10, "BUReport", "Exception ------ " + ex.ToString());
                //
                myTimer10.Stop();
            }

        }
        private void function11(object sender, EventArgs e)
        {


            string filepath11 = "";
            string folderPath11 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath11 = fileHelper.CreateFolder(date);
                filepath11 = fileHelper.CreateFile(folderPath11, "BOTReport");

                string valueNode = rf.getdatanode("BOTReport", filepath11);
                fileHelper.writelog(filepath11, "BOTReport", "-------Now start-----------");
                //code here          
                var url11 = valueNode;
                var uri = new Uri(url11);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer11.Stop();
                fileHelper.writelog(filepath11, "BOTReport", "-------end-----------");
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath11, "BOTReport", "Exception ------ " + ex.ToString());
                //
                myTimer11.Stop();
            }

        }
        private void function12(object sender, EventArgs e)
        {


            string filepath12 = "";
            string folderPath12 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath12 = fileHelper.CreateFolder(date);
                filepath12 = fileHelper.CreateFile(folderPath12, "UpdateCase");

                string valueNode = rf.getdatanode("UpdateCase", filepath12);
                fileHelper.writelog(filepath12, "UpdateCase", "-------Now start-----------");
                //code here          
                var url12 = valueNode;
                var uri = new Uri(url12);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer12.Stop();
                fileHelper.writelog(filepath12, "UpdateCase", "-------end-----------");
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath12, "UpdateCase", "Exception ------ " + ex.ToString());
                //
                myTimer12.Stop();
            }

        }
        private void function13(object sender, EventArgs e)
        {


            string filepath13 = "";
            string folderPath13 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath13 = fileHelper.CreateFolder(date);
                filepath13 = fileHelper.CreateFile(folderPath13, "temp1");

                string valueNode = rf.getdatanode("temp1", filepath13);
                fileHelper.writelog(filepath13, "temp1", "-------Now start-----------");
                //code here          
                var url13 = valueNode;
                var uri = new Uri(url13);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer13.Stop();
                fileHelper.writelog(filepath13, "temp1", "-------end-----------");
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath13, "Function13", "Exception ------ " + ex.ToString());
                //
                myTimer13.Stop();
            }

        }
        private void function14(object sender, EventArgs e)
        {


            string filepath14 = "";
            string folderPath14 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath14 = fileHelper.CreateFolder(date);
                filepath14 = fileHelper.CreateFile(folderPath14, "temp2");

                string valueNode = rf.getdatanode("temp2", filepath14);
                fileHelper.writelog(filepath14, "temp2", "-------Now start-----------");
                //code here          
                var url14 = valueNode;
                var uri = new Uri(url14);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer14.Stop();
                fileHelper.writelog(filepath14, "temp2", "-------end-----------");
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath14, "temp2", "Exception ------ " + ex.ToString());
                //
                myTimer14.Stop();
            }

        }
        private void function15(object sender, EventArgs e)
        {


            string filepath15 = "";
            string folderPath15 = "";
            try
            {
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                folderPath15 = fileHelper.CreateFolder(date);
                filepath15 = fileHelper.CreateFile(folderPath15, "temp3");

                string valueNode = rf.getdatanode("temp3", filepath15);
                fileHelper.writelog(filepath15, "temp3", "-------Now start-----------");
                //code here          
                var url15 = valueNode;
                var uri = new Uri(url15);
                var webClient = new System.Net.WebClient();
                webClient.DownloadStringAsync(uri);

                myTimer15.Stop();
                fileHelper.writelog(filepath15, "temp3", "-------end-----------");
            }
            catch (Exception ex)
            {

                // response9.Close();
                fileHelper.writelog(filepath15, "temp3", "Exception ------ " + ex.ToString());
                //
                myTimer15.Stop();
            }

        }

        #endregion
    }
}