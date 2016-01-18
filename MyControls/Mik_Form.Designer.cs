namespace MyControls
{
    partial class Mik_Form
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Close = new MyControls.Mik_LabelButton();
            this.label_Minimize = new MyControls.Mik_LabelButton();
            this.label_Title = new MyControls.Mik_Label();
            this.SuspendLayout();
            // 
            // label_Close
            // 
            this.label_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Close.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Close.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Close.Location = new System.Drawing.Point(254, 0);
            this.label_Close.Name = "label_Close";
            this.label_Close.Size = new System.Drawing.Size(46, 15);
            this.label_Close.TabIndex = 1;
            this.label_Close.Text = " Close ";
            this.label_Close.Click += new System.EventHandler(this.label_Close_Click);
            // 
            // label_Minimize
            // 
            this.label_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Minimize.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Minimize.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Minimize.Location = new System.Drawing.Point(188, 0);
            this.label_Minimize.Name = "label_Minimize";
            this.label_Minimize.Size = new System.Drawing.Size(66, 15);
            this.label_Minimize.TabIndex = 0;
            this.label_Minimize.Text = " Minimize ";
            this.label_Minimize.Click += new System.EventHandler(this.label_Minimize_Click);
            // 
            // label_Title
            // 
            this.label_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Title.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Title.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(33, 15);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Title";
            this.label_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Title_MouseDown);
            // 
            // Mik_Form
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.label_Close);
            this.Controls.Add(this.label_Minimize);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Mik_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Mik_LabelButton label_Minimize;
        private Mik_LabelButton label_Close;
        private Mik_Label label_Title;

    }
}
