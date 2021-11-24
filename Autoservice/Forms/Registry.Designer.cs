
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
            this.Huy = new System.Windows.Forms.Label();
            this.transportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Huy
            // 
            this.Huy.AutoSize = true;
            this.Huy.ForeColor = System.Drawing.SystemColors.Control;
            this.Huy.Location = new System.Drawing.Point(565, 9);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(71, 17);
            this.Huy.TabIndex = 1;
            this.Huy.Text = "Input auto";
            // 
            // transportTypeComboBox
            // 
            this.transportTypeComboBox.FormattingEnabled = true;
            this.transportTypeComboBox.Items.AddRange(new object[] {
            "Грузовой",
            "Легковой"});
            this.transportTypeComboBox.Location = new System.Drawing.Point(540, 63);
            this.transportTypeComboBox.Name = "transportTypeComboBox";
            this.transportTypeComboBox.Size = new System.Drawing.Size(120, 24);
            this.transportTypeComboBox.TabIndex = 2;
            this.transportTypeComboBox.DropDownClosed += new System.EventHandler(this.transportTypeComboBox_DropDownClosed);
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.transportTypeComboBox);
            this.Controls.Add(this.Huy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Registry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Huy;
        private System.Windows.Forms.ComboBox transportTypeComboBox;
    }
}