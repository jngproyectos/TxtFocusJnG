namespace TxtFocus
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pTop = new System.Windows.Forms.Panel();
            this.btnCer = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.pSecond = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.pNom = new System.Windows.Forms.Panel();
            this.Ape = new System.Windows.Forms.TextBox();
            this.pApe = new System.Windows.Forms.Panel();
            this.Cor = new System.Windows.Forms.TextBox();
            this.pCor = new System.Windows.Forms.Panel();
            this.pContainer = new System.Windows.Forms.Panel();
            this.Dir = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Eda = new System.Windows.Forms.TextBox();
            this.pbEda = new System.Windows.Forms.PictureBox();
            this.pbTel = new System.Windows.Forms.PictureBox();
            this.pbDir = new System.Windows.Forms.PictureBox();
            this.pTop.SuspendLayout();
            this.pSecond.SuspendLayout();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDir)).BeginInit();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.pTop.Controls.Add(this.btnCer);
            this.pTop.Controls.Add(this.btnMax);
            this.pTop.Controls.Add(this.btnMin);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(800, 37);
            this.pTop.TabIndex = 3;
            // 
            // btnCer
            // 
            this.btnCer.FlatAppearance.BorderSize = 0;
            this.btnCer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.btnCer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.btnCer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCer.Image = global::TxtFocus.Properties.Resources.close;
            this.btnCer.Location = new System.Drawing.Point(749, 1);
            this.btnCer.Name = "btnCer";
            this.btnCer.Size = new System.Drawing.Size(50, 35);
            this.btnCer.TabIndex = 1;
            this.btnCer.UseVisualStyleBackColor = true;
            this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::TxtFocus.Properties.Resources.max;
            this.btnMax.Location = new System.Drawing.Point(699, 1);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 35);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::TxtFocus.Properties.Resources.min;
            this.btnMin.Location = new System.Drawing.Point(649, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 35);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // pSecond
            // 
            this.pSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.pSecond.Controls.Add(this.label1);
            this.pSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSecond.Location = new System.Drawing.Point(0, 37);
            this.pSecond.Name = "pSecond";
            this.pSecond.Size = new System.Drawing.Size(800, 50);
            this.pSecond.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "JnG - Proyectos - Cambiar borde TextBox Focus";
            // 
            // Nom
            // 
            this.Nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nom.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(19, 45);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(321, 22);
            this.Nom.TabIndex = 5;
            this.Nom.Enter += new System.EventHandler(this.txt_Enter1);
            this.Nom.Leave += new System.EventHandler(this.txt_Leave1);
            // 
            // pNom
            // 
            this.pNom.BackColor = System.Drawing.Color.DarkGray;
            this.pNom.Location = new System.Drawing.Point(19, 69);
            this.pNom.Name = "pNom";
            this.pNom.Size = new System.Drawing.Size(321, 3);
            this.pNom.TabIndex = 6;
            // 
            // Ape
            // 
            this.Ape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ape.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ape.Location = new System.Drawing.Point(19, 78);
            this.Ape.Name = "Ape";
            this.Ape.Size = new System.Drawing.Size(321, 22);
            this.Ape.TabIndex = 5;
            this.Ape.Enter += new System.EventHandler(this.txt_Enter1);
            this.Ape.Leave += new System.EventHandler(this.txt_Leave1);
            // 
            // pApe
            // 
            this.pApe.BackColor = System.Drawing.Color.DarkGray;
            this.pApe.Location = new System.Drawing.Point(19, 102);
            this.pApe.Name = "pApe";
            this.pApe.Size = new System.Drawing.Size(321, 3);
            this.pApe.TabIndex = 6;
            // 
            // Cor
            // 
            this.Cor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cor.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cor.Location = new System.Drawing.Point(19, 111);
            this.Cor.Name = "Cor";
            this.Cor.Size = new System.Drawing.Size(321, 22);
            this.Cor.TabIndex = 5;
            this.Cor.Enter += new System.EventHandler(this.txt_Enter1);
            this.Cor.Leave += new System.EventHandler(this.txt_Leave1);
            // 
            // pCor
            // 
            this.pCor.BackColor = System.Drawing.Color.DarkGray;
            this.pCor.Location = new System.Drawing.Point(19, 135);
            this.pCor.Name = "pCor";
            this.pCor.Size = new System.Drawing.Size(321, 3);
            this.pCor.TabIndex = 6;
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.Dir);
            this.pContainer.Controls.Add(this.pbDir);
            this.pContainer.Controls.Add(this.Tel);
            this.pContainer.Controls.Add(this.pbTel);
            this.pContainer.Controls.Add(this.Eda);
            this.pContainer.Controls.Add(this.pbEda);
            this.pContainer.Controls.Add(this.Nom);
            this.pContainer.Controls.Add(this.pCor);
            this.pContainer.Controls.Add(this.Ape);
            this.pContainer.Controls.Add(this.pApe);
            this.pContainer.Controls.Add(this.Cor);
            this.pContainer.Controls.Add(this.pNom);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 87);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(800, 313);
            this.pContainer.TabIndex = 7;
            // 
            // Dir
            // 
            this.Dir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dir.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dir.Location = new System.Drawing.Point(428, 153);
            this.Dir.Name = "Dir";
            this.Dir.Size = new System.Drawing.Size(321, 22);
            this.Dir.TabIndex = 5;
            this.Dir.Enter += new System.EventHandler(this.txt_Enter);
            this.Dir.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // Tel
            // 
            this.Tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel.Location = new System.Drawing.Point(429, 102);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(321, 22);
            this.Tel.TabIndex = 5;
            this.Tel.Enter += new System.EventHandler(this.txt_Enter);
            this.Tel.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // Eda
            // 
            this.Eda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Eda.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eda.Location = new System.Drawing.Point(429, 55);
            this.Eda.Name = "Eda";
            this.Eda.Size = new System.Drawing.Size(321, 22);
            this.Eda.TabIndex = 5;
            this.Eda.Enter += new System.EventHandler(this.txt_Enter);
            this.Eda.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // pbEda
            // 
            this.pbEda.BackColor = System.Drawing.Color.DarkGray;
            this.pbEda.Location = new System.Drawing.Point(426, 52);
            this.pbEda.Name = "pbEda";
            this.pbEda.Size = new System.Drawing.Size(327, 28);
            this.pbEda.TabIndex = 7;
            this.pbEda.TabStop = false;
            // 
            // pbTel
            // 
            this.pbTel.BackColor = System.Drawing.Color.DarkGray;
            this.pbTel.Location = new System.Drawing.Point(426, 99);
            this.pbTel.Name = "pbTel";
            this.pbTel.Size = new System.Drawing.Size(327, 28);
            this.pbTel.TabIndex = 8;
            this.pbTel.TabStop = false;
            // 
            // pbDir
            // 
            this.pbDir.BackColor = System.Drawing.Color.DarkGray;
            this.pbDir.Location = new System.Drawing.Point(425, 150);
            this.pbDir.Name = "pbDir";
            this.pbDir.Size = new System.Drawing.Size(327, 28);
            this.pbDir.TabIndex = 9;
            this.pbDir.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pSecond);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pTop.ResumeLayout(false);
            this.pSecond.ResumeLayout(false);
            this.pSecond.PerformLayout();
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Button btnCer;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel pSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Panel pNom;
        private System.Windows.Forms.TextBox Ape;
        private System.Windows.Forms.Panel pApe;
        private System.Windows.Forms.TextBox Cor;
        private System.Windows.Forms.Panel pCor;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.TextBox Dir;
        private System.Windows.Forms.PictureBox pbDir;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.PictureBox pbTel;
        private System.Windows.Forms.TextBox Eda;
        private System.Windows.Forms.PictureBox pbEda;
    }
}

