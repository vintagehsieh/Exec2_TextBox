namespace Exec_Q3_Age
{
	partial class form1
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
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.birthdayLabel = new System.Windows.Forms.Label();
			this.birthdayTextBox = new System.Windows.Forms.TextBox();
			this.generateButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.nameLabel.Location = new System.Drawing.Point(148, 105);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(52, 25);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "姓名";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.nameTextBox.Location = new System.Drawing.Point(144, 130);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(235, 33);
			this.nameTextBox.TabIndex = 1;
			// 
			// birthdayLabel
			// 
			this.birthdayLabel.AutoSize = true;
			this.birthdayLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.birthdayLabel.Location = new System.Drawing.Point(148, 192);
			this.birthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.birthdayLabel.Name = "birthdayLabel";
			this.birthdayLabel.Size = new System.Drawing.Size(52, 25);
			this.birthdayLabel.TabIndex = 2;
			this.birthdayLabel.Text = "生日";
			// 
			// birthdayTextBox
			// 
			this.birthdayTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.birthdayTextBox.Location = new System.Drawing.Point(144, 218);
			this.birthdayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.birthdayTextBox.Name = "birthdayTextBox";
			this.birthdayTextBox.Size = new System.Drawing.Size(235, 33);
			this.birthdayTextBox.TabIndex = 3;
			// 
			// generateButton
			// 
			this.generateButton.Location = new System.Drawing.Point(144, 305);
			this.generateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(236, 28);
			this.generateButton.TabIndex = 4;
			this.generateButton.Text = "開始判斷";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(147, 389);
			this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(62, 31);
			this.resultLabel.TabIndex = 5;
			this.resultLabel.Text = "結果";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(261, 252);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "範例: 2020/1/1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 529);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.birthdayTextBox);
			this.Controls.Add(this.birthdayLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(603, 585);
			this.Name = "form1";
			this.Text = "判斷年紀";
			this.Load += new System.EventHandler(this.bdLabel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label birthdayLabel;
		private System.Windows.Forms.TextBox birthdayTextBox;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Label label1;
	}
}

