
namespace BingDictYoudaoConverter
{
    partial class Form1
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
            this.Bing2Youdao = new System.Windows.Forms.Button();
            this.Youdao2Bing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bing2Youdao
            // 
            this.Bing2Youdao.Location = new System.Drawing.Point(84, 39);
            this.Bing2Youdao.Name = "Bing2Youdao";
            this.Bing2Youdao.Size = new System.Drawing.Size(228, 26);
            this.Bing2Youdao.TabIndex = 0;
            this.Bing2Youdao.Text = "必应生词本转有道单词本";
            this.Bing2Youdao.UseVisualStyleBackColor = true;
            this.Bing2Youdao.Click += new System.EventHandler(this.Bing2Youdao_Click);
            // 
            // Youdao2Bing
            // 
            this.Youdao2Bing.Location = new System.Drawing.Point(84, 111);
            this.Youdao2Bing.Name = "Youdao2Bing";
            this.Youdao2Bing.Size = new System.Drawing.Size(228, 23);
            this.Youdao2Bing.TabIndex = 1;
            this.Youdao2Bing.Text = "有道单词本转必应生词本";
            this.Youdao2Bing.UseVisualStyleBackColor = true;
            this.Youdao2Bing.Click += new System.EventHandler(this.Youdao2Bing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 227);
            this.Controls.Add(this.Youdao2Bing);
            this.Controls.Add(this.Bing2Youdao);
            this.Name = "Form1";
            this.Text = "必应词典——有道词典生词本转换";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bing2Youdao;
        private System.Windows.Forms.Button Youdao2Bing;
    }
}

