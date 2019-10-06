namespace calc
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FourButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.NullButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.DeleteNumberButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.CommaButton = new System.Windows.Forms.Button();
            this.MatchButton = new System.Windows.Forms.Button();
            this.SignChangeButton = new System.Windows.Forms.Button();
            this.NumberInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FourButton
            // 
            this.FourButton.FlatAppearance.BorderSize = 0;
            this.FourButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.FourButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourButton.Location = new System.Drawing.Point(12, 335);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(100, 100);
            this.FourButton.TabIndex = 0;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.HandleNumberButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.White;
            this.SevenButton.FlatAppearance.BorderSize = 0;
            this.SevenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.SevenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SevenButton.Location = new System.Drawing.Point(12, 229);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(100, 100);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.HandleNumberButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CEButton.FlatAppearance.BorderSize = 0;
            this.CEButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.CEButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CEButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CEButton.Location = new System.Drawing.Point(12, 123);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(100, 100);
            this.CEButton.TabIndex = 0;
            this.CEButton.Tag = "Clear";
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.HandleActionButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.FlatAppearance.BorderSize = 0;
            this.TwoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.TwoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwoButton.Location = new System.Drawing.Point(118, 441);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(100, 100);
            this.TwoButton.TabIndex = 0;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.HandleNumberButton_Click);
            // 
            // NullButton
            // 
            this.NullButton.FlatAppearance.BorderSize = 0;
            this.NullButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.NullButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.NullButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NullButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NullButton.Location = new System.Drawing.Point(118, 547);
            this.NullButton.Name = "NullButton";
            this.NullButton.Size = new System.Drawing.Size(100, 100);
            this.NullButton.TabIndex = 0;
            this.NullButton.Text = "0";
            this.NullButton.UseVisualStyleBackColor = true;
            this.NullButton.Click += new System.EventHandler(this.HandleNumberButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.FlatAppearance.BorderSize = 0;
            this.OneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.OneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneButton.Location = new System.Drawing.Point(12, 441);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(100, 100);
            this.OneButton.TabIndex = 0;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.HandleNumberButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.FlatAppearance.BorderSize = 0;
            this.ThreeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.ThreeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreeButton.Location = new System.Drawing.Point(224, 441);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(100, 100);
            this.ThreeButton.TabIndex = 0;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.HandleNumberButton_Click);
            // 
            // DeleteNumberButton
            // 
            this.DeleteNumberButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteNumberButton.FlatAppearance.BorderSize = 0;
            this.DeleteNumberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.DeleteNumberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.DeleteNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNumberButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteNumberButton.Location = new System.Drawing.Point(224, 123);
            this.DeleteNumberButton.Name = "DeleteNumberButton";
            this.DeleteNumberButton.Size = new System.Drawing.Size(100, 100);
            this.DeleteNumberButton.TabIndex = 0;
            this.DeleteNumberButton.Tag = "DeleteNumber";
            this.DeleteNumberButton.Text = "<";
            this.DeleteNumberButton.UseVisualStyleBackColor = false;
            this.DeleteNumberButton.Click += new System.EventHandler(this.HandleActionButton_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CButton.FlatAppearance.BorderSize = 0;
            this.CButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.CButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CButton.Location = new System.Drawing.Point(118, 123);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(100, 100);
            this.CButton.TabIndex = 0;
            this.CButton.Tag = "ClearAll";
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.HandleActionButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.White;
            this.EightButton.FlatAppearance.BorderSize = 0;
            this.EightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.EightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EightButton.Location = new System.Drawing.Point(118, 229);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(100, 100);
            this.EightButton.TabIndex = 0;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.HandleNumberButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.FlatAppearance.BorderSize = 0;
            this.FiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.FiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiveButton.Location = new System.Drawing.Point(118, 335);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(100, 100);
            this.FiveButton.TabIndex = 0;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.HandleNumberButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.FlatAppearance.BorderSize = 0;
            this.SixButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.SixButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SixButton.Location = new System.Drawing.Point(224, 335);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(100, 100);
            this.SixButton.TabIndex = 0;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.HandleNumberButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.White;
            this.NineButton.FlatAppearance.BorderSize = 0;
            this.NineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.NineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NineButton.Location = new System.Drawing.Point(224, 229);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(100, 100);
            this.NineButton.TabIndex = 0;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.HandleNumberButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DivisionButton.FlatAppearance.BorderSize = 0;
            this.DivisionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.DivisionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.DivisionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivisionButton.Location = new System.Drawing.Point(330, 123);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(100, 100);
            this.DivisionButton.TabIndex = 0;
            this.DivisionButton.Tag = "Division";
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = false;
            this.DivisionButton.Click += new System.EventHandler(this.HandleActionButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MultiplyButton.FlatAppearance.BorderSize = 0;
            this.MultiplyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.MultiplyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplyButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.Location = new System.Drawing.Point(330, 229);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(100, 100);
            this.MultiplyButton.TabIndex = 0;
            this.MultiplyButton.Tag = "Multi";
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.Click += new System.EventHandler(this.HandleActionButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SubtractionButton.FlatAppearance.BorderSize = 0;
            this.SubtractionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.SubtractionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.SubtractionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtractionButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubtractionButton.Location = new System.Drawing.Point(330, 335);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(100, 100);
            this.SubtractionButton.TabIndex = 0;
            this.SubtractionButton.Tag = "Minus";
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.UseVisualStyleBackColor = false;
            this.SubtractionButton.Click += new System.EventHandler(this.HandleActionButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PlusButton.FlatAppearance.BorderSize = 0;
            this.PlusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.PlusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.Location = new System.Drawing.Point(330, 441);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(100, 100);
            this.PlusButton.TabIndex = 0;
            this.PlusButton.Tag = "Plus";
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.HandleActionButton_Click);
            // 
            // CommaButton
            // 
            this.CommaButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CommaButton.FlatAppearance.BorderSize = 0;
            this.CommaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.CommaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CommaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommaButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommaButton.Location = new System.Drawing.Point(224, 547);
            this.CommaButton.Name = "CommaButton";
            this.CommaButton.Size = new System.Drawing.Size(100, 100);
            this.CommaButton.TabIndex = 0;
            this.CommaButton.Tag = "Comma";
            this.CommaButton.Text = ",";
            this.CommaButton.UseVisualStyleBackColor = false;
            this.CommaButton.Click += new System.EventHandler(this.HandleActionButton_Click);
            // 
            // MatchButton
            // 
            this.MatchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MatchButton.FlatAppearance.BorderSize = 0;
            this.MatchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.MatchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.MatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatchButton.Location = new System.Drawing.Point(330, 547);
            this.MatchButton.Name = "MatchButton";
            this.MatchButton.Size = new System.Drawing.Size(100, 100);
            this.MatchButton.TabIndex = 0;
            this.MatchButton.Tag = "Match";
            this.MatchButton.Text = "=";
            this.MatchButton.UseVisualStyleBackColor = false;
            this.MatchButton.Click += new System.EventHandler(this.HandleActionButton_Click);
            // 
            // SignChangeButton
            // 
            this.SignChangeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SignChangeButton.FlatAppearance.BorderSize = 0;
            this.SignChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.SignChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.SignChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignChangeButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignChangeButton.Location = new System.Drawing.Point(12, 547);
            this.SignChangeButton.Name = "SignChangeButton";
            this.SignChangeButton.Size = new System.Drawing.Size(100, 100);
            this.SignChangeButton.TabIndex = 0;
            this.SignChangeButton.Tag = "SignChange";
            this.SignChangeButton.Text = "+/-";
            this.SignChangeButton.UseVisualStyleBackColor = false;
            this.SignChangeButton.Click += new System.EventHandler(this.HandleActionButton_Click);
            // 
            // NumberInput
            // 
            this.NumberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberInput.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberInput.Location = new System.Drawing.Point(12, 35);
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberInput.Size = new System.Drawing.Size(418, 43);
            this.NumberInput.TabIndex = 1;
            this.NumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 653);
            this.Controls.Add(this.NumberInput);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.CommaButton);
            this.Controls.Add(this.MatchButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.SubtractionButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.DeleteNumberButton);
            this.Controls.Add(this.CEButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.SignChangeButton);
            this.Controls.Add(this.NullButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.TwoButton);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button NullButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button DeleteNumberButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button CommaButton;
        private System.Windows.Forms.Button MatchButton;
        private System.Windows.Forms.Button SignChangeButton;
        private System.Windows.Forms.TextBox NumberInput;
    }
}

