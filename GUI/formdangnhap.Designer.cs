namespace FruitWorld
{
    partial class formdangnhap
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
            this.KeyPreview = true; 
            this.KeyDown += new KeyEventHandler(xacnhanbutton_enter);
            xacnhanbutton = new Button();
            SĐT = new TextBox();
            label1 = new Label();
            label2 = new Label();
            thanks = new Label();
            SuspendLayout();
            // 
            // xacnhanbutton
            // 
            xacnhanbutton.Location = new Point(224, 194);
            xacnhanbutton.Name = "xacnhanbutton";
            xacnhanbutton.Size = new Size(75, 23);
            xacnhanbutton.TabIndex = 2;
            xacnhanbutton.Text = "SUBMIT 👍";
            xacnhanbutton.UseVisualStyleBackColor = true;
            xacnhanbutton.Click += xacnhanbutton_Click;
            

            // 
            // SĐT
            // 
            SĐT.ForeColor = Color.MediumOrchid;
            SĐT.Location = new Point(134, 165);
            SĐT.Name = "SĐT";
            SĐT.Size = new Size(264, 23);
            SĐT.TabIndex = 1;
            SĐT.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(150, 125);
            label1.Name = "label1";
            label1.Size = new Size(239, 22);
            label1.TabIndex = 2;
            label1.Text = "Số điện thoại của quý khách";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 186);
            label2.Location = new Point(58, 9);
            label2.Name = "label2";
            label2.Size = new Size(425, 36);
            label2.TabIndex = 3;
            label2.Text = "Welcome to Fruit World of H-S";
            label2.Click += label2_Click;
            // 
            // thanks
            // 
            thanks.AutoSize = true;
            thanks.ForeColor = Color.DarkRed;
            thanks.Location = new Point(123, 267);
            thanks.Name = "thanks";
            thanks.Size = new Size(293, 15);
            thanks.TabIndex = 4;
            thanks.Text = "Cảm ơn quý khách đã sử dụng dịch vụ của chúng tôi !";
            thanks.Click += thanks_Click;
            // 
            // formdangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(534, 291);
            Controls.Add(thanks);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SĐT);
            Controls.Add(xacnhanbutton);
            Name = "formdangnhap";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button xacnhanbutton;
        private TextBox SĐT;
        private Label label1;
        private Label label2;
        private Label thanks;
    }
}
