
namespace gastos.Forms
{
    partial class AddNewComerce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewComerce));
            this.nombre_comercio_box = new System.Windows.Forms.TextBox();
            this.departamento_box = new System.Windows.Forms.TextBox();
            this.pais_box = new System.Windows.Forms.TextBox();
            this.contacto_box = new System.Windows.Forms.TextBox();
            this.direccion_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.categorias_box = new System.Windows.Forms.ComboBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.find_btn = new System.Windows.Forms.PictureBox();
            this.find_panel = new System.Windows.Forms.Panel();
            this.find_tip = new System.Windows.Forms.ToolTip(this.components);
            this.reset_tip = new System.Windows.Forms.ToolTip(this.components);
            this.agregar_tip = new System.Windows.Forms.ToolTip(this.components);
            this.panel_delete = new System.Windows.Forms.Panel();
            this.modificar_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.find_btn)).BeginInit();
            this.find_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre_comercio_box
            // 
            this.nombre_comercio_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre_comercio_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_comercio_box.Location = new System.Drawing.Point(107, 61);
            this.nombre_comercio_box.Name = "nombre_comercio_box";
            this.nombre_comercio_box.Size = new System.Drawing.Size(193, 30);
            this.nombre_comercio_box.TabIndex = 1;
            // 
            // departamento_box
            // 
            this.departamento_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.departamento_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamento_box.Location = new System.Drawing.Point(107, 270);
            this.departamento_box.Name = "departamento_box";
            this.departamento_box.Size = new System.Drawing.Size(193, 30);
            this.departamento_box.TabIndex = 4;
            // 
            // pais_box
            // 
            this.pais_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pais_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pais_box.Location = new System.Drawing.Point(107, 346);
            this.pais_box.Name = "pais_box";
            this.pais_box.Size = new System.Drawing.Size(193, 30);
            this.pais_box.TabIndex = 5;
            // 
            // contacto_box
            // 
            this.contacto_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.contacto_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacto_box.Location = new System.Drawing.Point(107, 422);
            this.contacto_box.MaxLength = 9;
            this.contacto_box.Name = "contacto_box";
            this.contacto_box.Size = new System.Drawing.Size(193, 30);
            this.contacto_box.TabIndex = 6;
            // 
            // direccion_box
            // 
            this.direccion_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.direccion_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_box.Location = new System.Drawing.Point(107, 201);
            this.direccion_box.Name = "direccion_box";
            this.direccion_box.Size = new System.Drawing.Size(193, 30);
            this.direccion_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre del comercio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Categoría:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Departamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "País:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contacto:";
            // 
            // categorias_box
            // 
            this.categorias_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorias_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorias_box.FormattingEnabled = true;
            this.categorias_box.Items.AddRange(new object[] {
            "",
            "BAZAR",
            "COMERCIO",
            "GENERAL",
            "FRUTERIA",
            "TECNOLOGIA"});
            this.categorias_box.Location = new System.Drawing.Point(107, 135);
            this.categorias_box.Name = "categorias_box";
            this.categorias_box.Size = new System.Drawing.Size(193, 32);
            this.categorias_box.TabIndex = 2;
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.ForeColor = System.Drawing.Color.White;
            this.Agregar.Location = new System.Drawing.Point(146, 472);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(109, 50);
            this.Agregar.TabIndex = 7;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // find_btn
            // 
            this.find_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find_btn.Image = ((System.Drawing.Image)(resources.GetObject("find_btn.Image")));
            this.find_btn.Location = new System.Drawing.Point(5, 12);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(41, 30);
            this.find_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.find_btn.TabIndex = 15;
            this.find_btn.TabStop = false;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // find_panel
            // 
            this.find_panel.Controls.Add(this.find_btn);
            this.find_panel.Location = new System.Drawing.Point(306, 52);
            this.find_panel.Name = "find_panel";
            this.find_panel.Size = new System.Drawing.Size(54, 53);
            this.find_panel.TabIndex = 16;
            // 
            // panel_delete
            // 
            this.panel_delete.AutoSize = true;
            this.panel_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_delete.Location = new System.Drawing.Point(322, 388);
            this.panel_delete.Name = "panel_delete";
            this.panel_delete.Size = new System.Drawing.Size(64, 64);
            this.panel_delete.TabIndex = 17;
            // 
            // modificar_panel
            // 
            this.modificar_panel.Location = new System.Drawing.Point(12, 388);
            this.modificar_panel.Name = "modificar_panel";
            this.modificar_panel.Size = new System.Drawing.Size(64, 64);
            this.modificar_panel.TabIndex = 18;
            // 
            // AddNewComerce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(420, 540);
            this.Controls.Add(this.modificar_panel);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.panel_delete);
            this.Controls.Add(this.find_panel);
            this.Controls.Add(this.categorias_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.direccion_box);
            this.Controls.Add(this.contacto_box);
            this.Controls.Add(this.pais_box);
            this.Controls.Add(this.departamento_box);
            this.Controls.Add(this.nombre_comercio_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewComerce";
            this.Text = "Agregar comercio";
            this.Load += new System.EventHandler(this.AddNewComerce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.find_btn)).EndInit();
            this.find_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombre_comercio_box;
        private System.Windows.Forms.TextBox departamento_box;
        private System.Windows.Forms.TextBox pais_box;
        private System.Windows.Forms.TextBox contacto_box;
        private System.Windows.Forms.TextBox direccion_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox categorias_box;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.PictureBox find_btn;
        private System.Windows.Forms.Panel find_panel;
        private System.Windows.Forms.ToolTip find_tip;
        private System.Windows.Forms.ToolTip reset_tip;
        private System.Windows.Forms.ToolTip agregar_tip;
        private System.Windows.Forms.Panel panel_delete;
        private System.Windows.Forms.Panel modificar_panel;
    }
}