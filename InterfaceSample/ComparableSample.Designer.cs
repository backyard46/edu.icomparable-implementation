namespace InterfaceSample
{
    partial class ComparableSample
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.buttonSort = new System.Windows.Forms.Button();
            this.listCharacters = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(8, 8);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(128, 32);
            this.buttonSort.TabIndex = 0;
            this.buttonSort.Text = "並べ替え";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // listCharacters
            // 
            this.listCharacters.FormattingEnabled = true;
            this.listCharacters.ItemHeight = 19;
            this.listCharacters.Location = new System.Drawing.Point(8, 48);
            this.listCharacters.Name = "listCharacters";
            this.listCharacters.Size = new System.Drawing.Size(512, 327);
            this.listCharacters.TabIndex = 1;
            // 
            // ComparableSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 385);
            this.Controls.Add(this.listCharacters);
            this.Controls.Add(this.buttonSort);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ComparableSample";
            this.Text = "IComparableを使ったソートサンプル";
            this.Load += new System.EventHandler(this.ComparableSample_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ListBox listCharacters;
    }
}

