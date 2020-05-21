using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AtlusFileSystemLibrary.FileSystems.PAK;
using AtlusFileSystemLibrary.Common.IO;
using AmicitiaLibrary.Graphics.RenderWare;
using GFDLibrary;
using GFDLibrary.Textures;
using p5eplinjector;
using AmicitiaLibrary.Graphics.TMX;
using AmicitiaLibrary.Graphics.SPR;
using AmicitiaLibrary.Graphics.SPD;

namespace PersonaTexDumper
{
    public partial class Form_PersonaTextDumper : Form
    {

        public Form_PersonaTextDumper()
        {
            InitializeComponent();
            comboBox_Type.SelectedIndex = 0;

            #if DEBUG
            txtBox_SearchDir.Text = @"C:\Users\Ryan\Downloads\RMD\Input";
            txtBox_OutputDir.Text = @"C:\Users\Ryan\Downloads\RMD\Output";
            #endif
        }

        private void btn_BrowseSearch_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtBox_SearchDir.Text = dialog.FileName;
            }
        }

        private void btn_BrowseOutput_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtBox_OutputDir.Text = dialog.FileName;
            }
        }

        private void btn_Dump_Click(object sender, EventArgs e)
        {
            txtBox_Log.Clear();
            if (Directory.Exists(txtBox_SearchDir.Text))
            {
                Directory.CreateDirectory(txtBox_OutputDir.Text);
                btn_Dump.Enabled = false; //Disallow pressing button again mid-operation
                var searchOptions = chkBox_SearchSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                var files = Directory.GetFiles(txtBox_SearchDir.Text, "*", searchOptions);
                if (comboBox_Type.Text != "Any")
                {
                    var allowedExtensions = new List<string>() { $".{comboBox_Type.Text}" };
                    if (chkBox_ExtractPAC.Checked)
                    {
                        allowedExtensions.Add($".PAC");
                        allowedExtensions.Add($".PAK");
                        allowedExtensions.Add($".BIN");
                        allowedExtensions.Add($".ARC");
                    }
                    files = files.Where(file => allowedExtensions.Any(file.ToUpper().EndsWith)).ToArray();
                }
                foreach (var file in files)
                    Search(file);
            }
            else
                txtBox_Log.Text += "Could not find Search Directory.\n";
            txtBox_Log.Text += "Done!\n";
            btn_Dump.Enabled = true;
        }

        private void Search(string file)
        {
            try
            {
                switch (Path.GetExtension(file).ToUpper())
                {
                    case (".PAC"):
                        ExtractPAC(file);
                        break;
                    case (".PAK"):
                        ExtractPAC(file);
                        break;
                    case (".BIN"):
                        ExtractPAC(file);
                        break;
                    case (".ARC"):
                        ExtractPAC(file);
                        break;
                    case (".RMD"):
                        ExtractRMD(file);
                        break;
                    case (".GMD"):
                        ExtractGMD(file);
                        break;
                    case (".GMO"):
                        //ExtractGMO(file);
                        break;
                    case (".EPL"):
                        ExtractEPL(file);
                        break;
                    case (".CPK"):
                        //ExtractCPK(file);
                        break;
                    case (".SPR"):
                        ExtractSPR(file);
                        break;
                    case (".SPD"):
                        ExtractSPD(file);
                        break;
                    case (".TMX"):
                        ExtractTMX(file);
                        break;
                }
            }
            catch
            {
                txtBox_Log.Text += $"Failed to load {Path.GetFileName(file)}.\n";
            }
            
        }

        private void ExtractSPD(string file)
        {
            SpdFile spd = new SpdFile(file);
            foreach (var texture in spd.Textures)
            {
                string output = txtBox_OutputDir.Text;
                if (chkBox_KeepFolderStructure.Checked)
                    output += Path.DirectorySeparatorChar + Path.GetDirectoryName(file).Substring(txtBox_SearchDir.Text.Length);
                if (chkBox_NameAfterContainers.Checked)
                    output += Path.DirectorySeparatorChar + Path.GetFileName(file) + "_extracted";
                Directory.CreateDirectory(output);

                var bitmap = texture.GetBitmap();
                bitmap.Save(output + Path.DirectorySeparatorChar + Path.ChangeExtension(texture.Description, "png"));
                txtBox_Log.Text += $"Saving texture: {texture.Description}\n";
            }
        }

        private void ExtractSPR(string file)
        {
            SprFile spr = SprFile.Load(file);
            foreach (var texture in spr.Textures)
            {
                string output = txtBox_OutputDir.Text;
                if (chkBox_KeepFolderStructure.Checked)
                    output += Path.DirectorySeparatorChar + Path.GetDirectoryName(file).Substring(txtBox_SearchDir.Text.Length);
                if (chkBox_NameAfterContainers.Checked)
                    output += Path.DirectorySeparatorChar + Path.GetFileName(file) + "_extracted";
                Directory.CreateDirectory(output);

                var bitmap = texture.GetBitmap();
                bitmap.Save(output + Path.DirectorySeparatorChar + Path.ChangeExtension(texture.UserComment, "png"));
                txtBox_Log.Text += $"Saving texture: {texture.UserComment}\n";
            }
        }

        private void ExtractTMX(string file)
        {
            string output = txtBox_OutputDir.Text;
            if (chkBox_KeepFolderStructure.Checked)
                output += Path.DirectorySeparatorChar + Path.GetDirectoryName(file).Substring(txtBox_SearchDir.Text.Length);
            if (chkBox_NameAfterContainers.Checked)
                output += Path.DirectorySeparatorChar + Path.GetFileName(file) + "_extracted";
            Directory.CreateDirectory(output);

            TmxFile tmx = new TmxFile(file);
            
            var bitmap = tmx.GetBitmap();
            bitmap.Save(output + Path.DirectorySeparatorChar + Path.ChangeExtension(Path.GetFileName(file), "png"));
            txtBox_Log.Text += $"Saving texture: {Path.GetFileName(file)}\n";
        }

        private void ExtractEPL(string file)
        {
            txtBox_Log.Text += $"Extracting {Path.GetFileName(file)}...\n";
            string output = txtBox_OutputDir.Text;
            if (chkBox_KeepFolderStructure.Checked)
                output += Path.DirectorySeparatorChar + Path.GetDirectoryName(file).Substring(txtBox_SearchDir.Text.Length);
            Directory.CreateDirectory(output);
            string copiedFile = output + Path.DirectorySeparatorChar + Path.GetFileName(file);
            File.Copy(file, copiedFile);

            Epl.ExtractModelsFromEpl(copiedFile);
            File.Delete(copiedFile);

            foreach (var gmd in Directory.GetFiles(output, "*.gmd", SearchOption.AllDirectories))
                Search(gmd);
        }

        private void ExtractGMD(string file)
        {
            var gmd = Resource.Load<ModelPack>(file);
            if (gmd.Textures != null)
            foreach (var texture in gmd.Textures.Textures)
            {
                string output = txtBox_OutputDir.Text;
                if (chkBox_KeepFolderStructure.Checked)
                    output += Path.DirectorySeparatorChar + Path.GetDirectoryName(file).Substring(txtBox_SearchDir.Text.Length);
                if (chkBox_NameAfterContainers.Checked)
                    output += Path.DirectorySeparatorChar + Path.GetFileName(file) + "_extracted";
                Directory.CreateDirectory(output);

                var bitmap = TextureDecoder.Decode(texture);
                bitmap.Save(output + Path.DirectorySeparatorChar + Path.ChangeExtension(texture.Name, "png"));
                txtBox_Log.Text += $"Saving texture: {texture.Name}\n";
            }
        }

        private void ExtractRMD(string file)
        {
            RmdScene rmd = new RmdScene(file);
            foreach (var texture in rmd.TextureDictionary.Textures)
            {
                string output = txtBox_OutputDir.Text;
                if (chkBox_KeepFolderStructure.Checked)
                    output += Path.DirectorySeparatorChar + Path.GetDirectoryName(file).Substring(txtBox_SearchDir.Text.Length + 1);
                if (chkBox_NameAfterContainers.Checked)
                    output += Path.DirectorySeparatorChar + Path.GetFileName(file) + "_extracted";
                Directory.CreateDirectory(output);

                var bitmap = texture.GetBitmap();
                bitmap.Save(output + Path.DirectorySeparatorChar + Path.ChangeExtension(texture.Name, "png"));
                txtBox_Log.Text += $"Saving texture: {texture.Name}\n";
            }
        }

        private void ExtractPAC(string file)
        {
            PAKFileSystem pak = new PAKFileSystem();
            if (PAKFileSystem.TryOpen(file, out pak))
            {
                List<string> pakFiles = new List<string>();
                txtBox_Log.Text += $"Extracting {Path.GetFileName(file)}...\n";
                foreach (var pakFile in pak.EnumerateFiles())
                {
                    var normalizedFilePath = pakFile.Replace("../", ""); // Remove backwards relative path
                    string output = txtBox_OutputDir.Text;
                    if (chkBox_KeepFolderStructure.Checked)
                        output += Path.DirectorySeparatorChar + Path.GetDirectoryName(file).Substring(txtBox_SearchDir.Text.Length);
                    if (chkBox_NameAfterContainers.Checked)
                        output += Path.DirectorySeparatorChar + Path.GetFileName(file) + "_extracted" + Path.DirectorySeparatorChar + normalizedFilePath;
                    else
                        output += Path.DirectorySeparatorChar + normalizedFilePath;

                    using (var stream = FileUtils.Create(output))
                    using (var inputStream = pak.OpenFile(pakFile))
                    {
                        inputStream.CopyTo(stream);
                        pakFiles.Add(output);
                    }
                    File.Delete(pakFile);
                }
                
                foreach (var pakFile in pakFiles)
                {
                    Search(pakFile);
                }
            }
            else
            {
                txtBox_Log.Text += $"Failed to open. Skipping...\n";
            }
        }
    }
}
