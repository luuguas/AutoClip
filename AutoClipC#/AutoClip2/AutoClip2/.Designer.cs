
namespace AutoClip2
{
    partial class FrmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ChkTopMost = new System.Windows.Forms.CheckBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.TbcSelect = new System.Windows.Forms.TabControl();
            this.TbpCount = new System.Windows.Forms.TabPage();
            this.Label1 = new System.Windows.Forms.Label();
            this.LblClip_Count = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbDown = new System.Windows.Forms.RadioButton();
            this.RdbUp = new System.Windows.Forms.RadioButton();
            this.LblDiscription = new System.Windows.Forms.Label();
            this.ChkLoop_Count = new System.Windows.Forms.CheckBox();
            this.LblWave = new System.Windows.Forms.Label();
            this.TxtInit = new System.Windows.Forms.TextBox();
            this.TxtMax = new System.Windows.Forms.TextBox();
            this.TxtStep = new System.Windows.Forms.TextBox();
            this.TxtClip = new System.Windows.Forms.TextBox();
            this.TxtMin = new System.Windows.Forms.TextBox();
            this.LblStep = new System.Windows.Forms.Label();
            this.LblRange = new System.Windows.Forms.Label();
            this.TbpList = new System.Windows.Forms.TabPage();
            this.BtnChangeStartIndex = new System.Windows.Forms.Button();
            this.ChkLoop_List = new System.Windows.Forms.CheckBox();
            this.LblStartIndex = new System.Windows.Forms.Label();
            this.TxtStartIndex = new System.Windows.Forms.TextBox();
            this.BtnReadFile = new System.Windows.Forms.Button();
            this.BtnReverse = new System.Windows.Forms.Button();
            this.BtnDeleteAll = new System.Windows.Forms.Button();
            this.BtnDeleteSelected = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAddSelected = new System.Windows.Forms.Button();
            this.BtnAddEnd = new System.Windows.Forms.Button();
            this.BtnInsertCrLf = new System.Windows.Forms.Button();
            this.BtnAddFront = new System.Windows.Forms.Button();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.LblAdd = new System.Windows.Forms.Label();
            this.LblClip_List = new System.Windows.Forms.Label();
            this.LstClip = new System.Windows.Forms.ListBox();
            this.TbcSelect.SuspendLayout();
            this.TbpCount.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TbpList.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChkTopMost
            // 
            this.ChkTopMost.AutoSize = true;
            this.ChkTopMost.Location = new System.Drawing.Point(16, 307);
            this.ChkTopMost.Name = "ChkTopMost";
            this.ChkTopMost.Size = new System.Drawing.Size(154, 16);
            this.ChkTopMost.TabIndex = 5;
            this.ChkTopMost.Text = "画面を常に前面に表示する";
            this.ChkTopMost.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(328, 303);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(126, 23);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "オートコピーの開始(&C)";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // TbcSelect
            // 
            this.TbcSelect.Controls.Add(this.TbpCount);
            this.TbcSelect.Controls.Add(this.TbpList);
            this.TbcSelect.Location = new System.Drawing.Point(12, 12);
            this.TbcSelect.Name = "TbcSelect";
            this.TbcSelect.SelectedIndex = 0;
            this.TbcSelect.Size = new System.Drawing.Size(459, 285);
            this.TbcSelect.TabIndex = 3;
            // 
            // TbpCount
            // 
            this.TbpCount.Controls.Add(this.Label1);
            this.TbpCount.Controls.Add(this.LblClip_Count);
            this.TbpCount.Controls.Add(this.GroupBox1);
            this.TbpCount.Controls.Add(this.LblDiscription);
            this.TbpCount.Controls.Add(this.ChkLoop_Count);
            this.TbpCount.Controls.Add(this.LblWave);
            this.TbpCount.Controls.Add(this.TxtInit);
            this.TbpCount.Controls.Add(this.TxtMax);
            this.TbpCount.Controls.Add(this.TxtStep);
            this.TbpCount.Controls.Add(this.TxtClip);
            this.TbpCount.Controls.Add(this.TxtMin);
            this.TbpCount.Controls.Add(this.LblStep);
            this.TbpCount.Controls.Add(this.LblRange);
            this.TbpCount.Location = new System.Drawing.Point(4, 22);
            this.TbpCount.Name = "TbpCount";
            this.TbpCount.Padding = new System.Windows.Forms.Padding(3);
            this.TbpCount.Size = new System.Drawing.Size(451, 259);
            this.TbpCount.TabIndex = 0;
            this.TbpCount.Text = "カウントで作成";
            this.TbpCount.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(155, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 12);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "初期値:";
            // 
            // LblClip_Count
            // 
            this.LblClip_Count.AutoSize = true;
            this.LblClip_Count.Location = new System.Drawing.Point(34, 143);
            this.LblClip_Count.Name = "LblClip_Count";
            this.LblClip_Count.Size = new System.Drawing.Size(89, 12);
            this.LblClip_Count.TabIndex = 10;
            this.LblClip_Count.Text = "コピーするテキスト:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RdbDown);
            this.GroupBox1.Controls.Add(this.RdbUp);
            this.GroupBox1.Location = new System.Drawing.Point(36, 62);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(249, 43);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "カウントの種類";
            // 
            // RdbDown
            // 
            this.RdbDown.AutoSize = true;
            this.RdbDown.Location = new System.Drawing.Point(128, 18);
            this.RdbDown.Name = "RdbDown";
            this.RdbDown.Size = new System.Drawing.Size(85, 16);
            this.RdbDown.TabIndex = 1;
            this.RdbDown.Text = "カウントダウン";
            this.RdbDown.UseVisualStyleBackColor = true;
            // 
            // RdbUp
            // 
            this.RdbUp.AutoSize = true;
            this.RdbUp.Location = new System.Drawing.Point(6, 18);
            this.RdbUp.Name = "RdbUp";
            this.RdbUp.Size = new System.Drawing.Size(83, 16);
            this.RdbUp.TabIndex = 0;
            this.RdbUp.Text = "カウントアップ";
            this.RdbUp.UseVisualStyleBackColor = true;
            // 
            // LblDiscription
            // 
            this.LblDiscription.AutoSize = true;
            this.LblDiscription.Location = new System.Drawing.Point(13, 174);
            this.LblDiscription.Name = "LblDiscription";
            this.LblDiscription.Size = new System.Drawing.Size(290, 72);
            this.LblDiscription.TabIndex = 12;
            this.LblDiscription.Text = "※\\d: これを入力した箇所にカウントの数値が挿入されます。\r\n　 \\f: 最大値の桁数に合わせて数値の先頭に0が加わり、\r\n　　　 桁数のそろった数値が挿入され" +
    "ます。\r\n　 \\x: x桁(xは1桁の自然数)に満たない数値には、その桁を\r\n　　　 満たすよう先頭に0が加わった値が挿入されます。 例:\\3\r\n　 \\\\: \\" +
    "が表示されます。  \\n: 改行が挿入されます。";
            // 
            // ChkLoop_Count
            // 
            this.ChkLoop_Count.AutoSize = true;
            this.ChkLoop_Count.Location = new System.Drawing.Point(36, 111);
            this.ChkLoop_Count.Name = "ChkLoop_Count";
            this.ChkLoop_Count.Size = new System.Drawing.Size(237, 16);
            this.ChkLoop_Count.TabIndex = 9;
            this.ChkLoop_Count.Text = "最大値に達したら再び最小値からカウントする";
            this.ChkLoop_Count.UseVisualStyleBackColor = true;
            // 
            // LblWave
            // 
            this.LblWave.AutoSize = true;
            this.LblWave.Location = new System.Drawing.Point(181, 13);
            this.LblWave.Name = "LblWave";
            this.LblWave.Size = new System.Drawing.Size(17, 12);
            this.LblWave.TabIndex = 2;
            this.LblWave.Text = "～";
            // 
            // TxtInit
            // 
            this.TxtInit.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TxtInit.Location = new System.Drawing.Point(204, 35);
            this.TxtInit.MaxLength = 10;
            this.TxtInit.Name = "TxtInit";
            this.TxtInit.Size = new System.Drawing.Size(75, 19);
            this.TxtInit.TabIndex = 7;
            // 
            // TxtMax
            // 
            this.TxtMax.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TxtMax.Location = new System.Drawing.Point(204, 10);
            this.TxtMax.MaxLength = 10;
            this.TxtMax.Name = "TxtMax";
            this.TxtMax.Size = new System.Drawing.Size(75, 19);
            this.TxtMax.TabIndex = 3;
            // 
            // TxtStep
            // 
            this.TxtStep.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TxtStep.Location = new System.Drawing.Point(100, 35);
            this.TxtStep.MaxLength = 5;
            this.TxtStep.Name = "TxtStep";
            this.TxtStep.Size = new System.Drawing.Size(48, 19);
            this.TxtStep.TabIndex = 5;
            // 
            // TxtClip
            // 
            this.TxtClip.Location = new System.Drawing.Point(129, 140);
            this.TxtClip.Name = "TxtClip";
            this.TxtClip.Size = new System.Drawing.Size(156, 19);
            this.TxtClip.TabIndex = 11;
            // 
            // TxtMin
            // 
            this.TxtMin.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TxtMin.Location = new System.Drawing.Point(100, 10);
            this.TxtMin.MaxLength = 10;
            this.TxtMin.Name = "TxtMin";
            this.TxtMin.Size = new System.Drawing.Size(75, 19);
            this.TxtMin.TabIndex = 1;
            // 
            // LblStep
            // 
            this.LblStep.AutoSize = true;
            this.LblStep.Location = new System.Drawing.Point(51, 39);
            this.LblStep.Name = "LblStep";
            this.LblStep.Size = new System.Drawing.Size(43, 12);
            this.LblStep.TabIndex = 4;
            this.LblStep.Text = "増加量:";
            // 
            // LblRange
            // 
            this.LblRange.AutoSize = true;
            this.LblRange.Location = new System.Drawing.Point(28, 13);
            this.LblRange.Name = "LblRange";
            this.LblRange.Size = new System.Drawing.Size(65, 12);
            this.LblRange.TabIndex = 0;
            this.LblRange.Text = "数値の範囲:";
            // 
            // TbpList
            // 
            this.TbpList.Controls.Add(this.BtnChangeStartIndex);
            this.TbpList.Controls.Add(this.ChkLoop_List);
            this.TbpList.Controls.Add(this.LblStartIndex);
            this.TbpList.Controls.Add(this.TxtStartIndex);
            this.TbpList.Controls.Add(this.BtnReadFile);
            this.TbpList.Controls.Add(this.BtnReverse);
            this.TbpList.Controls.Add(this.BtnDeleteAll);
            this.TbpList.Controls.Add(this.BtnDeleteSelected);
            this.TbpList.Controls.Add(this.GroupBox2);
            this.TbpList.Controls.Add(this.LblClip_List);
            this.TbpList.Controls.Add(this.LstClip);
            this.TbpList.Location = new System.Drawing.Point(4, 22);
            this.TbpList.Name = "TbpList";
            this.TbpList.Padding = new System.Windows.Forms.Padding(3);
            this.TbpList.Size = new System.Drawing.Size(451, 259);
            this.TbpList.TabIndex = 1;
            this.TbpList.Text = "リストから作成";
            this.TbpList.UseVisualStyleBackColor = true;
            // 
            // BtnChangeStartIndex
            // 
            this.BtnChangeStartIndex.Location = new System.Drawing.Point(343, 177);
            this.BtnChangeStartIndex.Name = "BtnChangeStartIndex";
            this.BtnChangeStartIndex.Size = new System.Drawing.Size(95, 37);
            this.BtnChangeStartIndex.TabIndex = 9;
            this.BtnChangeStartIndex.Text = "選択した要素を\r\n開始位置に指定";
            this.BtnChangeStartIndex.UseVisualStyleBackColor = true;
            // 
            // ChkLoop_List
            // 
            this.ChkLoop_List.AutoSize = true;
            this.ChkLoop_List.Location = new System.Drawing.Point(193, 222);
            this.ChkLoop_List.Name = "ChkLoop_List";
            this.ChkLoop_List.Size = new System.Drawing.Size(139, 28);
            this.ChkLoop_List.TabIndex = 7;
            this.ChkLoop_List.Text = "リストの終端に達したら\r\n再び先頭から貼り付ける";
            this.ChkLoop_List.UseVisualStyleBackColor = true;
            // 
            // LblStartIndex
            // 
            this.LblStartIndex.AutoSize = true;
            this.LblStartIndex.Location = new System.Drawing.Point(191, 189);
            this.LblStartIndex.Name = "LblStartIndex";
            this.LblStartIndex.Size = new System.Drawing.Size(92, 12);
            this.LblStartIndex.TabIndex = 5;
            this.LblStartIndex.Text = "コピーの開始位置:";
            // 
            // TxtStartIndex
            // 
            this.TxtStartIndex.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TxtStartIndex.Location = new System.Drawing.Point(289, 186);
            this.TxtStartIndex.MaxLength = 6;
            this.TxtStartIndex.Name = "TxtStartIndex";
            this.TxtStartIndex.Size = new System.Drawing.Size(43, 19);
            this.TxtStartIndex.TabIndex = 6;
            // 
            // BtnReadFile
            // 
            this.BtnReadFile.Location = new System.Drawing.Point(343, 217);
            this.BtnReadFile.Name = "BtnReadFile";
            this.BtnReadFile.Size = new System.Drawing.Size(95, 37);
            this.BtnReadFile.TabIndex = 8;
            this.BtnReadFile.Text = "ﾃｷｽﾄﾌｧｲﾙから\r\nﾘｽﾄを読み込み...";
            this.BtnReadFile.UseVisualStyleBackColor = true;
            // 
            // BtnReverse
            // 
            this.BtnReverse.Location = new System.Drawing.Point(30, 231);
            this.BtnReverse.Name = "BtnReverse";
            this.BtnReverse.Size = new System.Drawing.Size(142, 23);
            this.BtnReverse.TabIndex = 3;
            this.BtnReverse.Text = "ﾘｽﾄを逆順に並べ替える";
            this.BtnReverse.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteAll
            // 
            this.BtnDeleteAll.Location = new System.Drawing.Point(41, 202);
            this.BtnDeleteAll.Name = "BtnDeleteAll";
            this.BtnDeleteAll.Size = new System.Drawing.Size(120, 23);
            this.BtnDeleteAll.TabIndex = 3;
            this.BtnDeleteAll.Text = "全ての要素を削除";
            this.BtnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteSelected
            // 
            this.BtnDeleteSelected.Location = new System.Drawing.Point(41, 176);
            this.BtnDeleteSelected.Name = "BtnDeleteSelected";
            this.BtnDeleteSelected.Size = new System.Drawing.Size(120, 23);
            this.BtnDeleteSelected.TabIndex = 2;
            this.BtnDeleteSelected.Text = "選択した要素を削除";
            this.BtnDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.BtnAddSelected);
            this.GroupBox2.Controls.Add(this.BtnAddEnd);
            this.GroupBox2.Controls.Add(this.BtnInsertCrLf);
            this.GroupBox2.Controls.Add(this.BtnAddFront);
            this.GroupBox2.Controls.Add(this.TxtAdd);
            this.GroupBox2.Controls.Add(this.LblAdd);
            this.GroupBox2.Location = new System.Drawing.Point(238, 1);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(200, 172);
            this.GroupBox2.TabIndex = 4;
            this.GroupBox2.TabStop = false;
            // 
            // BtnAddSelected
            // 
            this.BtnAddSelected.Location = new System.Drawing.Point(21, 140);
            this.BtnAddSelected.Name = "BtnAddSelected";
            this.BtnAddSelected.Size = new System.Drawing.Size(158, 23);
            this.BtnAddSelected.TabIndex = 4;
            this.BtnAddSelected.Text = "文字列を選択した位置に追加";
            this.BtnAddSelected.UseVisualStyleBackColor = true;
            // 
            // BtnAddEnd
            // 
            this.BtnAddEnd.Location = new System.Drawing.Point(40, 88);
            this.BtnAddEnd.Name = "BtnAddEnd";
            this.BtnAddEnd.Size = new System.Drawing.Size(120, 23);
            this.BtnAddEnd.TabIndex = 3;
            this.BtnAddEnd.Text = "文字列を末尾に追加";
            this.BtnAddEnd.UseVisualStyleBackColor = true;
            // 
            // BtnInsertCrLf
            // 
            this.BtnInsertCrLf.Location = new System.Drawing.Point(21, 54);
            this.BtnInsertCrLf.Name = "BtnInsertCrLf";
            this.BtnInsertCrLf.Size = new System.Drawing.Size(158, 23);
            this.BtnInsertCrLf.TabIndex = 2;
            this.BtnInsertCrLf.Text = "選択位置に改行文字を挿入";
            this.BtnInsertCrLf.UseVisualStyleBackColor = true;
            // 
            // BtnAddFront
            // 
            this.BtnAddFront.Location = new System.Drawing.Point(40, 114);
            this.BtnAddFront.Name = "BtnAddFront";
            this.BtnAddFront.Size = new System.Drawing.Size(120, 23);
            this.BtnAddFront.TabIndex = 2;
            this.BtnAddFront.Text = "文字列を先頭に追加";
            this.BtnAddFront.UseVisualStyleBackColor = true;
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(13, 29);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(175, 19);
            this.TxtAdd.TabIndex = 1;
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.Location = new System.Drawing.Point(6, 13);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(86, 12);
            this.LblAdd.TabIndex = 0;
            this.LblAdd.Text = "追加する文字列:";
            // 
            // LblClip_List
            // 
            this.LblClip_List.AutoSize = true;
            this.LblClip_List.Location = new System.Drawing.Point(7, 8);
            this.LblClip_List.Name = "LblClip_List";
            this.LblClip_List.Size = new System.Drawing.Size(113, 12);
            this.LblClip_List.TabIndex = 0;
            this.LblClip_List.Text = "コピーする文字列リスト:";
            // 
            // LstClip
            // 
            this.LstClip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LstClip.FormattingEnabled = true;
            this.LstClip.HorizontalScrollbar = true;
            this.LstClip.ItemHeight = 12;
            this.LstClip.Items.AddRange(new object[] {
            "０１２３４５６７８９０１２３４５６７８９",
            "おはようございます。",
            "今日もいい天気ですね！"});
            this.LstClip.Location = new System.Drawing.Point(14, 24);
            this.LstClip.Name = "LstClip";
            this.LstClip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LstClip.Size = new System.Drawing.Size(215, 148);
            this.LstClip.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 336);
            this.Controls.Add(this.ChkTopMost);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TbcSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "AutoClip v2.0.0";
            this.TbcSelect.ResumeLayout(false);
            this.TbpCount.ResumeLayout(false);
            this.TbpCount.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TbpList.ResumeLayout(false);
            this.TbpList.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox ChkTopMost;
        internal System.Windows.Forms.Button BtnStart;
        internal System.Windows.Forms.TabControl TbcSelect;
        internal System.Windows.Forms.TabPage TbpCount;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LblClip_Count;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton RdbDown;
        internal System.Windows.Forms.RadioButton RdbUp;
        internal System.Windows.Forms.Label LblDiscription;
        internal System.Windows.Forms.CheckBox ChkLoop_Count;
        internal System.Windows.Forms.Label LblWave;
        internal System.Windows.Forms.TextBox TxtInit;
        internal System.Windows.Forms.TextBox TxtMax;
        internal System.Windows.Forms.TextBox TxtStep;
        internal System.Windows.Forms.TextBox TxtClip;
        internal System.Windows.Forms.TextBox TxtMin;
        internal System.Windows.Forms.Label LblStep;
        internal System.Windows.Forms.Label LblRange;
        internal System.Windows.Forms.TabPage TbpList;
        internal System.Windows.Forms.Button BtnChangeStartIndex;
        internal System.Windows.Forms.CheckBox ChkLoop_List;
        internal System.Windows.Forms.Label LblStartIndex;
        internal System.Windows.Forms.TextBox TxtStartIndex;
        internal System.Windows.Forms.Button BtnReadFile;
        internal System.Windows.Forms.Button BtnReverse;
        internal System.Windows.Forms.Button BtnDeleteAll;
        internal System.Windows.Forms.Button BtnDeleteSelected;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button BtnAddSelected;
        internal System.Windows.Forms.Button BtnAddEnd;
        internal System.Windows.Forms.Button BtnInsertCrLf;
        internal System.Windows.Forms.Button BtnAddFront;
        internal System.Windows.Forms.TextBox TxtAdd;
        internal System.Windows.Forms.Label LblAdd;
        internal System.Windows.Forms.Label LblClip_List;
        internal System.Windows.Forms.ListBox LstClip;
    }
}

