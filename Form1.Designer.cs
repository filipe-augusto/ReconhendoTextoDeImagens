namespace ReconhendoTextoDeImagens
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnLerImagem = new System.Windows.Forms.Button();
            this.txtLido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt
            // 
            this.txt.Enabled = false;
            this.txt.Location = new System.Drawing.Point(62, 61);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(651, 23);
            this.txt.TabIndex = 0;
            // 
            // btnLerImagem
            // 
            this.btnLerImagem.Location = new System.Drawing.Point(719, 57);
            this.btnLerImagem.Name = "btnLerImagem";
            this.btnLerImagem.Size = new System.Drawing.Size(191, 27);
            this.btnLerImagem.TabIndex = 1;
            this.btnLerImagem.Text = "Procurar imagem";
            this.btnLerImagem.UseVisualStyleBackColor = true;
            this.btnLerImagem.Click += new System.EventHandler(this.btnLerImagem_Click);
            // 
            // txtLido
            // 
            this.txtLido.Location = new System.Drawing.Point(62, 120);
            this.txtLido.Multiline = true;
            this.txtLido.Name = "txtLido";
            this.txtLido.Size = new System.Drawing.Size(651, 425);
            this.txtLido.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(719, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pegar texto da imagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(61, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(16, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Gerar modelo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(725, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 336);
            this.panel1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Validar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLido);
            this.Controls.Add(this.btnLerImagem);
            this.Controls.Add(this.txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pegando texto de imagens";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox txt;
        private Button btnLerImagem;
        private TextBox txtLido;
        private Button button1;
        private Label lblName;
        private Button button2;
        private Panel panel1;
        private Button button3;
    }
}