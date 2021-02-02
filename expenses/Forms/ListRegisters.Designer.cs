
namespace gastos.Forms
{
    partial class ListRegisters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRegisters));
            this.RegistersGrid = new System.Windows.Forms.DataGridView();
            this.monto_box = new System.Windows.Forms.TextBox();
            this.fecha_box = new System.Windows.Forms.TextBox();
            this.lugar_box = new System.Windows.Forms.TextBox();
            this.descripcion_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.PictureBox();
            this.deleteToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.save_btn = new System.Windows.Forms.PictureBox();
            this.saveToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.total_gastado_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RegistersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistersGrid
            // 
            this.RegistersGrid.AllowUserToAddRows = false;
            this.RegistersGrid.AllowUserToDeleteRows = false;
            this.RegistersGrid.AllowUserToResizeColumns = false;
            this.RegistersGrid.AllowUserToResizeRows = false;
            this.RegistersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistersGrid.Location = new System.Drawing.Point(89, 31);
            this.RegistersGrid.Name = "RegistersGrid";
            this.RegistersGrid.ReadOnly = true;
            this.RegistersGrid.RowHeadersVisible = false;
            this.RegistersGrid.RowHeadersWidth = 51;
            this.RegistersGrid.RowTemplate.Height = 24;
            this.RegistersGrid.Size = new System.Drawing.Size(908, 355);
            this.RegistersGrid.TabIndex = 0;
            this.RegistersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistersGrid_CellClick);
            // 
            // monto_box
            // 
            this.monto_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto_box.Location = new System.Drawing.Point(172, 487);
            this.monto_box.Name = "monto_box";
            this.monto_box.Size = new System.Drawing.Size(192, 30);
            this.monto_box.TabIndex = 1;
            // 
            // fecha_box
            // 
            this.fecha_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_box.Location = new System.Drawing.Point(172, 408);
            this.fecha_box.Name = "fecha_box";
            this.fecha_box.Size = new System.Drawing.Size(192, 30);
            this.fecha_box.TabIndex = 2;
            // 
            // lugar_box
            // 
            this.lugar_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugar_box.Location = new System.Drawing.Point(172, 445);
            this.lugar_box.Name = "lugar_box";
            this.lugar_box.Size = new System.Drawing.Size(192, 30);
            this.lugar_box.TabIndex = 3;
            // 
            // descripcion_box
            // 
            this.descripcion_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_box.Location = new System.Drawing.Point(609, 408);
            this.descripcion_box.Multiline = true;
            this.descripcion_box.Name = "descripcion_box";
            this.descripcion_box.Size = new System.Drawing.Size(388, 104);
            this.descripcion_box.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Importe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lugar:";
            // 
            // delete_btn
            // 
            this.delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.Image")));
            this.delete_btn.Location = new System.Drawing.Point(510, 445);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(68, 66);
            this.delete_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delete_btn.TabIndex = 9;
            this.delete_btn.TabStop = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
            this.save_btn.Location = new System.Drawing.Point(418, 445);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(70, 66);
            this.save_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.save_btn.TabIndex = 10;
            this.save_btn.TabStop = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOTAL GASTADO:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_gastado_lbl
            // 
            this.total_gastado_lbl.AutoSize = true;
            this.total_gastado_lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_gastado_lbl.Location = new System.Drawing.Point(523, 526);
            this.total_gastado_lbl.Name = "total_gastado_lbl";
            this.total_gastado_lbl.Size = new System.Drawing.Size(19, 24);
            this.total_gastado_lbl.TabIndex = 12;
            this.total_gastado_lbl.Text = "0";
            // 
            // ListRegisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1068, 559);
            this.Controls.Add(this.total_gastado_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descripcion_box);
            this.Controls.Add(this.lugar_box);
            this.Controls.Add(this.fecha_box);
            this.Controls.Add(this.monto_box);
            this.Controls.Add(this.RegistersGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListRegisters";
            this.Text = "ListRegisters";
            this.Load += new System.EventHandler(this.ListRegisters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RegistersGrid;
        private System.Windows.Forms.TextBox monto_box;
        private System.Windows.Forms.TextBox fecha_box;
        private System.Windows.Forms.TextBox lugar_box;
        private System.Windows.Forms.TextBox descripcion_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox delete_btn;
        private System.Windows.Forms.ToolTip deleteToolTip;
        private System.Windows.Forms.PictureBox save_btn;
        private System.Windows.Forms.ToolTip saveToolTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total_gastado_lbl;
    }
}