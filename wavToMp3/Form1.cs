using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wavToMp3
{
    public partial class frmPrincipal : Form
    {
        CreateLogFiles Err;

        public frmPrincipal()
        {
            InitializeComponent();
            Err = new CreateLogFiles();
        }


        private void convertirDirectory(string inputPath, string outputPath)
        {
            string[] fileNames = Directory.GetFiles(inputPath);
            string[] directoris = Directory.GetDirectories(inputPath);

            waveToMp3 p = new waveToMp3();
            try
            {
                foreach (string fileName in fileNames)
                {
                    p.mciConvertWavMP3(fileName, true, outputPath);
                    System.Threading.Thread.Sleep(1000);
                    lblInformer.Text = "convertint: " + fileName;
                }
            }
            catch (Exception ex)
            {
                Err.ErrorLog(AppDomain.CurrentDomain.BaseDirectory, ex.ToString() +
                  " " + ex.StackTrace + "  " + ex.Source);
            }

            if (directoris.Length != 0)
            {
                foreach (string directori in directoris)
                {
                    string[] dirSplitted = directori.Split('\\');
                    string nouDirectori = outputPath + dirSplitted[dirSplitted.Length - 1];
                    crearDirectori(nouDirectori);
                    convertirDirectory(directori, nouDirectori + "\\");
                }
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string inputPath = tbRuta.Text;
            string outputPath = tbDesti.Text + "\\";
            convertirDirectory(inputPath, outputPath);
            procesFinalitzat();
        }

        private void crearDirectori(string path)
        {
            try
            {
                if (!Directory.Exists(path))Directory.CreateDirectory(path);    
            }
            catch (Exception ex)
            {
                Err.ErrorLog(AppDomain.CurrentDomain.BaseDirectory, ex.ToString() +
                  " " + ex.StackTrace + "  " + ex.Source);
            }
        }
        
        private void btnExaminarCarpeta_Click(object sender, EventArgs e)
        {
            tbRuta.Clear();
            tbRuta.Text = getPath();
            tbRuta.Refresh();
            btnCarpetaDesti.Enabled = true;
            lblInformer.Text = "";
        }        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnConvertir.Enabled = false;
            btnCarpetaDesti.Enabled = false;
            lblInformer.Text = "";
        }

        private void btnCarpetaDesti_Click(object sender, EventArgs e)
        {
            tbDesti.Clear();
            tbDesti.Text = getPath();
            tbDesti.Refresh();
            btnConvertir.Enabled = true;
        }


        private string getPath()
        {
            string res = "";
            FolderBrowserDialog fldbrwDialog = new FolderBrowserDialog();
            if (fldbrwDialog.ShowDialog() == DialogResult.OK)
            {
                res = fldbrwDialog.SelectedPath;
            }
            return res;
        }

        private void procesFinalitzat()
        {
            btnCarpetaDesti.Enabled = false;
            btnConvertir.Enabled = false;
            tbDesti.Text = "";
            tbRuta.Text = "";
            lblInformer.Text = "Procés Finalitzat";
        }

    }
}
