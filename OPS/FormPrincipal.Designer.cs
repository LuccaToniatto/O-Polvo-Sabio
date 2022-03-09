namespace WinFormsApp1
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lblOpcao1 = new System.Windows.Forms.Label();
            this.lblOu = new System.Windows.Forms.Label();
            this.lblOpcao2 = new System.Windows.Forms.Label();
            this.txtOpcao1 = new System.Windows.Forms.TextBox();
            this.txtOpcao2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnResposta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpcao1
            // 
            this.lblOpcao1.AutoSize = true;
            this.lblOpcao1.Location = new System.Drawing.Point(92, 351);
            this.lblOpcao1.Name = "lblOpcao1";
            this.lblOpcao1.Size = new System.Drawing.Size(51, 15);
            this.lblOpcao1.TabIndex = 0;
            this.lblOpcao1.Text = "Opção 1";
            // 
            // lblOu
            // 
            this.lblOu.AutoSize = true;
            this.lblOu.BackColor = System.Drawing.SystemColors.Control;
            this.lblOu.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOu.Location = new System.Drawing.Point(217, 359);
            this.lblOu.Name = "lblOu";
            this.lblOu.Size = new System.Drawing.Size(57, 40);
            this.lblOu.TabIndex = 1;
            this.lblOu.Text = "Ou";
            // 
            // lblOpcao2
            // 
            this.lblOpcao2.AutoSize = true;
            this.lblOpcao2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpcao2.Location = new System.Drawing.Point(347, 351);
            this.lblOpcao2.Name = "lblOpcao2";
            this.lblOpcao2.Size = new System.Drawing.Size(51, 15);
            this.lblOpcao2.TabIndex = 2;
            this.lblOpcao2.Text = "Opção 2";
            // 
            // txtOpcao1
            // 
            this.txtOpcao1.Location = new System.Drawing.Point(92, 376);
            this.txtOpcao1.Name = "txtOpcao1";
            this.txtOpcao1.Size = new System.Drawing.Size(100, 23);
            this.txtOpcao1.TabIndex = 3;
            // 
            // txtOpcao2
            // 
            this.txtOpcao2.Location = new System.Drawing.Point(298, 376);
            this.txtOpcao2.Name = "txtOpcao2";
            this.txtOpcao2.Size = new System.Drawing.Size(100, 23);
            this.txtOpcao2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(92, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 101);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(128, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 210);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnResposta
            // 
            this.btnResposta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResposta.Location = new System.Drawing.Point(181, 415);
            this.btnResposta.Name = "btnResposta";
            this.btnResposta.Size = new System.Drawing.Size(129, 23);
            this.btnResposta.TabIndex = 7;
            this.btnResposta.Text = "Ver a resposta";
            this.btnResposta.UseVisualStyleBackColor = true;
            this.btnResposta.Click += new System.EventHandler(this.btnResposta_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.btnResposta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOpcao2);
            this.Controls.Add(this.txtOpcao1);
            this.Controls.Add(this.lblOpcao2);
            this.Controls.Add(this.lblOu);
            this.Controls.Add(this.lblOpcao1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "O Polvo Sábio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOpcao1;
        private Label lblOu;
        private Label lblOpcao2;
        private TextBox txtOpcao1;
        private TextBox txtOpcao2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnResposta;
    }
}