namespace DizionarioAlberato
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
            this.btnAggiungiParola = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAggiungiInglese = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAggiungiItaliano = new System.Windows.Forms.TextBox();
            this.tabDizionario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEliminaParola = new System.Windows.Forms.Button();
            this.lbxInglese = new System.Windows.Forms.ListBox();
            this.btnCercaItaliano = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCercaItaliano = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbxItaliano = new System.Windows.Forms.ListBox();
            this.btnCercaInglese = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCercaInglese = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnEliminaTraduzione = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabDizionario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAggiungiParola);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAggiungiInglese);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAggiungiItaliano);
            this.groupBox1.Location = new System.Drawing.Point(652, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aggiunta Parola";
            // 
            // btnAggiungiParola
            // 
            this.btnAggiungiParola.Location = new System.Drawing.Point(37, 143);
            this.btnAggiungiParola.Name = "btnAggiungiParola";
            this.btnAggiungiParola.Size = new System.Drawing.Size(143, 36);
            this.btnAggiungiParola.TabIndex = 4;
            this.btnAggiungiParola.Text = "Aggiungi Parola";
            this.btnAggiungiParola.UseVisualStyleBackColor = true;
            this.btnAggiungiParola.Click += new System.EventHandler(this.btnAggiungiParola_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Traduzione Inglese";
            // 
            // txtAggiungiInglese
            // 
            this.txtAggiungiInglese.Location = new System.Drawing.Point(37, 114);
            this.txtAggiungiInglese.Name = "txtAggiungiInglese";
            this.txtAggiungiInglese.Size = new System.Drawing.Size(143, 20);
            this.txtAggiungiInglese.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parola";
            // 
            // txtAggiungiItaliano
            // 
            this.txtAggiungiItaliano.Location = new System.Drawing.Point(37, 67);
            this.txtAggiungiItaliano.Name = "txtAggiungiItaliano";
            this.txtAggiungiItaliano.Size = new System.Drawing.Size(143, 20);
            this.txtAggiungiItaliano.TabIndex = 0;
            // 
            // tabDizionario
            // 
            this.tabDizionario.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabDizionario.Controls.Add(this.tabPage1);
            this.tabDizionario.Controls.Add(this.tabPage2);
            this.tabDizionario.Location = new System.Drawing.Point(13, 13);
            this.tabDizionario.Multiline = true;
            this.tabDizionario.Name = "tabDizionario";
            this.tabDizionario.SelectedIndex = 0;
            this.tabDizionario.Size = new System.Drawing.Size(633, 475);
            this.tabDizionario.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEliminaTraduzione);
            this.tabPage1.Controls.Add(this.btnEliminaParola);
            this.tabPage1.Controls.Add(this.lbxInglese);
            this.tabPage1.Controls.Add(this.btnCercaItaliano);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtCercaItaliano);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Italiano";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEliminaParola
            // 
            this.btnEliminaParola.Location = new System.Drawing.Point(27, 265);
            this.btnEliminaParola.Name = "btnEliminaParola";
            this.btnEliminaParola.Size = new System.Drawing.Size(143, 36);
            this.btnEliminaParola.TabIndex = 16;
            this.btnEliminaParola.Text = "Elimina Parola";
            this.btnEliminaParola.UseVisualStyleBackColor = true;
            this.btnEliminaParola.Click += new System.EventHandler(this.btnEliminaParola_Click);
            // 
            // lbxInglese
            // 
            this.lbxInglese.FormattingEnabled = true;
            this.lbxInglese.Location = new System.Drawing.Point(272, 111);
            this.lbxInglese.Name = "lbxInglese";
            this.lbxInglese.Size = new System.Drawing.Size(328, 251);
            this.lbxInglese.TabIndex = 15;
            // 
            // btnCercaItaliano
            // 
            this.btnCercaItaliano.Location = new System.Drawing.Point(27, 223);
            this.btnCercaItaliano.Name = "btnCercaItaliano";
            this.btnCercaItaliano.Size = new System.Drawing.Size(143, 36);
            this.btnCercaItaliano.TabIndex = 14;
            this.btnCercaItaliano.Text = "Cerca Parola";
            this.btnCercaItaliano.UseVisualStyleBackColor = true;
            this.btnCercaItaliano.Click += new System.EventHandler(this.btnCercaItaliano_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Traduzione";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Parola";
            // 
            // txtCercaItaliano
            // 
            this.txtCercaItaliano.Location = new System.Drawing.Point(27, 197);
            this.txtCercaItaliano.Name = "txtCercaItaliano";
            this.txtCercaItaliano.Size = new System.Drawing.Size(143, 20);
            this.txtCercaItaliano.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dizionario Italiano";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbxItaliano);
            this.tabPage2.Controls.Add(this.btnCercaInglese);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtCercaInglese);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inglese";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbxItaliano
            // 
            this.lbxItaliano.FormattingEnabled = true;
            this.lbxItaliano.Location = new System.Drawing.Point(272, 111);
            this.lbxItaliano.Name = "lbxItaliano";
            this.lbxItaliano.Size = new System.Drawing.Size(328, 251);
            this.lbxItaliano.TabIndex = 10;
            // 
            // btnCercaInglese
            // 
            this.btnCercaInglese.Location = new System.Drawing.Point(27, 223);
            this.btnCercaInglese.Name = "btnCercaInglese";
            this.btnCercaInglese.Size = new System.Drawing.Size(143, 36);
            this.btnCercaInglese.TabIndex = 9;
            this.btnCercaInglese.Text = "Cerca Parola";
            this.btnCercaInglese.UseVisualStyleBackColor = true;
            this.btnCercaInglese.Click += new System.EventHandler(this.btnCercaInglese_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Traduzione";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Parola";
            // 
            // txtCercaInglese
            // 
            this.txtCercaInglese.Location = new System.Drawing.Point(27, 197);
            this.txtCercaInglese.Name = "txtCercaInglese";
            this.txtCercaInglese.Size = new System.Drawing.Size(143, 20);
            this.txtCercaInglese.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dizionario Inglese";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.Location = new System.Drawing.Point(695, 245);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(131, 33);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Dizionario";
            this.lblParola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminaTraduzione
            // 
            this.btnEliminaTraduzione.Location = new System.Drawing.Point(27, 307);
            this.btnEliminaTraduzione.Name = "btnEliminaTraduzione";
            this.btnEliminaTraduzione.Size = new System.Drawing.Size(143, 36);
            this.btnEliminaTraduzione.TabIndex = 18;
            this.btnEliminaTraduzione.Text = "Elimina Traduzione";
            this.btnEliminaTraduzione.UseVisualStyleBackColor = true;
            this.btnEliminaTraduzione.Click += new System.EventHandler(this.btnEliminaTraduzione_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 500);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.tabDizionario);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dizionario Italiano";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabDizionario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAggiungiParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAggiungiInglese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAggiungiItaliano;
        private System.Windows.Forms.TabControl tabDizionario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxInglese;
        private System.Windows.Forms.Button btnCercaItaliano;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCercaItaliano;
        private System.Windows.Forms.ListBox lbxItaliano;
        private System.Windows.Forms.Button btnCercaInglese;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCercaInglese;
        private System.Windows.Forms.Button btnEliminaParola;
        private System.Windows.Forms.Button btnEliminaTraduzione;
    }
}