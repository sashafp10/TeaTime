namespace TeaTime
{
    partial class frmMain
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
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.txtBy = new System.Windows.Forms.TextBox();
            this.lblMinutesEach = new System.Windows.Forms.Label();
            this.txtEach = new System.Windows.Forms.TextBox();
            this.lblMinutesBy = new System.Windows.Forms.Label();
            this.lblBy = new System.Windows.Forms.Label();
            this.lblEach = new System.Windows.Forms.Label();
            this.tmrBreak = new System.Windows.Forms.Timer(this.components);
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnResetOptions = new System.Windows.Forms.Button();
            this.btnCancelOptions = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlSmallProgress = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.pbSmall = new System.Windows.Forms.ProgressBar();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShowSmallGo = new System.Windows.Forms.TextBox();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tmrTicker = new System.Windows.Forms.Timer(this.components);
            this.pnlOptions.SuspendLayout();
            this.pnlSmallProgress.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 10000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // txtBy
            // 
            this.txtBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBy.Location = new System.Drawing.Point(53, 23);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(25, 13);
            this.txtBy.TabIndex = 5;
            // 
            // lblMinutesEach
            // 
            this.lblMinutesEach.AutoSize = true;
            this.lblMinutesEach.Location = new System.Drawing.Point(84, 3);
            this.lblMinutesEach.Name = "lblMinutesEach";
            this.lblMinutesEach.Size = new System.Drawing.Size(30, 13);
            this.lblMinutesEach.TabIndex = 4;
            this.lblMinutesEach.Text = "мин.";
            this.lblMinutesEach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.lblMinutesEach.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.lblMinutesEach.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // txtEach
            // 
            this.txtEach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEach.Location = new System.Drawing.Point(53, 3);
            this.txtEach.Name = "txtEach";
            this.txtEach.Size = new System.Drawing.Size(25, 13);
            this.txtEach.TabIndex = 3;
            // 
            // lblMinutesBy
            // 
            this.lblMinutesBy.AutoSize = true;
            this.lblMinutesBy.Location = new System.Drawing.Point(84, 23);
            this.lblMinutesBy.Name = "lblMinutesBy";
            this.lblMinutesBy.Size = new System.Drawing.Size(30, 13);
            this.lblMinutesBy.TabIndex = 2;
            this.lblMinutesBy.Text = "мин.";
            this.lblMinutesBy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.lblMinutesBy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.lblMinutesBy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Location = new System.Drawing.Point(3, 23);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(19, 13);
            this.lblBy.TabIndex = 1;
            this.lblBy.Text = "по";
            this.lblBy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.lblBy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.lblBy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // lblEach
            // 
            this.lblEach.AutoSize = true;
            this.lblEach.Location = new System.Drawing.Point(3, 3);
            this.lblEach.Name = "lblEach";
            this.lblEach.Size = new System.Drawing.Size(48, 13);
            this.lblEach.TabIndex = 0;
            this.lblEach.Text = "Каждые";
            this.lblEach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.lblEach.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.lblEach.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // tmrBreak
            // 
            this.tmrBreak.Interval = 10000;
            this.tmrBreak.Tick += new System.EventHandler(this.tmrBreak_Tick);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnResetOptions);
            this.pnlOptions.Controls.Add(this.btnCancelOptions);
            this.pnlOptions.Controls.Add(this.btnSave);
            this.pnlOptions.Controls.Add(this.lblEach);
            this.pnlOptions.Controls.Add(this.txtBy);
            this.pnlOptions.Controls.Add(this.lblMinutesBy);
            this.pnlOptions.Controls.Add(this.lblMinutesEach);
            this.pnlOptions.Controls.Add(this.lblBy);
            this.pnlOptions.Controls.Add(this.txtEach);
            this.pnlOptions.Location = new System.Drawing.Point(1, 1);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(120, 64);
            this.pnlOptions.TabIndex = 6;
            this.pnlOptions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.pnlOptions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.pnlOptions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // btnResetOptions
            // 
            this.btnResetOptions.BackColor = System.Drawing.Color.Red;
            this.btnResetOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetOptions.Location = new System.Drawing.Point(94, 39);
            this.btnResetOptions.Name = "btnResetOptions";
            this.btnResetOptions.Size = new System.Drawing.Size(20, 22);
            this.btnResetOptions.TabIndex = 8;
            this.btnResetOptions.Text = "R";
            this.btnResetOptions.UseVisualStyleBackColor = false;
            this.btnResetOptions.Click += new System.EventHandler(this.btnResetOptions_Click);
            // 
            // btnCancelOptions
            // 
            this.btnCancelOptions.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOptions.Location = new System.Drawing.Point(6, 39);
            this.btnCancelOptions.Name = "btnCancelOptions";
            this.btnCancelOptions.Size = new System.Drawing.Size(16, 22);
            this.btnCancelOptions.TabIndex = 7;
            this.btnCancelOptions.Text = "X";
            this.btnCancelOptions.UseVisualStyleBackColor = false;
            this.btnCancelOptions.Click += new System.EventHandler(this.btnCancelOptions_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(23, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 22);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlSmallProgress
            // 
            this.pnlSmallProgress.Controls.Add(this.btnOptions);
            this.pnlSmallProgress.Controls.Add(this.pbSmall);
            this.pnlSmallProgress.Location = new System.Drawing.Point(295, 105);
            this.pnlSmallProgress.Name = "pnlSmallProgress";
            this.pnlSmallProgress.Size = new System.Drawing.Size(123, 27);
            this.pnlSmallProgress.TabIndex = 7;
            this.pnlSmallProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.pnlSmallProgress.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.pnlSmallProgress.MouseLeave += new System.EventHandler(this.frmMain_MouseLeave);
            this.pnlSmallProgress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.pnlSmallProgress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // btnOptions
            // 
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Location = new System.Drawing.Point(101, 1);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(19, 25);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "O";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            this.btnOptions.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.btnOptions.MouseLeave += new System.EventHandler(this.frmMain_MouseLeave);
            // 
            // pbSmall
            // 
            this.pbSmall.Location = new System.Drawing.Point(2, 2);
            this.pbSmall.Maximum = 10;
            this.pbSmall.Name = "pbSmall";
            this.pbSmall.Size = new System.Drawing.Size(98, 23);
            this.pbSmall.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSmall.TabIndex = 0;
            this.pbSmall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.pbSmall.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.pbSmall.MouseLeave += new System.EventHandler(this.frmMain_MouseLeave);
            this.pbSmall.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.pbSmall.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtShowSmallGo);
            this.pnlMain.Controls.Add(this.pbMain);
            this.pnlMain.Controls.Add(this.lblMessage);
            this.pnlMain.Location = new System.Drawing.Point(7, 146);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(449, 246);
            this.pnlMain.TabIndex = 8;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.pnlMain.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.pnlMain.MouseLeave += new System.EventHandler(this.frmMain_MouseLeave);
            this.pnlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.pnlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Закройся";
            // 
            // txtShowSmallGo
            // 
            this.txtShowSmallGo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShowSmallGo.Location = new System.Drawing.Point(3, 223);
            this.txtShowSmallGo.Name = "txtShowSmallGo";
            this.txtShowSmallGo.Size = new System.Drawing.Size(442, 20);
            this.txtShowSmallGo.TabIndex = 9;
            this.txtShowSmallGo.TextChanged += new System.EventHandler(this.txtShowSmallGo_TextChanged);
            // 
            // pbMain
            // 
            this.pbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMain.Location = new System.Drawing.Point(3, 68);
            this.pbMain.Maximum = 10;
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(442, 149);
            this.pbMain.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbMain.TabIndex = 1;
            this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.pbMain.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.pbMain.MouseLeave += new System.EventHandler(this.frmMain_MouseLeave);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Comic Sans MS", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.Location = new System.Drawing.Point(136, 8);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(164, 44);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Перерыв!";
            this.lblMessage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.lblMessage.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.lblMessage.MouseLeave += new System.EventHandler(this.frmMain_MouseLeave);
            this.lblMessage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.lblMessage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // tmrTicker
            // 
            this.tmrTicker.Tick += new System.EventHandler(this.tmrTicker_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 404);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSmallProgress);
            this.Controls.Add(this.pnlOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TeaTime";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.frmMain_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlSmallProgress.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Timer tmrBreak;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Label lblEach;
        private System.Windows.Forms.TextBox txtBy;
        private System.Windows.Forms.Label lblMinutesEach;
        private System.Windows.Forms.TextBox txtEach;
        private System.Windows.Forms.Label lblMinutesBy;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlSmallProgress;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.ProgressBar pbSmall;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.Timer tmrTicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelOptions;
        private System.Windows.Forms.Button btnResetOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShowSmallGo;
    }
}

