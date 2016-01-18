namespace MyControls
{
    partial class Mik_LabelButton
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
            this.SuspendLayout();
            // 
            // Mik_LabelButton
            // 
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Text = "LabelText";
            this.MouseEnter += new System.EventHandler(this.Mik_Label_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Mik_Label_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
