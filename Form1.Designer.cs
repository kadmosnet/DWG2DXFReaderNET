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
            DXFReaderNET.DxfDocument dxfDocument1 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor1 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables1 = new DXFReaderNET.Objects.RasterVariables();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadDWGFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDWGFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDXFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveDWGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDXFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomExtentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            this.dxfReaderNETControl1.CustomCursorColor = System.Drawing.Color.White;
            this.dxfReaderNETControl1.DistributionCode = "";
            dxfDocument1.ActiveLayout = "Model";
            dxfDocument1.Comments = null;
            aciColor1.Index = ((short)(256));
            aciColor1.IsByBlock = false;
            aciColor1.IsByLayer = true;
            aciColor1.UseTrueColor = false;
            dxfDocument1.CurrentColor = aciColor1;
            dxfDocument1.CurrentElevation = 0D;
            dxfDocument1.CurrentLayer = "0";
            dxfDocument1.CurrentLineTypeName = "ByLayer";
            dxfDocument1.CurrentLineTypeScale = 1D;
            dxfDocument1.CurrentTextSize = 2.5D;
            dxfDocument1.CurrentTextStyle = "STANDARD";
            dxfDocument1.CurrentThickness = 0D;
            dxfDocument1.DateCreated = new System.DateTime(2022, 7, 11, 15, 29, 30, 451);
            dxfDocument1.DateLastEdited = new System.DateTime(2022, 7, 11, 15, 29, 30, 451);
            dxfDocument1.Handle = "0";
            dxfDocument1.IsBinary = false;
            dxfDocument1.Modified = false;
            dxfDocument1.Name = null;
            dxfDocument1.Owner = null;
            rasterVariables1.DisplayFrame = true;
            rasterVariables1.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High;
            rasterVariables1.Handle = "2A";
            rasterVariables1.Owner = null;
            rasterVariables1.Units = DXFReaderNET.ImageUnits.Unitless;
            dxfDocument1.RasterVariables = rasterVariables1;
            dxfDocument1.SortentsTables = null;
            dxfDocument1.ThumbnailImage = null;
            dxfDocument1.TotalEditTime = new System.DateTime(2022, 7, 11, 0, 0, 0, 0);
            dxfDocument1.TotalEditTimeDays = 0;
            dxfDocument1.UserTimer = new System.DateTime(2022, 7, 11, 0, 0, 0, 0);
            dxfDocument1.UserTimerDays = 0;
            this.dxfReaderNETControl1.DXF = dxfDocument1;
            this.dxfReaderNETControl1.FileName = null;
            this.dxfReaderNETControl1.GrabPointsSize = 8;
            this.dxfReaderNETControl1.HighlightGrabPointsOnHover = false;
            this.dxfReaderNETControl1.HighlightGrabPointsOnHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta;
            this.dxfReaderNETControl1.HighlightNotContinuous = false;
            this.dxfReaderNETControl1.Location = new System.Drawing.Point(39, 43);
            this.dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            this.dxfReaderNETControl1.RubberBandColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
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
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
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
            this.loadDWGFileToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.loadDWGFileToolStripMenuItem1.Text = "Load DWG...";
            this.loadDWGFileToolStripMenuItem1.Click += new System.EventHandler(this.loadDWGFileToolStripMenuItem1_Click);
            // 
            // loadDXFToolStripMenuItem
            // 
            this.loadDXFToolStripMenuItem.Name = "loadDXFToolStripMenuItem";
            this.loadDXFToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.loadDXFToolStripMenuItem.Text = "Load DXF...";
            this.loadDXFToolStripMenuItem.Click += new System.EventHandler(this.loadDXFToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // saveDWGToolStripMenuItem
            // 
            this.saveDWGToolStripMenuItem.Name = "saveDWGToolStripMenuItem";
            this.saveDWGToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.saveDWGToolStripMenuItem.Text = "Save DWG...";
            this.saveDWGToolStripMenuItem.Click += new System.EventHandler(this.saveDWGToolStripMenuItem_Click);
            // 
            // saveDXFToolStripMenuItem
            // 
            this.saveDXFToolStripMenuItem.Name = "saveDXFToolStripMenuItem";
            this.saveDXFToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.saveDXFToolStripMenuItem.Text = "Save DXF...";
            this.saveDXFToolStripMenuItem.Click += new System.EventHandler(this.saveDXFToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.toolStripMenuItem1.Text = "DWG file converter path...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

