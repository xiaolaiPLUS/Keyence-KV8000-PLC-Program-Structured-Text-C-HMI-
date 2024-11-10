using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace KeyenceComunicationTest
{
    class KV7_8000Service
    {
        Socket KVTCPClicent;
        //TcpClient tcp = new TcpClient();
        readonly object LockKVTCP = new object();
        public enum DataType
        {
            /// <summary>
            /// 16位无符号
            /// </summary>
            U,
            /// <summary>
            /// 16位有符号
            /// </summary>
            S,
            /// <summary>
            /// 32位无符号
            /// </summary>
            D,
            /// <summary>
            /// 32位有符号
            /// </summary>
            L,
            /// <summary>
            /// 16位16进制数
            /// </summary>
            H,
            /// <summary>
            /// 默认
            /// </summary>
            N
        }
        #region 命令
        /// <summary>
        /// 更改模式
        /// </summary>
        const string Command1 = "M";
        /// <summary>
        /// 清除错误
        /// </summary>
        const string Command2 = "ER";
        /// <summary>
        /// 检查错误编号
        /// </summary>
        const string Command3 = "?E";
        /// <summary>
        /// 查询机型
        /// </summary>
        const string Command4 = "?K";
        /// <summary>
        /// 检查运行模式
        /// </summary>
        const string Command5 = "?M";
        /// <summary>
        /// 时间设定
        /// </summary>
        const string Command6 = "WRT";
        /// <summary>
        /// 强制置位
        /// </summary>
        const string Command7 = "ST";
        /// <summary>
        /// 强制复位
        /// </summary>
        const string Command8 = "RS";
        /// <summary>
        /// 连续强制置位
        /// </summary>
        const string Command9 = "STS";
        /// <summary>
        /// 连续强制复位
        /// </summary>
        const string Command10 = "RSS";
        /// <summary>
        /// 读取数据
        /// </summary>
        const string Command11 = "RD";
        /// <summary>
        /// 读取连续数据
        /// </summary>
        const string Command12 = "RDS";
        /// <summary>
        /// 读取连续数据
        /// </summary>
        const string Command13 = "RDE";
        /// <summary>
        /// 写入数据
        /// </summary>
        const string Command14 = "WR";
        /// <summary>
        /// 写入连续数据
        /// </summary>
        const string Command15 = "WRS";
        /// <summary>
        /// 写入连续数据
        /// </summary>
        const string Command16 = "WRE";
        /// <summary>
        /// 写入设定值
        /// </summary>
        const string Command17 = "WS";
        /// <summary>
        /// 写入连续设定值
        /// </summary>
        const string Command18 = "WSS";
        /// <summary>
        /// 监控器登录
        /// </summary>
        const string Command19 = "MBS";
        /// <summary>
        /// 监控器登录
        /// </summary>
        const string Command20 = "MWS";
        /// <summary>
        /// 读取监控器
        /// </summary>
        const string Command21 = "MBR";
        /// <summary>
        /// 读取监控器
        /// </summary>
        const string Command22 = "MWR";
        /// <summary>
        /// 注释读取
        /// </summary>
        const string Command23 = "RDC";
        /// <summary>
        /// 存储体切换
        /// </summary>
        const string Command24 = "BE";
        /// <summary>
        /// 读取扩展单元缓冲存储器
        /// </summary>
        const string Command25 = "URD";
        /// <summary>
        /// 写入扩展单元缓冲存储器
        /// </summary>
        const string Command26 = "UWR";
        /// <summary>
        /// 回车
        /// </summary>
        const string CR = "\r";
        /// <summary>
        /// 空格
        /// </summary>
        const string SP = " ";
        #endregion
        Encoding encoding = Encoding.ASCII;
        /// <summary>
        /// PLC连接状态
        /// </summary>
        public bool IsConnected { get; private set; }
        /// <summary>
        /// 发送超时时间
        /// </summary>
        public int SendTimeout { get; set; } = 2000;
        /// <summary>
        /// 接收超时时间
        /// </summary>
        public int ReceiveTimeout { get; set; } = 2000;
        /// <summary>
        /// 等待PLC响应周期,这里一个周期10ms
        /// </summary>
        public int MaxDelayCycle { get; set; } = 5;
        string ip;
        int port;
        private Dictionary<string, string> plcValue = new Dictionary<string, string>();
        /// <summary>
        /// PLC值键值对
        /// </summary>
        public Dictionary<string, string> PlcValue { get { return plcValue; } }
        /// <summary>
        /// 重连
        /// </summary>
        /// <returns></returns>
        public bool ReConnext()
        {
            if (ip == string.Empty || port == 0)
            {
                throw new Exception("没有IP和端口请调用Connect函数连接"); return false;
            }
            return Connect(ip, port);
        }
        /// <summary>
        /// 连接PLC
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        public bool Connect(string ip, int port = 8501)
        {
            if (this.ip != ip) this.ip = ip;
            if (this.port != port) this.port = port;
            KVTCPClicent = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            KVTCPClicent.SendTimeout = SendTimeout;
            KVTCPClicent.ReceiveTimeout = ReceiveTimeout;
            IAsyncResult asyncResult = KVTCPClicent.BeginConnect(new IPEndPoint(IPAddress.Parse(ip), port), null, null);
            asyncResult.AsyncWaitHandle.WaitOne(3000, true);
            if (!asyncResult.IsCompleted)
            {
                KVTCPClicent.Close();
                return false;
            }
            return true;
        }

        public bool Disconnect()
        {
            KVTCPClicent.Close();
            return true;
        }
        /// <summary>
        /// 改变PLC运行状态
        /// </summary>
        /// <param name="run">true让PLC运行false让PLC停止</param>
        /// <returns></returns>
        public string ChangeCPU(bool run = true)
        {
            string str = Command1 + (run ? "1" : "0") + CR;
            return SendRecive(str);
        }
        /// <summary>
        /// 查看PLC运行状态
        /// </summary>
        /// <returns></returns>
        public string SeeCPUState()
        {
            string str = Command5 + CR;
            return SendRecive(str);
        }
        /// <summary>
        /// 强制置位复位
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string Put(string address, bool value)
        {
            string str;
            if (value)
            {
                str = Command7 + SP + address + CR;
            }
            else
            {
                str = Command8 + SP + address + CR;
            }
            return SendRecive(str);
        }
        /// <summary>
        /// 连续强制置位复位
        /// </summary>
        /// <param name="address"></param>
        /// <param name="Value"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public string Put(string address, bool Value, int count)
        {
            string str;
            if (Value)
            {
                str = Command9 + SP + address + SP + count + CR;
            }
            else
            {
                str = Command10 + SP + address + SP + count + CR;
            }
            return SendRecive(str);
        }
        /// <summary>
        /// 写入字数据
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        /// <param name="tpye"></param>
        /// <returns></returns>
        public string Put(string address, string value, DataType tpye = DataType.N)
        {
            string str = Command14 + SP + address + GetDataType(tpye) + SP + value + CR;
            return SendRecive(str);
        }
        /// <summary>
        /// 写入单精度浮点数
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string Put(string address, float value)
        {
            List<string> result = CalFloatToInt16(value);
            return Put(address, result);
        }
        /// <summary>
        /// 写入连续字数据
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        /// <param name="tpye"></param>
        /// <returns></returns>
        public string Put(string address, List<string> value, DataType tpye = DataType.N)
        {
            StringBuilder sb = new StringBuilder(Command15 + SP + address + GetDataType(tpye) + SP + value.Count);
            for (int i = 0; i < value.Count; i++)
            {
                sb.Append(SP + value[i]);
            }
            sb.Append(CR);
            return SendRecive(sb.ToString());
        }
        /// <summary>
        /// 读取字数据
        /// </summary>
        /// <param name="address"></param>
        /// <param name="tpye"></param>
        /// <returns></returns>
        public string Get(string address, DataType tpye = DataType.N)
        {
            string str = Command11 + SP + address + GetDataType(tpye) + CR;
            return SendRecive(str);
        }
        /// <summary>
        /// 读取连续字数据
        /// </summary>
        /// <param name="address"></param>
        /// <param name="count"></param>
        /// <param name="tpye"></param>
        /// <returns></returns>
        public string Get(string address, int count, DataType tpye = DataType.N)
        {
            string str = Command12 + SP + address + GetDataType(tpye) + SP + count + CR;
            return SendRecive(str);
        }
        public string CalRD(string str, string type, int address, int count)
        {
            string[] s1 = str.Split(' ');
            if (count > s1.Length)
            {
                throw new Exception("映射长度过长");
            }
            for (int i = 0; i < count; i++)
            {
                plcValue[type + (address + i)] = s1[i].ToString();
            }
            return "OK";
        }
        /// <summary>
        /// 32位浮点转16位字
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<string> CalFloatToInt16(float value)
        {
            byte[] r1 = BitConverter.GetBytes(value);
            byte[] r2 = new byte[2] { r1[0], r1[1] };
            byte[] r3 = new byte[2] { r1[2], r1[3] };
            int r4 = BitConverter.ToUInt16(r2, 0);
            int r5 = BitConverter.ToUInt16(r3, 0);
            return new List<string>() { r4.ToString(), r5.ToString() };
        }
        /// <summary>
        /// 2个16位字转32位浮点
        /// </summary>
        /// <param name="value"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public float CalInt16ToFlaot(string[] value, int startIndex)
        {
            byte[] r1 = BitConverter.GetBytes(Convert.ToInt16(value[startIndex]));
            byte[] r2 = BitConverter.GetBytes(Convert.ToInt16(value[startIndex + 1]));
            byte[] r3 = new byte[4] { r1[0], r1[1], r2[0], r2[1] };
            return BitConverter.ToSingle(r3, 0);
        }
        /// <summary>
        /// ASCII编码解码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string SendRecive(string str)
        {
            return encoding.GetString(SendRecive(encoding.GetBytes(str)));
        }
        /// <summary>
        /// 发送接收字节数组报文
        /// </summary>
        /// <param name="arry"></param>
        /// <returns></returns>
        public byte[] SendRecive(byte[] arry)
        {
            try
            {
                Monitor.Enter(LockKVTCP);
                int delay = 0;
                int reslut = KVTCPClicent.Send(arry);
                while (KVTCPClicent.Available == 0)
                {
                    Thread.Sleep(10);
                    delay++;
                    if (delay > MaxDelayCycle)
                    {
                        break;
                    }
                }
                byte[] ResByte = new byte[KVTCPClicent.Available];
                reslut = KVTCPClicent.Receive(ResByte);
                return ResByte;
            }
            catch (Exception)
            {
                IsConnected = false;
                return null;
            }
            finally
            {
                Monitor.Exit(LockKVTCP);
            }
        }
        /// <summary>
        /// 根据数据类型生成报文
        /// </summary>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public string GetDataType(DataType dataType)
        {
            string str = string.Empty;
            switch (dataType)
            {
                case DataType.U:
                    str = ".U";
                    break;
                case DataType.S:
                    str = ".S";
                    break;
                case DataType.D:
                    str = ".D";
                    break;
                case DataType.L:
                    str = ".L";
                    break;
                case DataType.H:
                    str = ".H";
                    break;
                case DataType.N:
                    str = "";
                    break;
                default:
                    str = "";
                    break;
            }
            return str;
        }

    }
}
