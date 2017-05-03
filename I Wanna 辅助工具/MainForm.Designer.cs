namespace I_Wanna_辅助工具
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKeepFire = new System.Windows.Forms.Button();
            this.btnSmallJump = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKeepJump = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKeepFire
            // 
            this.btnKeepFire.Location = new System.Drawing.Point(74, 42);
            this.btnKeepFire.Name = "btnKeepFire";
            this.btnKeepFire.Size = new System.Drawing.Size(75, 23);
            this.btnKeepFire.TabIndex = 0;
            this.btnKeepFire.Text = "连发器";
            this.btnKeepFire.UseVisualStyleBackColor = true;
            this.btnKeepFire.Click += new System.EventHandler(this.btnKeepFire_Click);
            // 
            // btnSmallJump
            // 
            this.btnSmallJump.Location = new System.Drawing.Point(74, 134);
            this.btnSmallJump.Name = "btnSmallJump";
            this.btnSmallJump.Size = new System.Drawing.Size(75, 23);
            this.btnSmallJump.TabIndex = 1;
            this.btnSmallJump.Text = "小跳";
            this.btnSmallJump.UseVisualStyleBackColor = true;
            this.btnSmallJump.Click += new System.EventHandler(this.btnSmallJump_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "跳相生刺";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKeepJump
            // 
            this.btnKeepJump.Location = new System.Drawing.Point(74, 88);
            this.btnKeepJump.Name = "btnKeepJump";
            this.btnKeepJump.Size = new System.Drawing.Size(75, 23);
            this.btnKeepJump.TabIndex = 3;
            this.btnKeepJump.Text = "连跳";
            this.btnKeepJump.UseVisualStyleBackColor = true;
            this.btnKeepJump.Click += new System.EventHandler(this.btnKeepJump_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 244);
            this.Controls.Add(this.btnKeepJump);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSmallJump);
            this.Controls.Add(this.btnKeepFire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "I Wanna 辅助工具";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeepFire;
        private System.Windows.Forms.Button btnSmallJump;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKeepJump;
    }
}

