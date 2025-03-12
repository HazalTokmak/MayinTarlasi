namespace Mayin_Tarlasi.UI
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
            btnYeniOyun = new Button();
            grpMayinlar = new GroupBox();
            SuspendLayout();
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Location = new Point(17, 12);
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.Size = new Size(105, 37);
            btnYeniOyun.TabIndex = 2;
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.UseVisualStyleBackColor = true;
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // grpMayinlar
            // 
            grpMayinlar.Location = new Point(17, 51);
            grpMayinlar.Name = "grpMayinlar";
            grpMayinlar.Size = new Size(885, 487);
            grpMayinlar.TabIndex = 3;
            grpMayinlar.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 550);
            Controls.Add(grpMayinlar);
            Controls.Add(btnYeniOyun);
            Name = "Form1";
            Text = "Mayın Tarlası";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYeniOyun;
        private GroupBox grpMayinlar;
    }
}
