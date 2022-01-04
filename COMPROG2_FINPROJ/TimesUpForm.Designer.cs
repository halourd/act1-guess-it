
namespace COMPROG2_FINPROJ_DRAWY
{
    partial class TimesUpForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_corrWord = new System.Windows.Forms.Label();
            this.button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nexa Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(404, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "The correct answer is: ";
            // 
            // lbl_corrWord
            // 
            this.lbl_corrWord.BackColor = System.Drawing.Color.Transparent;
            this.lbl_corrWord.Font = new System.Drawing.Font("Nexa Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_corrWord.ForeColor = System.Drawing.Color.Khaki;
            this.lbl_corrWord.Location = new System.Drawing.Point(370, 169);
            this.lbl_corrWord.Name = "lbl_corrWord";
            this.lbl_corrWord.Size = new System.Drawing.Size(357, 68);
            this.lbl_corrWord.TabIndex = 0;
            this.lbl_corrWord.Text = "Word";
            this.lbl_corrWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_woc1
            // 
            this.button_woc1.BorderColor = System.Drawing.Color.Lime;
            this.button_woc1.ButtonColor = System.Drawing.Color.Crimson;
            this.button_woc1.FlatAppearance.BorderSize = 0;
            this.button_woc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_woc1.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_woc1.Location = new System.Drawing.Point(290, 382);
            this.button_woc1.Name = "button_woc1";
            this.button_woc1.OnHoverBorderColor = System.Drawing.Color.Crimson;
            this.button_woc1.OnHoverButtonColor = System.Drawing.Color.Lime;
            this.button_woc1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_woc1.Size = new System.Drawing.Size(165, 66);
            this.button_woc1.TabIndex = 1;
            this.button_woc1.Text = "Continue";
            this.button_woc1.TextColor = System.Drawing.Color.Lime;
            this.button_woc1.UseVisualStyleBackColor = true;
            this.button_woc1.Click += new System.EventHandler(this.button_woc1_Click);
            this.button_woc1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_woc1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMPROG2_FINPROJ_DRAWY.Properties.Resources.TImesup;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TimesUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(728, 488);
            this.Controls.Add(this.button_woc1);
            this.Controls.Add(this.lbl_corrWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(728, 488);
            this.MinimumSize = new System.Drawing.Size(728, 488);
            this.Name = "TimesUpForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimesUpForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TimesUpForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimesUpForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_corrWord;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}