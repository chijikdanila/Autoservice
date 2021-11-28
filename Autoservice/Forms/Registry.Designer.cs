
namespace Autoservice.Forms
{
    partial class Registry
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
            this.transportModelComboBox = new System.Windows.Forms.ComboBox();
            this.transportModelTextBox = new System.Windows.Forms.TextBox();
            this.editModelIfNotExistsLabel = new System.Windows.Forms.Label();
            this.transportModelGroupBox = new System.Windows.Forms.GroupBox();
            this.transportTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.carRadioButton = new System.Windows.Forms.RadioButton();
            this.truckRadioButton = new System.Windows.Forms.RadioButton();
            this.transportBodyGroupBox = new System.Windows.Forms.GroupBox();
            this.transportBodyComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerGroupBox = new System.Windows.Forms.GroupBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.transportAssemblyGroupBox = new System.Windows.Forms.GroupBox();
            this.carAssemblyTextBox = new System.Windows.Forms.TextBox();
            this.transportNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.transportNumberTextBox = new System.Windows.Forms.TextBox();
            this.transportModelGroupBox.SuspendLayout();
            this.transportTypeGroupBox.SuspendLayout();
            this.transportBodyGroupBox.SuspendLayout();
            this.manufacturerGroupBox.SuspendLayout();
            this.transportAssemblyGroupBox.SuspendLayout();
            this.transportNumberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // transportModelComboBox
            // 
            this.transportModelComboBox.FormattingEnabled = true;
            this.transportModelComboBox.Location = new System.Drawing.Point(6, 21);
            this.transportModelComboBox.Name = "transportModelComboBox";
            this.transportModelComboBox.Size = new System.Drawing.Size(121, 24);
            this.transportModelComboBox.TabIndex = 3;
            this.transportModelComboBox.SelectedIndexChanged += new System.EventHandler(this.transportModelComboBox_SelectedIndexChanged);
            this.transportModelComboBox.DropDownClosed += new System.EventHandler(this.transportModelComboBox_DropDownClosed);
            // 
            // transportModelTextBox
            // 
            this.transportModelTextBox.Location = new System.Drawing.Point(108, 61);
            this.transportModelTextBox.MaxLength = 50;
            this.transportModelTextBox.Name = "transportModelTextBox";
            this.transportModelTextBox.Size = new System.Drawing.Size(121, 22);
            this.transportModelTextBox.TabIndex = 4;
            this.transportModelTextBox.TextChanged += new System.EventHandler(this.transportModelTextBox_TextChanged);
            // 
            // editModelIfNotExistsLabel
            // 
            this.editModelIfNotExistsLabel.AutoSize = true;
            this.editModelIfNotExistsLabel.Location = new System.Drawing.Point(6, 64);
            this.editModelIfNotExistsLabel.Name = "editModelIfNotExistsLabel";
            this.editModelIfNotExistsLabel.Size = new System.Drawing.Size(96, 17);
            this.editModelIfNotExistsLabel.TabIndex = 5;
            this.editModelIfNotExistsLabel.Text = "Or input here:";
            // 
            // transportModelGroupBox
            // 
            this.transportModelGroupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.transportModelGroupBox.Controls.Add(this.transportModelComboBox);
            this.transportModelGroupBox.Controls.Add(this.transportModelTextBox);
            this.transportModelGroupBox.Controls.Add(this.editModelIfNotExistsLabel);
            this.transportModelGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transportModelGroupBox.Location = new System.Drawing.Point(237, 12);
            this.transportModelGroupBox.Name = "transportModelGroupBox";
            this.transportModelGroupBox.Size = new System.Drawing.Size(241, 100);
            this.transportModelGroupBox.TabIndex = 6;
            this.transportModelGroupBox.TabStop = false;
            this.transportModelGroupBox.Text = "Model";
            // 
            // transportTypeGroupBox
            // 
            this.transportTypeGroupBox.Controls.Add(this.carRadioButton);
            this.transportTypeGroupBox.Controls.Add(this.truckRadioButton);
            this.transportTypeGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transportTypeGroupBox.Location = new System.Drawing.Point(22, 12);
            this.transportTypeGroupBox.Name = "transportTypeGroupBox";
            this.transportTypeGroupBox.Size = new System.Drawing.Size(160, 78);
            this.transportTypeGroupBox.TabIndex = 7;
            this.transportTypeGroupBox.TabStop = false;
            this.transportTypeGroupBox.Text = "Type";
            // 
            // carRadioButton
            // 
            this.carRadioButton.AutoSize = true;
            this.carRadioButton.Location = new System.Drawing.Point(9, 48);
            this.carRadioButton.Name = "carRadioButton";
            this.carRadioButton.Size = new System.Drawing.Size(51, 21);
            this.carRadioButton.TabIndex = 9;
            this.carRadioButton.TabStop = true;
            this.carRadioButton.Text = "Car";
            this.carRadioButton.UseVisualStyleBackColor = true;
            this.carRadioButton.CheckedChanged += new System.EventHandler(this.carRadioButton_CheckedChanged);
            // 
            // truckRadioButton
            // 
            this.truckRadioButton.AutoSize = true;
            this.truckRadioButton.Location = new System.Drawing.Point(9, 21);
            this.truckRadioButton.Name = "truckRadioButton";
            this.truckRadioButton.Size = new System.Drawing.Size(65, 21);
            this.truckRadioButton.TabIndex = 8;
            this.truckRadioButton.TabStop = true;
            this.truckRadioButton.Text = "Truck";
            this.truckRadioButton.UseVisualStyleBackColor = true;
            this.truckRadioButton.CheckedChanged += new System.EventHandler(this.truckRadioButton_CheckedChanged);
            // 
            // transportBodyGroupBox
            // 
            this.transportBodyGroupBox.Controls.Add(this.transportBodyComboBox);
            this.transportBodyGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transportBodyGroupBox.Location = new System.Drawing.Point(22, 108);
            this.transportBodyGroupBox.Name = "transportBodyGroupBox";
            this.transportBodyGroupBox.Size = new System.Drawing.Size(200, 78);
            this.transportBodyGroupBox.TabIndex = 8;
            this.transportBodyGroupBox.TabStop = false;
            this.transportBodyGroupBox.Text = "Body";
            // 
            // transportBodyComboBox
            // 
            this.transportBodyComboBox.FormattingEnabled = true;
            this.transportBodyComboBox.Items.AddRange(new object[] {
            "Choose type"});
            this.transportBodyComboBox.Location = new System.Drawing.Point(9, 31);
            this.transportBodyComboBox.Name = "transportBodyComboBox";
            this.transportBodyComboBox.Size = new System.Drawing.Size(121, 24);
            this.transportBodyComboBox.TabIndex = 9;
            this.transportBodyComboBox.SelectedIndexChanged += new System.EventHandler(this.transportBodyComboBox_SelectedIndexChanged);
            this.transportBodyComboBox.DropDownClosed += new System.EventHandler(this.transportBodyComboBox_DropDownClosed);
            // 
            // manufacturerGroupBox
            // 
            this.manufacturerGroupBox.Controls.Add(this.manufacturerTextBox);
            this.manufacturerGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.manufacturerGroupBox.Location = new System.Drawing.Point(22, 214);
            this.manufacturerGroupBox.Name = "manufacturerGroupBox";
            this.manufacturerGroupBox.Size = new System.Drawing.Size(200, 77);
            this.manufacturerGroupBox.TabIndex = 9;
            this.manufacturerGroupBox.TabStop = false;
            this.manufacturerGroupBox.Text = "Manufacturer";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Enabled = false;
            this.manufacturerTextBox.Location = new System.Drawing.Point(9, 33);
            this.manufacturerTextBox.MaxLength = 25;
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(118, 22);
            this.manufacturerTextBox.TabIndex = 10;
            this.manufacturerTextBox.TextChanged += new System.EventHandler(this.manufacturerTextBox_TextChanged);
            // 
            // transportAssemblyGroupBox
            // 
            this.transportAssemblyGroupBox.Controls.Add(this.carAssemblyTextBox);
            this.transportAssemblyGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transportAssemblyGroupBox.Location = new System.Drawing.Point(237, 134);
            this.transportAssemblyGroupBox.Name = "transportAssemblyGroupBox";
            this.transportAssemblyGroupBox.Size = new System.Drawing.Size(200, 74);
            this.transportAssemblyGroupBox.TabIndex = 10;
            this.transportAssemblyGroupBox.TabStop = false;
            this.transportAssemblyGroupBox.Text = "Assembly";
            // 
            // carAssemblyTextBox
            // 
            this.carAssemblyTextBox.Location = new System.Drawing.Point(9, 33);
            this.carAssemblyTextBox.MaxLength = 50;
            this.carAssemblyTextBox.Name = "carAssemblyTextBox";
            this.carAssemblyTextBox.Size = new System.Drawing.Size(118, 22);
            this.carAssemblyTextBox.TabIndex = 11;
            this.carAssemblyTextBox.TextChanged += new System.EventHandler(this.carAssemblyTextBox_TextChanged);
            // 
            // transportNumberGroupBox
            // 
            this.transportNumberGroupBox.Controls.Add(this.transportNumberTextBox);
            this.transportNumberGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transportNumberGroupBox.Location = new System.Drawing.Point(237, 214);
            this.transportNumberGroupBox.Name = "transportNumberGroupBox";
            this.transportNumberGroupBox.Size = new System.Drawing.Size(200, 77);
            this.transportNumberGroupBox.TabIndex = 11;
            this.transportNumberGroupBox.TabStop = false;
            this.transportNumberGroupBox.Text = "Number";
            // 
            // transportNumberTextBox
            // 
            this.transportNumberTextBox.Location = new System.Drawing.Point(9, 35);
            this.transportNumberTextBox.MaxLength = 10;
            this.transportNumberTextBox.Name = "transportNumberTextBox";
            this.transportNumberTextBox.Size = new System.Drawing.Size(118, 22);
            this.transportNumberTextBox.TabIndex = 12;
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.transportNumberGroupBox);
            this.Controls.Add(this.transportAssemblyGroupBox);
            this.Controls.Add(this.manufacturerGroupBox);
            this.Controls.Add(this.transportBodyGroupBox);
            this.Controls.Add(this.transportTypeGroupBox);
            this.Controls.Add(this.transportModelGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Registry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registry";
            this.transportModelGroupBox.ResumeLayout(false);
            this.transportModelGroupBox.PerformLayout();
            this.transportTypeGroupBox.ResumeLayout(false);
            this.transportTypeGroupBox.PerformLayout();
            this.transportBodyGroupBox.ResumeLayout(false);
            this.manufacturerGroupBox.ResumeLayout(false);
            this.manufacturerGroupBox.PerformLayout();
            this.transportAssemblyGroupBox.ResumeLayout(false);
            this.transportAssemblyGroupBox.PerformLayout();
            this.transportNumberGroupBox.ResumeLayout(false);
            this.transportNumberGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox transportModelComboBox;
        private System.Windows.Forms.TextBox transportModelTextBox;
        private System.Windows.Forms.Label editModelIfNotExistsLabel;
        private System.Windows.Forms.GroupBox transportModelGroupBox;
        private System.Windows.Forms.GroupBox transportTypeGroupBox;
        private System.Windows.Forms.RadioButton carRadioButton;
        private System.Windows.Forms.RadioButton truckRadioButton;
        private System.Windows.Forms.GroupBox transportBodyGroupBox;
        private System.Windows.Forms.ComboBox transportBodyComboBox;
        private System.Windows.Forms.GroupBox manufacturerGroupBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.GroupBox transportAssemblyGroupBox;
        private System.Windows.Forms.TextBox carAssemblyTextBox;
        private System.Windows.Forms.GroupBox transportNumberGroupBox;
        private System.Windows.Forms.TextBox transportNumberTextBox;
    }
}