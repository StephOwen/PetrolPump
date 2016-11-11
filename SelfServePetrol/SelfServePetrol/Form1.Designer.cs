namespace SelfServePetrol
{
    partial class frmSelfServe
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPetrol = new System.Windows.Forms.Label();
            this.cboPetrol = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLitres = new System.Windows.Forms.Label();
            this.lblLtrs = new System.Windows.Forms.Label();
            this.lblPounds = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblFinished = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRLimit = new System.Windows.Forms.Button();
            this.btnRCard = new System.Windows.Forms.Button();
            this.btnRAll = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(344, 34);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(240, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Self Serve Petrol Pump";
            // 
            // lblPetrol
            // 
            this.lblPetrol.AutoSize = true;
            this.lblPetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetrol.Location = new System.Drawing.Point(58, 108);
            this.lblPetrol.Name = "lblPetrol";
            this.lblPetrol.Size = new System.Drawing.Size(219, 20);
            this.lblPetrol.TabIndex = 1;
            this.lblPetrol.Text = "Please select your petrol type:";
            // 
            // cboPetrol
            // 
            this.cboPetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPetrol.FormattingEnabled = true;
            this.cboPetrol.Items.AddRange(new object[] {
            "Diesel",
            "Unleaded"});
            this.cboPetrol.Location = new System.Drawing.Point(284, 106);
            this.cboPetrol.Name = "cboPetrol";
            this.cboPetrol.Size = new System.Drawing.Size(121, 28);
            this.cboPetrol.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(28, 155);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(249, 20);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Please enter the amount needed: ";
            // 
            // txtLimit
            // 
            this.txtLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimit.Location = new System.Drawing.Point(284, 154);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(121, 26);
            this.txtLimit.TabIndex = 4;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(58, 226);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(306, 20);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "Please enter the the following card details.";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.Location = new System.Drawing.Point(49, 273);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(105, 20);
            this.lblCard.TabIndex = 6;
            this.lblCard.Text = "Card number:";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExp.Location = new System.Drawing.Point(63, 317);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(91, 20);
            this.lblExp.TabIndex = 7;
            this.lblExp.Text = "Expiry date:";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNo.Location = new System.Drawing.Point(160, 270);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(204, 26);
            this.txtCardNo.TabIndex = 8;
            // 
            // txtExp
            // 
            this.txtExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExp.Location = new System.Drawing.Point(160, 315);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(121, 26);
            this.txtExp.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(160, 375);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 39);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLitres
            // 
            this.lblLitres.AutoSize = true;
            this.lblLitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitres.Location = new System.Drawing.Point(672, 125);
            this.lblLitres.Name = "lblLitres";
            this.lblLitres.Size = new System.Drawing.Size(55, 24);
            this.lblLitres.TabIndex = 11;
            this.lblLitres.Text = "00.00";
            // 
            // lblLtrs
            // 
            this.lblLtrs.AutoSize = true;
            this.lblLtrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLtrs.Location = new System.Drawing.Point(733, 131);
            this.lblLtrs.Name = "lblLtrs";
            this.lblLtrs.Size = new System.Drawing.Size(27, 17);
            this.lblLtrs.TabIndex = 12;
            this.lblLtrs.Text = "ltrs";
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPounds.Location = new System.Drawing.Point(653, 165);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(16, 17);
            this.lblPounds.TabIndex = 13;
            this.lblPounds.Text = "£";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimit.Location = new System.Drawing.Point(672, 161);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(20, 24);
            this.lblLimit.TabIndex = 14;
            this.lblLimit.Text = "0";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(656, 217);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(122, 39);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(656, 217);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(122, 39);
            this.btnContinue.TabIndex = 16;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(656, 273);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(122, 39);
            this.btnFinish.TabIndex = 17;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thank you for using the self serve petrol pump. ";
            this.label1.Visible = false;
            // 
            // lblFinished
            // 
            this.lblFinished.AutoSize = true;
            this.lblFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinished.Location = new System.Drawing.Point(541, 273);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(0, 20);
            this.lblFinished.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(684, 442);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 26);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(684, 400);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(162, 26);
            this.txtUser.TabIndex = 22;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(596, 445);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(591, 403);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(87, 20);
            this.lblUser.TabIndex = 20;
            this.lblUser.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(724, 500);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 39);
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRLimit
            // 
            this.btnRLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRLimit.Location = new System.Drawing.Point(32, 483);
            this.btnRLimit.Name = "btnRLimit";
            this.btnRLimit.Size = new System.Drawing.Size(122, 39);
            this.btnRLimit.TabIndex = 25;
            this.btnRLimit.Text = "Reset Limit";
            this.btnRLimit.UseVisualStyleBackColor = true;
            this.btnRLimit.Visible = false;
            this.btnRLimit.Click += new System.EventHandler(this.btnRLimit_Click);
            // 
            // btnRCard
            // 
            this.btnRCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRCard.Location = new System.Drawing.Point(179, 483);
            this.btnRCard.Name = "btnRCard";
            this.btnRCard.Size = new System.Drawing.Size(140, 39);
            this.btnRCard.TabIndex = 26;
            this.btnRCard.Text = "Reset Card Details";
            this.btnRCard.UseVisualStyleBackColor = true;
            this.btnRCard.Visible = false;
            this.btnRCard.Click += new System.EventHandler(this.btnRCard_Click);
            // 
            // btnRAll
            // 
            this.btnRAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAll.Location = new System.Drawing.Point(349, 483);
            this.btnRAll.Name = "btnRAll";
            this.btnRAll.Size = new System.Drawing.Size(122, 39);
            this.btnRAll.TabIndex = 27;
            this.btnRAll.Text = "Reset All";
            this.btnRAll.UseVisualStyleBackColor = true;
            this.btnRAll.Visible = false;
            this.btnRAll.Click += new System.EventHandler(this.btnRAll_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(796, 483);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 39);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmSelfServe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 551);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRAll);
            this.Controls.Add(this.btnRCard);
            this.Controls.Add(this.btnRLimit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblFinished);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblPounds);
            this.Controls.Add(this.lblLtrs);
            this.Controls.Add(this.lblLitres);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cboPetrol);
            this.Controls.Add(this.lblPetrol);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmSelfServe";
            this.Text = "Self Serve Petrol Pump";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPetrol;
        private System.Windows.Forms.ComboBox cboPetrol;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLitres;
        private System.Windows.Forms.Label lblLtrs;
        private System.Windows.Forms.Label lblPounds;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFinished;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRLimit;
        private System.Windows.Forms.Button btnRCard;
        private System.Windows.Forms.Button btnRAll;
        private System.Windows.Forms.Button btnLogout;
    }
}

