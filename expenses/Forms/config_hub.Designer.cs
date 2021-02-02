
namespace gastos.Forms
{
    partial class config_hub
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(config_hub));
            this.user_picture = new System.Windows.Forms.PictureBox();
            this.user_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.correo_lbl = new System.Windows.Forms.Label();
            this.agregar_comercios_btn = new System.Windows.Forms.Button();
            this.edit_correo_btn = new System.Windows.Forms.PictureBox();
            this.correo_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.user_label = new System.Windows.Forms.Label();
            this.change_correo_tip = new System.Windows.Forms.ToolTip(this.components);
            this.cancel_correo_tip = new System.Windows.Forms.ToolTip(this.components);
            this.edit_correo_tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.user_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_correo_btn)).BeginInit();
            this.correo_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_picture
            // 
            this.user_picture.Image = ((System.Drawing.Image)(resources.GetObject("user_picture.Image")));
            this.user_picture.Location = new System.Drawing.Point(55, 36);
            this.user_picture.Name = "user_picture";
            this.user_picture.Size = new System.Drawing.Size(194, 148);
            this.user_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_picture.TabIndex = 0;
            this.user_picture.TabStop = false;
            this.user_picture.Click += new System.EventHandler(this.user_picture_Click);
            this.user_picture.MouseEnter += new System.EventHandler(this.user_picture_MouseEnter);
            this.user_picture.MouseLeave += new System.EventHandler(this.user_picture_MouseLeave);
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(50, 199);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(223, 29);
            this.user_name.TabIndex = 1;
            this.user_name.Text = "NOMBRE DE USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Menú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Abrir";
            this.openFileDialog.Filter = "*.png|*.jpg";
            // 
            // correo_lbl
            // 
            this.correo_lbl.AutoSize = true;
            this.correo_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.correo_lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_lbl.Location = new System.Drawing.Point(3, 6);
            this.correo_lbl.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.correo_lbl.Name = "correo_lbl";
            this.correo_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.correo_lbl.Size = new System.Drawing.Size(20, 24);
            this.correo_lbl.TabIndex = 6;
            this.correo_lbl.Text = "-";
            // 
            // agregar_comercios_btn
            // 
            this.agregar_comercios_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.agregar_comercios_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar_comercios_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_comercios_btn.ForeColor = System.Drawing.Color.White;
            this.agregar_comercios_btn.Location = new System.Drawing.Point(448, 103);
            this.agregar_comercios_btn.Name = "agregar_comercios_btn";
            this.agregar_comercios_btn.Size = new System.Drawing.Size(271, 52);
            this.agregar_comercios_btn.TabIndex = 7;
            this.agregar_comercios_btn.Text = "Agregar comercios frecuentes";
            this.agregar_comercios_btn.UseVisualStyleBackColor = false;
            this.agregar_comercios_btn.Click += new System.EventHandler(this.agregar_comercios_btn_Click);
            // 
            // edit_correo_btn
            // 
            this.edit_correo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_correo_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.edit_correo_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_correo_btn.Image")));
            this.edit_correo_btn.Location = new System.Drawing.Point(38, 3);
            this.edit_correo_btn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.edit_correo_btn.Name = "edit_correo_btn";
            this.edit_correo_btn.Size = new System.Drawing.Size(39, 24);
            this.edit_correo_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edit_correo_btn.TabIndex = 8;
            this.edit_correo_btn.TabStop = false;
            this.edit_correo_btn.Click += new System.EventHandler(this.edit_correo_btn_Click);
            // 
            // correo_panel
            // 
            this.correo_panel.AutoSize = true;
            this.correo_panel.Controls.Add(this.correo_lbl);
            this.correo_panel.Controls.Add(this.edit_correo_btn);
            this.correo_panel.Location = new System.Drawing.Point(112, 231);
            this.correo_panel.Name = "correo_panel";
            this.correo_panel.Size = new System.Drawing.Size(111, 38);
            this.correo_panel.TabIndex = 10;
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.Location = new System.Drawing.Point(115, 269);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(15, 24);
            this.user_label.TabIndex = 11;
            this.user_label.Text = "-";
            // 
            // config_hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1086, 564);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.correo_panel);
            this.Controls.Add(this.agregar_comercios_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.user_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "config_hub";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "config_hub";
            this.Load += new System.EventHandler(this.config_hub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_correo_btn)).EndInit();
            this.correo_panel.ResumeLayout(false);
            this.correo_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox user_picture;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label correo_lbl;
        private System.Windows.Forms.Button agregar_comercios_btn;
        private System.Windows.Forms.PictureBox edit_correo_btn;
        private System.Windows.Forms.FlowLayoutPanel correo_panel;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.ToolTip change_correo_tip;
        private System.Windows.Forms.ToolTip cancel_correo_tip;
        private System.Windows.Forms.ToolTip edit_correo_tip;
    }
}