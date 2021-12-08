
namespace Autoservice.Forms
{
    partial class CarInfo
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
            this.carLabel = new System.Windows.Forms.Label();
            this.engineGroupBox = new System.Windows.Forms.GroupBox();
            this.engineRadioButton3 = new System.Windows.Forms.RadioButton();
            this.engineRadioButton2 = new System.Windows.Forms.RadioButton();
            this.engineRadioButton1 = new System.Windows.Forms.RadioButton();
            this.chassisGroupBox = new System.Windows.Forms.GroupBox();
            this.chassisRadioButton3 = new System.Windows.Forms.RadioButton();
            this.chassisRadioButton2 = new System.Windows.Forms.RadioButton();
            this.chassisRadioButton1 = new System.Windows.Forms.RadioButton();
            this.carcassRadioButtons = new System.Windows.Forms.GroupBox();
            this.carcassRadioButton3 = new System.Windows.Forms.RadioButton();
            this.carcassRadioButton2 = new System.Windows.Forms.RadioButton();
            this.carcassRadioButton1 = new System.Windows.Forms.RadioButton();
            this.assignButton = new System.Windows.Forms.Button();
            this.mechanicsComboBox = new System.Windows.Forms.ComboBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.engineGroupBox.SuspendLayout();
            this.chassisGroupBox.SuspendLayout();
            this.carcassRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carLabel.Location = new System.Drawing.Point(488, 358);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(53, 25);
            this.carLabel.TabIndex = 0;
            this.carLabel.Text = "label1";
            // 
            // engineGroupBox
            // 
            this.engineGroupBox.Controls.Add(this.engineRadioButton3);
            this.engineGroupBox.Controls.Add(this.engineRadioButton2);
            this.engineGroupBox.Controls.Add(this.engineRadioButton1);
            this.engineGroupBox.Location = new System.Drawing.Point(32, 185);
            this.engineGroupBox.Name = "engineGroupBox";
            this.engineGroupBox.Size = new System.Drawing.Size(200, 100);
            this.engineGroupBox.TabIndex = 2;
            this.engineGroupBox.TabStop = false;
            this.engineGroupBox.Text = "Engine";
            // 
            // engineRadioButton3
            // 
            this.engineRadioButton3.AutoSize = true;
            this.engineRadioButton3.Location = new System.Drawing.Point(6, 65);
            this.engineRadioButton3.Name = "engineRadioButton3";
            this.engineRadioButton3.Size = new System.Drawing.Size(118, 17);
            this.engineRadioButton3.TabIndex = 2;
            this.engineRadioButton3.TabStop = true;
            this.engineRadioButton3.Text = "Can not be repaired";
            this.engineRadioButton3.UseVisualStyleBackColor = true;
            this.engineRadioButton3.CheckedChanged += new System.EventHandler(this.EngineRadioButtons_CheckedChanged);
            // 
            // engineRadioButton2
            // 
            this.engineRadioButton2.AutoSize = true;
            this.engineRadioButton2.Location = new System.Drawing.Point(6, 42);
            this.engineRadioButton2.Name = "engineRadioButton2";
            this.engineRadioButton2.Size = new System.Drawing.Size(59, 17);
            this.engineRadioButton2.TabIndex = 1;
            this.engineRadioButton2.TabStop = true;
            this.engineRadioButton2.Text = "Broken";
            this.engineRadioButton2.UseVisualStyleBackColor = true;
            this.engineRadioButton2.CheckedChanged += new System.EventHandler(this.EngineRadioButtons_CheckedChanged);
            // 
            // engineRadioButton1
            // 
            this.engineRadioButton1.AutoSize = true;
            this.engineRadioButton1.Location = new System.Drawing.Point(6, 19);
            this.engineRadioButton1.Name = "engineRadioButton1";
            this.engineRadioButton1.Size = new System.Drawing.Size(72, 17);
            this.engineRadioButton1.TabIndex = 0;
            this.engineRadioButton1.TabStop = true;
            this.engineRadioButton1.Text = "Unbroken";
            this.engineRadioButton1.UseVisualStyleBackColor = true;
            this.engineRadioButton1.CheckedChanged += new System.EventHandler(this.EngineRadioButtons_CheckedChanged);
            // 
            // chassisGroupBox
            // 
            this.chassisGroupBox.Controls.Add(this.chassisRadioButton3);
            this.chassisGroupBox.Controls.Add(this.chassisRadioButton2);
            this.chassisGroupBox.Controls.Add(this.chassisRadioButton1);
            this.chassisGroupBox.Location = new System.Drawing.Point(317, 185);
            this.chassisGroupBox.Name = "chassisGroupBox";
            this.chassisGroupBox.Size = new System.Drawing.Size(200, 100);
            this.chassisGroupBox.TabIndex = 3;
            this.chassisGroupBox.TabStop = false;
            this.chassisGroupBox.Text = "Chassis";
            // 
            // chassisRadioButton3
            // 
            this.chassisRadioButton3.AutoSize = true;
            this.chassisRadioButton3.Location = new System.Drawing.Point(6, 65);
            this.chassisRadioButton3.Name = "chassisRadioButton3";
            this.chassisRadioButton3.Size = new System.Drawing.Size(118, 17);
            this.chassisRadioButton3.TabIndex = 2;
            this.chassisRadioButton3.TabStop = true;
            this.chassisRadioButton3.Text = "Can not be repaired";
            this.chassisRadioButton3.UseVisualStyleBackColor = true;
            this.chassisRadioButton3.CheckedChanged += new System.EventHandler(this.ChassisRadioButtons_CheckedChanged);
            // 
            // chassisRadioButton2
            // 
            this.chassisRadioButton2.AutoSize = true;
            this.chassisRadioButton2.Location = new System.Drawing.Point(6, 42);
            this.chassisRadioButton2.Name = "chassisRadioButton2";
            this.chassisRadioButton2.Size = new System.Drawing.Size(59, 17);
            this.chassisRadioButton2.TabIndex = 1;
            this.chassisRadioButton2.TabStop = true;
            this.chassisRadioButton2.Text = "Broken";
            this.chassisRadioButton2.UseVisualStyleBackColor = true;
            this.chassisRadioButton2.CheckedChanged += new System.EventHandler(this.ChassisRadioButtons_CheckedChanged);
            // 
            // chassisRadioButton1
            // 
            this.chassisRadioButton1.AutoSize = true;
            this.chassisRadioButton1.Location = new System.Drawing.Point(6, 19);
            this.chassisRadioButton1.Name = "chassisRadioButton1";
            this.chassisRadioButton1.Size = new System.Drawing.Size(72, 17);
            this.chassisRadioButton1.TabIndex = 0;
            this.chassisRadioButton1.TabStop = true;
            this.chassisRadioButton1.Text = "Unbroken";
            this.chassisRadioButton1.UseVisualStyleBackColor = true;
            this.chassisRadioButton1.CheckedChanged += new System.EventHandler(this.ChassisRadioButtons_CheckedChanged);
            // 
            // carcassRadioButtons
            // 
            this.carcassRadioButtons.Controls.Add(this.carcassRadioButton3);
            this.carcassRadioButtons.Controls.Add(this.carcassRadioButton2);
            this.carcassRadioButtons.Controls.Add(this.carcassRadioButton1);
            this.carcassRadioButtons.Location = new System.Drawing.Point(588, 185);
            this.carcassRadioButtons.Name = "carcassRadioButtons";
            this.carcassRadioButtons.Size = new System.Drawing.Size(200, 100);
            this.carcassRadioButtons.TabIndex = 4;
            this.carcassRadioButtons.TabStop = false;
            this.carcassRadioButtons.Text = "Carcass";
            // 
            // carcassRadioButton3
            // 
            this.carcassRadioButton3.AutoSize = true;
            this.carcassRadioButton3.Location = new System.Drawing.Point(6, 65);
            this.carcassRadioButton3.Name = "carcassRadioButton3";
            this.carcassRadioButton3.Size = new System.Drawing.Size(118, 17);
            this.carcassRadioButton3.TabIndex = 2;
            this.carcassRadioButton3.TabStop = true;
            this.carcassRadioButton3.Text = "Can not be repaired";
            this.carcassRadioButton3.UseVisualStyleBackColor = true;
            this.carcassRadioButton3.CheckedChanged += new System.EventHandler(this.CarcassRadioButtons_CheckedChanged);
            // 
            // carcassRadioButton2
            // 
            this.carcassRadioButton2.AutoSize = true;
            this.carcassRadioButton2.Location = new System.Drawing.Point(6, 42);
            this.carcassRadioButton2.Name = "carcassRadioButton2";
            this.carcassRadioButton2.Size = new System.Drawing.Size(59, 17);
            this.carcassRadioButton2.TabIndex = 1;
            this.carcassRadioButton2.TabStop = true;
            this.carcassRadioButton2.Text = "Broken";
            this.carcassRadioButton2.UseVisualStyleBackColor = true;
            this.carcassRadioButton2.CheckedChanged += new System.EventHandler(this.CarcassRadioButtons_CheckedChanged);
            // 
            // carcassRadioButton1
            // 
            this.carcassRadioButton1.AutoSize = true;
            this.carcassRadioButton1.Location = new System.Drawing.Point(6, 19);
            this.carcassRadioButton1.Name = "carcassRadioButton1";
            this.carcassRadioButton1.Size = new System.Drawing.Size(72, 17);
            this.carcassRadioButton1.TabIndex = 0;
            this.carcassRadioButton1.TabStop = true;
            this.carcassRadioButton1.Text = "Unbroken";
            this.carcassRadioButton1.UseVisualStyleBackColor = true;
            this.carcassRadioButton1.CheckedChanged += new System.EventHandler(this.CarcassRadioButtons_CheckedChanged);
            // 
            // assignButton
            // 
            this.assignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.assignButton.Location = new System.Drawing.Point(94, 355);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(200, 41);
            this.assignButton.TabIndex = 5;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // mechanicsComboBox
            // 
            this.mechanicsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mechanicsComboBox.FormattingEnabled = true;
            this.mechanicsComboBox.Location = new System.Drawing.Point(339, 358);
            this.mechanicsComboBox.Name = "mechanicsComboBox";
            this.mechanicsComboBox.Size = new System.Drawing.Size(121, 28);
            this.mechanicsComboBox.TabIndex = 6;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mileageTextBox.Location = new System.Drawing.Point(32, 133);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(100, 26);
            this.mileageTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Milleage";
            // 
            // CarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Autoservice.Properties.Resources.GarageImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mileageTextBox);
            this.Controls.Add(this.mechanicsComboBox);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.carcassRadioButtons);
            this.Controls.Add(this.chassisGroupBox);
            this.Controls.Add(this.engineGroupBox);
            this.Controls.Add(this.carLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CarInfo";
            this.Text = "CarInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarInfo_FormClosed);
            this.engineGroupBox.ResumeLayout(false);
            this.engineGroupBox.PerformLayout();
            this.chassisGroupBox.ResumeLayout(false);
            this.chassisGroupBox.PerformLayout();
            this.carcassRadioButtons.ResumeLayout(false);
            this.carcassRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.GroupBox engineGroupBox;
        private System.Windows.Forms.RadioButton engineRadioButton3;
        private System.Windows.Forms.RadioButton engineRadioButton2;
        private System.Windows.Forms.RadioButton engineRadioButton1;
        private System.Windows.Forms.GroupBox chassisGroupBox;
        private System.Windows.Forms.RadioButton chassisRadioButton3;
        private System.Windows.Forms.RadioButton chassisRadioButton2;
        private System.Windows.Forms.RadioButton chassisRadioButton1;
        private System.Windows.Forms.GroupBox carcassRadioButtons;
        private System.Windows.Forms.RadioButton carcassRadioButton3;
        private System.Windows.Forms.RadioButton carcassRadioButton2;
        private System.Windows.Forms.RadioButton carcassRadioButton1;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.ComboBox mechanicsComboBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.Label label1;
    }
}