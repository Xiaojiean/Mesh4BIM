using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mesh4BIMApp
{
    public partial class Mesh4BIM : Form
    {
        public static string pathOpenFolder { get; set; }
        public static string pathOutputFolder { get; set; }
        public static string radius { get; set; }
        public static string triangles { get; set; }
        public static string ballRaddius { get; set; }
        public static string meshlabPath { get; set; }
        public static string currentDirectory { get; set; }
        public static StringBuilder sbScript { get; set; }
        public static int countFiles { get; set; }

        public Mesh4BIM()
        {
            InitializeComponent();
            radius = "0.05";
            triangles = "100000";
            ballRaddius = "0.05";
            meshlabPath = "C:\\Program Files\\VCG\\MeshLab\\meshlabserver.exe";
            currentDirectory = Directory.GetCurrentDirectory();
            //Visibility
            menuFileOutputFolder.Enabled = false;
            toolOutputFolder.Enabled = false;
            btnOutputFolder.Enabled = false;
            txbPathOutput.Enabled = false;
            menuProcess.Enabled = false;
            toolProcess.Enabled = false;
            btnProcess.Enabled = false;
            menuOpenOutput.Enabled = false;
            toolOpenOutput.Enabled = false;
            btnOpenOutput.Enabled = false;
            //StatusBar
            lblStatus.Text = "Select a PointCloud folder";
            //Visibility Preset CheckBox
            chbRename.Enabled = false;
            chbSampling.Enabled = false;
            chbNormals.Enabled = false;
            chbSurface.Enabled = false;
            chbDecimation.Enabled = false;
            //Visibility Preset
            radPTS.Enabled = false;
            radPTX.Enabled = false;
            radCustom.Enabled = false;
            //Preset Options
            txbRadius.Text = radius;
            txbBallRadius.Text = ballRaddius;
            txbTriangles.Text = triangles;
        }

        private void toolOpenFolder_Click(object sender, EventArgs e)
        {
            countFiles = 0;
            DialogResult resOpenFolder = BrowseFolderOpen.ShowDialog();

            if (resOpenFolder == DialogResult.OK)
            {
                pathOpenFolder = BrowseFolderOpen.SelectedPath;
                txbPathInputFolder.Text = pathOpenFolder;
                listViewOpen.Items.Clear();
                //Visibility
                menuFileOutputFolder.Enabled = true;
                toolOutputFolder.Enabled = true;
                btnOutputFolder.Enabled = true;
                txbPathOutput.Enabled = true;
                //StatusBar
                lblStatus.Text = "Select an Output folder";

                foreach (string f in Directory.GetFiles(pathOpenFolder)) //, "*.ptx").Union(Directory.GetFiles(foldername, "*.rfa")))
                {
                    this.listViewOpen.Items.Add(f);
                    countFiles += 1;
                }
            }
            else
            {
                
            }
            
        }

        private void toolOutputFolder_Click(object sender, EventArgs e)
        {
            DialogResult resFolderOutput = BrowseFolderOutput.ShowDialog();
            if (resFolderOutput == DialogResult.OK)
            {
                pathOutputFolder = BrowseFolderOutput.SelectedPath;
                txbPathOutput.Text = pathOutputFolder;
                lblStatus.Text = "Select a Preset";
                //Visibility buttons
                menuOpenOutput.Enabled = true;
                toolOpenOutput.Enabled = true;
                btnOpenOutput.Enabled = true;
                //Visibility Preset
                radPTS.Enabled = true;
                radPTX.Enabled = true;
                radCustom.Enabled = true;
            }
            else
            {

            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            pgbBarra.Minimum = 0;
            pgbBarra.Maximum = countFiles * 2;
            pgbBarra.Step = 1;
            string exportFile;
            int pathLengthOpen = pathOpenFolder.Length;
            lblStatus.Text = "Start Process";
            //Crear el Script
            scripts.scriptStart();
            //Presets
            
            if (chbSampling.Checked == true)
            {
                scripts.poissonDiskSampling(radius);
            }
            if (chbNormals.Checked == true)
            {
                scripts.conputeNormals();
            }
            if (chbSurface.Checked == true)
            {
                double ballRad = Convert.ToDouble(ballRaddius);
                double ballRad2 = ballRad * 2;
                double ballRad10 = ballRad * 10;
                double ballRad30 = ballRad * 30;

                scripts.surfaceReconstruction(ballRaddius);
                scripts.surfaceReconstruction(ballRad2.ToString());
                scripts.surfaceReconstruction(ballRad10.ToString());
                scripts.surfaceReconstruction(ballRad30.ToString());
            }
            if (chbDecimation.Checked == true)
            {
                scripts.collapseDecimation(triangles);
            }
            scripts.scriptEnding();
            scripts.nothing();

            foreach (string f in Directory.GetFiles(pathOpenFolder))
            {
                string g = f.Remove(0, pathLengthOpen + 1);
                string h = g.Remove(g.Length - 3, 3);
                string i = pathOutputFolder + "\\" + h + "ply";
                string m = pathOutputFolder + "\\" + h + "dxf";

                if (chbRename.Checked == true)
                {
                    string j = f.Remove(f.Length - 3, 3);
                    string k = j + "asc";
                    File.Move(f, k);
                    meshlab.meshlabserverStart(meshlabPath, k, i,"script.mlx");
                    pgbBarra.PerformStep();
                    meshlab.meshlabserverStart(meshlabPath, i, m, "nothing.mlx");
                    File.Delete(i);
                    pgbBarra.PerformStep();
                }
                if (chbRename.Checked == false)
                {
                    meshlab.meshlabserverStart(meshlabPath, f, i, "script.mlx");
                    pgbBarra.PerformStep();
                    meshlab.meshlabserverStart(meshlabPath, i, m, "nothing.mlx");
                    File.Delete(i);
                    pgbBarra.PerformStep();
                }
                //pgbBarra.PerformStep();
            }
            lblStatus.Text = "Process Finished";
            MessageBox.Show("Process Finished");
            pgbBarra.Value = 0;
        }

        private void radPTS_CheckedChanged(object sender, EventArgs e)
        {
            chbRename.Enabled = false;
            chbSampling.Enabled = false;
            chbNormals.Enabled = false;
            chbSurface.Enabled = false;
            chbDecimation.Enabled = false;
            chbRename.Checked = true;
            chbSampling.Checked = true;
            chbNormals.Checked = true;
            chbSurface.Checked = true;
            chbDecimation.Checked = true;
            //Visibility
            menuProcess.Enabled = true;
            toolProcess.Enabled = true;
            btnProcess.Enabled = true;
            lblStatus.Text = "Ready for Process";
        }

        private void radPTX_CheckedChanged(object sender, EventArgs e)
        {
            chbRename.Enabled = false;
            chbSampling.Enabled = false;
            chbNormals.Enabled = false;
            chbSurface.Enabled = false;
            chbDecimation.Enabled = false;
            chbRename.Checked = false;
            chbSampling.Checked = false;
            chbNormals.Checked = false;
            chbSurface.Checked = false;
            chbDecimation.Checked = true;
            //Visibility
            menuProcess.Enabled = true;
            toolProcess.Enabled = true;
            btnProcess.Enabled = true;
            lblStatus.Text = "Ready for Process";
        }

        private void radCustom_CheckedChanged(object sender, EventArgs e)
        {
            chbRename.Enabled = true;
            chbSampling.Enabled = true;
            chbNormals.Enabled = true;
            chbSurface.Enabled = true;
            chbDecimation.Enabled = true;
            //Visibility
            menuProcess.Enabled = true;
            toolProcess.Enabled = true;
            btnProcess.Enabled = true;
            lblStatus.Text = "Ready for Process";
        }

        private void txbRadius_TextChanged(object sender, EventArgs e)
        {
            radius = txbRadius.Text;
        }

        private void txbBallRadius_TextChanged(object sender, EventArgs e)
        {
            ballRaddius = txbBallRadius.Text;
        }

        private void txbTriangles_TextChanged(object sender, EventArgs e)
        {
            triangles = txbTriangles.Text;
        }

        private void toolOpenOutput_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(pathOutputFolder);
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            about frmAbout = new about();
            frmAbout.ShowDialog();
        }
    }
}
