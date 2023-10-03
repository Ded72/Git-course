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

namespace FileManager
{
    public partial class FeaturesFiles : Form
    {
        public FeaturesFiles()
        {
            InitializeComponent();
        }
        string fullPath = " ";

        public void FileInfo(string path, string name)
        {
            string date = "";
            string create = "";
            double size = 0;
            textBoxName.Text = name;
            fullPath = Path.Combine(path,name);
            labelLocation.Text = "Расположение: "+fullPath;

          
            FileInfo fileInfo = new FileInfo(fullPath);
            DirectoryInfo files = new DirectoryInfo(fullPath);
            date = fileInfo.LastAccessTime.ToString();
            create= fileInfo.CreationTime.ToString();
            labelOpen.Text = "Открыт: "+date;
            labelCreat.Text = "Создан: "+create;
            try
            {
                string ssize = fileInfo.Length.ToString();
                size = System.Convert.ToDouble(ssize);
            }
            catch 
            {
                
            }
            
            if (size >= 1073741824)
            {
                size /= 1073741824;
                size = Math.Truncate(100 * size) / 100;
                labelSize.Text = "Размер: " + size.ToString() + " гб";
            }

            else if(size >= 1048576)
            {
                size /= 1048576;
                size = Math.Truncate(100 * size) / 100;
                labelSize.Text = "Размер: " + size.ToString() + " мб";
            }

            else
                labelSize.Text = "Размер: " + size.ToString() + " байт";

            FileAttributes attributes = File.GetAttributes(fullPath);

            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                checkBoxOnlyRead.Checked = true;
            }

            if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                checkBoxHidden.Checked = true;
            }

        }

        private void FeaturesFiles_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            FileAttributes attributes = File.GetAttributes(fullPath);
            DirectoryInfo directoryInfo = new DirectoryInfo(fullPath);
            
            

            if (checkBoxOnlyRead.Checked == true)
            {
                directoryInfo.Attributes = FileAttributes.ReadOnly;
            }
            if(checkBoxOnlyRead.Checked == false)
            {
                File.SetAttributes(fullPath, File.GetAttributes(fullPath) & ~FileAttributes.ReadOnly);
            }

            if (checkBoxHidden.Checked == true)
            {
                directoryInfo.Attributes = FileAttributes.Hidden;
            }
            if(checkBoxHidden.Checked == false)
            {
                File.SetAttributes(fullPath, File.GetAttributes(fullPath) & ~FileAttributes.Hidden);
            }

            FileInfo file = new FileInfo(fullPath);
            string p = fullPath.Replace(file.Name,textBoxName.Text);

            DirectoryInfo directoryInfo1= new DirectoryInfo(fullPath);
            string di = fullPath.Replace(directoryInfo1.Name, textBoxName.Text);
            try
            {
                File.Move(fullPath, p + file.Extension.ToString());
            }
            catch
            {
                Directory.Move(fullPath, di);
            }
        }
    }
}
