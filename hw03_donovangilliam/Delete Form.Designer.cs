namespace hw03_donovangilliam
{
    partial class DeleteForm
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
            this.lbl_vin = new System.Windows.Forms.Label();
            this.pnl_deleteform = new System.Windows.Forms.Panel();
            this.lbl_allfields = new System.Windows.Forms.Label();
            this.txt_deletevin = new System.Windows.Forms.TextBox();
            this.btn_deletecar = new System.Windows.Forms.Button();
            this.lbl_vinnoexist = new System.Windows.Forms.Label();
            this.pnl_deleteform.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_vin
            // 
            this.lbl_vin.AutoSize = true;
            this.lbl_vin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vin.Location = new System.Drawing.Point(225, 95);
            this.lbl_vin.Name = "lbl_vin";
            this.lbl_vin.Size = new System.Drawing.Size(79, 20);
            this.lbl_vin.TabIndex = 0;
            this.lbl_vin.Text = "Enter VIN";
            // 
            // pnl_deleteform
            // 
            this.pnl_deleteform.Controls.Add(this.lbl_allfields);
            this.pnl_deleteform.Controls.Add(this.txt_deletevin);
            this.pnl_deleteform.Location = new System.Drawing.Point(166, 135);
            this.pnl_deleteform.Name = "pnl_deleteform";
            this.pnl_deleteform.Size = new System.Drawing.Size(200, 100);
            this.pnl_deleteform.TabIndex = 1;
            // 
            // lbl_allfields
            // 
            this.lbl_allfields.AutoSize = true;
            this.lbl_allfields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_allfields.ForeColor = System.Drawing.Color.Red;
            this.lbl_allfields.Location = new System.Drawing.Point(27, 26);
            this.lbl_allfields.Name = "lbl_allfields";
            this.lbl_allfields.Size = new System.Drawing.Size(154, 16);
            this.lbl_allfields.TabIndex = 16;
            this.lbl_allfields.Text = "All fields must be filled in.";
            this.lbl_allfields.Visible = false;
            // 
            // txt_deletevin
            // 
            this.txt_deletevin.Location = new System.Drawing.Point(52, 3);
            this.txt_deletevin.Name = "txt_deletevin";
            this.txt_deletevin.Size = new System.Drawing.Size(100, 20);
            this.txt_deletevin.TabIndex = 0;
            // 
            // btn_deletecar
            // 
            this.btn_deletecar.Location = new System.Drawing.Point(185, 250);
            this.btn_deletecar.Name = "btn_deletecar";
            this.btn_deletecar.Size = new System.Drawing.Size(162, 97);
            this.btn_deletecar.TabIndex = 17;
            this.btn_deletecar.Text = "Delete Car";
            this.btn_deletecar.UseVisualStyleBackColor = true;
            this.btn_deletecar.Click += new System.EventHandler(this.btn_deletecar_Click);
            // 
            // lbl_vinnoexist
            // 
            this.lbl_vinnoexist.AutoSize = true;
            this.lbl_vinnoexist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vinnoexist.ForeColor = System.Drawing.Color.Red;
            this.lbl_vinnoexist.Location = new System.Drawing.Point(324, 139);
            this.lbl_vinnoexist.Name = "lbl_vinnoexist";
            this.lbl_vinnoexist.Size = new System.Drawing.Size(117, 16);
            this.lbl_vinnoexist.TabIndex = 17;
            this.lbl_vinnoexist.Text = "VIN does not exist.";
            this.lbl_vinnoexist.Visible = false;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 502);
            this.Controls.Add(this.lbl_vinnoexist);
            this.Controls.Add(this.btn_deletecar);
            this.Controls.Add(this.pnl_deleteform);
            this.Controls.Add(this.lbl_vin);
            this.Name = "DeleteForm";
            this.Text = "Delete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteForm_FormClosing);
            this.pnl_deleteform.ResumeLayout(false);
            this.pnl_deleteform.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_vin;
        private System.Windows.Forms.Panel pnl_deleteform;
        private System.Windows.Forms.TextBox txt_deletevin;
        private System.Windows.Forms.Label lbl_allfields;
        private System.Windows.Forms.Button btn_deletecar;
        private System.Windows.Forms.Label lbl_vinnoexist;
    }
}