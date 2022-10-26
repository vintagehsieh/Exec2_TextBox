namespace Exec2_TextBox
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
			this.numLabel = new System.Windows.Forms.Label();
			this.numTextBox = new System.Windows.Forms.TextBox();
			this.isRangeButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// numLabel
			// 
			this.numLabel.AutoSize = true;
			this.numLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numLabel.Location = new System.Drawing.Point(112, 78);
			this.numLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.numLabel.Name = "numLabel";
			this.numLabel.Size = new System.Drawing.Size(206, 31);
			this.numLabel.TabIndex = 0;
			this.numLabel.Text = "請輸入要判斷的值";
			// 
			// numTextBox
			// 
			this.numTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numTextBox.Location = new System.Drawing.Point(124, 114);
			this.numTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.numTextBox.MaxLength = 1000000000;
			this.numTextBox.Name = "numTextBox";
			this.numTextBox.Size = new System.Drawing.Size(177, 39);
			this.numTextBox.TabIndex = 1;
			this.numTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// isRangeButton
			// 
			this.isRangeButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.isRangeButton.Location = new System.Drawing.Point(124, 171);
			this.isRangeButton.Margin = new System.Windows.Forms.Padding(4);
			this.isRangeButton.Name = "isRangeButton";
			this.isRangeButton.Size = new System.Drawing.Size(179, 36);
			this.isRangeButton.TabIndex = 2;
			this.isRangeButton.Text = "開始判斷";
			this.isRangeButton.UseVisualStyleBackColor = true;
			this.isRangeButton.Click += new System.EventHandler(this.isRangeButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(119, 238);
			this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(62, 31);
			this.resultLabel.TabIndex = 3;
			this.resultLabel.Text = "範圍";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 399);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.isRangeButton);
			this.Controls.Add(this.numTextBox);
			this.Controls.Add(this.numLabel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(463, 455);
			this.Name = "Form1";
			this.Text = "判斷數值";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label numLabel;
		private System.Windows.Forms.TextBox numTextBox;
		private System.Windows.Forms.Button isRangeButton;
		private System.Windows.Forms.Label resultLabel;
	}
}

