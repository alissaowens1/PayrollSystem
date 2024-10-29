namespace PayRoll
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_hourswork = new System.Windows.Forms.Label();
            this.lbl_Depend = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Hours = new System.Windows.Forms.TextBox();
            this.txt_Dependents = new System.Windows.Forms.TextBox();
            this.button_cal = new System.Windows.Forms.Button();
            this.buton_Reset = new System.Windows.Forms.Button();
            this.lbl_Gross = new System.Windows.Forms.Label();
            this.lbl_FedDed = new System.Windows.Forms.Label();
            this.lbl_Soc = new System.Windows.Forms.Label();
            this.lbl_Agency = new System.Windows.Forms.Label();
            this.lbl_Netpay = new System.Windows.Forms.Label();
            this.txt_Gross = new System.Windows.Forms.TextBox();
            this.txt_Fed = new System.Windows.Forms.TextBox();
            this.txt_Soc = new System.Windows.Forms.TextBox();
            this.txt_agency = new System.Windows.Forms.TextBox();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Title.Location = new System.Drawing.Point(292, 30);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(178, 30);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "XYZ JobSource";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_name.Location = new System.Drawing.Point(22, 132);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(69, 27);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_hourswork
            // 
            this.lbl_hourswork.AutoSize = true;
            this.lbl_hourswork.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hourswork.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_hourswork.Location = new System.Drawing.Point(22, 186);
            this.lbl_hourswork.Name = "lbl_hourswork";
            this.lbl_hourswork.Size = new System.Drawing.Size(220, 27);
            this.lbl_hourswork.TabIndex = 2;
            this.lbl_hourswork.Text = "No. Of Hours Worked";
            // 
            // lbl_Depend
            // 
            this.lbl_Depend.AutoSize = true;
            this.lbl_Depend.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Depend.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Depend.Location = new System.Drawing.Point(22, 258);
            this.lbl_Depend.Name = "lbl_Depend";
            this.lbl_Depend.Size = new System.Drawing.Size(192, 27);
            this.lbl_Depend.TabIndex = 3;
            this.lbl_Depend.Text = "No. of Dependents";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(273, 131);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(152, 31);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_Hours
            // 
            this.txt_Hours.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hours.Location = new System.Drawing.Point(274, 185);
            this.txt_Hours.Name = "txt_Hours";
            this.txt_Hours.Size = new System.Drawing.Size(152, 31);
            this.txt_Hours.TabIndex = 5;
            this.txt_Hours.Text = "0";
            this.txt_Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Dependents
            // 
            this.txt_Dependents.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dependents.Location = new System.Drawing.Point(274, 258);
            this.txt_Dependents.Name = "txt_Dependents";
            this.txt_Dependents.Size = new System.Drawing.Size(152, 31);
            this.txt_Dependents.TabIndex = 6;
            this.txt_Dependents.Text = "0";
            this.txt_Dependents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_cal
            // 
            this.button_cal.BackColor = System.Drawing.Color.SeaShell;
            this.button_cal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_cal.Location = new System.Drawing.Point(52, 372);
            this.button_cal.Name = "button_cal";
            this.button_cal.Size = new System.Drawing.Size(87, 33);
            this.button_cal.TabIndex = 7;
            this.button_cal.Text = "Calculate";
            this.button_cal.UseVisualStyleBackColor = false;
            this.button_cal.Click += new System.EventHandler(this.button_cal_Click);
            // 
            // buton_Reset
            // 
            this.buton_Reset.BackColor = System.Drawing.Color.SeaShell;
            this.buton_Reset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buton_Reset.Location = new System.Drawing.Point(308, 372);
            this.buton_Reset.Name = "buton_Reset";
            this.buton_Reset.Size = new System.Drawing.Size(87, 33);
            this.buton_Reset.TabIndex = 8;
            this.buton_Reset.Text = "Reset";
            this.buton_Reset.UseVisualStyleBackColor = false;
            // 
            // lbl_Gross
            // 
            this.lbl_Gross.AutoSize = true;
            this.lbl_Gross.Location = new System.Drawing.Point(514, 142);
            this.lbl_Gross.Name = "lbl_Gross";
            this.lbl_Gross.Size = new System.Drawing.Size(70, 16);
            this.lbl_Gross.TabIndex = 9;
            this.lbl_Gross.Text = "Gross Pay";
            // 
            // lbl_FedDed
            // 
            this.lbl_FedDed.AutoSize = true;
            this.lbl_FedDed.Location = new System.Drawing.Point(487, 185);
            this.lbl_FedDed.Name = "lbl_FedDed";
            this.lbl_FedDed.Size = new System.Drawing.Size(118, 16);
            this.lbl_FedDed.TabIndex = 10;
            this.lbl_FedDed.Text = "Federal Deduction";
            // 
            // lbl_Soc
            // 
            this.lbl_Soc.AutoSize = true;
            this.lbl_Soc.Location = new System.Drawing.Point(477, 224);
            this.lbl_Soc.Name = "lbl_Soc";
            this.lbl_Soc.Size = new System.Drawing.Size(128, 16);
            this.lbl_Soc.TabIndex = 11;
            this.lbl_Soc.Text = "Soc. Sec. Deduction";
            // 
            // lbl_Agency
            // 
            this.lbl_Agency.AutoSize = true;
            this.lbl_Agency.Location = new System.Drawing.Point(504, 272);
            this.lbl_Agency.Name = "lbl_Agency";
            this.lbl_Agency.Size = new System.Drawing.Size(80, 16);
            this.lbl_Agency.TabIndex = 12;
            this.lbl_Agency.Text = "Agency Fee";
            // 
            // lbl_Netpay
            // 
            this.lbl_Netpay.AutoSize = true;
            this.lbl_Netpay.Location = new System.Drawing.Point(517, 317);
            this.lbl_Netpay.Name = "lbl_Netpay";
            this.lbl_Netpay.Size = new System.Drawing.Size(55, 16);
            this.lbl_Netpay.TabIndex = 13;
            this.lbl_Netpay.Text = "Net Pay";
            // 
            // txt_Gross
            // 
            this.txt_Gross.Location = new System.Drawing.Point(612, 142);
            this.txt_Gross.Name = "txt_Gross";
            this.txt_Gross.Size = new System.Drawing.Size(100, 22);
            this.txt_Gross.TabIndex = 14;
            this.txt_Gross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Gross.Visible = false;
            // 
            // txt_Fed
            // 
            this.txt_Fed.Location = new System.Drawing.Point(612, 179);
            this.txt_Fed.Name = "txt_Fed";
            this.txt_Fed.Size = new System.Drawing.Size(100, 22);
            this.txt_Fed.TabIndex = 15;
            this.txt_Fed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Fed.Visible = false;
            // 
            // txt_Soc
            // 
            this.txt_Soc.Location = new System.Drawing.Point(612, 224);
            this.txt_Soc.Name = "txt_Soc";
            this.txt_Soc.Size = new System.Drawing.Size(100, 22);
            this.txt_Soc.TabIndex = 16;
            this.txt_Soc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Soc.Visible = false;
            // 
            // txt_agency
            // 
            this.txt_agency.Location = new System.Drawing.Point(612, 272);
            this.txt_agency.Name = "txt_agency";
            this.txt_agency.Size = new System.Drawing.Size(100, 22);
            this.txt_agency.TabIndex = 17;
            this.txt_agency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_agency.Visible = false;
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(612, 317);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(100, 22);
            this.txt_net.TabIndex = 18;
            this.txt_net.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_net.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_net);
            this.Controls.Add(this.txt_agency);
            this.Controls.Add(this.txt_Soc);
            this.Controls.Add(this.txt_Fed);
            this.Controls.Add(this.txt_Gross);
            this.Controls.Add(this.lbl_Netpay);
            this.Controls.Add(this.lbl_Agency);
            this.Controls.Add(this.lbl_Soc);
            this.Controls.Add(this.lbl_FedDed);
            this.Controls.Add(this.lbl_Gross);
            this.Controls.Add(this.buton_Reset);
            this.Controls.Add(this.button_cal);
            this.Controls.Add(this.txt_Dependents);
            this.Controls.Add(this.txt_Hours);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Depend);
            this.Controls.Add(this.lbl_hourswork);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_hourswork;
        private System.Windows.Forms.Label lbl_Depend;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Hours;
        private System.Windows.Forms.TextBox txt_Dependents;
        private System.Windows.Forms.Button button_cal;
        private System.Windows.Forms.Button buton_Reset;
        private System.Windows.Forms.Label lbl_Gross;
        private System.Windows.Forms.Label lbl_FedDed;
        private System.Windows.Forms.Label lbl_Soc;
        private System.Windows.Forms.Label lbl_Agency;
        private System.Windows.Forms.Label lbl_Netpay;
        private System.Windows.Forms.TextBox txt_Gross;
        private System.Windows.Forms.TextBox txt_Fed;
        private System.Windows.Forms.TextBox txt_Soc;
        private System.Windows.Forms.TextBox txt_agency;
        private System.Windows.Forms.TextBox txt_net;
    }
}

