namespace Exec2_parkingfee
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.pplLabel = new System.Windows.Forms.Label();
			this.pplTextBox = new System.Windows.Forms.TextBox();
			this.carLabel = new System.Windows.Forms.Label();
			this.carTextBox = new System.Windows.Forms.TextBox();
			this.calcButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pplLabel
			// 
			this.pplLabel.AutoSize = true;
			this.pplLabel.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.pplLabel.Location = new System.Drawing.Point(69, 77);
			this.pplLabel.Name = "pplLabel";
			this.pplLabel.Size = new System.Drawing.Size(52, 25);
			this.pplLabel.TabIndex = 0;
			this.pplLabel.Text = "人數";
			// 
			// pplTextBox
			// 
			this.pplTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.pplTextBox.Location = new System.Drawing.Point(144, 70);
			this.pplTextBox.Name = "pplTextBox";
			this.pplTextBox.Size = new System.Drawing.Size(146, 39);
			this.pplTextBox.TabIndex = 1;
			// 
			// carLabel
			// 
			this.carLabel.AutoSize = true;
			this.carLabel.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.carLabel.Location = new System.Drawing.Point(69, 145);
			this.carLabel.Name = "carLabel";
			this.carLabel.Size = new System.Drawing.Size(52, 25);
			this.carLabel.TabIndex = 2;
			this.carLabel.Text = "車數";
			// 
			// carTextBox
			// 
			this.carTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.carTextBox.Location = new System.Drawing.Point(145, 140);
			this.carTextBox.Name = "carTextBox";
			this.carTextBox.Size = new System.Drawing.Size(145, 39);
			this.carTextBox.TabIndex = 3;
			this.carTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// calcButton
			// 
			this.calcButton.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.calcButton.Location = new System.Drawing.Point(319, 70);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(109, 109);
			this.calcButton.TabIndex = 4;
			this.calcButton.Text = "計算\r\n費用";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(68, 225);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(85, 31);
			this.resultLabel.TabIndex = 5;
			this.resultLabel.Text = "label3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 444);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.calcButton);
			this.Controls.Add(this.carTextBox);
			this.Controls.Add(this.carLabel);
			this.Controls.Add(this.pplTextBox);
			this.Controls.Add(this.pplLabel);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(557, 500);
			this.Name = "Form1";
			this.Text = "停車收費計算";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pplLabel;
		private System.Windows.Forms.TextBox pplTextBox;
		private System.Windows.Forms.Label carLabel;
		private System.Windows.Forms.TextBox carTextBox;
		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.Label resultLabel;
	}
}

