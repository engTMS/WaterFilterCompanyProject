namespace WaterFilterCoFormsApplication
{
    partial class FormMain
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage_customers = new System.Windows.Forms.TabPage();
            this.button_dataEntry = new System.Windows.Forms.Button();
            this.groupBox_customerData = new System.Windows.Forms.GroupBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.textBox_midName = new System.Windows.Forms.TextBox();
            this.label_midName = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_customerRecord = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPage_customers.SuspendLayout();
            this.groupBox_customerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlMain.Controls.Add(this.tabPage_customers);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.RightToLeftLayout = true;
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(690, 248);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage_customers
            // 
            this.tabPage_customers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage_customers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage_customers.Controls.Add(this.button_dataEntry);
            this.tabPage_customers.Controls.Add(this.groupBox_customerData);
            this.tabPage_customers.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tabPage_customers.Location = new System.Drawing.Point(4, 25);
            this.tabPage_customers.Name = "tabPage_customers";
            this.tabPage_customers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_customers.Size = new System.Drawing.Size(682, 219);
            this.tabPage_customers.TabIndex = 0;
            this.tabPage_customers.Text = " بيانات العملاء";
            this.tabPage_customers.UseVisualStyleBackColor = true;
            // 
            // button_dataEntry
            // 
            this.button_dataEntry.Location = new System.Drawing.Point(100, 181);
            this.button_dataEntry.Name = "button_dataEntry";
            this.button_dataEntry.Size = new System.Drawing.Size(75, 23);
            this.button_dataEntry.TabIndex = 1;
            this.button_dataEntry.Text = "تسجيل";
            this.button_dataEntry.UseVisualStyleBackColor = true;
            this.button_dataEntry.Click += new System.EventHandler(this.button_dataEntry_Click);
            // 
            // groupBox_customerData
            // 
            this.groupBox_customerData.Controls.Add(this.button_customerRecord);
            this.groupBox_customerData.Controls.Add(this.textBox_id);
            this.groupBox_customerData.Controls.Add(this.textBox_lastName);
            this.groupBox_customerData.Controls.Add(this.label_lastName);
            this.groupBox_customerData.Controls.Add(this.textBox_midName);
            this.groupBox_customerData.Controls.Add(this.label_midName);
            this.groupBox_customerData.Controls.Add(this.textBox_firstName);
            this.groupBox_customerData.Controls.Add(this.label_firstName);
            this.groupBox_customerData.Location = new System.Drawing.Point(1, 1);
            this.groupBox_customerData.Name = "groupBox_customerData";
            this.groupBox_customerData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox_customerData.Size = new System.Drawing.Size(679, 100);
            this.groupBox_customerData.TabIndex = 0;
            this.groupBox_customerData.TabStop = false;
            this.groupBox_customerData.Text = "تسجيل بيانات العميل";
            this.groupBox_customerData.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(6, 29);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_lastName.TabIndex = 3;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(133, 29);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(36, 13);
            this.label_lastName.TabIndex = 2;
            this.label_lastName.Text = "اللقب";
            // 
            // textBox_midName
            // 
            this.textBox_midName.Location = new System.Drawing.Point(218, 26);
            this.textBox_midName.Name = "textBox_midName";
            this.textBox_midName.Size = new System.Drawing.Size(100, 20);
            this.textBox_midName.TabIndex = 3;
            // 
            // label_midName
            // 
            this.label_midName.AutoSize = true;
            this.label_midName.Location = new System.Drawing.Point(337, 29);
            this.label_midName.Name = "label_midName";
            this.label_midName.Size = new System.Drawing.Size(81, 13);
            this.label_midName.TabIndex = 2;
            this.label_midName.Text = "الإسم الأوسط";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(439, 29);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_firstName.TabIndex = 1;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(566, 29);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(68, 13);
            this.label_firstName.TabIndex = 0;
            this.label_firstName.Text = "الإسم الأول";
            this.label_firstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(439, 65);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 4;
            // 
            // button_customerRecord
            // 
            this.button_customerRecord.Location = new System.Drawing.Point(182, 63);
            this.button_customerRecord.Name = "button_customerRecord";
            this.button_customerRecord.Size = new System.Drawing.Size(111, 31);
            this.button_customerRecord.TabIndex = 5;
            this.button_customerRecord.Text = "بيانات أخرى ...";
            this.button_customerRecord.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 261);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage_customers.ResumeLayout(false);
            this.groupBox_customerData.ResumeLayout(false);
            this.groupBox_customerData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage_customers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox_customerData;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.TextBox textBox_midName;
        private System.Windows.Forms.Label label_midName;
        private System.Windows.Forms.Button button_dataEntry;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_customerRecord;
    }
}