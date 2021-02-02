
namespace gastos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FormContainer = new System.Windows.Forms.Panel();
            this.BtnContainer = new System.Windows.Forms.Panel();
            this.ListRegistersBtn = new System.Windows.Forms.PictureBox();
            this.add_btn = new System.Windows.Forms.PictureBox();
            this.top_bar = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.AddBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ListRegisterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrar_Top = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimir_top = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.informacion_top = new System.Windows.Forms.ToolStripMenuItem();
            this.config_btn = new System.Windows.Forms.PictureBox();
            this.BtnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListRegistersBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_bar)).BeginInit();
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // FormContainer
            // 
            this.FormContainer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FormContainer.Location = new System.Drawing.Point(87, 67);
            this.FormContainer.Name = "FormContainer";
            this.FormContainer.Size = new System.Drawing.Size(1086, 564);
            this.FormContainer.TabIndex = 11;
            // 
            // BtnContainer
            // 
            this.BtnContainer.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnContainer.Controls.Add(this.config_btn);
            this.BtnContainer.Controls.Add(this.ListRegistersBtn);
            this.BtnContainer.Controls.Add(this.add_btn);
            this.BtnContainer.Location = new System.Drawing.Point(-2, 24);
            this.BtnContainer.Name = "BtnContainer";
            this.BtnContainer.Size = new System.Drawing.Size(92, 607);
            this.BtnContainer.TabIndex = 12;
            // 
            // ListRegistersBtn
            // 
            this.ListRegistersBtn.Image = ((System.Drawing.Image)(resources.GetObject("ListRegistersBtn.Image")));
            this.ListRegistersBtn.Location = new System.Drawing.Point(0, 219);
            this.ListRegistersBtn.Name = "ListRegistersBtn";
            this.ListRegistersBtn.Size = new System.Drawing.Size(92, 67);
            this.ListRegistersBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ListRegistersBtn.TabIndex = 1;
            this.ListRegistersBtn.TabStop = false;
            this.ListRegistersBtn.Click += new System.EventHandler(this.ListRegistersBtn_Click);
            this.ListRegistersBtn.MouseEnter += new System.EventHandler(this.ListRegistersBtn_MouseEnter);
            this.ListRegistersBtn.MouseLeave += new System.EventHandler(this.ListRegistersBtn_MouseLeave);
            // 
            // add_btn
            // 
            this.add_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_btn.Image")));
            this.add_btn.Location = new System.Drawing.Point(3, 145);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(89, 68);
            this.add_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_btn.TabIndex = 0;
            this.add_btn.TabStop = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            this.add_btn.MouseEnter += new System.EventHandler(this.add_btn_MouseEnter);
            this.add_btn.MouseLeave += new System.EventHandler(this.add_btn_MouseLeave);
            // 
            // top_bar
            // 
            this.top_bar.BackColor = System.Drawing.Color.MidnightBlue;
            this.top_bar.Location = new System.Drawing.Point(87, 24);
            this.top_bar.Name = "top_bar";
            this.top_bar.Size = new System.Drawing.Size(1086, 50);
            this.top_bar.TabIndex = 13;
            this.top_bar.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.BackColor = System.Drawing.Color.MidnightBlue;
            this.label_title.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(417, 36);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(470, 28);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "SISTEMA DE CONTROL DE GASTOS";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.TopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1172, 28);
            this.TopMenu.TabIndex = 14;
            this.TopMenu.Text = "TopMenu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrar_Top,
            this.imprimir_top,
            this.informacion_top});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrar_Top
            // 
            this.cerrar_Top.Name = "cerrar_Top";
            this.cerrar_Top.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.cerrar_Top.Size = new System.Drawing.Size(224, 26);
            this.cerrar_Top.Text = "Cerrar";
            this.cerrar_Top.Click += new System.EventHandler(this.cerrar_Top_Click);
            // 
            // imprimir_top
            // 
            this.imprimir_top.Name = "imprimir_top";
            this.imprimir_top.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimir_top.Size = new System.Drawing.Size(224, 26);
            this.imprimir_top.Text = "Imprimir";
            this.imprimir_top.Click += new System.EventHandler(this.imprimir_top_Click);
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // informacion_top
            // 
            this.informacion_top.Name = "informacion_top";
            this.informacion_top.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.informacion_top.Size = new System.Drawing.Size(224, 26);
            this.informacion_top.Text = "Información";
            // 
            // config_btn
            // 
            this.config_btn.Image = ((System.Drawing.Image)(resources.GetObject("config_btn.Image")));
            this.config_btn.Location = new System.Drawing.Point(14, 540);
            this.config_btn.Name = "config_btn";
            this.config_btn.Size = new System.Drawing.Size(58, 50);
            this.config_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.config_btn.TabIndex = 2;
            this.config_btn.TabStop = false;
            this.config_btn.Click += new System.EventHandler(this.config_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1172, 626);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.BtnContainer);
            this.Controls.Add(this.top_bar);
            this.Controls.Add(this.FormContainer);
            this.Controls.Add(this.TopMenu);
            this.MainMenuStrip = this.TopMenu;
            this.Name = "Form1";
            this.Text = "Ingresar Gasto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BtnContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListRegistersBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_bar)).EndInit();
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormContainer;
        private System.Windows.Forms.Panel BtnContainer;
        private System.Windows.Forms.PictureBox add_btn;
        private System.Windows.Forms.PictureBox top_bar;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox ListRegistersBtn;
        private System.Windows.Forms.ToolTip AddBtnToolTip;
        private System.Windows.Forms.ToolTip ListRegisterToolTip;
        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrar_Top;
        private System.Windows.Forms.ToolStripMenuItem imprimir_top;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem informacion_top;
        private System.Windows.Forms.PictureBox config_btn;
    }
}

