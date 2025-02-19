﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HslCommunication.Profinet;
using HslCommunication;
using HslCommunication.ModBus;
using System.Threading;
using HslCommunication.Core.Net;
using HslCommunicationDemo.Modbus;


/***************************************************************************************************
 * 
 *     说明：本界面是Modbus-Tcp的异形客户端的创建
 *     
 *     什么是异形客户端
 *     一般的Modbus-Tcp需要主动连接服务器才能进行读写操作
 *     异形客户端的意思是不主动连接，侦听服务器的连接，然后再对服务器进行数据交换
 *     
 *     这种场景多半用于一些特殊的工业环境，很多地方称之为 DTU
 * 
 * ***************************************************************************************************/

namespace HslCommunicationDemo
{
	public partial class FormModbusAlien : HslFormContent
	{
		public FormModbusAlien( )
		{
			InitializeComponent( );
		}


		private ModbusTcpNet busTcpClient = null;
		private ModbusControl control;

		private void FormSiemens_Load( object sender, EventArgs e )
		{
			panel2.Enabled = false;
			Language( Program.Language );
			control = new ModbusControl( );
			this.userControlReadWriteDevice1.AddSpecialFunctionTab( control );
		}


		private void Language( int language )
		{
			if (language == 2)
			{
				Text = "Alien Modbus Tcp Read Demo";
				
				label3.Text = "Port:";
				label21.Text = "station";
				checkBox1.Text = "address from 0";
				button1.Text = "Connect";
				button2.Text = "Disconnect";
				label22.Text = "(11-bit ASCII characters)";
			}
		}


		private void FormSiemens_FormClosing( object sender, FormClosingEventArgs e )
		{
		}

		#region Alien Server

		/**************************************************************************************************
		 * 
		 *    说明：异形服务器的创建，为异形Modbus-Tcp客户端的创建提供必要的网络支撑
		 * 
		 **************************************************************************************************/

		private NetworkAlienClient networkAlien = null;

		private void NetworkAlienStart( int port )
		{
			networkAlien = new NetworkAlienClient( );
			networkAlien.OnClientConnected += NetworkAlien_OnClientConnected;
			networkAlien.ServerStart( port );
		}

		private void NetworkAlien_OnClientConnected( AlienSession session )
		{
			if(session.DTU == busTcpClient.ConnectionId)
			{
				busTcpClient.ConnectServer( session );
				Invoke( new Action( ( ) =>
				 {
					 panel2.Enabled = true;
					 button2.Enabled = true;

				 } ) );
			}
		}

		#endregion

		#region Connect And Close

		private void button1_Click( object sender, EventArgs e )
		{
			// 连接
			if (!int.TryParse( textBox2.Text, out int port ))
			{
				MessageBox.Show( "端口输入不正确！" );
				return;
			}

			if (!byte.TryParse( textBox15.Text, out byte station ))
			{
				MessageBox.Show( "站号输入不正确！" );
				return;
			}

			busTcpClient = new ModbusTcpNet( "127.0.0.1", port, station );
			busTcpClient.LogNet = LogNet;
			busTcpClient.AddressStartWithZero = checkBox1.Checked;

			try
			{
				busTcpClient.ConnectionId = textBox1.Text; // 设置唯一的ID
				NetworkAlienStart( port );
				busTcpClient.ConnectServer( null );        // 切换为异形客户端，并等待服务器的连接。

				// 设置子控件的读取能力
				userControlReadWriteDevice1.ReadWriteOp.SetReadWriteNet( busTcpClient, "100", true );
				// 设置批量读取
				userControlReadWriteDevice1.BatchRead.SetReadWriteNet( busTcpClient, "100", string.Empty );
				// 设置报文读取
				userControlReadWriteDevice1.MessageRead.SetReadSourceBytes( m => busTcpClient.ReadFromCoreServer( m, true, false ), string.Empty, string.Empty );

				control.SetDevice( busTcpClient, "100" );

				MessageBox.Show( "等待服务器的连接！" );
				button1.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show( ex.Message );
			}
		}

		private void button2_Click( object sender, EventArgs e )
		{
			// 断开连接
			busTcpClient.ConnectClose( );
			button2.Enabled = false;
			panel2.Enabled = false;
			// 通知下线
		}

		#endregion

		#region Test Function


		private void Test1()
		{
			OperateResult<bool[]> read = busTcpClient.ReadCoil( "100", 10 );
			if(read.IsSuccess)
			{
				bool coil_100 = read.Content[0];
				// and so on 
				bool coil_109 = read.Content[9];
			}
			else
			{
				// failed
				string err = read.Message;
			}
		}


		private void Test2()
		{
			bool[] values = new bool[] { true, false, false, false, true, true, false, true, false, false };
			OperateResult write = busTcpClient.Write( "100", values );
			if (write.IsSuccess)
			{
				// success
			}
			else
			{
				// failed
				string err = write.Message;
			}

			HslCommunication.Core.IByteTransform ByteTransform = new HslCommunication.Core.ReverseWordTransform( );
		}

		#endregion


	}
}
