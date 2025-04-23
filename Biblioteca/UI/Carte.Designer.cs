
namespace UI
{
    partial class Carte
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
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.numericUpDownAn = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescriere = new System.Windows.Forms.TextBox();
            this.comboBoxEditura = new System.Windows.Forms.ComboBox();
            this.checkedListBoxAutor = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAn)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.Location = new System.Drawing.Point(110, 6);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(181, 20);
            this.textBoxTitlu.TabIndex = 0;
            // 
            // numericUpDownAn
            // 
            this.numericUpDownAn.Location = new System.Drawing.Point(110, 46);
            this.numericUpDownAn.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numericUpDownAn.Name = "numericUpDownAn";
            this.numericUpDownAn.Size = new System.Drawing.Size(181, 20);
            this.numericUpDownAn.TabIndex = 1;
            this.numericUpDownAn.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // textBoxDescriere
            // 
            this.textBoxDescriere.Location = new System.Drawing.Point(110, 87);
            this.textBoxDescriere.Name = "textBoxDescriere";
            this.textBoxDescriere.Size = new System.Drawing.Size(181, 20);
            this.textBoxDescriere.TabIndex = 2;
            // 
            // comboBoxEditura
            // 
            this.comboBoxEditura.FormattingEnabled = true;
            this.comboBoxEditura.Location = new System.Drawing.Point(110, 129);
            this.comboBoxEditura.Name = "comboBoxEditura";
            this.comboBoxEditura.Size = new System.Drawing.Size(181, 21);
            this.comboBoxEditura.TabIndex = 3;
            // 
            // checkedListBoxAutor
            // 
            this.checkedListBoxAutor.FormattingEnabled = true;
            this.checkedListBoxAutor.Location = new System.Drawing.Point(110, 179);
            this.checkedListBoxAutor.Name = "checkedListBoxAutor";
            this.checkedListBoxAutor.Size = new System.Drawing.Size(181, 109);
            this.checkedListBoxAutor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titlu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "AnPublicare:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descriere:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Editura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Autor/Autori:";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(12, 304);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(132, 45);
            this.btnSalveaza.TabIndex = 10;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(159, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 45);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Carte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxAutor);
            this.Controls.Add(this.comboBoxEditura);
            this.Controls.Add(this.textBoxDescriere);
            this.Controls.Add(this.numericUpDownAn);
            this.Controls.Add(this.textBoxTitlu);
            this.Name = "Carte";
            this.Text = "Carte";
            this.Load += new System.EventHandler(this.Carte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.NumericUpDown numericUpDownAn;
        private System.Windows.Forms.TextBox textBoxDescriere;
        private System.Windows.Forms.ComboBox comboBoxEditura;
        private System.Windows.Forms.CheckedListBox checkedListBoxAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnExit;
    }
}