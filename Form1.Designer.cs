namespace DWG2DXFReaderNET
{
    partial class Form1
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
            DXFReaderNET.DxfDocument dxfDocument12 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor12 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables12 = new DXFReaderNET.Objects.RasterVariables();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadDWGFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDWGFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDXFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDWGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDXFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomExtentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dxfReaderNETControl1
            // 
            this.dxfReaderNETControl1.AutoSize = true;
            this.dxfReaderNETControl1.ContinuousHighlight = false;
            this.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            dxfDocument12.ActiveLayout = "Model";
            dxfDocument12.Comments = null;
            aciColor12.Index = ((short)(256));
            aciColor12.IsByBlock = false;
            aciColor12.IsByLayer = true;
            aciColor12.UseTrueColor = false;
            dxfDocument12.CurrentColor = aciColor12;
            dxfDocument12.CurrentElevation = 0D;
            dxfDocument12.CurrentLayer = "0";
            dxfDocument12.CurrentLineTypeName = "ByLayer";
            dxfDocument12.CurrentLineTypeScale = 1D;
            dxfDocument12.CurrentTextSize = 2.5D;
            dxfDocument12.CurrentTextStyle = "STANDARD";
            dxfDocument12.CurrentThickness = 0D;
            dxfDocument12.DateCreated = new System.DateTime(2022, 7, 11, 15, 29, 30, 451);
            dxfDocument12.DateLastEdited = new System.DateTime(2022, 7, 11, 15, 29, 30, 451);
            dxfDocument12.Handle = "0";
            dxfDocument12.IsBinary = false;
            dxfDocument12.Modified = false;
            dxfDocument12.Name = null;
            dxfDocument12.Owner = null;
            rasterVariables12.DisplayFrame = true;
            rasterVariables12.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High;
            rasterVariables12.Handle = "2A";
            rasterVariables12.Owner = null;
            rasterVariables12.Units = DXFReaderNET.ImageUnits.Unitless;
            dxfDocument12.RasterVariables = rasterVariables12;
            dxfDocument12.ThumbnailImage = null;
            dxfDocument12.TotalEditTime = new System.DateTime(2022, 7, 11, 0, 0, 0, 0);
            dxfDocument12.TotalEditTimeDays = 0;
            dxfDocument12.UserTimer = new System.DateTime(2022, 7, 11, 0, 0, 0, 0);
            dxfDocument12.UserTimerDays = 0;
            this.dxfReaderNETControl1.DXF = dxfDocument12;
            this.dxfReaderNETControl1.FileName = null;
            this.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta;
            this.dxfReaderNETControl1.HighlightNotContinuous = false;
            this.dxfReaderNETControl1.Location = new System.Drawing.Point(39, 43);
            this.dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            this.dxfReaderNETControl1.ShowAxes = false;
            this.dxfReaderNETControl1.ShowGrid = true;
            this.dxfReaderNETControl1.ShowGridRuler = false;
            this.dxfReaderNETControl1.Size = new System.Drawing.Size(1047, 494);
            this.dxfReaderNETControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDWGFileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadDWGFileToolStripMenuItem
            // 
            this.loadDWGFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDWGFileToolStripMenuItem1,
            this.loadDXFToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveDWGToolStripMenuItem,
            this.saveDXFToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.loadDWGFileToolStripMenuItem.Name = "loadDWGFileToolStripMenuItem";
            this.loadDWGFileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.loadDWGFileToolStripMenuItem.Text = "File";
            // 
            // loadDWGFileToolStripMenuItem1
            // 
            this.loadDWGFileToolStripMenuItem1.Name = "loadDWGFileToolStripMenuItem1";
            this.loadDWGFileToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loadDWGFileToolStripMenuItem1.Text = "Load DWG...";
            this.loadDWGFileToolStripMenuItem1.Click += new System.EventHandler(this.loadDWGFileToolStripMenuItem1_Click);
            // 
            // loadDXFToolStripMenuItem
            // 
            this.loadDXFToolStripMenuItem.Name = "loadDXFToolStripMenuItem";
            this.loadDXFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadDXFToolStripMenuItem.Text = "Load DXF...";
            this.loadDXFToolStripMenuItem.Click += new System.EventHandler(this.loadDXFToolStripMenuItem_Click);
            // 
            // saveDWGToolStripMenuItem
            // 
            this.saveDWGToolStripMenuItem.Name = "saveDWGToolStripMenuItem";
            this.saveDWGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveDWGToolStripMenuItem.Text = "Save DWG...";
            this.saveDWGToolStripMenuItem.Click += new System.EventHandler(this.saveDWGToolStripMenuItem_Click);
            // 
            // saveDXFToolStripMenuItem
            // 
            this.saveDXFToolStripMenuItem.Name = "saveDXFToolStripMenuItem";
            this.saveDXFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveDXFToolStripMenuItem.Text = "Save DXF...";
            this.saveDXFToolStripMenuItem.Click += new System.EventHandler(this.saveDXFToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomExtentsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomExtentsToolStripMenuItem
            // 
            this.zoomExtentsToolStripMenuItem.Name = "zoomExtentsToolStripMenuItem";
            this.zoomExtentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomExtentsToolStripMenuItem.Text = "Zoom extents";
            this.zoomExtentsToolStripMenuItem.Click += new System.EventHandler(this.zoomExtentsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 611);
            this.Controls.Add(this.dxfReaderNETControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Open/Save DWG files ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DXFReaderNET.DXFReaderNETControl dxfReaderNETControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadDWGFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDWGFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadDXFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDWGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDXFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomExtentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

