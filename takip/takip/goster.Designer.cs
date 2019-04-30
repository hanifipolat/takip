namespace takip
{
    partial class goster
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(goster));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coladi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhosting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalanadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyazilim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1113, 602);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_takip_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select * from musteri";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coladi,
            this.coltelefon,
            this.colmail,
            this.coladres,
            this.colhosting,
            this.colalanadi,
            this.colyazilim,
            this.colsure,
            this.colfiyat,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ClearFindOnClose = false;
            // 
            // coladi
            // 
            this.coladi.FieldName = "adi";
            this.coladi.Name = "coladi";
            this.coladi.Visible = true;
            this.coladi.VisibleIndex = 0;
            // 
            // coltelefon
            // 
            this.coltelefon.FieldName = "telefon";
            this.coltelefon.Name = "coltelefon";
            this.coltelefon.Visible = true;
            this.coltelefon.VisibleIndex = 1;
            // 
            // colmail
            // 
            this.colmail.FieldName = "mail";
            this.colmail.Name = "colmail";
            this.colmail.Visible = true;
            this.colmail.VisibleIndex = 2;
            // 
            // coladres
            // 
            this.coladres.FieldName = "adres";
            this.coladres.Name = "coladres";
            this.coladres.Visible = true;
            this.coladres.VisibleIndex = 3;
            // 
            // colhosting
            // 
            this.colhosting.FieldName = "hosting";
            this.colhosting.Name = "colhosting";
            this.colhosting.Visible = true;
            this.colhosting.VisibleIndex = 4;
            // 
            // colalanadi
            // 
            this.colalanadi.FieldName = "alanadi";
            this.colalanadi.Name = "colalanadi";
            this.colalanadi.Visible = true;
            this.colalanadi.VisibleIndex = 5;
            // 
            // colyazilim
            // 
            this.colyazilim.FieldName = "yazilim";
            this.colyazilim.Name = "colyazilim";
            this.colyazilim.Visible = true;
            this.colyazilim.VisibleIndex = 6;
            // 
            // colsure
            // 
            this.colsure.FieldName = "sure";
            this.colsure.Name = "colsure";
            this.colsure.Visible = true;
            this.colsure.VisibleIndex = 7;
            // 
            // colfiyat
            // 
            this.colfiyat.FieldName = "fiyat";
            this.colfiyat.Name = "colfiyat";
            this.colfiyat.Visible = true;
            this.colfiyat.VisibleIndex = 8;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1113, 602);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // goster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 602);
            this.Controls.Add(this.gridSplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "goster";
            this.Text = "goster";
            this.Load += new System.EventHandler(this.goster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn coladi;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colmail;
        private DevExpress.XtraGrid.Columns.GridColumn coladres;
        private DevExpress.XtraGrid.Columns.GridColumn colhosting;
        private DevExpress.XtraGrid.Columns.GridColumn colalanadi;
        private DevExpress.XtraGrid.Columns.GridColumn colyazilim;
        private DevExpress.XtraGrid.Columns.GridColumn colsure;
        private DevExpress.XtraGrid.Columns.GridColumn colfiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
    }
}