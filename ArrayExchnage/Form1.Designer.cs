namespace ArrayExchnage
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
            this.btnLoadArray = new System.Windows.Forms.Button();
            this.btnExchangeArray = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLeftArray = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstRightArray = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadArray
            // 
            this.btnLoadArray.Location = new System.Drawing.Point(37, 380);
            this.btnLoadArray.Name = "btnLoadArray";
            this.btnLoadArray.Size = new System.Drawing.Size(75, 43);
            this.btnLoadArray.TabIndex = 0;
            this.btnLoadArray.Text = "Load Array";
            this.btnLoadArray.UseVisualStyleBackColor = true;
            this.btnLoadArray.Click += new System.EventHandler(this.btnLoadArray_Click);
            // 
            // btnExchangeArray
            // 
            this.btnExchangeArray.Location = new System.Drawing.Point(166, 380);
            this.btnExchangeArray.Name = "btnExchangeArray";
            this.btnExchangeArray.Size = new System.Drawing.Size(81, 43);
            this.btnExchangeArray.TabIndex = 1;
            this.btnExchangeArray.Text = "Exchange Arrays";
            this.btnExchangeArray.UseVisualStyleBackColor = true;
            this.btnExchangeArray.Click += new System.EventHandler(this.btnExchangeArray_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLeftArray);
            this.groupBox1.Location = new System.Drawing.Point(47, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 269);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Even Array";
            // 
            // lstLeftArray
            // 
            this.lstLeftArray.FormattingEnabled = true;
            this.lstLeftArray.ItemHeight = 16;
            this.lstLeftArray.Location = new System.Drawing.Point(6, 21);
            this.lstLeftArray.Name = "lstLeftArray";
            this.lstLeftArray.Size = new System.Drawing.Size(166, 244);
            this.lstLeftArray.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstRightArray);
            this.groupBox2.Location = new System.Drawing.Point(272, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 269);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odd Array";
            // 
            // lstRightArray
            // 
            this.lstRightArray.FormattingEnabled = true;
            this.lstRightArray.ItemHeight = 16;
            this.lstRightArray.Location = new System.Drawing.Point(6, 21);
            this.lstRightArray.Name = "lstRightArray";
            this.lstRightArray.Size = new System.Drawing.Size(166, 244);
            this.lstRightArray.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(326, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 43);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(448, 418);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 43);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 493);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExchangeArray);
            this.Controls.Add(this.btnLoadArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadArray;
        private System.Windows.Forms.Button btnExchangeArray;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLeftArray;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstRightArray;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnd;
    }
}

