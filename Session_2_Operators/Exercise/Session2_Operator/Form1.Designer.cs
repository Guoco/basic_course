namespace Session2_Operator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			this.label3 = new System.Windows.Forms.Label();
			this.btnClearAdd = new System.Windows.Forms.Button();
			this.txtAnswerA = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAdd2 = new System.Windows.Forms.TextBox();
			this.txtAdd1 = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(531, 18);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 21);
			this.label3.TabIndex = 15;
			this.label3.Text = "答案";
			// 
			// btnClearAdd
			// 
			this.btnClearAdd.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnClearAdd.Location = new System.Drawing.Point(79, 60);
			this.btnClearAdd.Margin = new System.Windows.Forms.Padding(2);
			this.btnClearAdd.Name = "btnClearAdd";
			this.btnClearAdd.Size = new System.Drawing.Size(80, 31);
			this.btnClearAdd.TabIndex = 13;
			this.btnClearAdd.Text = "Clear";
			this.btnClearAdd.UseVisualStyleBackColor = true;
			this.btnClearAdd.Click += new System.EventHandler(this.btnClearAdd_Click);
			// 
			// txtAnswerA
			// 
			this.txtAnswerA.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAnswerA.Location = new System.Drawing.Point(518, 60);
			this.txtAnswerA.Margin = new System.Windows.Forms.Padding(2);
			this.txtAnswerA.Name = "txtAnswerA";
			this.txtAnswerA.Size = new System.Drawing.Size(76, 30);
			this.txtAnswerA.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(453, 69);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 19);
			this.label2.TabIndex = 12;
			this.label2.Text = "=";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(311, 66);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "+";
			// 
			// txtAdd2
			// 
			this.txtAdd2.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAdd2.Location = new System.Drawing.Point(342, 62);
			this.txtAdd2.Margin = new System.Windows.Forms.Padding(2);
			this.txtAdd2.Name = "txtAdd2";
			this.txtAdd2.Size = new System.Drawing.Size(76, 30);
			this.txtAdd2.TabIndex = 10;
			this.txtAdd2.TextChanged += new System.EventHandler(this.txtAdd2_TextChanged);
			// 
			// txtAdd1
			// 
			this.txtAdd1.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAdd1.Location = new System.Drawing.Point(223, 60);
			this.txtAdd1.Margin = new System.Windows.Forms.Padding(2);
			this.txtAdd1.Name = "txtAdd1";
			this.txtAdd1.Size = new System.Drawing.Size(76, 30);
			this.txtAdd1.TabIndex = 9;
			this.txtAdd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd1_KeyPress);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCalculate.Location = new System.Drawing.Point(649, 57);
			this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(70, 30);
			this.btnCalculate.TabIndex = 16;
			this.btnCalculate.Text = "計算";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 336);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClearAdd);
			this.Controls.Add(this.txtAnswerA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAdd2);
			this.Controls.Add(this.txtAdd1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearAdd;
        private System.Windows.Forms.TextBox txtAnswerA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.Button btnCalculate;
    }
}

