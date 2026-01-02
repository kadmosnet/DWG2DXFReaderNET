using DXFReaderNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DWG2DXFReaderNET
{
    public partial class Form1 : Form
    {
        private string DWGFileConverterFullPath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width - 40;
            this.Height = Screen.PrimaryScreen.Bounds.Height - 80;
            this.Left = 20;
            this.Top = 20;

            dxfReaderNETControl1.NewDrawing();
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
            dxfReaderNETControl1.Dock = DockStyle.Fill;
        }

        private void zoomExtentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ZoomExtents();
        }

        private void loadDWGFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DWGFileConverterFullPath)
                || !System.IO.File.Exists(DWGFileConverterFullPath))
            {
                MessageBox.Show("Please select the File Converter executable file first.", "DWG to DXF Converter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            openFileDialog1.DefaultExt = "dwg";
            openFileDialog1.Filter = "DWG|*.dwg|All files (*.*)|*.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.Directory.CreateDirectory("tempdir");
                System.IO.Directory.CreateDirectory(@"tempdir/dxf");
                System.IO.File.Copy(openFileDialog1.FileName, @"tempdir\tmpfile.dwg", true);
                ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.FileName = @"C:\Program Files\ODA\ODAFileConverter 23.5.0\ODAFileConverter.exe";
                startInfo.FileName = DWGFileConverterFullPath;
                startInfo.Arguments = " \"tempdir\"  \"tempdir/dxf\" \"ACAD2018\" \"DXF\" \"0\" \"0\"";
                startInfo.UseShellExecute = true;
                startInfo.CreateNoWindow = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Process proc = Process.Start(startInfo);

                proc.WaitForExit();
                dxfReaderNETControl1.ReadDXF(@"tempdir\dxf\tmpfile.dxf");


                System.IO.File.Delete(@"tempdir\dxf\tmpfile.dxf");
                System.IO.Directory.Delete(@"tempdir\dxf");
                System.IO.File.Delete(@"tempdir\tmpfile.dwg");
                System.IO.Directory.Delete(@"tempdir");

                dxfReaderNETControl1.ZoomExtents();


            }
        }

        private void loadDXFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "dxf";
            openFileDialog1.Filter = "DXF|*.dxf|All files (*.*)|*.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.ReadDXF(openFileDialog1.FileName);
                dxfReaderNETControl1.ZoomExtents();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void saveDXFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DWGFileConverterFullPath)
                || !System.IO.File.Exists(DWGFileConverterFullPath))
            {
                MessageBox.Show("Please select the File Converter executable file first.", "DWG to DXF Converter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            saveFileDialog1.DefaultExt = "dxf";
            saveFileDialog1.Filter = "DXF|*.dxf";
            saveFileDialog1.FileName = "drawing.dxf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.WriteDXF(saveFileDialog1.FileName);

            }
        }

        private void saveDWGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "dwg";
            saveFileDialog1.Filter = "DWG|*.dwg";
            saveFileDialog1.FileName = "drawing.dwg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.Directory.CreateDirectory("tempdir");
                System.IO.Directory.CreateDirectory(@"tempdir/dxf");
                dxfReaderNETControl1.WriteDXF(@"tempdir/dxf/tmpfile.dxf");

               
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = DWGFileConverterFullPath;
                startInfo.Arguments = " \"tempdir/dxf\"  \"tempdir\" \"ACAD2018\" \"DWG\" \"0\" \"0\"";

                startInfo.UseShellExecute = true;
                startInfo.CreateNoWindow = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Process proc = Process.Start(startInfo);

                proc.WaitForExit();
               

                System.IO.File.Copy(@"tempdir\tmpfile.dwg", saveFileDialog1.FileName, true);
                
                System.IO.File.Delete(@"tempdir\dxf\tmpfile.dxf");
                System.IO.File.Delete(@"tempdir\tmpfile.dwg");
                System.IO.Directory.Delete(@"tempdir/dxf");
                
                System.IO.Directory.Delete(@"tempdir");

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "exe";
            openFileDialog1.Filter = "EXE file|*.exe";
            openFileDialog1.FileName = DWGFileConverterFullPath;
            if (DWGFileConverterFullPath != "")
            {
                openFileDialog1.InitialDirectory = Path.GetDirectoryName(DWGFileConverterFullPath);
            }
            else
            {
                openFileDialog1.InitialDirectory = Environment.ExpandEnvironmentVariables("%ProgramW6432%");
            }


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DWGFileConverterFullPath = openFileDialog1.FileName;




            }
        }
    }
}
