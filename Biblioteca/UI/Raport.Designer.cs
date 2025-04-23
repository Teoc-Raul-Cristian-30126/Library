
namespace UI
{
    partial class Raport
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
            this.numericUpDownAnPublicareMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAnPublicareMax = new System.Windows.Forms.NumericUpDown();
            this.comboBoxEditura = new System.Windows.Forms.ComboBox();
            this.btnFiltru = new System.Windows.Forms.Button();
            this.dataGridViewFiltrare = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnPublicareMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnPublicareMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltrare)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAnPublicareMin
            // 
            this.numericUpDownAnPublicareMin.Location = new System.Drawing.Point(12, 30);
            this.numericUpDownAnPublicareMin.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numericUpDownAnPublicareMin.Name = "numericUpDownAnPublicareMin";
            this.numericUpDownAnPublicareMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAnPublicareMin.TabIndex = 0;
            this.numericUpDownAnPublicareMin.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericUpDownAnPublicareMax
            // 
            this.numericUpDownAnPublicareMax.Location = new System.Drawing.Point(175, 30);
            this.numericUpDownAnPublicareMax.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numericUpDownAnPublicareMax.Name = "numericUpDownAnPublicareMax";
            this.numericUpDownAnPublicareMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAnPublicareMax.TabIndex = 1;
            this.numericUpDownAnPublicareMax.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // comboBoxEditura
            // 
            this.comboBoxEditura.FormattingEnabled = true;
            this.comboBoxEditura.Location = new System.Drawing.Point(325, 29);
            this.comboBoxEditura.Name = "comboBoxEditura";
            this.comboBoxEditura.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEditura.TabIndex = 2;
            // 
            // btnFiltru
            // 
            this.btnFiltru.Location = new System.Drawing.Point(478, 27);
            this.btnFiltru.Name = "btnFiltru";
            this.btnFiltru.Size = new System.Drawing.Size(98, 23);
            this.btnFiltru.TabIndex = 3;
            this.btnFiltru.Text = "Filtreaza";
            this.btnFiltru.UseVisualStyleBackColor = true;
            this.btnFiltru.Click += new System.EventHandler(this.btnFiltru_Click);
            // 
            // dataGridViewFiltrare
            // 
            this.dataGridViewFiltrare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiltrare.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewFiltrare.Name = "dataGridViewFiltrare";
            this.dataGridViewFiltrare.Size = new System.Drawing.Size(564, 164);
            this.dataGridViewFiltrare.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "AnPublicareMin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "AnPublicareMax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Editura";
            // 
            // Raport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 248);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFiltrare);
            this.Controls.Add(this.btnFiltru);
            this.Controls.Add(this.comboBoxEditura);
            this.Controls.Add(this.numericUpDownAnPublicareMax);
            this.Controls.Add(this.numericUpDownAnPublicareMin);
            this.Name = "Raport";
            this.Text = "Raport";
            this.Load += new System.EventHandler(this.Raport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnPublicareMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnPublicareMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltrare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAnPublicareMin;
        private System.Windows.Forms.NumericUpDown numericUpDownAnPublicareMax;
        private System.Windows.Forms.ComboBox comboBoxEditura;
        private System.Windows.Forms.Button btnFiltru;
        private System.Windows.Forms.DataGridView dataGridViewFiltrare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}