using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyenceComunicationTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KV7_8000Service Plc = new KV7_8000Service();

        private string SendStrmessage(string str_r)
        {
            string SendW = str_r;
            var ByteSendW = Encoding.ASCII.GetBytes(SendW);//把发送数据转换为ASCII数组
            var StringRD = "";
            var s = "";

            for (int i = 0; i < ByteSendW.Length; i++)
            {
                int a = Convert.ToString(ByteSendW[i], 2).Length % 8;

                s = Convert.ToString(ByteSendW[i], 2).PadLeft(8, '0');

                StringRD = StringRD + s;
                s = "";

            }
            int b = Convert.ToInt32(StringRD, 2); //二进制字符串转整数
            return Convert.ToString(b);

        }

        private string ReadStrmessage(string str_r)
        {
            string StringTP = "";
            string[] strArray = str_r.Split(' ');
            int[] int_32 = new int[strArray.Length];
            byte[] by = new byte[strArray.Length * 2];
            for (int i = 0; i < strArray.Length; i++)
            {
                int_32[i] = Convert.ToInt32(strArray[i]);
            }
            //int int_32 = Convert.ToInt32(str_r);
            for (int i = 0; i < strArray.Length; i++)
            {
                StringTP = StringTP + Convert.ToString(int_32[i], 2).PadLeft(16, '0');
                //by[i]= Convert.ToByte(Convert.ToString(int_32[i], 2).PadLeft(16, '0'));
            }
            for (int i = 0; i < strArray.Length * 2; i++)
            {
                string temp;
                temp = StringTP.Substring(0, 8);
                StringTP = StringTP.Remove(0, 8);
                by[i] = Convert.ToByte(temp, 2);
            }


            //Console.WriteLine(Cha(StringTP));  //将ascii码字符串转为并打印
            var StringRD = "未返回数据";


            StringRD = Encoding.ASCII.GetString(by);
            return StringRD;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool ConnectStatus = Plc.Connect(textBox1.Text, Convert.ToInt32(textBox2.Text));
            if (ConnectStatus)
            {
                textBox13.Text = "已连接";
                //MessageBox.Show("连接成功"); 
                return;
            }
            else
            {
                textBox13.Text = "未连接";
                MessageBox.Show("连接失败");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Put(textBox3.Text, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Put(textBox3.Text, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Get(textBox4.Text, KV7_8000Service.DataType.N);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Get(textBox4.Text, KV7_8000Service.DataType.U) + "\r\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Get(textBox4.Text, KV7_8000Service.DataType.S) + "\r\n";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Get(textBox4.Text, KV7_8000Service.DataType.D) + "\r\n";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Get(textBox4.Text, KV7_8000Service.DataType.L) + "\r\n";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Get(textBox4.Text, KV7_8000Service.DataType.H) + "\r\n";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Put(textBox3.Text, textBox5.Text, KV7_8000Service.DataType.U);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Put(textBox3.Text, textBox5.Text, KV7_8000Service.DataType.S);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Put(textBox3.Text, textBox5.Text, KV7_8000Service.DataType.D);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Put(textBox3.Text, textBox5.Text, KV7_8000Service.DataType.L);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Put(textBox3.Text, textBox5.Text, KV7_8000Service.DataType.H);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            //{
            //    e.Handled = true;
            //}
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Plc.Disconnect())
            {
                textBox13.Text = "未连接";
            }
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.textBox7.SelectionStart = this.textBox7.Text.Length;
            this.textBox7.SelectionLength = 0;
            this.textBox7.ScrollToCaret();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox7.Text += ReadStrmessage(Plc.Get(textBox4.Text, KV7_8000Service.DataType.S)) + "\r\n";
        }
        /// <summary>
        /// 将数值转换为ASCII码
        /// </summary>
        /// <param name="asciiCode"></param>
        /// <returns></returns>
        public string Chr(int asciiCode)
        {
            if (asciiCode >= 0 && asciiCode <= 255)
            {
                System.Text.ASCIIEncoding
                asciiEncoding = new
                System.Text.ASCIIEncoding();
                byte[] byteArray = new byte[] { (byte)asciiCode };
                string strCharacter = asciiEncoding.GetString(byteArray);
                return (strCharacter);
            }
            else
            {
                throw new Exception("ASCII Code is not valid.");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox6.Text += Plc.Get(textBox8.Text, Convert.ToInt32(textBox11.Text), KV7_8000Service.DataType.N) + "\r\n";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox6.Text += Plc.Get(textBox8.Text, Convert.ToInt32(textBox11.Text), KV7_8000Service.DataType.U) + "\r\n";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox6.Text += Plc.Get(textBox8.Text, Convert.ToInt32(textBox11.Text), KV7_8000Service.DataType.S) + "\r\n";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox6.Text += Plc.Get(textBox8.Text, Convert.ToInt32(textBox11.Text), KV7_8000Service.DataType.D) + "\r\n";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox6.Text += Plc.Get(textBox8.Text, Convert.ToInt32(textBox11.Text), KV7_8000Service.DataType.L) + "\r\n";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox6.Text += Plc.Get(textBox8.Text, Convert.ToInt32(textBox11.Text), KV7_8000Service.DataType.H) + "\r\n";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox6.Text += Plc.Put(textBox10.Text, true, Convert.ToInt32(textBox12.Text));
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox6.Text += Plc.Put(textBox10.Text, false, Convert.ToInt32(textBox12.Text));
        }

        private void button24_Click(object sender, EventArgs e)
        {
            List<string> value = new List<string>();

            for (int i = 0; i < Convert.ToInt32(textBox12.Text); i++)
            {
                value.Add(textBox9.Text);
            }

            textBox6.Text += Plc.Put(textBox10.Text, value, KV7_8000Service.DataType.H);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            List<string> value = new List<string>();

            for (int i = 0; i < Convert.ToInt32(textBox12.Text); i++)
            {
                value.Add(textBox9.Text);
            }

            textBox6.Text += Plc.Put(textBox10.Text, value,KV7_8000Service.DataType.U );
        }

        private void button27_Click(object sender, EventArgs e)
        {
            List<string> value = new List<string>();

            for (int i = 0; i < Convert.ToInt32(textBox12.Text); i++)
            {
                value.Add(textBox9.Text);
            }

            textBox6.Text += Plc.Put(textBox10.Text, value, KV7_8000Service.DataType.S);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            List<string> value = new List<string>();

            for (int i = 0; i < Convert.ToInt32(textBox12.Text); i++)
            {
                value.Add(textBox9.Text);
            }

            textBox6.Text += Plc.Put(textBox10.Text, value, KV7_8000Service.DataType.D);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            List<string> value = new List<string>();

            for (int i = 0; i < Convert.ToInt32(textBox12.Text); i++)
            {
                value.Add(textBox9.Text);
            }

            textBox6.Text += Plc.Put(textBox10.Text, value, KV7_8000Service.DataType.L);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.textBox6.SelectionStart = this.textBox6.Text.Length;
            this.textBox6.SelectionLength = 0;
            this.textBox6.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "192.168.0.10";
            textBox2.Text = "8501";
            textBox13.Text = "未连接";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox6.Text += ReadStrmessage(Plc.Get(textBox8.Text, Convert.ToInt32(textBox11.Text), KV7_8000Service.DataType.S)) + "\r\n";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Math.Ceiling((double)textBox14.Text.Length / 2));
            string RD = "WRS " + textBox10.Text + ".U " + Convert.ToString(a);
            string[] st = new string[a];
            int c;
            if (Convert.ToInt32(textBox14.Text.Length % 2) == 0)
            {
                c = 0;
                for (int i = 0; i < a; i++)
                {
                    st[i] = textBox14.Text.Substring(c, 2);
                    c = c + 2;

                }
                c = 0;

            }
            else
            {
                c = 0;
                for (int i = 0; i < a - 1; i++)
                {
                    st[i] = textBox14.Text.Substring(c, 2);
                    c = c + 2;
                }
                c = 0;
                st[a - 1] = textBox14.Text.Substring(textBox14.Text.Length - 1, 1) + ",";

            }
            for (int i = 0; i < a; i++)
            {
                RD = RD + " " + SendStrmessage(st[i]);
            }



            RD = RD + "\r";
            textBox6.Text += Plc.SendRecive(RD);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox7.Text += Plc.Put(textBox3.Text, SendStrmessage(textBox5.Text), KV7_8000Service.DataType.U);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }
    }
}
