
namespace Autoservice.Forms
{
    partial class CarStatus
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
            this.currentStatusLabel = new System.Windows.Forms.Label();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.decommissionedRadioButton = new System.Windows.Forms.RadioButton();
            this.repairedRadioButton = new System.Windows.Forms.RadioButton();
            this.confirmButton = new System.Windows.Forms.Button();
            this.statusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carLabel.Location = new System.Drawing.Point(157, 23);
            this.carLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(45, 33);
            this.carLabel.TabIndex = 1;
            this.carLabel.Text = "Car";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.AutoSize = true;
            this.currentStatusLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentStatusLabel.Location = new System.Drawing.Point(157, 71);
            this.currentStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(73, 33);
            this.currentStatusLabel.TabIndex = 2;
            this.currentStatusLabel.Text = "Status";
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.decommissionedRadioButton);
            this.statusGroupBox.Controls.Add(this.repairedRadioButton);
            this.statusGroupBox.Location = new System.Drawing.Point(200, 143);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(273, 145);
            this.statusGroupBox.TabIndex = 3;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Status";
            // 
            // decommissionedRadioButton
            // 
            this.decommissionedRadioButton.AutoSize = true;
            this.decommissionedRadioButton.Location = new System.Drawing.Point(28, 92);
            this.decommissionedRadioButton.Name = "decommissionedRadioButton";
            this.decommissionedRadioButton.Size = new System.Drawing.Size(136, 21);
            this.decommissionedRadioButton.TabIndex = 5;
            this.decommissionedRadioButton.TabStop = true;
            this.decommissionedRadioButton.Text = "Decommissioned";
            this.decommissionedRadioButton.UseVisualStyleBackColor = true;
            this.decommissionedRadioButton.CheckedChanged += new System.EventHandler(this.StatusRadioButtons_CheckedChanged);
            // 
            // repairedRadioButton
            // 
            this.repairedRadioButton.AutoSize = true;
            this.repairedRadioButton.Location = new System.Drawing.Point(28, 37);
            this.repairedRadioButton.Name = "repairedRadioButton";
            this.repairedRadioButton.Size = new System.Drawing.Size(87, 21);
            this.repairedRadioButton.TabIndex = 4;
            this.repairedRadioButton.TabStop = true;
            this.repairedRadioButton.Text = "Repaired";
            this.repairedRadioButton.UseVisualStyleBackColor = true;
            this.repairedRadioButton.CheckedChanged += new System.EventHandler(this.StatusRadioButtons_CheckedChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(290, 326);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(92, 42);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Сonfirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // CarStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 406);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.currentStatusLabel);
            this.Controls.Add(this.carLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CarStatus";
            this.Text = "CarStatus";
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label currentStatusLabel;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.RadioButton decommissionedRadioButton;
        private System.Windows.Forms.RadioButton repairedRadioButton;
        private System.Windows.Forms.Button confirmButton;
    }
}