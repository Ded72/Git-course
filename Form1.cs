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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Microsoft.VisualBasic.FileIO;
using System.Threading;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;


namespace FileManager
{
    public partial class Form1 : Form
    {
        string NameFile;
        bool cutLogic = false;
        string sourcePathCut;
        string targetPathCut;
        FileProcessingcs files;

        private ListViewColumnSorter lvwColumnSorter;

        public Form1()
        {
            InitializeComponent();
            listViewManager.ContextMenuStrip = contextMenuStrip1;
            lvwColumnSorter = new ListViewColumnSorter();
            this.listViewManager.ListViewItemSorter = lvwColumnSorter;
        }


        public void comboBoxDisckInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                comboBoxDisck.Items.Add(d.Name);
            }
        }

        public void OpenSelectedDrives()
        {
            listViewManager.Items.Clear();

            DirectoryInfo Drives = new DirectoryInfo(comboBoxDisck.Text.ToString());
            DirectoryInfo[] drive = Drives.GetDirectories();

            foreach (DirectoryInfo d in drive)
            {
                listViewManager.Items.Add(d.ToString());
            }



            FileInfo[] files = Drives.GetFiles();
            foreach (FileInfo file in files)
            {
                listViewManager.Items.Add(file.ToString());

            }



            textBoxPath.Text = comboBoxDisck.Text;
        }

        public async void OpenFile()
        {
            listViewManager.Items.Clear();
            int i = 0;

            DirectoryInfo Drives = new DirectoryInfo(textBoxPath.Text);

            if (Drives.Exists == true)
            {
                ListViewItem item;
                DirectoryInfo[] drive = Drives.GetDirectories();
                List<ListViewItem> listItem = new List<ListViewItem>();

                int fCount = Drives.GetDirectories().Length;
                int fCount2 = Drives.GetFiles().Length;
                fCount += fCount2;
                labelCountFile.Text = "Количество файлов: " + fCount.ToString();
                progressBarLoad.Maximum = fCount;

                await Task.Run(() =>
                {
                    foreach (DirectoryInfo d in drive)
                    {

                        Invoke(new Action(() =>
                        {
                            i++;
                            Icon iconForFile = SystemIcons.WinLogo;
                            item = new ListViewItem(d.Name, 0);
                            item.SubItems.Add(d.CreationTime.ToString());
                            listViewManager.Items.Add(item);
                            progressBarLoad.Value = i;
                            if (progressBarLoad.Value == progressBarLoad.Maximum)
                            {
                                toolStripButtonBack.Enabled = true;
                                for (int j = 0; j < listItem.Count; j++)
                                {
                                    listViewManager.Items.Add(listItem[j]);
                                }
                            }

                        }));
                        Thread.Sleep(0);
                    }
                });


                listViewManager.BeginUpdate();


                await Task.Run(() =>
                {
                    foreach (System.IO.FileInfo file in Drives.GetFiles())
                    {
                        Invoke(new Action(() =>
                        {
                            FileAttributes attributes = File.GetAttributes(file.FullName);
                            if ((attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                            {

                                i++;
                                Icon iconForFile = SystemIcons.WinLogo;

                                item = new ListViewItem(file.Name, 0);
                                if (!imageListIcon.Images.ContainsKey(file.Name))
                                {
                                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                                    imageListIcon.Images.Add(file.Name, iconForFile);
                                }


                                item.ImageKey = file.Name;
                                item.SubItems.Add(file.CreationTime.ToString());
                                item.SubItems.Add(file.Extension.ToString());
                                listViewManager.Items.Add(item);
                                progressBarLoad.Value = i;

                                if (progressBarLoad.Value == progressBarLoad.Maximum)
                                {
                                    toolStripButtonBack.Enabled = true;
                                }
                                Thread.Sleep(0);
                            }
                            else
                            {
                                i++;
                                progressBarLoad.Value = i;
                            }

                        }));
                    }


                });

                listViewManager.EndUpdate();
            }

            else
            {
                Process.Start(textBoxPath.Text);
                toolStripButtonBack.Enabled = true;
                btnBack();
            }

            if (progressBarLoad.Value == progressBarLoad.Maximum)
            {
                toolStripButtonBack.Enabled = true;
            }

        }

        public void openFileHidePres()
        {
            listViewManager.Items.Clear();
            int i = 0;

            DirectoryInfo Drives = new DirectoryInfo(textBoxPath.Text);

            if (Drives.Exists == true)
            {
                ListViewItem item;
                DirectoryInfo[] drive = Drives.GetDirectories();
                List<ListViewItem> listItem = new List<ListViewItem>();

                int fCount = Drives.GetDirectories().Length;
                int fCount2 = Drives.GetFiles().Length;
                fCount += fCount2;
                labelCountFile.Text = "Количество файлов: " + fCount.ToString();
                progressBarLoad.Maximum = fCount;

                Task.Run(() =>
                {
                    foreach (DirectoryInfo d in drive)
                    {

                        Invoke(new Action(() =>
                        {
                            i++;
                            Icon iconForFile = SystemIcons.WinLogo;
                            item = new ListViewItem(d.Name, 0);
                            listViewManager.Items.Add(item);
                            progressBarLoad.Value = i;
                            if (progressBarLoad.Value == progressBarLoad.Maximum)
                            {
                                toolStripButtonBack.Enabled = true;
                                for (int j = 0; j < listItem.Count; j++)
                                {
                                    listViewManager.Items.Add(listItem[j]);
                                }
                            }

                        }));
                        Thread.Sleep(0);
                    }
                });


                listViewManager.BeginUpdate();

                if (fCount >= 70)
                {

                    Task.Run(() =>
                    {
                        foreach (System.IO.FileInfo file in Drives.GetFiles())
                        {

                            Invoke(new Action(() =>
                            {
                                i++;
                                Icon iconForFile = SystemIcons.WinLogo;

                                item = new ListViewItem(file.Name);
                                if (!imageListIcon.Images.ContainsKey(file.FullName))
                                {
                                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                                    imageListIcon.Images.Add(file.Name, iconForFile);
                                }


                                item.ImageKey = file.Name;
                                listItem.Add(item);
                                progressBarLoad.Value = i;

                                if (progressBarLoad.Value == progressBarLoad.Maximum)
                                {
                                    toolStripButtonBack.Enabled = true;
                                    for (int j = 0; j < listItem.Count; j++)
                                    {
                                        listViewManager.Items.Add(listItem[j]);
                                    }
                                }



                            }));

                            Thread.Sleep(0);



                        }


                    });
                }

                else
                {
                    foreach (System.IO.FileInfo file in Drives.GetFiles())
                    {

                        i++;
                        Icon iconForFile = SystemIcons.WinLogo;

                        item = new ListViewItem(file.Name);
                        if (!imageListIcon.Images.ContainsKey(file.FullName))
                        {
                            iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                            imageListIcon.Images.Add(file.Name, iconForFile);
                        }

                        item.ImageKey = file.Name;
                        listViewManager.Items.Add(item);
                        progressBarLoad.Value = i;


                    }
                    toolStripButtonBack.Enabled = true;
                }



                listViewManager.EndUpdate();
            }

            else
            {
                Process.Start(textBoxPath.Text);
                toolStripButtonBack.Enabled = true;
            }

            if (progressBarLoad.Value == progressBarLoad.Maximum)
            {
                toolStripButtonBack.Enabled = true;
            }
        }

        public void PastePath()
        {
            string lw = "";
            string lw1 = "";

            for (int i = NameFile.Length; i >= 0; i--)
            {
                if (lw.Contains("\\"))
                {
                    lw = lw.Remove(lw.Length - 1);
                    break;
                }
                else
                {
                    lw += NameFile[NameFile.Length - 1];
                    NameFile = NameFile.Remove(NameFile.Length - 1);
                }
            }

            for (int i = lw.Length; i > 0; i--)
            {
                lw1 += lw[lw.Length - 1];
                lw = lw.Remove(lw.Length - 1);
            }

            NameFile = lw1;
        }

        public void CopyFiles()
        {
            if (listViewManager.SelectedItems.Count > 0)
            {
                System.Collections.Specialized.StringCollection replacementList = new System.Collections.Specialized.StringCollection();
                for (int i = 0; i < listViewManager.SelectedItems.Count; i++)
                {
                    try
                    {
                        replacementList.Add(textBoxPath.Text + "\\" + listViewManager.SelectedItems[i].Text);
                        Clipboard.SetFileDropList(replacementList);
                    }

                    catch
                    {
                        MessageBox.Show("Такой файл уже есть");
                    }

                }
            }
        }

        public void PasteFiles()
        {
            if (Clipboard.ContainsFileDropList() == true)
            {
                string[] paths = (string[])Clipboard.GetDataObject().GetData(DataFormats.FileDrop);
                for (int i = 0; i < paths.Length; i++)
                {

                    NameFile = paths[i];

                    PastePath();

                    System.IO.File.Copy(paths[i], textBoxPath.Text + "\\" + NameFile, true);
                }
                OpenFile();
            }
        }

        public void CutFile()
        {
            string[] paths = (string[])Clipboard.GetDataObject().GetData(DataFormats.FileDrop);
            NameFile = paths[0];

            PastePath();

            targetPathCut = textBoxPath.Text + "\\" + NameFile;

            File.Move(sourcePathCut, targetPathCut);
            cutLogic = false;
            OpenFile();
        }

        public void DeleteFile()
        {
            if (listViewManager.SelectedItems.Count > 0)
            {
                var attention = MessageBox.Show("Удалить файл?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (attention == DialogResult.Yes)
                {
                    for (int i = 0; i < listViewManager.SelectedItems.Count; i++)
                    {
                        try
                        {
                            FileSystem.DeleteFile(textBoxPath.Text + "\\" + listViewManager.SelectedItems[i].Text, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        }

                        catch
                        {
                            Directory.Delete(textBoxPath.Text + "\\" + listViewManager.SelectedItems[i].Text, true);
                        }
                    }
                }

                OpenFile();
            }
        }

        public void btnBack()
        {
            listViewManager.Items.Clear();

            char symbol;
            string back = textBoxPath.Text;

            while (back.Length > 0)
            {
                symbol = back[back.Length - 1];

                if (symbol != '\\')
                {
                    back = back.Remove(back.Length - 1);
                }

                else
                {
                    back = back.Remove(back.Length - 1);
                    if (back.EndsWith(":"))
                    {
                        back += "\\";
                        toolStripButtonBack.Enabled = false;
                    }
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDisckInfo();
            comboBoxDisck.SelectedIndex = 0;
            textBoxPath.Text = comboBoxDisck.Text;
            files = new FileProcessingcs();

        }

        private void comboBoxDisck_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo allDrives = new DriveInfo(comboBoxDisck.SelectedItem.ToString());

            double freeplace = System.Convert.ToDouble(allDrives.TotalFreeSpace);
            freeplace /= 1073741824;
            freeplace = Math.Truncate(100 * freeplace) / 100;

            double place = System.Convert.ToDouble(allDrives.TotalSize);
            place /= 1073741824;
            place = Math.Truncate(100 * place) / 100;


            labelSpace.Text = "Свободно " + freeplace.ToString() + " гб из " + place.ToString() + " гб";

            //OpenSelectedDrives();

            textBoxPath.Text = comboBoxDisck.Text;
            OpenFile();


        }

        private void buttonSearchFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFile();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, возможно файл не существует");
            }

        }

        private void comboBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPath.Text = comboBoxHistory.Text;
            OpenFile();
            toolStripButtonBack.Enabled = true;

        }

        private void listViewManager_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewManager.SelectedItems.Count > 0)
            {
                toolStripButtonBack.Enabled = false;
                textBoxPath.Text = Path.Combine(textBoxPath.Text, listViewManager.SelectedItems[0].Text);

                try
                {
                    OpenFile();
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка, возможно файл не существует");
                }


                if (comboBoxHistory.Items.Contains(textBoxPath.Text) == false)
                    comboBoxHistory.Items.Add(textBoxPath.Text);
            }
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            OpenSelectedDrives();
            OpenFile();
        }

        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            CopyFiles();
        }

        private void toolStripButtonPaste_Click(object sender, EventArgs e)
        {

            if (cutLogic == false)
            {
                PasteFiles();
            }

            else
            {
                CutFile();
            }
        }

        private void toolStripButtonCut_Click(object sender, EventArgs e)
        {
            if (listViewManager.SelectedItems.Count > 0)
            {
                cutLogic = true;
                sourcePathCut = textBoxPath.Text + "\\" + listViewManager.SelectedItems[0].Text;
                CopyFiles();
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CopyFiles();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cutLogic == false)
            {
                PasteFiles();
            }

            else
            {
                CutFile();
            }
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listViewManager.SelectedItems.Count > 0)
            {
                cutLogic = true;
                sourcePathCut = textBoxPath.Text + "\\" + listViewManager.SelectedItems[0].Text;
                CopyFiles();
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {

            listViewManager.Items.Clear();

            char symbol;
            string back = textBoxPath.Text;

            while (back.Length > 0)
            {
                symbol = back[back.Length - 1];

                if (symbol != '\\')
                {
                    back = back.Remove(back.Length - 1);
                }

                else
                {
                    back = back.Remove(back.Length - 1);
                    if (back.EndsWith(":"))
                    {
                        back += "\\";
                        toolStripButtonBack.Enabled = false;
                    }
                    break;
                }

            }

            textBoxPath.Text = back;

            try
            {
                OpenFile();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, возможно файл не существует");
            }
        }

        private void toolStripButtonDisckInfo_Click(object sender, EventArgs e)
        {
            FormDiskInfo diskInfo = new FormDiskInfo();
            diskInfo.ShowDialog();
        }

        private void FeaturestoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string path = textBoxPath.Text;
            string name = listViewManager.SelectedItems[0].Text;
            FeaturesFiles f = new FeaturesFiles();
            f.FileInfo(path, name);
            f.ShowDialog();
            OpenFile();
        }

        private void показатьСкрытыеФайлыToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileHidePres();
            //for (int i = 0; i < imageListIcon.Images.Count; i++)
            //{
            //    System.Drawing.Image image = imageListIcon.Images[i];

            //    // Создание объекта Bitmap


            //    // Сохранение объекта Bitmap в папку
            //    string path = @"C:\Users\egori\Desktop\images";
            //    string fileName = "image"+i+".png";
            //    image.Save(Path.Combine(path, fileName));
            //}
        }

        private void папкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 1;
                string path = Path.Combine(textBoxPath.Text, "Новая папка");

                while (Directory.Exists(path))
                {
                    path = Path.Combine(textBoxPath.Text, "Новая папка");
                    path += " (" + i.ToString() + ")";
                    i++;
                }
                Directory.CreateDirectory(path);
                OpenFile();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void документWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 1;
                string path = Path.Combine(textBoxPath.Text, "Документ Microsoft Word.docx");

                while (File.Exists(path))
                {
                    path = Path.Combine(textBoxPath.Text, "Документ Microsoft Word");
                    path += "(" + i.ToString() + ").docx";
                    i++;
                }
                File.Create(path);
                OpenFile();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void текстовыйДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 1;
                string path = Path.Combine(textBoxPath.Text, "Текстовый документ.txt");

                while (File.Exists(path))
                {
                    path = Path.Combine(textBoxPath.Text, "Текстовый документ");
                    path += "(" + i.ToString() + ").txt";
                    i++;
                }
                File.Create(path);
                OpenFile();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void listViewManager_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listViewManager.Sort();
        }

        private void скрытьТулбарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(toolStripBar.Visible==false)
            {
                toolStripBar.Visible = true;
                скрытьТулбарToolStripMenuItem.Text = "Скрыть тулбар";
            }

            else
            {
                toolStripBar.Visible = false;
                скрытьТулбарToolStripMenuItem.Text = "Показать тулбар";
            }

            MessageBox.Show("es");
        }
    }
}
