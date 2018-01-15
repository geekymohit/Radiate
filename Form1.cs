using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Raidiate
{
    public partial class radiate : Form
    {
        Disk disk;

        public radiate()
        {
            // init
            InitializeComponent();
            disk = new Disk();

            // populating disk + partition + volume
            diskComboBox.DataSource = disk.DiskNames;
            partitionComboBox.DataSource = disk.PartitionNames;
            
        }

        //custom methods
        private void Rescan()
        {
            disk = new Disk();
            diskComboBox.DataSource = disk.DiskNames;
            partitionComboBox.DataSource = disk.PartitionNames;
        }

        private void diskComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            partitionComboBox.DataSource = disk.GetPartitionNames(diskComboBox.SelectedIndex);
        }

        private void rescanButton_Click(object sender, EventArgs e)
        {
            Rescan();
        }

        //Disk Information
        private void diskButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(disk.GetDiskInfo(diskComboBox.SelectedIndex), diskComboBox.SelectedValue.ToString());
        }

        private void partitionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(disk.GetPartitionInfo(diskComboBox.SelectedIndex, partitionComboBox.SelectedIndex + 1),
                diskComboBox.SelectedValue.ToString() + " - " + partitionComboBox.SelectedValue.ToString() + ":\\");
        }

        private void filesystemButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(disk.GetFSInfo(diskComboBox.SelectedIndex, partitionComboBox.SelectedIndex + 1),
                diskComboBox.SelectedValue.ToString() + " - " + partitionComboBox.SelectedValue.ToString() + ":\\");
        }

        private void mountButton_Click(object sender, EventArgs e)
        {          
            int dI = diskComboBox.SelectedIndex,
                pI = partitionComboBox.SelectedIndex;
            disk.Diskpart("select disk " + dI + "\n" +
                "select partition " + (pI + 1) + "\n" +
                "assign");
            Rescan();
            diskComboBox.SelectedIndex = dI;
            partitionComboBox.SelectedIndex = pI;
        }       

        private void unmountButton_Click(object sender, EventArgs e)
        {
            int dI = diskComboBox.SelectedIndex,
                pI = partitionComboBox.SelectedIndex;
            disk.Diskpart("select disk " + dI + "\n" +
                "select partition " + (pI + 1) + "\n" +
                "remove");
            Rescan();
        }       

        private void formatButton_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("This will delete all data on the drive. Do you want to proceed?", "Quick Format Disk", MessageBoxButtons.OKCancel);
            if (dR == DialogResult.Cancel)
                return;
            int dI = diskComboBox.SelectedIndex,
                pI = partitionComboBox.SelectedIndex;
            disk.Diskpart("select disk " + dI + "\n" +
                "select partition " + (pI + 1) + "\n" +
                "format fs=" + fsTextBox.Text + " quick");
        }       

        private void eraseButton_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("This will delete all data on the drive and write 0s. Do you want to proceed?", "Complete Format Disk", MessageBoxButtons.OKCancel);
            if (dR == DialogResult.Cancel)
                return;
            int dI = diskComboBox.SelectedIndex,
                pI = partitionComboBox.SelectedIndex;
            disk.Diskpart("select disk " + dI + "\n" +
                "select partition " + (pI + 1) + "\n" +
                "clean\n" +
                "create partition primary\n" +
                "format fs=" + fsTextBox.Text + " quick\n" +
                "assign");
        }

        private void partitionCreateButton_Click(object sender, EventArgs e)
        {
            int dI = diskComboBox.SelectedIndex,
                pI = partitionComboBox.SelectedIndex;
            disk.Diskpart("select disk " + dI + "\n" +
                "select partition " + (pI + 1) + "\n" +
                "shrink desired=" + sizeTextBox.Text + "\n" +
                "create partition primary\n" +
                "format fs=" + fsTextBox.Text + " quick\n" +
                "assign");
        }
    }
}
