using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wavToMp3
{
    class waveToMp3
    {
        public void mciConvertWavMP3(string fileName, bool waitFlag, string outdir)
        {
            string converterExeDir = AppDomain.CurrentDomain.BaseDirectory +
                     "Converter\\"; //location of lame.exe file
                                    //remember, i used forward slash in app.config file
                                    //for input and output directory so '/' is used here
            string[] splittedFileName = fileName.Split('\\');
            string fileNamePart = splittedFileName[splittedFileName.Length - 1];//get the last part as the file name
            string pworkingDir = outdir;
            //string outfile = "-b 32 --resample 22.05 -m m \"" + pworkingDir + fileName + "\" \"" + pworkingDir +fileName.Replace(".wav", ".mp3") + "\"";
            string outfile = "-b 32 --resample 22.05 -m m \"" + fileName +"\" \"" + pworkingDir + fileNamePart.Replace(".wav", ".mp3") + "\"";
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            psi.FileName = "\"" + converterExeDir + "lame.exe" + "\"";
            psi.Arguments = outfile;
            psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
            if (waitFlag)
            {
                p.WaitForExit();
            }
        }
    }
}
