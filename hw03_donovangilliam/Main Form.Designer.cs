namespace hw03_donovangilliam
{
    partial class MainForm
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
            this.lbl_listofcars = new System.Windows.Forms.Label();
            this.LB_vinlist = new System.Windows.Forms.ListBox();
            this.btn_addcars = new System.Windows.Forms.Button();
            this.btn_updatecars = new System.Windows.Forms.Button();
            this.btn_deletecars = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_listofcars
            // 
            this.lbl_listofcars.AutoSize = true;
            this.lbl_listofcars.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listofcars.Location = new System.Drawing.Point(296, 20);
            this.lbl_listofcars.Name = "lbl_listofcars";
            this.lbl_listofcars.Size = new System.Drawing.Size(180, 37);
            this.lbl_listofcars.TabIndex = 0;
            this.lbl_listofcars.Text = "List of Cars";
            // 
            // LB_vinlist
            // 
            this.LB_vinlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_vinlist.FormattingEnabled = true;
            this.LB_vinlist.ItemHeight = 24;
            this.LB_vinlist.Location = new System.Drawing.Point(235, 60);
            this.LB_vinlist.Name = "LB_vinlist";
            this.LB_vinlist.Size = new System.Drawing.Size(314, 364);
            this.LB_vinlist.TabIndex = 1;
            this.LB_vinlist.DoubleClick += new System.EventHandler(this.LB_vinlist_DoubleClick);
            // 
            // btn_addcars
            // 
            this.btn_addcars.Location = new System.Drawing.Point(555, 60);
            this.btn_addcars.Name = "btn_addcars";
            this.btn_addcars.Size = new System.Drawing.Size(163, 72);
            this.btn_addcars.TabIndex = 2;
            this.btn_addcars.Text = "Add Cars";
            this.btn_addcars.UseVisualStyleBackColor = true;
            this.btn_addcars.Click += new System.EventHandler(this.btn_addcars_Click);
            // 
            // btn_updatecars
            // 
            this.btn_updatecars.Location = new System.Drawing.Point(555, 138);
            this.btn_updatecars.Name = "btn_updatecars";
            this.btn_updatecars.Size = new System.Drawing.Size(163, 72);
            this.btn_updatecars.TabIndex = 3;
            this.btn_updatecars.Text = "Update Cars";
            this.btn_updatecars.UseVisualStyleBackColor = true;
            this.btn_updatecars.Click += new System.EventHandler(this.btn_updatecars_Click);
            // 
            // btn_deletecars
            // 
            this.btn_deletecars.Location = new System.Drawing.Point(555, 216);
            this.btn_deletecars.Name = "btn_deletecars";
            this.btn_deletecars.Size = new System.Drawing.Size(163, 72);
            this.btn_deletecars.TabIndex = 4;
            this.btn_deletecars.Text = "Delete Cars";
            this.btn_deletecars.UseVisualStyleBackColor = true;
            this.btn_deletecars.Click += new System.EventHandler(this.btn_deletecars_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_deletecars);
            this.Controls.Add(this.btn_updatecars);
            this.Controls.Add(this.btn_addcars);
            this.Controls.Add(this.LB_vinlist);
            this.Controls.Add(this.lbl_listofcars);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_listofcars;
        private System.Windows.Forms.ListBox LB_vinlist;
        private System.Windows.Forms.Button btn_addcars;
        private System.Windows.Forms.Button btn_updatecars;
        private System.Windows.Forms.Button btn_deletecars;
    }
}

