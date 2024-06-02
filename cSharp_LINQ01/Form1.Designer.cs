namespace cSharp_LINQ01
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQ1 = new System.Windows.Forms.Button();
            this.btnQ2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnQ3 = new System.Windows.Forms.Button();
            this.btnQ4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnQ1
            // 
            this.btnQ1.Location = new System.Drawing.Point(40, 32);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(75, 23);
            this.btnQ1.TabIndex = 1;
            this.btnQ1.Text = "Query-1";
            this.btnQ1.UseVisualStyleBackColor = true;
            this.btnQ1.Click += new System.EventHandler(this.btnQ1_Click);
            // 
            // btnQ2
            // 
            this.btnQ2.Location = new System.Drawing.Point(148, 32);
            this.btnQ2.Name = "btnQ2";
            this.btnQ2.Size = new System.Drawing.Size(75, 23);
            this.btnQ2.TabIndex = 2;
            this.btnQ2.Text = "Query-2";
            this.btnQ2.UseVisualStyleBackColor = true;
            this.btnQ2.Click += new System.EventHandler(this.btnQ2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnQ3
            // 
            this.btnQ3.Location = new System.Drawing.Point(392, 31);
            this.btnQ3.Name = "btnQ3";
            this.btnQ3.Size = new System.Drawing.Size(75, 23);
            this.btnQ3.TabIndex = 4;
            this.btnQ3.Text = "Query-3";
            this.btnQ3.UseVisualStyleBackColor = true;
            this.btnQ3.Click += new System.EventHandler(this.btnQ3_Click);
            // 
            // btnQ4
            // 
            this.btnQ4.Location = new System.Drawing.Point(496, 31);
            this.btnQ4.Name = "btnQ4";
            this.btnQ4.Size = new System.Drawing.Size(75, 23);
            this.btnQ4.TabIndex = 5;
            this.btnQ4.Text = "Query-4";
            this.btnQ4.UseVisualStyleBackColor = true;
            this.btnQ4.Click += new System.EventHandler(this.btnQ4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.btnQ4);
            this.Controls.Add(this.btnQ3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnQ2);
            this.Controls.Add(this.btnQ1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.Button btnQ2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnQ3;
        private System.Windows.Forms.Button btnQ4;
    }
}

