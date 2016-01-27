namespace Times_table
{
    partial class frm_timesTable
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
            this.lst_output = new System.Windows.Forms.ListBox();
            this.lbl_Mult = new System.Windows.Forms.Label();
            this.Btn_mult = new System.Windows.Forms.Button();
            this.txt_mult = new System.Windows.Forms.TextBox();
            this.lbl_End = new System.Windows.Forms.Label();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.txt_End = new System.Windows.Forms.TextBox();
            this.txt_Start = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_output
            // 
            this.lst_output.FormattingEnabled = true;
            this.lst_output.Location = new System.Drawing.Point(12, 106);
            this.lst_output.Name = "lst_output";
            this.lst_output.Size = new System.Drawing.Size(260, 134);
            this.lst_output.TabIndex = 0;
            // 
            // lbl_Mult
            // 
            this.lbl_Mult.AutoSize = true;
            this.lbl_Mult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mult.ForeColor = System.Drawing.Color.White;
            this.lbl_Mult.Location = new System.Drawing.Point(12, 49);
            this.lbl_Mult.Name = "lbl_Mult";
            this.lbl_Mult.Size = new System.Drawing.Size(71, 20);
            this.lbl_Mult.TabIndex = 1;
            this.lbl_Mult.Text = "Operand";
            // 
            // Btn_mult
            // 
            this.Btn_mult.Location = new System.Drawing.Point(76, 77);
            this.Btn_mult.Name = "Btn_mult";
            this.Btn_mult.Size = new System.Drawing.Size(58, 23);
            this.Btn_mult.TabIndex = 4;
            this.Btn_mult.Text = "Multiply";
            this.Btn_mult.UseVisualStyleBackColor = true;
            this.Btn_mult.Click += new System.EventHandler(this.Btn_Operation_Click);
            // 
            // txt_mult
            // 
            this.txt_mult.Location = new System.Drawing.Point(89, 51);
            this.txt_mult.Name = "txt_mult";
            this.txt_mult.Size = new System.Drawing.Size(183, 20);
            this.txt_mult.TabIndex = 3;
            // 
            // lbl_End
            // 
            this.lbl_End.AutoSize = true;
            this.lbl_End.BackColor = System.Drawing.Color.Transparent;
            this.lbl_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_End.ForeColor = System.Drawing.Color.White;
            this.lbl_End.Location = new System.Drawing.Point(12, 29);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Size = new System.Drawing.Size(38, 20);
            this.lbl_End.TabIndex = 4;
            this.lbl_End.Text = "End";
            // 
            // lbl_Start
            // 
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Start.ForeColor = System.Drawing.Color.White;
            this.lbl_Start.Location = new System.Drawing.Point(12, 9);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(44, 20);
            this.lbl_Start.TabIndex = 5;
            this.lbl_Start.Text = "Start";
            // 
            // txt_End
            // 
            this.txt_End.Location = new System.Drawing.Point(89, 31);
            this.txt_End.Name = "txt_End";
            this.txt_End.Size = new System.Drawing.Size(183, 20);
            this.txt_End.TabIndex = 2;
            // 
            // txt_Start
            // 
            this.txt_Start.Location = new System.Drawing.Point(89, 9);
            this.txt_Start.Name = "txt_Start";
            this.txt_Start.Size = new System.Drawing.Size(183, 20);
            this.txt_Start.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 77);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(58, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(150, 77);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(58, 23);
            this.btnSubtract.TabIndex = 7;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(214, 77);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(58, 23);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(12, 246);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(260, 35);
            this.btn_clr.TabIndex = 9;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // frm_timesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Times_table.Properties.Resources.black_gradient_background;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_Start);
            this.Controls.Add(this.txt_End);
            this.Controls.Add(this.lbl_Start);
            this.Controls.Add(this.lbl_End);
            this.Controls.Add(this.txt_mult);
            this.Controls.Add(this.Btn_mult);
            this.Controls.Add(this.lbl_Mult);
            this.Controls.Add(this.lst_output);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_timesTable";
            this.Text = "Times Table Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_output;
        private System.Windows.Forms.Label lbl_Mult;
        private System.Windows.Forms.Button Btn_mult;
        private System.Windows.Forms.TextBox txt_mult;
        private System.Windows.Forms.Label lbl_End;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.TextBox txt_End;
        private System.Windows.Forms.TextBox txt_Start;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn_clr;
    }
}

