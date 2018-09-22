namespace WaterFilterCoFormsApplication
{
    partial class FormCustomerRecord
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
            this.comboBox_customer_id = new System.Windows.Forms.ComboBox();
            this.comboBox_customer_name = new System.Windows.Forms.ComboBox();
            this.comboBox_customer_address2 = new System.Windows.Forms.ComboBox();
            this.comboBox_customer_identity = new System.Windows.Forms.ComboBox();
            this.comboBox_customer_address_city = new System.Windows.Forms.ComboBox();
            this.comboBox_customer_phone = new System.Windows.Forms.ComboBox();
            this.comboBox_customer_address1 = new System.Windows.Forms.ComboBox();
            this.label_customer_id = new System.Windows.Forms.Label();
            this.label_customer_name = new System.Windows.Forms.Label();
            this.label_customer_identity = new System.Windows.Forms.Label();
            this.label_customer_phone = new System.Windows.Forms.Label();
            this.label_address1 = new System.Windows.Forms.Label();
            this.label_address2 = new System.Windows.Forms.Label();
            this.label_address_city = new System.Windows.Forms.Label();
            this.groupBox_customer_record = new System.Windows.Forms.GroupBox();
            this.customertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterCompanyDataSet = new WaterFilterCoFormsApplication.FilterCompanyDataSet();
            this.customer_tableTableAdapter = new WaterFilterCoFormsApplication.FilterCompanyDataSetTableAdapters.customer_tableTableAdapter();
            this.groupBox_customer_record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCompanyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_customer_id
            // 
            this.comboBox_customer_id.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_customer_id.FormattingEnabled = true;
            this.comboBox_customer_id.Location = new System.Drawing.Point(632, 21);
            this.comboBox_customer_id.Name = "comboBox_customer_id";
            this.comboBox_customer_id.Size = new System.Drawing.Size(125, 21);
            this.comboBox_customer_id.TabIndex = 0;
            // 
            // comboBox_customer_name
            // 
            this.comboBox_customer_name.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_customer_name.FormattingEnabled = true;
            this.comboBox_customer_name.Location = new System.Drawing.Point(22, 20);
            this.comboBox_customer_name.Name = "comboBox_customer_name";
            this.comboBox_customer_name.Size = new System.Drawing.Size(374, 21);
            this.comboBox_customer_name.TabIndex = 1;
            // 
            // comboBox_customer_address2
            // 
            this.comboBox_customer_address2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_customer_address2.FormattingEnabled = true;
            this.comboBox_customer_address2.Location = new System.Drawing.Point(252, 110);
            this.comboBox_customer_address2.Name = "comboBox_customer_address2";
            this.comboBox_customer_address2.Size = new System.Drawing.Size(186, 21);
            this.comboBox_customer_address2.TabIndex = 2;
            // 
            // comboBox_customer_identity
            // 
            this.comboBox_customer_identity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_customer_identity.FormattingEnabled = true;
            this.comboBox_customer_identity.Location = new System.Drawing.Point(435, 64);
            this.comboBox_customer_identity.Name = "comboBox_customer_identity";
            this.comboBox_customer_identity.Size = new System.Drawing.Size(287, 21);
            this.comboBox_customer_identity.TabIndex = 3;
            // 
            // comboBox_customer_address_city
            // 
            this.comboBox_customer_address_city.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_customer_address_city.FormattingEnabled = true;
            this.comboBox_customer_address_city.Location = new System.Drawing.Point(7, 110);
            this.comboBox_customer_address_city.Name = "comboBox_customer_address_city";
            this.comboBox_customer_address_city.Size = new System.Drawing.Size(175, 21);
            this.comboBox_customer_address_city.TabIndex = 4;
            // 
            // comboBox_customer_phone
            // 
            this.comboBox_customer_phone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_customer_phone.FormattingEnabled = true;
            this.comboBox_customer_phone.Location = new System.Drawing.Point(12, 64);
            this.comboBox_customer_phone.Name = "comboBox_customer_phone";
            this.comboBox_customer_phone.Size = new System.Drawing.Size(250, 21);
            this.comboBox_customer_phone.TabIndex = 5;
            // 
            // comboBox_customer_address1
            // 
            this.comboBox_customer_address1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_customer_address1.FormattingEnabled = true;
            this.comboBox_customer_address1.Location = new System.Drawing.Point(514, 110);
            this.comboBox_customer_address1.Name = "comboBox_customer_address1";
            this.comboBox_customer_address1.Size = new System.Drawing.Size(259, 21);
            this.comboBox_customer_address1.TabIndex = 7;
            // 
            // label_customer_id
            // 
            this.label_customer_id.AutoSize = true;
            this.label_customer_id.Location = new System.Drawing.Point(770, 23);
            this.label_customer_id.Name = "label_customer_id";
            this.label_customer_id.Size = new System.Drawing.Size(53, 13);
            this.label_customer_id.TabIndex = 9;
            this.label_customer_id.Text = "مسلسل";
            this.label_customer_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_customer_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_customer_name
            // 
            this.label_customer_name.AutoSize = true;
            this.label_customer_name.Location = new System.Drawing.Point(456, 24);
            this.label_customer_name.Name = "label_customer_name";
            this.label_customer_name.Size = new System.Drawing.Size(68, 13);
            this.label_customer_name.TabIndex = 10;
            this.label_customer_name.Text = "إسم العميل";
            // 
            // label_customer_identity
            // 
            this.label_customer_identity.AutoSize = true;
            this.label_customer_identity.Location = new System.Drawing.Point(756, 68);
            this.label_customer_identity.Name = "label_customer_identity";
            this.label_customer_identity.Size = new System.Drawing.Size(67, 13);
            this.label_customer_identity.TabIndex = 11;
            this.label_customer_identity.Text = "رقم البطاقة";
            // 
            // label_customer_phone
            // 
            this.label_customer_phone.AutoSize = true;
            this.label_customer_phone.Location = new System.Drawing.Point(294, 68);
            this.label_customer_phone.Name = "label_customer_phone";
            this.label_customer_phone.Size = new System.Drawing.Size(41, 13);
            this.label_customer_phone.TabIndex = 12;
            this.label_customer_phone.Text = "الهاتف";
            // 
            // label_address1
            // 
            this.label_address1.AutoSize = true;
            this.label_address1.Location = new System.Drawing.Point(779, 114);
            this.label_address1.Name = "label_address1";
            this.label_address1.Size = new System.Drawing.Size(44, 13);
            this.label_address1.TabIndex = 13;
            this.label_address1.Text = "العنوان";
            // 
            // label_address2
            // 
            this.label_address2.AutoSize = true;
            this.label_address2.Location = new System.Drawing.Point(444, 114);
            this.label_address2.Name = "label_address2";
            this.label_address2.Size = new System.Drawing.Size(48, 13);
            this.label_address2.TabIndex = 14;
            this.label_address2.Text = "المنطقة";
            // 
            // label_address_city
            // 
            this.label_address_city.AutoSize = true;
            this.label_address_city.Location = new System.Drawing.Point(203, 114);
            this.label_address_city.Name = "label_address_city";
            this.label_address_city.Size = new System.Drawing.Size(43, 13);
            this.label_address_city.TabIndex = 15;
            this.label_address_city.Text = "المدينة";
            this.label_address_city.Click += new System.EventHandler(this.label_address_city_Click);
            // 
            // groupBox_customer_record
            // 
            this.groupBox_customer_record.Controls.Add(this.comboBox_customer_id);
            this.groupBox_customer_record.Controls.Add(this.label_customer_id);
            this.groupBox_customer_record.Controls.Add(this.label_address_city);
            this.groupBox_customer_record.Controls.Add(this.label_customer_name);
            this.groupBox_customer_record.Controls.Add(this.label_address2);
            this.groupBox_customer_record.Controls.Add(this.comboBox_customer_name);
            this.groupBox_customer_record.Controls.Add(this.label_address1);
            this.groupBox_customer_record.Controls.Add(this.comboBox_customer_identity);
            this.groupBox_customer_record.Controls.Add(this.label_customer_phone);
            this.groupBox_customer_record.Controls.Add(this.comboBox_customer_address1);
            this.groupBox_customer_record.Controls.Add(this.comboBox_customer_phone);
            this.groupBox_customer_record.Controls.Add(this.comboBox_customer_address_city);
            this.groupBox_customer_record.Controls.Add(this.label_customer_identity);
            this.groupBox_customer_record.Controls.Add(this.comboBox_customer_address2);
            this.groupBox_customer_record.Location = new System.Drawing.Point(12, 12);
            this.groupBox_customer_record.Name = "groupBox_customer_record";
            this.groupBox_customer_record.Size = new System.Drawing.Size(860, 180);
            this.groupBox_customer_record.TabIndex = 17;
            this.groupBox_customer_record.TabStop = false;
            this.groupBox_customer_record.Text = "تسجيل بيانات العميل";
            // 
            // customertableBindingSource
            // 
            this.customertableBindingSource.DataMember = "customer_table";
            this.customertableBindingSource.DataSource = this.filterCompanyDataSet;
            // 
            // filterCompanyDataSet
            // 
            this.filterCompanyDataSet.DataSetName = "FilterCompanyDataSet";
            this.filterCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_tableTableAdapter
            // 
            this.customer_tableTableAdapter.ClearBeforeFill = true;
            // 
            // FormCustomerRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(847, 437);
            this.Controls.Add(this.groupBox_customer_record);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FormCustomerRecord";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "بيانات العملاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCustomerRecord_Load);
            this.groupBox_customer_record.ResumeLayout(false);
            this.groupBox_customer_record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCompanyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_customer_id;
        private System.Windows.Forms.ComboBox comboBox_customer_name;
        private System.Windows.Forms.ComboBox comboBox_customer_address2;
        private System.Windows.Forms.ComboBox comboBox_customer_identity;
        private System.Windows.Forms.ComboBox comboBox_customer_address_city;
        private System.Windows.Forms.ComboBox comboBox_customer_phone;
        private System.Windows.Forms.ComboBox comboBox_customer_address1;
        private FilterCompanyDataSet filterCompanyDataSet;
        private System.Windows.Forms.BindingSource customertableBindingSource;
        private FilterCompanyDataSetTableAdapters.customer_tableTableAdapter customer_tableTableAdapter;
        private System.Windows.Forms.Label label_customer_id;
        private System.Windows.Forms.Label label_customer_name;
        private System.Windows.Forms.Label label_customer_identity;
        private System.Windows.Forms.Label label_customer_phone;
        private System.Windows.Forms.Label label_address1;
        private System.Windows.Forms.Label label_address2;
        private System.Windows.Forms.Label label_address_city;
        private System.Windows.Forms.GroupBox groupBox_customer_record;
    }
}