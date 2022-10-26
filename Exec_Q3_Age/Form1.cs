using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec_Q3_Age
{
	public partial class form1 : Form
	{
		/// <summary>
		/// Exec2_TextBox
		/// Q3: 經由輸入生日判斷是否已滿13歲
		/// </summary>
		public form1()
		{
			InitializeComponent();
			resultLabel.Text = string.Empty;
		}

		private void bdLabel_Load(object sender, EventArgs e)
		{

		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			//取得姓名
			string name;

			try
			{
				name = GetName();
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//取得生日
			DateTime birthday = new DateTime();

			try
			{
				birthday = GetBirthday();
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//計算年齡
			int age = 0;

			try
			{
				age = CalAge(birthday);
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//呈現結果
			string result = lessThirteen(age);
			resultLabel.Text = $"嗨囉，{name}的生日是{birthday:yyyy/MM/dd}，\r\n您的年紀是{age.ToString()}，{result}。"; 
		}

		private string lessThirteen(int age)
		{
			return (age >= 13) ? "您已滿13歲" : "您未滿13歲";
		}

		private int CalAge(DateTime inputDate)
		{
			DateTime today = DateTime.Today;
			int age = today.Year - inputDate.Year;

			if ( inputDate.AddYears(age) > today.Date)
			{
				age--;
			}

			return age;
		}

		private DateTime GetBirthday()
		{
			string inputDate = birthdayTextBox.Text;
			bool isDate = DateTime.TryParse(inputDate, out DateTime birthday);
			DateTime today = DateTime.Today;

			if (string.IsNullOrEmpty(inputDate))
			{
				throw new Exception("請輸入您的生日!");
			}

			if (isDate == false)
			{
				throw new Exception("請輸入正確格式!");
			}

			if (birthday > today)
			{
				throw new Exception("不可以輸入比今天晚的時間");
			}

			return birthday;
		}

		private string GetName()
		{
			string inputName = nameTextBox.Text.ToString();

			return (string.IsNullOrEmpty(inputName)) ? throw new Exception("請輸入姓名") : inputName;
		}

	}
}
