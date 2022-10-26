namespace Exec2_DateTime
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
			this.timeLabel = new System.Windows.Forms.Label();
			this.timeTextBox = new System.Windows.Forms.TextBox();
			this.resultHintLabel = new System.Windows.Forms.Label();
			this.checkButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.timeLabel.Location = new System.Drawing.Point(156, 100);
			this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(230, 31);
			this.timeLabel.TabIndex = 0;
			this.timeLabel.Text = "請輸入欲判斷的時間";
			this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timeTextBox
			// 
			this.timeTextBox.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.timeTextBox.Location = new System.Drawing.Point(144, 165);
			this.timeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.timeTextBox.Name = "timeTextBox";
			this.timeTextBox.Size = new System.Drawing.Size(228, 34);
			this.timeTextBox.TabIndex = 1;
			this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// resultHintLabel
			// 
			this.resultHintLabel.AutoSize = true;
			this.resultHintLabel.Font = new System.Drawing.Font("微軟正黑體 Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultHintLabel.Location = new System.Drawing.Point(147, 291);
			this.resultHintLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.resultHintLabel.Name = "resultHintLabel";
			this.resultHintLabel.Size = new System.Drawing.Size(261, 25);
			this.resultHintLabel.TabIndex = 2;
			this.resultHintLabel.Text = "您輸入的時間是否大於今日?";
			// 
			// checkButton
			// 
			this.checkButton.Location = new System.Drawing.Point(144, 208);
			this.checkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(229, 31);
			this.checkButton.TabIndex = 3;
			this.checkButton.Text = "開始判斷";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(97, 325);
			this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(59, 29);
			this.resultLabel.TabIndex = 4;
			this.resultLabel.Text = "結果";
			this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(188, 130);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "(範例: 2020/1/1)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 502);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.checkButton);
			this.Controls.Add(this.resultHintLabel);
			this.Controls.Add(this.timeTextBox);
			this.Controls.Add(this.timeLabel);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(549, 558);
			this.Name = "Form1";
			this.Text = "判斷時間";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.TextBox timeTextBox;
		private System.Windows.Forms.Label resultHintLabel;
		private System.Windows.Forms.Button checkButton;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Label label1;
	}
}

