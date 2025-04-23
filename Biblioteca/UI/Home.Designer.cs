
namespace UI
{
    partial class Home
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
            this.dataGridCarti = new System.Windows.Forms.DataGridView();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnListeaza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCarti
            // 
            this.dataGridCarti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarti.Location = new System.Drawing.Point(12, 12);
            this.dataGridCarti.Name = "dataGridCarti";
            this.dataGridCarti.Size = new System.Drawing.Size(661, 262);
            this.dataGridCarti.TabIndex = 0;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(12, 293);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(154, 41);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(181, 293);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(154, 41);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(350, 293);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(154, 41);
            this.btnSterge.TabIndex = 3;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnListeaza
            // 
            this.btnListeaza.Location = new System.Drawing.Point(519, 293);
            this.btnListeaza.Name = "btnListeaza";
            this.btnListeaza.Size = new System.Drawing.Size(154, 41);
            this.btnListeaza.TabIndex = 4;
            this.btnListeaza.Text = "Listeaza";
            this.btnListeaza.UseVisualStyleBackColor = true;
            this.btnListeaza.Click += new System.EventHandler(this.btnListeaza_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 346);
            this.Controls.Add(this.btnListeaza);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dataGridCarti);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCarti;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnListeaza;
    }
}

