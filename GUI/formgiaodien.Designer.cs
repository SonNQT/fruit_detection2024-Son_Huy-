namespace FruitWorld.GUI
{
    partial class formgiaodien
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
            label1 = new Label();
            labelChao = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 186);
            label1.Location = new Point(193, 9);
            label1.Name = "label1";
            label1.Size = new Size(425, 36);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Fruit World of H-S";
           
            // 
            // labelChao
            // 
            labelChao.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            labelChao.Location = new Point(50, 50);
            labelChao.Name = "labelChao";
            labelChao.Size = new Size(300, 30);
            labelChao.TabIndex = 0;
            // 
            // formgiaodien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(800, 450);
            Controls.Add(labelChao);
            Controls.Add(label1);
            Name = "formgiaodien";
            Text = "Giao diện chào đón";
            Load += formgiaodien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelChao;


    }
}