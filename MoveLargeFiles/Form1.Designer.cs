namespace MoveLargeFiles
{
	partial class frm
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
            this.lstDirectories = new System.Windows.Forms.ListBox();
            this.lstBigFiles = new System.Windows.Forms.ListBox();
            this.txtMoveTo = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThreashold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDirectories
            // 
            this.lstDirectories.AllowDrop = true;
            this.lstDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDirectories.FormattingEnabled = true;
            this.lstDirectories.Location = new System.Drawing.Point(12, 30);
            this.lstDirectories.Name = "lstDirectories";
            this.lstDirectories.Size = new System.Drawing.Size(208, 199);
            this.lstDirectories.TabIndex = 0;
            this.lstDirectories.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDirectories_DragDrop);
            this.lstDirectories.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstDirectories_DragEnter);
            this.lstDirectories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstDirectories_KeyDown);
            // 
            // lstBigFiles
            // 
            this.lstBigFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBigFiles.FormattingEnabled = true;
            this.lstBigFiles.Location = new System.Drawing.Point(244, 30);
            this.lstBigFiles.Name = "lstBigFiles";
            this.lstBigFiles.Size = new System.Drawing.Size(314, 251);
            this.lstBigFiles.TabIndex = 2;
            // 
            // txtMoveTo
            // 
            this.txtMoveTo.AllowDrop = true;
            this.txtMoveTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoveTo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMoveTo.Location = new System.Drawing.Point(12, 359);
            this.txtMoveTo.Name = "txtMoveTo";
            this.txtMoveTo.Size = new System.Drawing.Size(546, 20);
            this.txtMoveTo.TabIndex = 3;
            this.txtMoveTo.Text = "Drag output folder here";
            this.txtMoveTo.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtMoveTo_DragDrop);
            this.txtMoveTo.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtMoveTo_DragEnter);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.Location = new System.Drawing.Point(483, 386);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "Move Files";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find all the large files from these directories";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Large files found in the folders on the left";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Move the large files to this folder";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Threashold (MB)";
            // 
            // txtThreashold
            // 
            this.txtThreashold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtThreashold.Location = new System.Drawing.Point(12, 283);
            this.txtThreashold.Name = "txtThreashold";
            this.txtThreashold.Size = new System.Drawing.Size(46, 20);
            this.txtThreashold.TabIndex = 9;
            this.txtThreashold.Text = "2";
            this.txtThreashold.TextChanged += new System.EventHandler(this.txtThreashold_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Drag Folder Containing Large Files Here";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 421);
            this.Controls.Add(this.txtThreashold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoveTo);
            this.Controls.Add(this.lstBigFiles);
            this.Controls.Add(this.lstDirectories);
            this.Controls.Add(this.btnMove);
            this.Name = "frm";
            this.Text = "Move Large Files";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstDirectories;
		private System.Windows.Forms.ListBox lstBigFiles;
		private System.Windows.Forms.TextBox txtMoveTo;
		private System.Windows.Forms.Button btnMove;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThreashold;
		private System.Windows.Forms.Label label5;
	}
}

