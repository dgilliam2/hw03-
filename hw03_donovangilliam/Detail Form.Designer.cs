namespace hw03_donovangilliam
{
    partial class DetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_vin = new System.Windows.Forms.Label();
            this.lbl_make = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Details";
            // 
            // lbl_vin
            // 
            this.lbl_vin.AutoSize = true;
            this.lbl_vin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vin.Location = new System.Drawing.Point(106, 105);
            this.lbl_vin.Name = "lbl_vin";
            this.lbl_vin.Size = new System.Drawing.Size(64, 29);
            this.lbl_vin.TabIndex = 1;
            this.lbl_vin.Text = "VIN: ";
            // 
            // lbl_make
            // 
            this.lbl_make.AutoSize = true;
            this.lbl_make.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_make.Location = new System.Drawing.Point(106, 134);
            this.lbl_make.Name = "lbl_make";
            this.lbl_make.Size = new System.Drawing.Size(84, 29);
            this.lbl_make.TabIndex = 2;
            this.lbl_make.Text = "Make: ";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(106, 163);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(93, 29);
            this.lbl_model.TabIndex = 3;
            this.lbl_model.Text = "Model: ";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.Location = new System.Drawing.Point(106, 192);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(76, 29);
            this.lbl_year.TabIndex = 4;
            this.lbl_year.Text = "Year: ";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.Location = new System.Drawing.Point(106, 221);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(84, 29);
            this.lbl_color.TabIndex = 5;
            this.lbl_color.Text = "Color: ";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_make);
            this.Controls.Add(this.lbl_vin);
            this.Controls.Add(this.label1);
            this.Name = "DetailForm";
            this.Text = "Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_vin;
        private System.Windows.Forms.Label lbl_make;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_color;
    }
}