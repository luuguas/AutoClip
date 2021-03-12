
namespace AutoClip2
{
    partial class FrmAutoCloseMsg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutoCloseMsg));
            this.ImgInfo = new System.Windows.Forms.PictureBox();
            this.TmrClose = new System.Windows.Forms.Timer(this.components);
            this.LblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgInfo
            // 
            this.ImgInfo.Image = ((System.Drawing.Image)(resources.GetObject("ImgInfo.Image")));
            this.ImgInfo.ImageLocation = "";
            this.ImgInfo.Location = new System.Drawing.Point(12, 17);
            this.ImgInfo.Name = "ImgInfo";
            this.ImgInfo.Size = new System.Drawing.Size(32, 33);
            this.ImgInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgInfo.TabIndex = 3;
            this.ImgInfo.TabStop = false;
            // 
            // TmrClose
            // 
            this.TmrClose.Interval = 2000;
            // 
            // LblInfo
            // 
            this.LblInfo.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblInfo.Location = new System.Drawing.Point(57, 2);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(197, 62);
            this.LblInfo.TabIndex = 2;
            this.LblInfo.Text = "指定範囲の最後の値を貼り付けました。オートコピーを終了します。";
            this.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAutoCloseMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 67);
            this.Controls.Add(this.ImgInfo);
            this.Controls.Add(this.LblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutoCloseMsg";
            this.Text = "AutoClip - オートコピーの終了";
            ((System.ComponentModel.ISupportInitialize)(this.ImgInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox ImgInfo;
        internal System.Windows.Forms.Timer TmrClose;
        internal System.Windows.Forms.Label LblInfo;
    }
}