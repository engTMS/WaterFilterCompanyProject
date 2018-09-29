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
            this.tabPage_contractInfo = new System.Windows.Forms.TabPage();
            this.groupBox_purchaseData = new System.Windows.Forms.GroupBox();
            this.label_price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label_quantity = new System.Windows.Forms.Label();
            this.textBox_equipType = new System.Windows.Forms.TextBox();
            this.label_equipType = new System.Windows.Forms.Label();
            this.button_dataEntry = new System.Windows.Forms.Button();
            this.groupBox_customerData = new System.Windows.Forms.GroupBox();
            this.label_address = new System.Windows.Forms.Label();
            this.button_customerRecord = new System.Windows.Forms.Button();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.label_phoneNumber = new System.Windows.Forms.Label();
            this.textBox_customerName = new System.Windows.Forms.TextBox();
            this.label_customerName = new System.Windows.Forms.Label();
            this.tabPage_operationOrder = new System.Windows.Forms.TabPage();
            this.groupBox_accountData = new System.Windows.Forms.GroupBox();
            this.label_downPayment = new System.Windows.Forms.Label();
            this.textBox_downPayment = new System.Windows.Forms.TextBox();
            this.textBox_totalPrice = new System.Windows.Forms.TextBox();
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.label_account = new System.Windows.Forms.Label();
            this.label_installment = new System.Windows.Forms.Label();
            this.textBox_installment = new System.Windows.Forms.TextBox();
            this.label_1stDate = new System.Windows.Forms.Label();
            this.textBox_1stDate = new System.Windows.Forms.TextBox();
            this.label_numofInstalls = new System.Windows.Forms.Label();
            this.textBox_numofInstalls = new System.Windows.Forms.TextBox();
            this.textBox_contractPayment = new System.Windows.Forms.TextBox();
            this.label_contractPayment = new System.Windows.Forms.Label();
            this.label_paymentType = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_contractCopy = new System.Windows.Forms.Button();
            this.radioButton_payAll = new System.Windows.Forms.RadioButton();
            this.radioButton_semiPayment = new System.Windows.Forms.RadioButton();
            this.radioButton_installment = new System.Windows.Forms.RadioButton();
            this.tabControlMain.SuspendLayout();
            this.tabPage_contractInfo.SuspendLayout();
            this.groupBox_purchaseData.SuspendLayout();
            this.groupBox_customerData.SuspendLayout();
            this.groupBox_accountData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlMain.Controls.Add(this.tabPage_contractInfo);
            this.tabControlMain.Controls.Add(this.tabPage_operationOrder);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.RightToLeftLayout = true;
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(791, 539);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage_contractInfo
            // 
            this.tabPage_contractInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage_contractInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage_contractInfo.Controls.Add(this.button_contractCopy);
            this.tabPage_contractInfo.Controls.Add(this.button_exit);
            this.tabPage_contractInfo.Controls.Add(this.groupBox_accountData);
            this.tabPage_contractInfo.Controls.Add(this.groupBox_purchaseData);
            this.tabPage_contractInfo.Controls.Add(this.button_dataEntry);
            this.tabPage_contractInfo.Controls.Add(this.groupBox_customerData);
            this.tabPage_contractInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tabPage_contractInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPage_contractInfo.Name = "tabPage_contractInfo";
            this.tabPage_contractInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_contractInfo.Size = new System.Drawing.Size(783, 510);
            this.tabPage_contractInfo.TabIndex = 0;
            this.tabPage_contractInfo.Text = " بيانات التعاقد";
            this.tabPage_contractInfo.UseVisualStyleBackColor = true;
            // 
            // groupBox_purchaseData
            // 
            this.groupBox_purchaseData.Controls.Add(this.label_price);
            this.groupBox_purchaseData.Controls.Add(this.button1);
            this.groupBox_purchaseData.Controls.Add(this.textBox_price);
            this.groupBox_purchaseData.Controls.Add(this.textBox_quantity);
            this.groupBox_purchaseData.Controls.Add(this.label_quantity);
            this.groupBox_purchaseData.Controls.Add(this.textBox_equipType);
            this.groupBox_purchaseData.Controls.Add(this.label_equipType);
            this.groupBox_purchaseData.Location = new System.Drawing.Point(1, 107);
            this.groupBox_purchaseData.Name = "groupBox_purchaseData";
            this.groupBox_purchaseData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox_purchaseData.Size = new System.Drawing.Size(778, 100);
            this.groupBox_purchaseData.TabIndex = 7;
            this.groupBox_purchaseData.TabStop = false;
            this.groupBox_purchaseData.Text = "بيانات الشراء";
            this.groupBox_purchaseData.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(431, 69);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(40, 13);
            this.label_price.TabIndex = 6;
            this.label_price.Text = "السعر";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "إضافة";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(301, 62);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(124, 20);
            this.textBox_price.TabIndex = 4;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(301, 29);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(124, 20);
            this.textBox_quantity.TabIndex = 3;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(431, 29);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(40, 13);
            this.label_quantity.TabIndex = 2;
            this.label_quantity.Text = "الكمية";
            // 
            // textBox_equipType
            // 
            this.textBox_equipType.Location = new System.Drawing.Point(491, 29);
            this.textBox_equipType.Name = "textBox_equipType";
            this.textBox_equipType.Size = new System.Drawing.Size(181, 20);
            this.textBox_equipType.TabIndex = 1;
            // 
            // label_equipType
            // 
            this.label_equipType.AutoSize = true;
            this.label_equipType.Location = new System.Drawing.Point(699, 29);
            this.label_equipType.Name = "label_equipType";
            this.label_equipType.Size = new System.Drawing.Size(59, 13);
            this.label_equipType.TabIndex = 0;
            this.label_equipType.Text = "نوع الجهاز";
            // 
            // button_dataEntry
            // 
            this.button_dataEntry.Location = new System.Drawing.Point(359, 440);
            this.button_dataEntry.Name = "button_dataEntry";
            this.button_dataEntry.Size = new System.Drawing.Size(105, 34);
            this.button_dataEntry.TabIndex = 1;
            this.button_dataEntry.Text = "تسجيل البيانات";
            this.button_dataEntry.UseVisualStyleBackColor = true;
            this.button_dataEntry.Click += new System.EventHandler(this.button_dataEntry_Click);
            // 
            // groupBox_customerData
            // 
            this.groupBox_customerData.Controls.Add(this.label_address);
            this.groupBox_customerData.Controls.Add(this.button_customerRecord);
            this.groupBox_customerData.Controls.Add(this.textBox_address);
            this.groupBox_customerData.Controls.Add(this.textBox_phoneNumber);
            this.groupBox_customerData.Controls.Add(this.label_phoneNumber);
            this.groupBox_customerData.Controls.Add(this.textBox_customerName);
            this.groupBox_customerData.Controls.Add(this.label_customerName);
            this.groupBox_customerData.Location = new System.Drawing.Point(1, 1);
            this.groupBox_customerData.Name = "groupBox_customerData";
            this.groupBox_customerData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox_customerData.Size = new System.Drawing.Size(778, 100);
            this.groupBox_customerData.TabIndex = 0;
            this.groupBox_customerData.TabStop = false;
            this.groupBox_customerData.Text = "تسجيل بيانات العميل";
            this.groupBox_customerData.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(699, 66);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(79, 13);
            this.label_address.TabIndex = 6;
            this.label_address.Text = "عنوان التركيب";
            // 
            // button_customerRecord
            // 
            this.button_customerRecord.Location = new System.Drawing.Point(6, 63);
            this.button_customerRecord.Name = "button_customerRecord";
            this.button_customerRecord.Size = new System.Drawing.Size(111, 31);
            this.button_customerRecord.TabIndex = 5;
            this.button_customerRecord.Text = "بيانات أخرى ...";
            this.button_customerRecord.UseVisualStyleBackColor = true;
            this.button_customerRecord.Click += new System.EventHandler(this.button_customerRecord_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(390, 63);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(282, 20);
            this.textBox_address.TabIndex = 4;
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(139, 27);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(154, 20);
            this.textBox_phoneNumber.TabIndex = 3;
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.Location = new System.Drawing.Point(299, 27);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(63, 13);
            this.label_phoneNumber.TabIndex = 2;
            this.label_phoneNumber.Text = "رقم الهاتف";
            // 
            // textBox_customerName
            // 
            this.textBox_customerName.Location = new System.Drawing.Point(390, 27);
            this.textBox_customerName.Name = "textBox_customerName";
            this.textBox_customerName.Size = new System.Drawing.Size(282, 20);
            this.textBox_customerName.TabIndex = 1;
            this.textBox_customerName.TextChanged += new System.EventHandler(this.textBox_firstName_TextChanged);
            // 
            // label_customerName
            // 
            this.label_customerName.AutoSize = true;
            this.label_customerName.Location = new System.Drawing.Point(699, 27);
            this.label_customerName.Name = "label_customerName";
            this.label_customerName.Size = new System.Drawing.Size(68, 13);
            this.label_customerName.TabIndex = 0;
            this.label_customerName.Text = "إسم العميل";
            this.label_customerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage_operationOrder
            // 
            this.tabPage_operationOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPage_operationOrder.Name = "tabPage_operationOrder";
            this.tabPage_operationOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_operationOrder.Size = new System.Drawing.Size(783, 510);
            this.tabPage_operationOrder.TabIndex = 1;
            this.tabPage_operationOrder.Text = "أمر شغل / صيانة";
            this.tabPage_operationOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox_accountData
            // 
            this.groupBox_accountData.Controls.Add(this.radioButton_installment);
            this.groupBox_accountData.Controls.Add(this.radioButton_semiPayment);
            this.groupBox_accountData.Controls.Add(this.radioButton_payAll);
            this.groupBox_accountData.Controls.Add(this.label_paymentType);
            this.groupBox_accountData.Controls.Add(this.label_1stDate);
            this.groupBox_accountData.Controls.Add(this.textBox_1stDate);
            this.groupBox_accountData.Controls.Add(this.label_numofInstalls);
            this.groupBox_accountData.Controls.Add(this.textBox_numofInstalls);
            this.groupBox_accountData.Controls.Add(this.textBox_contractPayment);
            this.groupBox_accountData.Controls.Add(this.label_contractPayment);
            this.groupBox_accountData.Controls.Add(this.label_installment);
            this.groupBox_accountData.Controls.Add(this.textBox_installment);
            this.groupBox_accountData.Controls.Add(this.label_downPayment);
            this.groupBox_accountData.Controls.Add(this.textBox_downPayment);
            this.groupBox_accountData.Controls.Add(this.textBox_totalPrice);
            this.groupBox_accountData.Controls.Add(this.label_totalPrice);
            this.groupBox_accountData.Controls.Add(this.textBox_account);
            this.groupBox_accountData.Controls.Add(this.label_account);
            this.groupBox_accountData.Location = new System.Drawing.Point(0, 214);
            this.groupBox_accountData.Name = "groupBox_accountData";
            this.groupBox_accountData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox_accountData.Size = new System.Drawing.Size(778, 169);
            this.groupBox_accountData.TabIndex = 8;
            this.groupBox_accountData.TabStop = false;
            this.groupBox_accountData.Text = "بيانات الحساب";
            this.groupBox_accountData.Enter += new System.EventHandler(this.groupBox_accountData_Enter);
            // 
            // label_downPayment
            // 
            this.label_downPayment.AutoSize = true;
            this.label_downPayment.Location = new System.Drawing.Point(426, 68);
            this.label_downPayment.Name = "label_downPayment";
            this.label_downPayment.Size = new System.Drawing.Size(41, 13);
            this.label_downPayment.TabIndex = 6;
            this.label_downPayment.Text = "المقدم";
            // 
            // textBox_downPayment
            // 
            this.textBox_downPayment.Location = new System.Drawing.Point(296, 61);
            this.textBox_downPayment.Name = "textBox_downPayment";
            this.textBox_downPayment.Size = new System.Drawing.Size(124, 20);
            this.textBox_downPayment.TabIndex = 4;
            // 
            // textBox_totalPrice
            // 
            this.textBox_totalPrice.Location = new System.Drawing.Point(296, 28);
            this.textBox_totalPrice.Name = "textBox_totalPrice";
            this.textBox_totalPrice.Size = new System.Drawing.Size(124, 20);
            this.textBox_totalPrice.TabIndex = 3;
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Location = new System.Drawing.Point(426, 28);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(83, 13);
            this.label_totalPrice.TabIndex = 2;
            this.label_totalPrice.Text = "إجمالي السعر";
            // 
            // textBox_account
            // 
            this.textBox_account.Location = new System.Drawing.Point(515, 28);
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.Size = new System.Drawing.Size(152, 20);
            this.textBox_account.TabIndex = 1;
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.Location = new System.Drawing.Point(694, 28);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(65, 13);
            this.label_account.TabIndex = 0;
            this.label_account.Text = "إلى حساب";
            // 
            // label_installment
            // 
            this.label_installment.AutoSize = true;
            this.label_installment.Location = new System.Drawing.Point(426, 105);
            this.label_installment.Name = "label_installment";
            this.label_installment.Size = new System.Drawing.Size(70, 13);
            this.label_installment.TabIndex = 8;
            this.label_installment.Text = "قيمة القسط";
            // 
            // textBox_installment
            // 
            this.textBox_installment.Location = new System.Drawing.Point(296, 98);
            this.textBox_installment.Name = "textBox_installment";
            this.textBox_installment.Size = new System.Drawing.Size(124, 20);
            this.textBox_installment.TabIndex = 7;
            // 
            // label_1stDate
            // 
            this.label_1stDate.AutoSize = true;
            this.label_1stDate.Location = new System.Drawing.Point(184, 105);
            this.label_1stDate.Name = "label_1stDate";
            this.label_1stDate.Size = new System.Drawing.Size(85, 13);
            this.label_1stDate.TabIndex = 14;
            this.label_1stDate.Text = "تاريخ أول قسط";
            // 
            // textBox_1stDate
            // 
            this.textBox_1stDate.Location = new System.Drawing.Point(54, 98);
            this.textBox_1stDate.Name = "textBox_1stDate";
            this.textBox_1stDate.Size = new System.Drawing.Size(124, 20);
            this.textBox_1stDate.TabIndex = 13;
            // 
            // label_numofInstalls
            // 
            this.label_numofInstalls.AutoSize = true;
            this.label_numofInstalls.Location = new System.Drawing.Point(184, 68);
            this.label_numofInstalls.Name = "label_numofInstalls";
            this.label_numofInstalls.Size = new System.Drawing.Size(73, 13);
            this.label_numofInstalls.TabIndex = 12;
            this.label_numofInstalls.Text = "عدد الأقساط";
            // 
            // textBox_numofInstalls
            // 
            this.textBox_numofInstalls.Location = new System.Drawing.Point(54, 61);
            this.textBox_numofInstalls.Name = "textBox_numofInstalls";
            this.textBox_numofInstalls.Size = new System.Drawing.Size(124, 20);
            this.textBox_numofInstalls.TabIndex = 11;
            // 
            // textBox_contractPayment
            // 
            this.textBox_contractPayment.Location = new System.Drawing.Point(54, 28);
            this.textBox_contractPayment.Name = "textBox_contractPayment";
            this.textBox_contractPayment.Size = new System.Drawing.Size(124, 20);
            this.textBox_contractPayment.TabIndex = 10;
            // 
            // label_contractPayment
            // 
            this.label_contractPayment.AutoSize = true;
            this.label_contractPayment.Location = new System.Drawing.Point(184, 28);
            this.label_contractPayment.Name = "label_contractPayment";
            this.label_contractPayment.Size = new System.Drawing.Size(61, 13);
            this.label_contractPayment.TabIndex = 9;
            this.label_contractPayment.Text = "دفعة تعاقد";
            // 
            // label_paymentType
            // 
            this.label_paymentType.AutoSize = true;
            this.label_paymentType.Location = new System.Drawing.Point(673, 69);
            this.label_paymentType.Name = "label_paymentType";
            this.label_paymentType.Size = new System.Drawing.Size(66, 13);
            this.label_paymentType.TabIndex = 16;
            this.label_paymentType.Text = "نوع التعامل";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(547, 440);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(105, 34);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "خروج";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_contractCopy
            // 
            this.button_contractCopy.Location = new System.Drawing.Point(161, 440);
            this.button_contractCopy.Name = "button_contractCopy";
            this.button_contractCopy.Size = new System.Drawing.Size(105, 34);
            this.button_contractCopy.TabIndex = 10;
            this.button_contractCopy.Text = "صورة العقد";
            this.button_contractCopy.UseVisualStyleBackColor = true;
            // 
            // radioButton_payAll
            // 
            this.radioButton_payAll.AutoSize = true;
            this.radioButton_payAll.Location = new System.Drawing.Point(602, 69);
            this.radioButton_payAll.Name = "radioButton_payAll";
            this.radioButton_payAll.Size = new System.Drawing.Size(50, 17);
            this.radioButton_payAll.TabIndex = 17;
            this.radioButton_payAll.TabStop = true;
            this.radioButton_payAll.Text = "كاش";
            this.radioButton_payAll.UseVisualStyleBackColor = true;
            // 
            // radioButton_semiPayment
            // 
            this.radioButton_semiPayment.AutoSize = true;
            this.radioButton_semiPayment.Location = new System.Drawing.Point(549, 115);
            this.radioButton_semiPayment.Name = "radioButton_semiPayment";
            this.radioButton_semiPayment.Size = new System.Drawing.Size(103, 17);
            this.radioButton_semiPayment.TabIndex = 18;
            this.radioButton_semiPayment.TabStop = true;
            this.radioButton_semiPayment.Text = "دفعة تعاقد فقط";
            this.radioButton_semiPayment.UseVisualStyleBackColor = true;
            // 
            // radioButton_installment
            // 
            this.radioButton_installment.AutoSize = true;
            this.radioButton_installment.Location = new System.Drawing.Point(591, 92);
            this.radioButton_installment.Name = "radioButton_installment";
            this.radioButton_installment.Size = new System.Drawing.Size(61, 17);
            this.radioButton_installment.TabIndex = 19;
            this.radioButton_installment.TabStop = true;
            this.radioButton_installment.Text = "تقسيط";
            this.radioButton_installment.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 544);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage_contractInfo.ResumeLayout(false);
            this.groupBox_purchaseData.ResumeLayout(false);
            this.groupBox_purchaseData.PerformLayout();
            this.groupBox_customerData.ResumeLayout(false);
            this.groupBox_customerData.PerformLayout();
            this.groupBox_accountData.ResumeLayout(false);
            this.groupBox_accountData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage_contractInfo;
        private System.Windows.Forms.TabPage tabPage_operationOrder;
        private System.Windows.Forms.GroupBox groupBox_customerData;
        private System.Windows.Forms.TextBox textBox_customerName;
        private System.Windows.Forms.Label label_customerName;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.Label label_phoneNumber;
        private System.Windows.Forms.Button button_dataEntry;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Button button_customerRecord;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.GroupBox groupBox_purchaseData;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.TextBox textBox_equipType;
        private System.Windows.Forms.Label label_equipType;
        private System.Windows.Forms.GroupBox groupBox_accountData;
        private System.Windows.Forms.Label label_1stDate;
        private System.Windows.Forms.TextBox textBox_1stDate;
        private System.Windows.Forms.Label label_numofInstalls;
        private System.Windows.Forms.TextBox textBox_numofInstalls;
        private System.Windows.Forms.TextBox textBox_contractPayment;
        private System.Windows.Forms.Label label_contractPayment;
        private System.Windows.Forms.Label label_installment;
        private System.Windows.Forms.TextBox textBox_installment;
        private System.Windows.Forms.Label label_downPayment;
        private System.Windows.Forms.TextBox textBox_downPayment;
        private System.Windows.Forms.TextBox textBox_totalPrice;
        private System.Windows.Forms.Label label_totalPrice;
        private System.Windows.Forms.TextBox textBox_account;
        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.Label label_paymentType;
        private System.Windows.Forms.Button button_contractCopy;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.RadioButton radioButton_installment;
        private System.Windows.Forms.RadioButton radioButton_semiPayment;
        private System.Windows.Forms.RadioButton radioButton_payAll;
    }
}