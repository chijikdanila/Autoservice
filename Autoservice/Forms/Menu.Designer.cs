
namespace Autoservice
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewForCars = new System.Windows.Forms.DataGridView();
            this.isTruckComboBox = new System.Windows.Forms.ComboBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.carTypeTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.carAssemblyTextBox = new System.Windows.Forms.TextBox();
            this.carNumberTextBox = new System.Windows.Forms.TextBox();
            this.carStatusComboBox = new System.Windows.Forms.ComboBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.deleteCarButton = new System.Windows.Forms.Button();
            this.searchCarButton = new System.Windows.Forms.Button();
            this.putButton = new System.Windows.Forms.Button();
            this.mechanicTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForCars
            // 
            this.dataGridViewForCars.AllowUserToAddRows = false;
            this.dataGridViewForCars.AllowUserToDeleteRows = false;
            this.dataGridViewForCars.AllowUserToResizeColumns = false;
            this.dataGridViewForCars.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewForCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewForCars.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewForCars.Location = new System.Drawing.Point(51, 86);
            this.dataGridViewForCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewForCars.MultiSelect = false;
            this.dataGridViewForCars.Name = "dataGridViewForCars";
            this.dataGridViewForCars.RowHeadersWidth = 51;
            this.dataGridViewForCars.RowTemplate.Height = 24;
            this.dataGridViewForCars.Size = new System.Drawing.Size(1200, 700);
            this.dataGridViewForCars.TabIndex = 0;
            this.dataGridViewForCars.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewForCars_MouseDoubleClick);
            // 
            // isTruckComboBox
            // 
            this.isTruckComboBox.FormattingEnabled = true;
            this.isTruckComboBox.Items.AddRange(new object[] {
            "Truck",
            "Car"});
            this.isTruckComboBox.Location = new System.Drawing.Point(119, 38);
            this.isTruckComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isTruckComboBox.Name = "isTruckComboBox";
            this.isTruckComboBox.Size = new System.Drawing.Size(65, 24);
            this.isTruckComboBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(200, 39);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 22);
            this.modelTextBox.TabIndex = 3;
            // 
            // carTypeTextBox
            // 
            this.carTypeTextBox.Location = new System.Drawing.Point(332, 39);
            this.carTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carTypeTextBox.Name = "carTypeTextBox";
            this.carTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.carTypeTextBox.TabIndex = 4;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(479, 39);
            this.manufacturerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 22);
            this.manufacturerTextBox.TabIndex = 5;
            // 
            // carAssemblyTextBox
            // 
            this.carAssemblyTextBox.Location = new System.Drawing.Point(611, 39);
            this.carAssemblyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carAssemblyTextBox.Name = "carAssemblyTextBox";
            this.carAssemblyTextBox.Size = new System.Drawing.Size(86, 22);
            this.carAssemblyTextBox.TabIndex = 6;
            // 
            // carNumberTextBox
            // 
            this.carNumberTextBox.Location = new System.Drawing.Point(732, 39);
            this.carNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carNumberTextBox.Name = "carNumberTextBox";
            this.carNumberTextBox.Size = new System.Drawing.Size(113, 22);
            this.carNumberTextBox.TabIndex = 7;
            // 
            // carStatusComboBox
            // 
            this.carStatusComboBox.FormattingEnabled = true;
            this.carStatusComboBox.Items.AddRange(new object[] {
            "serviceable operated",
            "serviceable not exploited",
            "faulty being repaired",
            "defective cannot be repaired",
            "decommissioned"});
            this.carStatusComboBox.Location = new System.Drawing.Point(886, 39);
            this.carStatusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carStatusComboBox.Name = "carStatusComboBox";
            this.carStatusComboBox.Size = new System.Drawing.Size(164, 24);
            this.carStatusComboBox.TabIndex = 8;
            // 
            // addCarButton
            // 
            this.addCarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addCarButton.Location = new System.Drawing.Point(51, 793);
            this.addCarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(75, 48);
            this.addCarButton.TabIndex = 9;
            this.addCarButton.Text = "Add";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteCarButton.Location = new System.Drawing.Point(131, 793);
            this.deleteCarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(105, 48);
            this.deleteCarButton.TabIndex = 10;
            this.deleteCarButton.Text = "Delete";
            this.deleteCarButton.UseVisualStyleBackColor = true;
            this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click);
            // 
            // searchCarButton
            // 
            this.searchCarButton.BackgroundImage = global::Autoservice.Properties.Resources.залупа;
            this.searchCarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchCarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchCarButton.Location = new System.Drawing.Point(51, 33);
            this.searchCarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCarButton.Name = "searchCarButton";
            this.searchCarButton.Size = new System.Drawing.Size(40, 32);
            this.searchCarButton.TabIndex = 1;
            this.searchCarButton.UseVisualStyleBackColor = true;
            this.searchCarButton.Click += new System.EventHandler(this.searchCarButton_Click);
            // 
            // putButton
            // 
            this.putButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.putButton.Location = new System.Drawing.Point(243, 794);
            this.putButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(191, 46);
            this.putButton.TabIndex = 11;
            this.putButton.Text = "Put Into Operation";
            this.putButton.UseVisualStyleBackColor = true;
            this.putButton.Click += new System.EventHandler(this.putButton_Click);
            // 
            // mechanicTextBox
            // 
            this.mechanicTextBox.Location = new System.Drawing.Point(1127, 40);
            this.mechanicTextBox.Name = "mechanicTextBox";
            this.mechanicTextBox.Size = new System.Drawing.Size(100, 22);
            this.mechanicTextBox.TabIndex = 12;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1303, 853);
            this.Controls.Add(this.mechanicTextBox);
            this.Controls.Add(this.putButton);
            this.Controls.Add(this.deleteCarButton);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.carStatusComboBox);
            this.Controls.Add(this.carNumberTextBox);
            this.Controls.Add(this.carAssemblyTextBox);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(this.carTypeTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.isTruckComboBox);
            this.Controls.Add(this.searchCarButton);
            this.Controls.Add(this.dataGridViewForCars);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForCars;
        private System.Windows.Forms.Button searchCarButton;
        private System.Windows.Forms.ComboBox isTruckComboBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox carTypeTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox carAssemblyTextBox;
        private System.Windows.Forms.TextBox carNumberTextBox;
        private System.Windows.Forms.ComboBox carStatusComboBox;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button deleteCarButton;
        private System.Windows.Forms.Button putButton;
        private System.Windows.Forms.TextBox mechanicTextBox;
    }
}

