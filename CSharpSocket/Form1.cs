using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace CSharpSocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//禁用此异常
        }

        private bool bConnected = false;//客户机与服务器之间的连接状态
        private Thread tAcceptMsg = null;//侦听线程
        private IPEndPoint IPP = null;//用于Socket通信的IP地址和端口
        private Socket socket = null;
        private Socket clientSocket = null;
        private NetworkStream nStream = null;//网络访问基础数据流
        private TextReader tReader = null;//创建读取器
        private TextWriter tWriter = null;//创建编写器

        public void AcceptMessage()
        {
            clientSocket = socket.Accept();
            if (clientSocket!=null)
            {
                bConnected = true;
                this.Label1.Text = "与客户" + clientSocket.RemoteEndPoint.ToString() + "成功建立连接";
            }
            nStream = new NetworkStream(clientSocket);
            tReader = new StreamReader(nStream);//读字节流
            tWriter = new StreamWriter(nStream);//写字节流
            string sTemp;//临时存储读取的字符串
            while (bConnected)
            {
                try
                {
                    //连续从当前流中读取字符串直至结束
                    sTemp = tReader.ReadLine();
                    if (sTemp.Length!=0)
                    {
                        //RichTextBox2_KeyPress()和AcceptMessage()都将向
                        //RichTextBox1写入字符,可能冲突,需要多线程互斥
                        lock (this)
                        {
                            RichTextBox1.Text = "客户机:" + sTemp + "\n" + RichTextBox1.Text;
                        }
                    }
                }
                catch (Exception)
                {
                    tAcceptMsg.Abort();
                    MessageBox.Show("无法与客户机通信!");
                }
            }
            //禁止当前Socket上的发送与接收
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();//关闭Socket并释放所有关联资源
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        private void Btn_Start_Click(object sender, EventArgs e)//启动侦听并显示聊天信息
        {
            //服务器侦听端口可以预先指定,这里使用最大端口值
            //Any表示服务器应侦听所有网络接口上的客户活动
            IPP = new IPEndPoint(IPAddress.Any, 65535);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(IPP);//绑定节点
            socket.Listen(0);//0表示连接数量不限
            tAcceptMsg = new Thread(new ThreadStart(this.AcceptMessage));
            tAcceptMsg.Start();
            Btn_Start.Enabled = false;
        }

        private void RichTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)//按下的是回车
            {
                if (bConnected)
                {
                    try
                    {
                        //RichTextBox2_KeyPress()和AcceptMessage()都将向
                        //RichTextBox1写入字符,可能冲突,需要多线程互斥
                        lock (this)
                        {
                            RichTextBox1.Text = "服务器:" + RichTextBox2.Text + RichTextBox2.Text + RichTextBox1.Text;
                            //客户机聊天信息写入网络流便于服务器接收
                            tWriter.WriteLine(RichTextBox2.Text);
                            tWriter.Flush();//清理当前缓冲区,使缓冲数据写入基础设备
                            RichTextBox2.Text = "";//发送成功后,清空输入框并聚焦
                            RichTextBox2.Focus();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("无法与客户机通信!");
                    }
                }
                else
                {
                    MessageBox.Show("未与客户机建立连接,无法与客户机通信!");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                socket.Close();
                tAcceptMsg.Abort();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
