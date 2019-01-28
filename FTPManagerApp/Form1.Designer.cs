namespace FTPManagerApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.tbnOds = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRen = new System.Windows.Forms.Button();
            this.tbRn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbF = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgV = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLog);
            this.groupBox1.Controls.Add(this.tbnOds);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbHost);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.tbN);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(494, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logowanie";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(325, 53);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(152, 28);
            this.btnLog.TabIndex = 26;
            this.btnLog.Text = "Zaloguj i przejdź";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.login);
            // 
            // tbnOds
            // 
            this.tbnOds.Location = new System.Drawing.Point(325, 16);
            this.tbnOds.Margin = new System.Windows.Forms.Padding(4);
            this.tbnOds.Name = "tbnOds";
            this.tbnOds.Size = new System.Drawing.Size(152, 28);
            this.tbnOds.TabIndex = 25;
            this.tbnOds.Text = "Odśwież";
            this.tbnOds.UseVisualStyleBackColor = true;
            this.tbnOds.Click += new System.EventHandler(this.ods);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa:";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(103, 87);
            this.tbHost.Margin = new System.Windows.Forms.Padding(4);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(374, 22);
            this.tbHost.TabIndex = 2;
            this.tbHost.Text = "ftp://mkwk019.cba.pl/";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(103, 55);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(136, 22);
            this.tbPass.TabIndex = 1;
            this.tbPass.Text = "GACftp123";
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(103, 23);
            this.tbN.Margin = new System.Windows.Forms.Padding(4);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(136, 22);
            this.tbN.TabIndex = 0;
            this.tbN.Text = "gacftp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.btnRen);
            this.groupBox2.Controls.Add(this.tbRn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbRp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbF);
            this.groupBox2.Location = new System.Drawing.Point(14, 149);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(493, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Akcje";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(339, 70);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(137, 28);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Stwórz";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreateF);
            // 
            // btnRen
            // 
            this.btnRen.Location = new System.Drawing.Point(339, 32);
            this.btnRen.Margin = new System.Windows.Forms.Padding(4);
            this.btnRen.Name = "btnRen";
            this.btnRen.Size = new System.Drawing.Size(137, 28);
            this.btnRen.TabIndex = 22;
            this.btnRen.Text = "Zmień nazwę";
            this.btnRen.UseVisualStyleBackColor = true;
            this.btnRen.Click += new System.EventHandler(this.rename);
            // 
            // tbRn
            // 
            this.tbRn.Location = new System.Drawing.Point(205, 34);
            this.tbRn.Margin = new System.Windows.Forms.Padding(4);
            this.tbRn.Name = "tbRn";
            this.tbRn.Size = new System.Drawing.Size(126, 22);
            this.tbRn.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nowa:";
            // 
            // tbRp
            // 
            this.tbRp.Location = new System.Drawing.Point(72, 34);
            this.tbRp.Margin = new System.Windows.Forms.Padding(4);
            this.tbRp.Name = "tbRp";
            this.tbRp.Size = new System.Drawing.Size(125, 22);
            this.tbRp.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stwórz folder:";
            // 
            // tbF
            // 
            this.tbF.Location = new System.Drawing.Point(111, 73);
            this.tbF.Margin = new System.Windows.Forms.Padding(4);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(220, 22);
            this.tbF.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgV);
            this.groupBox3.Location = new System.Drawing.Point(14, 277);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(493, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pliki";
            // 
            // dgV
            // 
            this.dgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1});
            this.dgV.Location = new System.Drawing.Point(12, 23);
            this.dgV.Margin = new System.Windows.Forms.Padding(4);
            this.dgV.Name = "dgV";
            this.dgV.Size = new System.Drawing.Size(468, 439);
            this.dgV.TabIndex = 0;
            this.dgV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            this.Name1.Width = 400;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 574);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button tbnOds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRen;
        private System.Windows.Forms.TextBox tbRn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
    }
}

