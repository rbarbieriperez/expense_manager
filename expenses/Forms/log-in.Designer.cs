
namespace gastos.Forms
{
    partial class log_in
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
            this.user_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ingresar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_box
            // 
            this.user_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_box.Location = new System.Drawing.Point(95, 154);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(211, 30);
            this.user_box.TabIndex = 0;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.Location = new System.Drawing.Point(95, 228);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(211, 30);
            this.password_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // ingresar_btn
            // 
            this.ingresar_btn.BackColor = System.Drawing.Color.SlateGray;
            this.ingresar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresar_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar_btn.ForeColor = System.Drawing.Color.White;
            this.ingresar_btn.Location = new System.Drawing.Point(124, 311);
            this.ingresar_btn.Name = "ingresar_btn";
            this.ingresar_btn.Size = new System.Drawing.Size(143, 39);
            this.ingresar_btn.TabIndex = 4;
            this.ingresar_btn.Text = "INGRESAR";
            this.ingresar_btn.UseVisualStyleBackColor = false;
            this.ingresar_btn.Click += new System.EventHandler(this.ingresar_btn_Click);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(405, 527);
            this.Controls.Add(this.ingresar_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.user_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "log_in";
            this.Text = "log_in";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.log_in_FormClosing);
            this.Load += new System.EventHandler(this.log_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ingresar_btn;
    }
}