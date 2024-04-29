namespace hw03_donovangilliam
{
    partial class AddForm
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
            this.btn_addcar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_allfields = new System.Windows.Forms.Label();
            this.pnl_addform = new System.Windows.Forms.Panel();
            this.txt_vin = new System.Windows.Forms.TextBox();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.lbl_vinunique = new System.Windows.Forms.Label();
            this.pnl_addform.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addcar
            // 
            this.btn_addcar.Location = new System.Drawing.Point(89, 287);
            this.btn_addcar.Name = "btn_addcar";
            this.btn_addcar.Size = new System.Drawing.Size(148, 65);
            this.btn_addcar.TabIndex = 5;
            this.btn_addcar.Text = "Add Car";
            this.btn_addcar.UseVisualStyleBackColor = true;
            this.btn_addcar.Click += new System.EventHandler(this.btn_addcar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "VIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color:";
            // 
            // lbl_allfields
            // 
            this.lbl_allfields.AutoSize = true;
            this.lbl_allfields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_allfields.ForeColor = System.Drawing.Color.Red;
            this.lbl_allfields.Location = new System.Drawing.Point(103, 271);
            this.lbl_allfields.Name = "lbl_allfields";
            this.lbl_allfields.Size = new System.Drawing.Size(123, 13);
            this.lbl_allfields.TabIndex = 11;
            this.lbl_allfields.Text = "All fields must be filled in.";
            this.lbl_allfields.Visible = false;
            // 
            // pnl_addform
            // 
            this.pnl_addform.Controls.Add(this.lbl_vinunique);
            this.pnl_addform.Controls.Add(this.txt_color);
            this.pnl_addform.Controls.Add(this.txt_year);
            this.pnl_addform.Controls.Add(this.txt_model);
            this.pnl_addform.Controls.Add(this.txt_make);
            this.pnl_addform.Controls.Add(this.txt_vin);
            this.pnl_addform.Location = new System.Drawing.Point(0, 0);
            this.pnl_addform.Name = "pnl_addform";
            this.pnl_addform.Size = new System.Drawing.Size(325, 256);
            this.pnl_addform.TabIndex = 12;
            // 
            // txt_vin
            // 
            this.txt_vin.Location = new System.Drawing.Point(89, 76);
            this.txt_vin.Name = "txt_vin";
            this.txt_vin.Size = new System.Drawing.Size(148, 20);
            this.txt_vin.TabIndex = 13;
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(89, 105);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(148, 20);
            this.txt_make.TabIndex = 14;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(89, 131);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(148, 20);
            this.txt_model.TabIndex = 15;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(89, 157);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(148, 20);
            this.txt_year.TabIndex = 16;
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(89, 183);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(148, 20);
            this.txt_color.TabIndex = 17;
            // 
            // lbl_vinunique
            // 
            this.lbl_vinunique.AutoSize = true;
            this.lbl_vinunique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vinunique.ForeColor = System.Drawing.Color.Red;
            this.lbl_vinunique.Location = new System.Drawing.Point(103, 60);
            this.lbl_vinunique.Name = "lbl_vinunique";
            this.lbl_vinunique.Size = new System.Drawing.Size(103, 13);
            this.lbl_vinunique.TabIndex = 13;
            this.lbl_vinunique.Text = "VIN must be unique.";
            this.lbl_vinunique.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 364);
            this.Controls.Add(this.lbl_allfields);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addcar);
            this.Controls.Add(this.pnl_addform);
            this.Name = "AddForm";
            this.Text = "Add";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing);
            this.pnl_addform.ResumeLayout(false);
            this.pnl_addform.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addcar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_allfields;
        private System.Windows.Forms.Panel pnl_addform;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_make;
        private System.Windows.Forms.TextBox txt_vin;
        private System.Windows.Forms.Label lbl_vinunique;
    }
}