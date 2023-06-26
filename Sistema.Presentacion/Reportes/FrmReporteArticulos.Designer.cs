
namespace Sistema.Presentacion.Reportes
{
    partial class FrmReporteArticulos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvArticulos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsSistema = new Sistema.Presentacion.Reportes.dsSistema();
            this.articulo_listarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulo_listarTableAdapter = new Sistema.Presentacion.Reportes.dsSistemaTableAdapters.articulo_listarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulo_listarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvArticulos
            // 
            this.rpvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsArticulo";
            reportDataSource1.Value = this.articulo_listarBindingSource;
            this.rpvArticulos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvArticulos.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.rptArticulos.rdlc";
            this.rpvArticulos.Location = new System.Drawing.Point(0, 0);
            this.rpvArticulos.Name = "rpvArticulos";
            this.rpvArticulos.ServerReport.BearerToken = null;
            this.rpvArticulos.Size = new System.Drawing.Size(800, 450);
            this.rpvArticulos.TabIndex = 0;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "dsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulo_listarBindingSource
            // 
            this.articulo_listarBindingSource.DataMember = "articulo_listar";
            this.articulo_listarBindingSource.DataSource = this.dsSistema;
            // 
            // articulo_listarTableAdapter
            // 
            this.articulo_listarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvArticulos);
            this.Name = "FrmReporteArticulos";
            this.Text = "Reporte Articulos";
            this.Load += new System.EventHandler(this.FrmReporteArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulo_listarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvArticulos;
        private System.Windows.Forms.BindingSource articulo_listarBindingSource;
        private dsSistema dsSistema;
        private dsSistemaTableAdapters.articulo_listarTableAdapter articulo_listarTableAdapter;
    }
}