using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_parkingfee
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Exec2_TextBox
		/// Q4: 入場費用計算規則：每一個團體要進入園區時，可以用比較便宜的團體，限制是只能採取以下兩種裡的一種，不能分成兩個團體
		//  按車輛計費：每部車收200元，不管裡面做多少乘客
		//  按人頭計費﹔每人收60元，無論多少部車
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			resultLabel.Text = String.Empty;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			//取得人數、車數
			int pplAmount = 0;
			int carAmount = 0;

			try
			{
				pplAmount = GetPplAmount();
				carAmount = GetCarAmount();
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//計算費用
			int fee = CalcFee(pplAmount, carAmount);

			//呈現結果
			resultLabel.Text = $"此次停車共有 {pplAmount} 位乘客、{carAmount} 輛汽車，\r\n共收費{fee.ToString()} 元整。";
		}

		private int CalcFee(int pplamount, int caramount)
		{
			int carFee = 200;
			int pplFee = 60;

			int carCharge = caramount * carFee;
			int pplCharge = pplamount * pplFee;

			return (carCharge >= pplCharge) ? carCharge : pplCharge;
		}

		private int SetDefense(string input)
		{
			bool isInt = int.TryParse(input, out int amount);

			if (string.IsNullOrEmpty(input))
			{
				throw new Exception("請輸入數量!");
			}

			if (isInt == false)
			{
				throw new Exception("僅可填入數字!");
			}

			if (amount <= 0)
			{
				throw new Exception("請輸入非零的正整數!");
			}

			return amount;
		}
		private int GetCarAmount()
		{
			string carInput = carTextBox.Text.ToString();
			return SetDefense(carInput);
		}

		private int GetPplAmount()
		{
			string pplInput = pplTextBox.Text.ToString();
			return SetDefense(pplInput);
		}
	}
}
