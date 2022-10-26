using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Exec2_TextBox
		/// Q1: 輸入數值是否在[1, 99]之間
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			resultLabel.Text = String.Empty;
		}

		private void isRangeButton_Click(object sender, EventArgs e)
		{
			//輸入要判斷的值
			int value = 0;

			try
			{
				value = GetValue();
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//判斷是否在[1, 99]中
			string range = string.Empty;

			try
			{
				range = checkRange(value);
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//結果呈現
			resultLabel.Text = range;
		}

		private string checkRange(int number)
		{
			string result = string.Empty;
			
			if (number > 99 || number < 1)
			{
				return result = $"{number} 不在1到99當中。";
			}
			else
			{
				return result = $"{number} 在1到99當中。";
			}
		}

		private int GetValue()
		{
			bool isInt = int.TryParse(numTextBox.Text, out int number);
			
			if (isInt == false)
			{
				throw new Exception("請輸入數字!");
			}

			return number;
		}
	}
}
