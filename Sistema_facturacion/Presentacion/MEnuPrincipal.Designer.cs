namespace Presentacion
{
    partial class FrmMenuPp
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirListadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1102, 28);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClientesToolStripMenuItem,
            this.imprimirListadoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // gestionClientesToolStripMenuItem
            // 
            this.gestionClientesToolStripMenuItem.Name = "gestionClientesToolStripMenuItem";
            this.gestionClientesToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.gestionClientesToolStripMenuItem.Text = "Gestion Clientes";
            // 
            // imprimirListadoToolStripMenuItem
            // 
            this.imprimirListadoToolStripMenuItem.Name = "imprimirListadoToolStripMenuItem";
            this.imprimirListadoToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.imprimirListadoToolStripMenuItem.Text = "Imprimir Listado";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarArticulosToolStripMenuItem,
            this.imprimirListadoToolStripMenuItem1});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // gestionarArticulosToolStripMenuItem
            // 
            this.gestionarArticulosToolStripMenuItem.Name = "gestionarArticulosToolStripMenuItem";
            this.gestionarArticulosToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.gestionarArticulosToolStripMenuItem.Text = "Gestionar Articulos";
            // 
            // imprimirListadoToolStripMenuItem1
            // 
            this.imprimirListadoToolStripMenuItem1.Name = "imprimirListadoToolStripMenuItem1";
            this.imprimirListadoToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.imprimirListadoToolStripMenuItem1.Text = "Imprimir Listado";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarFacturasToolStripMenuItem,
            this.listarFacturasToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // gestionarFacturasToolStripMenuItem
            // 
            this.gestionarFacturasToolStripMenuItem.Name = "gestionarFacturasToolStripMenuItem";
            this.gestionarFacturasToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.gestionarFacturasToolStripMenuItem.Text = "Gestionar Facturas";
            // 
            // listarFacturasToolStripMenuItem
            // 
            this.listarFacturasToolStripMenuItem.Name = "listarFacturasToolStripMenuItem";
            this.listarFacturasToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.listarFacturasToolStripMenuItem.Text = "Listar Facturas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // FrmMenuPp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 733);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "FrmMenuPp";
            this.Text = "FrmMenuPrincipal";
            this.TopMost = true;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirListadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirListadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

