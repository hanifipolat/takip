﻿namespace takip
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(goster));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.takipDataSet12 = new takip.takipDataSet12();
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
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btndelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.musteriTableAdapter = new takip.takipDataSet12TableAdapters.musteriTableAdapter();
            this.takipDataSet12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnedit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takipDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takipDataSet12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedit)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.musteriBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btndelete,
            this.btnedit});
            this.gridControl1.Size = new System.Drawing.Size(1113, 602);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "musteri";
            this.musteriBindingSource.DataSource = this.takipDataSet12;
            // 
            // takipDataSet12
            // 
            this.takipDataSet12.DataSetName = "takipDataSet12";
            this.takipDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Gruplamak istediğiniz kolonu sürükleyiniz.";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ClearFindOnClose = false;
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // coladi
            // 
            this.coladi.Caption = "Adi";
            this.coladi.FieldName = "adi";
            this.coladi.Name = "coladi";
            this.coladi.Visible = true;
            this.coladi.VisibleIndex = 0;
            // 
            // coltelefon
            // 
            this.coltelefon.Caption = "Telefon No";
            this.coltelefon.FieldName = "telefon";
            this.coltelefon.Name = "coltelefon";
            this.coltelefon.Visible = true;
            this.coltelefon.VisibleIndex = 1;
            // 
            // colmail
            // 
            this.colmail.Caption = "Mail Adresi";
            this.colmail.FieldName = "mail";
            this.colmail.Name = "colmail";
            this.colmail.Visible = true;
            this.colmail.VisibleIndex = 2;
            // 
            // coladres
            // 
            this.coladres.Caption = "Adres";
            this.coladres.FieldName = "adres";
            this.coladres.Name = "coladres";
            this.coladres.Visible = true;
            this.coladres.VisibleIndex = 3;
            // 
            // colhosting
            // 
            this.colhosting.Caption = "Hosting";
            this.colhosting.FieldName = "hosting";
            this.colhosting.Name = "colhosting";
            this.colhosting.Visible = true;
            this.colhosting.VisibleIndex = 4;
            // 
            // colalanadi
            // 
            this.colalanadi.Caption = "Alan Adi";
            this.colalanadi.FieldName = "alanadi";
            this.colalanadi.Name = "colalanadi";
            this.colalanadi.Visible = true;
            this.colalanadi.VisibleIndex = 5;
            // 
            // colyazilim
            // 
            this.colyazilim.Caption = "Yazilim";
            this.colyazilim.FieldName = "yazilim";
            this.colyazilim.Name = "colyazilim";
            this.colyazilim.Visible = true;
            this.colyazilim.VisibleIndex = 6;
            // 
            // colsure
            // 
            this.colsure.Caption = "Bitiş Süresi";
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
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "tutar";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sil";
            this.gridColumn3.ColumnEdit = this.btndelete;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 10;
            // 
            // btndelete
            // 
            this.btndelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btndelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btndelete.Name = "btndelete";
            this.btndelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btndelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btndelete_ButtonClick);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // takipDataSet12BindingSource
            // 
            this.takipDataSet12BindingSource.DataSource = this.takipDataSet12;
            this.takipDataSet12BindingSource.Position = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Düzenle";
            this.gridColumn4.ColumnEdit = this.btnedit;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 11;
            // 
            // btnedit
            // 
            this.btnedit.AutoHeight = false;
            this.btnedit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnedit.Name = "btnedit";
            this.btnedit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // goster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 602);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "goster";
            this.Text = "goster";
            this.Load += new System.EventHandler(this.goster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takipDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takipDataSet12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnedit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private takipDataSet12 takipDataSet12;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private takipDataSet12TableAdapters.musteriTableAdapter musteriTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btndelete;
        private System.Windows.Forms.BindingSource takipDataSet12BindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnedit;
    }
}