using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoomDialog
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String path = Environment.GetEnvironmentVariable(STEAM_DIR_ENV_VAR_NAME, EnvironmentVariableTarget.User);
            if(path != null) {
                path += (path.EndsWith("\\") ? "" : "\\");
                path += "Steam.exe";
            }

            while (!File.Exists(path))
            {
                MessageBox.Show("Steam directory is invalid : '" + (path == null ? "null" : path) + "'",
                                "Invalid directory",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);

                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Select Steam directory :";
                DialogResult result = fbd.ShowDialog();

                if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = fbd.SelectedPath;
                    path += (path.EndsWith("\\") ? "" : "\\");
                    path += "Steam.exe";
                }
                else
                {
                    return;
                }

                if (File.Exists(path))
                {
                    Environment.SetEnvironmentVariable(STEAM_DIR_ENV_VAR_NAME, fbd.SelectedPath, EnvironmentVariableTarget.User);
                }
            }

            Application.Run(new DoomDialog(path));
        }

        private const String STEAM_DIR_ENV_VAR_NAME = "STEAM_DIR";
    }
}
