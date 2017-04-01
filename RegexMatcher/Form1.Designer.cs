namespace RegexMatcher {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.tbRegex = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.tbGroups = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblMatches = new System.Windows.Forms.Label();
			this.lblGroups = new System.Windows.Forms.Label();
			this.cbLiveUpdate = new System.Windows.Forms.CheckBox();
			this.cmdUpdateNow = new System.Windows.Forms.Button();
			this.cbCaseInsensitive = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblGroupName = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.cmdUnfilter = new System.Windows.Forms.Button();
			this.cmdFilter = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tbEncodedRegex = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.tbGroups)).BeginInit();
			this.SuspendLayout();
			// 
			// tbRegex
			// 
			this.tbRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbRegex.Location = new System.Drawing.Point(13, 13);
			this.tbRegex.Name = "tbRegex";
			this.tbRegex.Size = new System.Drawing.Size(565, 20);
			this.tbRegex.TabIndex = 0;
			this.tbRegex.TextChanged += new System.EventHandler(this.tbRegex_TextChanged);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(13, 139);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(669, 292);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// tbGroups
			// 
			this.tbGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbGroups.Location = new System.Drawing.Point(13, 66);
			this.tbGroups.Name = "tbGroups";
			this.tbGroups.Size = new System.Drawing.Size(565, 45);
			this.tbGroups.TabIndex = 3;
			this.tbGroups.Scroll += new System.EventHandler(this.tbGroups_Scroll);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(584, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Matches:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(584, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Groups:";
			// 
			// lblMatches
			// 
			this.lblMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMatches.AutoSize = true;
			this.lblMatches.Location = new System.Drawing.Point(641, 95);
			this.lblMatches.Name = "lblMatches";
			this.lblMatches.Size = new System.Drawing.Size(0, 13);
			this.lblMatches.TabIndex = 6;
			// 
			// lblGroups
			// 
			this.lblGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblGroups.AutoSize = true;
			this.lblGroups.Location = new System.Drawing.Point(634, 114);
			this.lblGroups.Name = "lblGroups";
			this.lblGroups.Size = new System.Drawing.Size(0, 13);
			this.lblGroups.TabIndex = 7;
			// 
			// cbLiveUpdate
			// 
			this.cbLiveUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbLiveUpdate.AutoSize = true;
			this.cbLiveUpdate.Location = new System.Drawing.Point(584, 42);
			this.cbLiveUpdate.Name = "cbLiveUpdate";
			this.cbLiveUpdate.Size = new System.Drawing.Size(84, 17);
			this.cbLiveUpdate.TabIndex = 8;
			this.cbLiveUpdate.Text = "Live Update";
			this.cbLiveUpdate.UseVisualStyleBackColor = true;
			this.cbLiveUpdate.CheckedChanged += new System.EventHandler(this.cbLiveUpdate_CheckedChanged);
			// 
			// cmdUpdateNow
			// 
			this.cmdUpdateNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdUpdateNow.Location = new System.Drawing.Point(584, 65);
			this.cmdUpdateNow.Name = "cmdUpdateNow";
			this.cmdUpdateNow.Size = new System.Drawing.Size(95, 23);
			this.cmdUpdateNow.TabIndex = 9;
			this.cmdUpdateNow.Text = "Update Now";
			this.cmdUpdateNow.UseVisualStyleBackColor = true;
			this.cmdUpdateNow.Click += new System.EventHandler(this.cmdUpdateNow_Click);
			// 
			// cbCaseInsensitive
			// 
			this.cbCaseInsensitive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCaseInsensitive.AutoSize = true;
			this.cbCaseInsensitive.Location = new System.Drawing.Point(585, 15);
			this.cbCaseInsensitive.Name = "cbCaseInsensitive";
			this.cbCaseInsensitive.Size = new System.Drawing.Size(107, 17);
			this.cbCaseInsensitive.TabIndex = 10;
			this.cbCaseInsensitive.Text = "Case Insensetive";
			this.cbCaseInsensitive.UseVisualStyleBackColor = true;
			this.cbCaseInsensitive.CheckedChanged += new System.EventHandler(this.cbCaseInsensitive_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(236, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Group: ";
			// 
			// lblGroupName
			// 
			this.lblGroupName.AutoSize = true;
			this.lblGroupName.Location = new System.Drawing.Point(284, 114);
			this.lblGroupName.Name = "lblGroupName";
			this.lblGroupName.Size = new System.Drawing.Size(0, 13);
			this.lblGroupName.TabIndex = 12;
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(13, 120);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(0, 13);
			this.lblTime.TabIndex = 13;
			// 
			// cmdUnfilter
			// 
			this.cmdUnfilter.Location = new System.Drawing.Point(12, 109);
			this.cmdUnfilter.Name = "cmdUnfilter";
			this.cmdUnfilter.Size = new System.Drawing.Size(75, 23);
			this.cmdUnfilter.TabIndex = 14;
			this.cmdUnfilter.Text = "Unfilter (0)";
			this.cmdUnfilter.UseVisualStyleBackColor = true;
			this.cmdUnfilter.Click += new System.EventHandler(this.cmdUnfilter_Click);
			// 
			// cmdFilter
			// 
			this.cmdFilter.Location = new System.Drawing.Point(93, 110);
			this.cmdFilter.Name = "cmdFilter";
			this.cmdFilter.Size = new System.Drawing.Size(75, 23);
			this.cmdFilter.TabIndex = 15;
			this.cmdFilter.Text = "Filter";
			this.cmdFilter.UseVisualStyleBackColor = true;
			this.cmdFilter.Click += new System.EventHandler(this.cmdFilter_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.CausesValidation = false;
			this.label4.Location = new System.Drawing.Point(12, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Encoded";
			// 
			// tbEncodedRegex
			// 
			this.tbEncodedRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbEncodedRegex.Location = new System.Drawing.Point(69, 40);
			this.tbEncodedRegex.Name = "tbEncodedRegex";
			this.tbEncodedRegex.Size = new System.Drawing.Size(509, 20);
			this.tbEncodedRegex.TabIndex = 17;
			this.tbEncodedRegex.TextChanged += new System.EventHandler(this.tbEncodedRegex_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 443);
			this.Controls.Add(this.tbEncodedRegex);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmdFilter);
			this.Controls.Add(this.cmdUnfilter);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.lblGroupName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbCaseInsensitive);
			this.Controls.Add(this.cmdUpdateNow);
			this.Controls.Add(this.cbLiveUpdate);
			this.Controls.Add(this.lblGroups);
			this.Controls.Add(this.lblMatches);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbGroups);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.tbRegex);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.tbGroups)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRegex;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TrackBar tbGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.CheckBox cbLiveUpdate;
        private System.Windows.Forms.Button cmdUpdateNow;
        private System.Windows.Forms.CheckBox cbCaseInsensitive;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblGroupName;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Button cmdUnfilter;
		private System.Windows.Forms.Button cmdFilter;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbEncodedRegex;
    }
}

