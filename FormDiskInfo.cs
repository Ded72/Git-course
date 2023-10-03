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

    public partial class FormDiskInfo : Form
    {
        double freeplace, totalplace;

        public FormDiskInfo()
        {
            InitializeComponent();
        }

        public void comboBoxDiskInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                comboBoxDisk.Items.Add(d.Name);
            }
        }

        public void DiskInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    labelCondition.Text = "Готов";
                    labelNameFileSystem.Text = d.DriveFormat.ToString();
                    labelTypeDisk.Text = d.DriveType.ToString();

                    DriveInfo Drives = new DriveInfo(comboBoxDisk.SelectedItem.ToString());

                    freeplace = System.Convert.ToDouble(Drives.TotalFreeSpace);
                    freeplace /= 1073741824;
                    freeplace = Math.Truncate(100 * freeplace) / 100;

                    totalplace = System.Convert.ToDouble(Drives.TotalSize);
                    totalplace /= 1073741824;
                    totalplace = Math.Truncate(100 * totalplace) / 100;

                    labelPlace.Text = "Свободно " + freeplace + " гб. из " + totalplace+" гб.";
                }

                else
                {
                    labelCondition.Text = "Не готов";

                }
            }
        }

        private void comboBoxDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiskInfo();
        }

        private void FormDiskInfo_Load(object sender, EventArgs e)
        {
            comboBoxDiskInfo();
            comboBoxDisk.SelectedIndex = 0;
            DiskInfo();
        }
    }
}
