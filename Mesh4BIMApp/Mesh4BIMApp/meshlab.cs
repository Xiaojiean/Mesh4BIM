using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mesh4BIMApp
{
    public class meshlab
    {
        public static void meshlabserverStart(string meshlabPath, string pathFile, string exportPath, string scriptFile)
        {
            StringBuilder sbBat = new StringBuilder();
            sbBat.Clear();
            sbBat.Append("\"" + meshlabPath + "\"" + " -i " + "\"" + pathFile + "\"" + " -o " + "\"" + exportPath + "\"" + " -s " + "\"" + scriptFile + "\"" + " -om vc fq wn");
            File.WriteAllText("meshlabAlgoritm.bat", sbBat.ToString());
            var process = System.Diagnostics.Process.Start("meshlabAlgoritm.bat");
            process.WaitForExit();
        }
    }
}
