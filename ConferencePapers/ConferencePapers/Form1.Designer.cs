namespace ConferencePapers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listconference = new System.Windows.Forms.ListBox();
            this.comboyear = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.comboyear);
            this.groupBox1.Controls.Add(this.listconference);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listconference
            // 
            this.listconference.FormattingEnabled = true;
            this.listconference.Location = new System.Drawing.Point(6, 19);
            this.listconference.Name = "listconference";
            this.listconference.Size = new System.Drawing.Size(358, 225);
            this.listconference.TabIndex = 0;
            // 
            // comboyear
            // 
            this.comboyear.FormattingEnabled = true;
            this.comboyear.Location = new System.Drawing.Point(6, 268);
            this.comboyear.Name = "comboyear";
            this.comboyear.Size = new System.Drawing.Size(358, 21);
            this.comboyear.TabIndex = 1;
            this.comboyear.SelectedIndexChanged += new System.EventHandler(this.comboyear_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(6, 312);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(358, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Додади конференција";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(6, 358);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(358, 23);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Избриши конференција";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 411);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Конференции";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox comboyear;
        private System.Windows.Forms.ListBox listconference;
    }
}

