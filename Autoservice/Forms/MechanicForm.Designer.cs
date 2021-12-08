
namespace Autoservice.Forms
{
    partial class MechanicForm
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
            this.dataGridViewForCars = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForCars
            // 
            this.dataGridViewForCars.AllowUserToResizeColumns = false;
            this.dataGridViewForCars.AllowUserToResizeRows = false;
            this.dataGridViewForCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForCars.Location = new System.Drawing.Point(49, 22);
            this.dataGridViewForCars.MultiSelect = false;
            this.dataGridViewForCars.Name = "dataGridViewForCars";
            this.dataGridViewForCars.RowHeadersWidth = 51;
            this.dataGridViewForCars.RowTemplate.Height = 24;
            this.dataGridViewForCars.Size = new System.Drawing.Size(1200, 460);
            this.dataGridViewForCars.TabIndex = 0;
            this.dataGridViewForCars.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewForCars_MouseDoubleClick);
            // 
            // MechanicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1303, 514);
            this.Controls.Add(this.dataGridViewForCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MechanicForm";
            this.Text = "MechanicMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MechanicForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForCars;
    }
}