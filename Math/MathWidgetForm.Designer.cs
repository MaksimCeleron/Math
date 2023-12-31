
namespace Math
{
    partial class MathWidgetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathWidgetForm));
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubstractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Num1AndOperationLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DeleteOneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(12, 12);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ReadOnly = true;
            this.InputTextBox.Size = new System.Drawing.Size(126, 26);
            this.InputTextBox.TabIndex = 1;
            this.InputTextBox.Text = "0";
            this.InputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ToolTip.SetToolTip(this.InputTextBox, "Alt+ЛКМ для видалення однієї цифри");
            this.InputTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InputTextBox_MouseDown);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button7.Location = new System.Drawing.Point(12, 77);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(27, 27);
            this.Button7.TabIndex = 2;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button8.Location = new System.Drawing.Point(45, 77);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(27, 27);
            this.Button8.TabIndex = 3;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button9.Location = new System.Drawing.Point(78, 77);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(27, 27);
            this.Button9.TabIndex = 4;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button6.Location = new System.Drawing.Point(78, 110);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(27, 27);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button5.Location = new System.Drawing.Point(45, 110);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(27, 27);
            this.Button5.TabIndex = 6;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button4.Location = new System.Drawing.Point(12, 110);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(27, 27);
            this.Button4.TabIndex = 5;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button3.Location = new System.Drawing.Point(78, 143);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(27, 27);
            this.Button3.TabIndex = 10;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button2.Location = new System.Drawing.Point(45, 143);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(27, 27);
            this.Button2.TabIndex = 9;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.Location = new System.Drawing.Point(12, 143);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(27, 27);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(111, 143);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(27, 60);
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.Text = "=";
            this.ToolTip.SetToolTip(this.CalculateButton, "Enter");
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecimalButton.Location = new System.Drawing.Point(78, 176);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(27, 27);
            this.DecimalButton.TabIndex = 12;
            this.DecimalButton.Text = ",";
            this.ToolTip.SetToolTip(this.DecimalButton, ". або ,");
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // Button0
            // 
            this.Button0.Enabled = false;
            this.Button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button0.Location = new System.Drawing.Point(12, 176);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(60, 27);
            this.Button0.TabIndex = 11;
            this.Button0.Text = "0";
            this.ToolTip.SetToolTip(this.Button0, "Alt+0 для написання двох нулів");
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(111, 77);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(27, 60);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "+";
            this.ToolTip.SetToolTip(this.AddButton, "Ctrl++ для зміни числа на додатнє");
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubstractButton
            // 
            this.SubstractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubstractButton.Location = new System.Drawing.Point(111, 44);
            this.SubstractButton.Name = "SubstractButton";
            this.SubstractButton.Size = new System.Drawing.Size(27, 27);
            this.SubstractButton.TabIndex = 16;
            this.SubstractButton.Text = "-";
            this.ToolTip.SetToolTip(this.SubstractButton, "Ctrl+- для зміни числа на від\'ємне");
            this.SubstractButton.UseVisualStyleBackColor = true;
            this.SubstractButton.Click += new System.EventHandler(this.SubstractButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.Location = new System.Drawing.Point(78, 44);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(27, 27);
            this.MultiplyButton.TabIndex = 15;
            this.MultiplyButton.Text = "×";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivideButton.Location = new System.Drawing.Point(45, 44);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(27, 27);
            this.DivideButton.TabIndex = 14;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(12, 44);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(27, 27);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Num1AndOperationLabel
            // 
            this.Num1AndOperationLabel.AutoSize = true;
            this.Num1AndOperationLabel.Location = new System.Drawing.Point(12, 25);
            this.Num1AndOperationLabel.Name = "Num1AndOperationLabel";
            this.Num1AndOperationLabel.Size = new System.Drawing.Size(0, 13);
            this.Num1AndOperationLabel.TabIndex = 22;
            // 
            // DeleteOneButton
            // 
            this.DeleteOneButton.Enabled = false;
            this.DeleteOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteOneButton.Location = new System.Drawing.Point(45, 44);
            this.DeleteOneButton.Name = "DeleteOneButton";
            this.DeleteOneButton.Size = new System.Drawing.Size(27, 27);
            this.DeleteOneButton.TabIndex = 19;
            this.DeleteOneButton.Text = "←";
            this.DeleteOneButton.UseVisualStyleBackColor = true;
            this.DeleteOneButton.Visible = false;
            this.DeleteOneButton.Click += new System.EventHandler(this.DeleteOneButton_Click);
            // 
            // MathWidgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 215);
            this.Controls.Add(this.Num1AndOperationLabel);
            this.Controls.Add(this.DeleteOneButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SubstractButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.InputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MathWidgetForm";
            this.Text = "Math";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MathWidgetForm_FormClosed);
            this.Load += new System.EventHandler(this.MathForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MathForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubstractButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label Num1AndOperationLabel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button DeleteOneButton;
    }
}

