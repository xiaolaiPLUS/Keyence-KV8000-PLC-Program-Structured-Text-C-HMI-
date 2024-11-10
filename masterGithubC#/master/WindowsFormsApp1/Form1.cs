using KeyenceComunicationTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAxisMotionControl0630
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KV7_8000Service Plc = new KV7_8000Service();
        System.Windows.Forms.Timer FormsTimer1 = new System.Windows.Forms.Timer();//用于周期读取驱动器状态信息,单线程定时器
        //连接plc
        private void button1_Click(object sender, EventArgs e)
        {
            bool ConnectStatus = Plc.Connect(textBox1.Text, Convert.ToInt32(textBox2.Text));
            if (ConnectStatus)
            {
                textBox13.Text = "已连接";
                //MessageBox.Show("连接成功"); 
                FormsTimer1.Start();//开始读取三轴当前位置速度

                Plc.Put("MR002", false);
                Plc.Put("MR002", true);//使能电机

                return;
            }
            else
            {
                textBox13.Text = "未连接";
                MessageBox.Show("连接失败");
                FormsTimer1.Stop();
                return;
            }
        }
        //断开连接plc
        private void button2_Click(object sender, EventArgs e)
        {

            Plc.Put("MR002", true);
            Plc.Put("MR002", false);//去使能电机

            if (Plc.Disconnect())
            {
                textBox13.Text = "未连接";
            }

            FormsTimer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "192.168.0.10";
            textBox2.Text = "8501";
            textBox13.Text = "未连接";

            //Initialization FormsTimer1
            //FormsTimer1.Enabled = true;//主任务循环计时器
            FormsTimer1.Interval = 100;
            FormsTimer1.Tick += new System.EventHandler(this.timer1_Tick);
            //FormsTimer1.Stop();
        }
        bool TimerTickNumber = false;
        byte TimerTickNumberByte = 0;
        string [] getstringArray = new string[12];
        const byte indexes0 = 0, indexes1 = 1, indexes2 = 2, indexes3 = 3, indexes4 = 4, indexes5 = 5, indexes6 = 6, indexes7 = 7, indexes8 = 8, indexes9 = 9, indexes10 = 10, indexes11 = 11;
        //周期读取位置信息
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerTickNumberByte += 1;
            switch (TimerTickNumberByte) 
            {
                case 1:
                    #region 读取位置与速度
                    string[] strArray = Plc.Get("DM10", 6, KV7_8000Service.DataType.L).Split(' ');//按空格符号分割

                    if ((strArray.Length > 0) && (getstringArray[indexes0] != strArray[indexes0]))
                    {
                        //if (getstringArray[indexes0] != strArray[indexes0]) 
                        //{
                        getstringArray[indexes0] = strArray[indexes0];//第一次就是赋予初值
                        MotorPosition_01.Text = strArray[indexes0];

                        //}

                    }
                    if ((strArray.Length > 1) && (getstringArray[indexes1] != strArray[indexes1]))
                    {

                        //if (getstringArray[indexes1] != strArray[indexes1])
                        //{
                        getstringArray[indexes1] = strArray[indexes1];//第一次就是赋予初值
                        MotorPosition_02.Text = strArray[indexes1];

                        //}
                    }

                    if ((strArray.Length > 2) && (getstringArray[indexes2] != strArray[indexes2]))
                    {

                        //if (getstringArray[indexes2] != strArray[indexes2])
                        //{
                        getstringArray[indexes2] = strArray[indexes2];//第一次就是赋予初值
                        MotorPosition_03.Text = strArray[indexes2];

                        //}
                    }

                    if ((strArray.Length > 3) && (getstringArray[indexes3] != strArray[indexes3]))
                    {

                        //if (getstringArray[indexes3] != strArray[indexes3])
                        //{
                        getstringArray[indexes3] = strArray[indexes3];//第一次就是赋予初值
                        MotorSpeed_01.Text = strArray[indexes3];

                        //}

                    }

                    if ((strArray.Length > 4) && (getstringArray[indexes4] != strArray[indexes4]))
                    {

                        //if (getstringArray[indexes4] != strArray[indexes4])
                        //{
                        getstringArray[indexes4] = strArray[indexes4];//第一次就是赋予初值
                        MotorSpeed_02.Text = strArray[indexes4];

                        //}

                    }

                    if ((strArray.Length > 5) && (getstringArray[indexes5] != strArray[indexes5]))
                    {

                        //if (getstringArray[indexes5] != strArray[indexes5])
                        //{
                        getstringArray[indexes5] = strArray[indexes5];//第一次就是赋予初值
                        MotorSpeed_03.Text = strArray[indexes5];

                        //}

                    }
                    break;
                    #endregion
                case 2:
                    #region 读取轴1状态
                    string R40900 = Plc.Get("R40900", KV7_8000Service.DataType.N).TrimEnd('\r', '\n');
                    if (getstringArray[indexes6] != R40900)
                    {
                        getstringArray[indexes6] = R40900;//赋予初值
                        if (R40900 == "1")
                        {
                            axleStateText01.Text = "轴01错误";
                        }
                        else { axleStateText01.Text = "轴01正常"; }
                    }
                    #endregion 
                    break;
                case 3:
                    #region 读取轴2状态
                    string R41300 = Plc.Get("R41300", KV7_8000Service.DataType.N).TrimEnd('\r', '\n');
                    if (getstringArray[indexes7] != R41300)
                    {
                        getstringArray[indexes7] = R41300;//赋予初值
                        if (R41300 == "1")
                        {
                            axleStateText02.Text = "轴02错误";
                        }
                        else { axleStateText02.Text = "轴02正常"; }
                    }
                    #endregion
                    break;
                case 4:
                    #region 读取轴3状态
                    string R41700 = Plc.Get("R41700", KV7_8000Service.DataType.N).TrimEnd('\r', '\n');
                    if (getstringArray[indexes8] != R41700)
                    {
                        getstringArray[indexes8] = R41700;//赋予初值
                        if (R41700 == "1")
                        {
                            axleStateText03.Text = "轴03错误";
                        }
                        else { axleStateText03.Text = "轴03正常"; }
                    }
                    #endregion
                    break;
                case 5:
                    #region 读取plc状态及错误代码编号
                    string CPUstate = Plc.SeeCPUState().TrimEnd('\r', '\n');
                    if (getstringArray[indexes9] != CPUstate)
                    {
                        getstringArray[indexes9] = CPUstate;//赋予初值
                        if (CPUstate == "1")
                        {
                            PLCSysPatternLable.Text = "PLC系统模式：RUN";
                        }
                        else
                        {
                            PLCSysPatternLable.Text = "PPLC系统模式：ROGRAM";
                        }
                    }


                    string err = Plc.GetCPUErrorSerialNumber().TrimEnd('\r', '\n');
                    if (getstringArray[indexes10] != err)
                    {
                        getstringArray[indexes10] = err;//赋予初值
                        PLCErrorNumberLable.Text = "错误编号：" + err;//
                    }


                    if (getstringArray[indexes11] != err)
                    {
                        getstringArray[indexes11] = err;//赋予初值
                        if (err == "000")
                        {
                            PLCSysStateLable.Text = "PLC系统状态：正常运行";

                        }
                        else
                        {
                            PLCSysStateLable.Text = "PLC系统状态：存在错误";
                        }
                    }
                    #endregion
                    TimerTickNumberByte = 0;//归零
                    break;


                default:
                    break;

            }


            //TimerTickNumber = !TimerTickNumber;//取反
            //if (TimerTickNumber)
            //{

            //}
            //else 
            //{







            //}








        }



        //写入新位置，并使能更新位置
        private void button3_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                // 根据需要执行特定按钮的操作
                if (clickedButton.Name == "button3")
                {
                    // 按钮1触发了事件
                    Plc.Put("DM39", NewMotorPosition_01.Text, KV7_8000Service.DataType.L);//位置
                    Plc.Put("DM41", NewMotorSpeed_01.Text, KV7_8000Service.DataType.L);//位置

                    Plc.Put("MR009", false);
                    Plc.Put("MR009", true);//更改轴1点1

                    Plc.Put("MR010", false);
                    Plc.Put("MR010", true);//运动轴1点1
                }
                else if (clickedButton.Name == "button4")
                {
                    // 按钮2触发了事件
                    Plc.Put("DM22", NewMotorPosition_02.Text, KV7_8000Service.DataType.L);//位置
                    Plc.Put("DM24", NewMotorSpeed_02.Text, KV7_8000Service.DataType.L);//位置

                    Plc.Put("MR000", false);
                    Plc.Put("MR000", true);//更改轴2点1

                    Plc.Put("MR001", false);
                    Plc.Put("MR001", true);//运动轴2点1
                }
                else if (clickedButton.Name == "button5")
                {
                    // 按钮3触发了事件
                    Plc.Put("DM26", NewMotorPosition_03.Text, KV7_8000Service.DataType.L);//位置
                    Plc.Put("DM28", NewMotorSpeed_03.Text, KV7_8000Service.DataType.L);//位置

                    Plc.Put("MR003", false);
                    Plc.Put("MR003", true);//更改轴2点1

                    Plc.Put("MR004", false);
                    Plc.Put("MR004", true);//运动轴2点1
                }
                // 可以继续添加其他按钮的判断


            }
        }

        //清除错误，并获得错误代码
        private void ClearError_Axle01_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string[] strArray;

            if (clickedButton != null)
            {
                // 根据需要执行特定按钮的操作
                if (clickedButton.Name == "ClearError_Axle01")
                {
                    // 按钮1触发了事件
                    Plc.Put("MR005", false);
                    Plc.Put("MR005", true);//尝试复位错误，并得到错误代码

                    strArray = Plc.Get("DM30", 3, KV7_8000Service.DataType.U).Split(' ');//按空格符号分割

                    if (strArray.Length > 0)
                        ErrorCode01.Text = strArray[0];
                    if (strArray.Length > 1)
                        ErrorData101.Text = strArray[1];
                    if (strArray.Length > 2)
                        ErrorData201.Text = strArray[2];

                }
                else if (clickedButton.Name == "ClearError_Axle02")
                {
                    // 按钮2触发了事件
                    Plc.Put("MR006", false);
                    Plc.Put("MR006", true);//尝试复位错误，并得到错误代码

                    strArray = Plc.Get("DM33", 3, KV7_8000Service.DataType.U).Split(' ');//按空格符号分割

                    if (strArray.Length > 0)
                        ErrorCode02.Text = strArray[0];
                    if (strArray.Length > 1)
                        ErrorData102.Text = strArray[1];
                    if (strArray.Length > 2)
                        ErrorData202.Text = strArray[2];
                }
                else if (clickedButton.Name == "ClearError_Axle03")
                {
                    // 按钮3触发了事件
                    Plc.Put("MR007", false);
                    Plc.Put("MR007", true);//尝试复位错误，并得到错误代码

                    strArray = Plc.Get("DM36", 3, KV7_8000Service.DataType.U).Split(' ');//按空格符号分割

                    if (strArray.Length > 0)
                        ErrorCode03.Text = strArray[0];
                    if (strArray.Length > 1)
                        ErrorData103.Text = strArray[1];
                    if (strArray.Length > 2)
                        ErrorData203.Text = strArray[2];
                }
                // 可以继续添加其他按钮的判断
            }
        }


        //更改系统运行模式
        private void ChangeSystemPattern_Click(object sender, EventArgs e)
        {
            bool state;
            if (PLCSysPatternLable.Text == "PLC系统模式：RUN")
            {
                bool PROGRAM_Pattern = false;
                state = PROGRAM_Pattern;
            }
            else 
            {
                bool RUN_Pattern = true;
                state = RUN_Pattern;
            }

            string str = Plc.ChangeCPU(state).TrimEnd('\r', '\n');
            if ( str != "OK") 
            {
                if (str == "E1")
                {
                    str += ":命令异常";
                }
                else if (str == "E2") 
                {
                    str += ":未登录程序";
                }
                else if (str == "E5")
                {
                    str += ":单元错误";
                }
                // 显示一个消息框，只有一个“确定”按钮
                MessageBox.Show("这是一个消息框", str, MessageBoxButtons.OK);
            }
            
        }


        //清除PLC错误
        private void PLCClearError_Click(object sender, EventArgs e)
        {
            
            string str = Plc.ClearCPUError().TrimEnd('\r', '\n');
            if (str != "OK")
            {
                if (str == "E1")
                {
                    str += ":命令异常";
                }

                // 显示一个消息框，只有一个“确定”按钮
                MessageBox.Show("这是一个消息框", str, MessageBoxButtons.OK);
            }
        }
    }
}
