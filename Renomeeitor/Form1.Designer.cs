namespace Renomeeitor
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
            button1 = new Button();
            listFiles = new ListBox();
            txtTexto2 = new TextBox();
            txtTexto1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnTrocar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 0;
            button1.Text = "Carregar Arquivos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listFiles
            // 
            listFiles.FormattingEnabled = true;
            listFiles.ItemHeight = 15;
            listFiles.Location = new Point(12, 41);
            listFiles.Name = "listFiles";
            listFiles.Size = new Size(710, 334);
            listFiles.TabIndex = 1;
            // 
            // txtTexto2
            // 
            txtTexto2.Location = new Point(136, 426);
            txtTexto2.Name = "txtTexto2";
            txtTexto2.Size = new Size(273, 23);
            txtTexto2.TabIndex = 2;
            // 
            // txtTexto1
            // 
            txtTexto1.Location = new Point(136, 381);
            txtTexto1.Name = "txtTexto1";
            txtTexto1.Size = new Size(273, 23);
            txtTexto1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 384);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Trocar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 429);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 5;
            label2.Text = "Por";
            // 
            // btnTrocar
            // 
            btnTrocar.Location = new Point(472, 384);
            btnTrocar.Name = "btnTrocar";
            btnTrocar.Size = new Size(89, 68);
            btnTrocar.TabIndex = 6;
            btnTrocar.Text = "Trocar";
            btnTrocar.UseVisualStyleBackColor = true;
            btnTrocar.Click += btnTrocar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(btnTrocar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTexto1);
            Controls.Add(txtTexto2);
            Controls.Add(listFiles);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Renomeeitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listFiles;
        private TextBox txtTexto2;
        private TextBox txtTexto1;
        private Label label1;
        private Label label2;
        private Button btnTrocar;
    }
}