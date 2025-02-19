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
using System.Threading;
using HslCommunication.Profinet.LSIS;
using System.Xml.Linq;
using HslCommunicationDemo.PLC.Common;

namespace HslCommunicationDemo
{
	public partial class FormLsisXGKFEnet : HslFormContent
	{
		public FormLsisXGKFEnet( )
		{
			InitializeComponent( );
			fastEnet = new XGKFastEnet( );
		}


		private XGKFastEnet fastEnet = null;
		private SpecialFeaturesControl control;
		

		private void FormSiemens_Load( object sender, EventArgs e )
		{
			panel2.Enabled = false;

			Language( Program.Language );

			cboxModel.DataSource = Enum.GetNames( typeof( LSCpuInfo ) );
			cboxCompanyID.SelectedIndex = 0;

			control = new SpecialFeaturesControl( );
			this.userControlReadWriteDevice1.AddSpecialFunctionTab( control );
		}


		private void Language( int language )
		{
			if (language == 2)
			{
				Text = "Lsis Read PLC Demo";
			   

				label1.Text = "Ip:";
				label3.Text = "Port:";
				button1.Text = "Connect";
				button2.Text = "Disconnect";
				label21.Text = "Address:";
			}
		}

		private void FormSiemens_FormClosing( object sender, FormClosingEventArgs e )
		{

		}
		
		#region Connect And Close



		private void button1_Click( object sender, EventArgs e )
		{

			if (!int.TryParse( textBox2.Text, out int port ))
			{
				MessageBox.Show( DemoUtils.PortInputWrong );
				return;
			}

			if(!byte.TryParse(textBox12.Text, out byte slot ))
			{
				MessageBox.Show( DemoUtils.SlotInputWrong );
				return;
			}

			fastEnet.IpAddress = textBox1.Text;
			fastEnet.Port = port;
			fastEnet.SlotNo = slot;
			fastEnet.SetCpuType = cboxModel.Text;
			fastEnet.CompanyID = cboxCompanyID.Text;
			fastEnet.LogNet = LogNet;

			try
			{
				OperateResult connect = fastEnet.ConnectServer( );
				if (connect.IsSuccess)
				{
					MessageBox.Show( HslCommunication.StringResources.Language.ConnectedSuccess );
					button2.Enabled = true;
					button1.Enabled = false;
					panel2.Enabled = true;

					// 设置子控件的读取能力
					userControlReadWriteDevice1.ReadWriteOp.SetReadWriteNet( fastEnet, "MB100", true );
					// 设置批量读取
					userControlReadWriteDevice1.BatchRead.SetReadWriteNet( fastEnet, "MB100", string.Empty );
					// 设置报文读取
					userControlReadWriteDevice1.MessageRead.SetReadSourceBytes( m => fastEnet.ReadFromCoreServer( m, true, false ), string.Empty, string.Empty );

					control.SetDevice( fastEnet, "MB100" );
				}
				else
				{
					MessageBox.Show( HslCommunication.StringResources.Language.ConnectedFailed );
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show( ex.Message );
			}
		}

		private void button2_Click( object sender, EventArgs e )
		{
			// 断开连接
			fastEnet.ConnectClose( );
			button2.Enabled = false;
			button1.Enabled = true;
			panel2.Enabled = false;
		}

		#endregion

		public override void SaveXmlParameter( XElement element )
		{
			element.SetAttributeValue( DemoDeviceList.XmlIpAddress, textBox1.Text );
			element.SetAttributeValue( DemoDeviceList.XmlPort, textBox2.Text );
			element.SetAttributeValue( DemoDeviceList.XmlCpuType, cboxModel.Text );
			element.SetAttributeValue( DemoDeviceList.XmlCompanyID, cboxCompanyID.Text );
			element.SetAttributeValue( DemoDeviceList.XmlSlot, textBox12.Text );
		}

		public override void LoadXmlParameter( XElement element )
		{
			base.LoadXmlParameter( element );
			textBox1.Text = element.Attribute( DemoDeviceList.XmlIpAddress ).Value;
			textBox2.Text = element.Attribute( DemoDeviceList.XmlPort ).Value;
			cboxModel.Text = element.Attribute( DemoDeviceList.XmlCpuType ).Value;
			cboxCompanyID.Text = element.Attribute( DemoDeviceList.XmlCompanyID ).Value;
			textBox12.Text = element.Attribute( DemoDeviceList.XmlSlot ).Value;
		}

		private void userControlHead1_SaveConnectEvent_1( object sender, EventArgs e )
		{
			userControlHead1_SaveConnectEvent( sender, e );
		}
	}
}
