
namespace AutoClip2
{
    partial class FrmClip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClip));
            this.LblList = new System.Windows.Forms.Label();
            this.LblNext = new System.Windows.Forms.Label();
            this.LblBef = new System.Windows.Forms.Label();
            this.LblNow = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnBef = new System.Windows.Forms.Button();
            this.LblDiscription = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.LblMode = new System.Windows.Forms.Label();
            this.LblM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblList
            // 
            this.LblList.AutoSize = true;
            this.LblList.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.LblList.Location = new System.Drawing.Point(255, 8);
            this.LblList.Name = "LblList";
            this.LblList.Size = new System.Drawing.Size(38, 14);
            this.LblList.TabIndex = 118;
            this.LblList.Text = "xx/xx";
            // 
            // LblNext
            // 
            this.LblNext.AutoEllipsis = true;
            this.LblNext.BackColor = System.Drawing.SystemColors.Window;
            this.LblNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblNext.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblNext.Location = new System.Drawing.Point(105, 135);
            this.LblNext.Name = "LblNext";
            this.LblNext.Size = new System.Drawing.Size(201, 18);
            this.LblNext.TabIndex = 115;
            this.LblNext.Text = "０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９";
            this.LblNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblBef
            // 
            this.LblBef.AutoEllipsis = true;
            this.LblBef.BackColor = System.Drawing.SystemColors.Window;
            this.LblBef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBef.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblBef.Location = new System.Drawing.Point(105, 43);
            this.LblBef.Name = "LblBef";
            this.LblBef.Size = new System.Drawing.Size(201, 18);
            this.LblBef.TabIndex = 116;
            this.LblBef.Text = "０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９";
            this.LblBef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblNow
            // 
            this.LblNow.AutoEllipsis = true;
            this.LblNow.BackColor = System.Drawing.SystemColors.Window;
            this.LblNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblNow.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Bold);
            this.LblNow.Location = new System.Drawing.Point(81, 88);
            this.LblNow.Name = "LblNow";
            this.LblNow.Size = new System.Drawing.Size(251, 20);
            this.LblNow.TabIndex = 117;
            this.LblNow.Text = "０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９";
            this.LblNow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(37, 129);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(58, 31);
            this.BtnNext.TabIndex = 113;
            this.BtnNext.Text = "1つ進む";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // BtnBef
            // 
            this.BtnBef.Location = new System.Drawing.Point(37, 37);
            this.BtnBef.Name = "BtnBef";
            this.BtnBef.Size = new System.Drawing.Size(58, 31);
            this.BtnBef.TabIndex = 114;
            this.BtnBef.Text = "1つ戻る";
            this.BtnBef.UseVisualStyleBackColor = true;
            // 
            // LblDiscription
            // 
            this.LblDiscription.AutoSize = true;
            this.LblDiscription.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.LblDiscription.Location = new System.Drawing.Point(13, 93);
            this.LblDiscription.Name = "LblDiscription";
            this.LblDiscription.Size = new System.Drawing.Size(63, 12);
            this.LblDiscription.TabIndex = 110;
            this.LblDiscription.Text = "Ctrl+V ->";
            this.LblDiscription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblB.Location = new System.Drawing.Point(196, 114);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(19, 15);
            this.LblB.TabIndex = 111;
            this.LblB.Text = "∧";
            this.LblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblA.Location = new System.Drawing.Point(196, 67);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(19, 15);
            this.LblA.TabIndex = 112;
            this.LblA.Text = "∧";
            this.LblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(194, 179);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(131, 23);
            this.BtnStop.TabIndex = 108;
            this.BtnStop.Text = "オートコピーを終了(&E)";
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(25, 179);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(161, 23);
            this.BtnPause.TabIndex = 109;
            this.BtnPause.Text = "オートコピーの一時停止(&C)";
            this.BtnPause.UseVisualStyleBackColor = true;
            // 
            // LblMode
            // 
            this.LblMode.AutoSize = true;
            this.LblMode.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblMode.Location = new System.Drawing.Point(80, 8);
            this.LblMode.Name = "LblMode";
            this.LblMode.Size = new System.Drawing.Size(84, 14);
            this.LblMode.TabIndex = 107;
            this.LblMode.Text = "カウントアップ";
            this.LblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblM
            // 
            this.LblM.AutoSize = true;
            this.LblM.Location = new System.Drawing.Point(12, 9);
            this.LblM.Name = "LblM";
            this.LblM.Size = new System.Drawing.Size(62, 12);
            this.LblM.TabIndex = 106;
            this.LblM.Text = "コピーモード:";
            // 
            // FrmClip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 215);
            this.Controls.Add(this.LblList);
            this.Controls.Add(this.LblNext);
            this.Controls.Add(this.LblBef);
            this.Controls.Add(this.LblNow);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnBef);
            this.Controls.Add(this.LblDiscription);
            this.Controls.Add(this.LblB);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.LblMode);
            this.Controls.Add(this.LblM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClip";
            this.Text = "AutoClip v2.0.0 [オートコピー中]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblList;
        internal System.Windows.Forms.Label LblNext;
        internal System.Windows.Forms.Label LblBef;
        internal System.Windows.Forms.Label LblNow;
        internal System.Windows.Forms.Button BtnNext;
        internal System.Windows.Forms.Button BtnBef;
        internal System.Windows.Forms.Label LblDiscription;
        internal System.Windows.Forms.Label LblB;
        internal System.Windows.Forms.Label LblA;
        internal System.Windows.Forms.Button BtnStop;
        internal System.Windows.Forms.Button BtnPause;
        internal System.Windows.Forms.Label LblMode;
        internal System.Windows.Forms.Label LblM;
    }
}