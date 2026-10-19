namespace Airline_Ticket
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtPassengerAge = new System.Windows.Forms.TextBox();
            this.txtNumberOfTicket = new System.Windows.Forms.TextBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoFirstClass = new System.Windows.Forms.RadioButton();
            this.rdoNormalClass = new System.Windows.Forms.RadioButton();
            this.rdoBusinessClass = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.chkTravelInsurance = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstBooking = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passenger Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passenger Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of ticket";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Baggage Weight(kg)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(208, 61);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(137, 26);
            this.txtPassengerName.TabIndex = 5;
            // 
            // txtPassengerAge
            // 
            this.txtPassengerAge.Location = new System.Drawing.Point(208, 103);
            this.txtPassengerAge.Name = "txtPassengerAge";
            this.txtPassengerAge.Size = new System.Drawing.Size(137, 26);
            this.txtPassengerAge.TabIndex = 6;
            // 
            // txtNumberOfTicket
            // 
            this.txtNumberOfTicket.Location = new System.Drawing.Point(208, 144);
            this.txtNumberOfTicket.Name = "txtNumberOfTicket";
            this.txtNumberOfTicket.Size = new System.Drawing.Size(137, 26);
            this.txtNumberOfTicket.TabIndex = 7;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Location = new System.Drawing.Point(208, 187);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(137, 26);
            this.txtBaggageWeight.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Travel Class";
            // 
            // rdoFirstClass
            // 
            this.rdoFirstClass.AutoSize = true;
            this.rdoFirstClass.Location = new System.Drawing.Point(16, 280);
            this.rdoFirstClass.Name = "rdoFirstClass";
            this.rdoFirstClass.Size = new System.Drawing.Size(108, 24);
            this.rdoFirstClass.TabIndex = 10;
            this.rdoFirstClass.TabStop = true;
            this.rdoFirstClass.Text = "First Class";
            this.rdoFirstClass.UseVisualStyleBackColor = true;
            // 
            // rdoNormalClass
            // 
            this.rdoNormalClass.AutoSize = true;
            this.rdoNormalClass.Location = new System.Drawing.Point(187, 280);
            this.rdoNormalClass.Name = "rdoNormalClass";
            this.rdoNormalClass.Size = new System.Drawing.Size(127, 24);
            this.rdoNormalClass.TabIndex = 11;
            this.rdoNormalClass.TabStop = true;
            this.rdoNormalClass.Text = "Normal Class";
            this.rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // rdoBusinessClass
            // 
            this.rdoBusinessClass.AutoSize = true;
            this.rdoBusinessClass.Location = new System.Drawing.Point(380, 280);
            this.rdoBusinessClass.Name = "rdoBusinessClass";
            this.rdoBusinessClass.Size = new System.Drawing.Size(142, 24);
            this.rdoBusinessClass.TabIndex = 12;
            this.rdoBusinessClass.TabStop = true;
            this.rdoBusinessClass.Text = "Business Class";
            this.rdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adition option";
            // 
            // chkTravelInsurance
            // 
            this.chkTravelInsurance.AutoSize = true;
            this.chkTravelInsurance.Location = new System.Drawing.Point(3, 358);
            this.chkTravelInsurance.Name = "chkTravelInsurance";
            this.chkTravelInsurance.Size = new System.Drawing.Size(275, 24);
            this.chkTravelInsurance.TabIndex = 14;
            this.chkTravelInsurance.Text = "Add Travel insurance ($ per ticket)";
            this.chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(29, 404);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(105, 34);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(334, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstBooking
            // 
            this.lstBooking.FormattingEnabled = true;
            this.lstBooking.ItemHeight = 20;
            this.lstBooking.Location = new System.Drawing.Point(561, 69);
            this.lstBooking.Name = "lstBooking";
            this.lstBooking.Size = new System.Drawing.Size(203, 344);
            this.lstBooking.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBooking);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkTravelInsurance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdoBusinessClass);
            this.Controls.Add(this.rdoNormalClass);
            this.Controls.Add(this.rdoFirstClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBaggageWeight);
            this.Controls.Add(this.txtNumberOfTicket);
            this.Controls.Add(this.txtPassengerAge);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Booking System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.TextBox txtPassengerAge;
        private System.Windows.Forms.TextBox txtNumberOfTicket;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoFirstClass;
        private System.Windows.Forms.RadioButton rdoNormalClass;
        private System.Windows.Forms.RadioButton rdoBusinessClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkTravelInsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstBooking;
    }
}

