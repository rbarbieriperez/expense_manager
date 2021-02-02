
namespace gastos.Forms
{
    partial class InsertExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertExpenses));
            this.fecha_picker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.importe_box = new System.Windows.Forms.TextBox();
            this.descripcion_box = new System.Windows.Forms.TextBox();
            this.lugar_box = new System.Windows.Forms.TextBox();
            this.GuardarToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.insertar_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.insertar_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha_picker
            // 
            this.fecha_picker.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_picker.Location = new System.Drawing.Point(464, 150);
            this.fecha_picker.Name = "fecha_picker";
            this.fecha_picker.Size = new System.Drawing.Size(200, 30);
            this.fecha_picker.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lugar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Importe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha:";
            // 
            // importe_box
            // 
            this.importe_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importe_box.Location = new System.Drawing.Point(464, 300);
            this.importe_box.Name = "importe_box";
            this.importe_box.Size = new System.Drawing.Size(200, 30);
            this.importe_box.TabIndex = 14;
            // 
            // descripcion_box
            // 
            this.descripcion_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descripcion_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_box.Location = new System.Drawing.Point(464, 252);
            this.descripcion_box.Name = "descripcion_box";
            this.descripcion_box.Size = new System.Drawing.Size(200, 30);
            this.descripcion_box.TabIndex = 13;
            // 
            // lugar_box
            // 
            this.lugar_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lugar_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugar_box.Location = new System.Drawing.Point(464, 197);
            this.lugar_box.Name = "lugar_box";
            this.lugar_box.Size = new System.Drawing.Size(200, 30);
            this.lugar_box.TabIndex = 12;
            // 
            // insertar_btn
            // 
            this.insertar_btn.Image = ((System.Drawing.Image)(resources.GetObject("insertar_btn.Image")));
            this.insertar_btn.Location = new System.Drawing.Point(517, 356);
            this.insertar_btn.Name = "insertar_btn";
            this.insertar_btn.Size = new System.Drawing.Size(82, 66);
            this.insertar_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.insertar_btn.TabIndex = 20;
            this.insertar_btn.TabStop = false;
            this.insertar_btn.Click += new System.EventHandler(this.insertar_btn_Click);
            this.insertar_btn.MouseEnter += new System.EventHandler(this.insertar_btn_MouseEnter);
            this.insertar_btn.MouseLeave += new System.EventHandler(this.insertar_btn_MouseLeave);
            // 
            // InsertExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1086, 581);
            this.Controls.Add(this.insertar_btn);
            this.Controls.Add(this.fecha_picker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.importe_box);
            this.Controls.Add(this.descripcion_box);
            this.Controls.Add(this.lugar_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertExpenses";
            this.Text = "InsertExpenses";
            this.Load += new System.EventHandler(this.InsertExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insertar_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha_picker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox importe_box;
        private System.Windows.Forms.TextBox descripcion_box;
        private System.Windows.Forms.TextBox lugar_box;
        private System.Windows.Forms.ToolTip GuardarToolTip;
        private System.Windows.Forms.PictureBox insertar_btn;
    }
}