using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_DateTime
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Exec2_TextBox
		/// Q2: 輸入日期是否不大於今天
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			resultLabel.Text = string.Empty;
		}

		private void checkButton_Click(object sender, EventArgs e)
		{
			//取得輸入時間
			DateTime input = new DateTime();
			

			//將輸入字串轉成時間
			try
			{
				input = GetTime();
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//判斷是否不大於今天
			string result = string.Empty;

			try
			{
				result = checkTime(input);
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//顯示結果
			resultLabel.Text = result;
		}

		private string checkTime(DateTime inputTime)
		{
			DateTime today = DateTime.Today;
			TimeSpan diff = inputTime - today;

			if (diff.TotalDays >= 1)
			{
				return $"{inputTime: yyyy/MM/dd} 在{today: yyyy/MM/dd} 以後";
			} 
			else if (diff.TotalDays <1 && diff.TotalDays >=0)
			{
				return $"{inputTime: yyyy/MM/dd} 和{today: yyyy/MM/dd} 是同一天";
			}else
			{
				return $"{inputTime: yyyy/MM/dd} 和{today: yyyy/MM/dd} 以前";
			}
		}

		private DateTime GetTime()
		{
			string input = timeTextBox.Text;

			bool isFuture = DateTime.TryParse(input, out DateTime inputTime);

			if (string.IsNullOrEmpty(input))
			{
				throw new Exception("請輸入欲判斷的時間");
			}

			if (isFuture == false)
			{
				throw new Exception("請輸入正確的時間格式");
			}

			return inputTime;
		}


	}
}
