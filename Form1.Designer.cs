namespace Raidiate
{
    partial class radiate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button formatButton;
            System.Windows.Forms.Button eraseButton;
            System.Windows.Forms.Button partitionButton;
            System.Windows.Forms.Button diskButton;
            System.Windows.Forms.Button filesystemButton;
            System.Windows.Forms.Button unmountButton;
            System.Windows.Forms.Button mountButton;
            System.Windows.Forms.Button rescanButton;
            System.Windows.Forms.Button partitionCreateButton;
            this.diskControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.diskInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.diskComboBox = new System.Windows.Forms.ComboBox();
            this.diskSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.partitionLabel = new System.Windows.Forms.Label();
            this.diskLabel = new System.Windows.Forms.Label();
            this.partitionComboBox = new System.Windows.Forms.ComboBox();
            this.diskMountControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.fsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            formatButton = new System.Windows.Forms.Button();
            eraseButton = new System.Windows.Forms.Button();
            partitionButton = new System.Windows.Forms.Button();
            diskButton = new System.Windows.Forms.Button();
            filesystemButton = new System.Windows.Forms.Button();
            unmountButton = new System.Windows.Forms.Button();
            mountButton = new System.Windows.Forms.Button();
            rescanButton = new System.Windows.Forms.Button();
            partitionCreateButton = new System.Windows.Forms.Button();
            this.diskControlsGroupBox.SuspendLayout();
            this.diskInfoGroupBox.SuspendLayout();
            this.diskSelectionGroupBox.SuspendLayout();
            this.diskMountControlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // formatButton
            // 
            formatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            formatButton.Location = new System.Drawing.Point(55, 156);
            formatButton.Name = "formatButton";
            formatButton.Size = new System.Drawing.Size(125, 23);
            formatButton.TabIndex = 0;
            formatButton.Text = "Format";
            formatButton.UseVisualStyleBackColor = true;
            formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // eraseButton
            // 
            eraseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            eraseButton.Location = new System.Drawing.Point(55, 185);
            eraseButton.Name = "eraseButton";
            eraseButton.Size = new System.Drawing.Size(125, 23);
            eraseButton.TabIndex = 0;
            eraseButton.Text = "Write 0s";
            eraseButton.UseVisualStyleBackColor = true;
            eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // partitionButton
            // 
            partitionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            partitionButton.Location = new System.Drawing.Point(55, 64);
            partitionButton.Name = "partitionButton";
            partitionButton.Size = new System.Drawing.Size(125, 23);
            partitionButton.TabIndex = 0;
            partitionButton.Text = "Partition";
            partitionButton.UseVisualStyleBackColor = true;
            partitionButton.Click += new System.EventHandler(this.partitionButton_Click);
            // 
            // diskButton
            // 
            diskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            diskButton.Location = new System.Drawing.Point(55, 35);
            diskButton.Name = "diskButton";
            diskButton.Size = new System.Drawing.Size(125, 23);
            diskButton.TabIndex = 0;
            diskButton.Text = "Disk";
            diskButton.UseVisualStyleBackColor = true;
            diskButton.Click += new System.EventHandler(this.diskButton_Click);
            // 
            // filesystemButton
            // 
            filesystemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            filesystemButton.Location = new System.Drawing.Point(55, 93);
            filesystemButton.Name = "filesystemButton";
            filesystemButton.Size = new System.Drawing.Size(125, 23);
            filesystemButton.TabIndex = 0;
            filesystemButton.Text = "Filesystem";
            filesystemButton.UseVisualStyleBackColor = true;
            filesystemButton.Click += new System.EventHandler(this.filesystemButton_Click);
            // 
            // unmountButton
            // 
            unmountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            unmountButton.Location = new System.Drawing.Point(55, 62);
            unmountButton.Name = "unmountButton";
            unmountButton.Size = new System.Drawing.Size(125, 23);
            unmountButton.TabIndex = 0;
            unmountButton.Text = "Unmount";
            unmountButton.UseVisualStyleBackColor = true;
            unmountButton.Click += new System.EventHandler(this.unmountButton_Click);
            // 
            // mountButton
            // 
            mountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            mountButton.Location = new System.Drawing.Point(55, 33);
            mountButton.Name = "mountButton";
            mountButton.Size = new System.Drawing.Size(125, 23);
            mountButton.TabIndex = 0;
            mountButton.Text = "Mount";
            mountButton.UseVisualStyleBackColor = true;
            mountButton.Click += new System.EventHandler(this.mountButton_Click);
            // 
            // rescanButton
            // 
            rescanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            rescanButton.Location = new System.Drawing.Point(77, 149);
            rescanButton.Name = "rescanButton";
            rescanButton.Size = new System.Drawing.Size(92, 23);
            rescanButton.TabIndex = 0;
            rescanButton.Text = "Rescan";
            rescanButton.UseVisualStyleBackColor = true;
            rescanButton.Click += new System.EventHandler(this.rescanButton_Click);
            // 
            // partitionCreateButton
            // 
            partitionCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            partitionCreateButton.Location = new System.Drawing.Point(55, 127);
            partitionCreateButton.Name = "partitionCreateButton";
            partitionCreateButton.Size = new System.Drawing.Size(125, 23);
            partitionCreateButton.TabIndex = 0;
            partitionCreateButton.Text = "Partition";
            partitionCreateButton.UseVisualStyleBackColor = true;
            partitionCreateButton.Click += new System.EventHandler(this.partitionCreateButton_Click);
            // 
            // diskControlsGroupBox
            // 
            this.diskControlsGroupBox.Controls.Add(this.label2);
            this.diskControlsGroupBox.Controls.Add(this.sizeTextBox);
            this.diskControlsGroupBox.Controls.Add(this.label1);
            this.diskControlsGroupBox.Controls.Add(this.fsTextBox);
            this.diskControlsGroupBox.Controls.Add(partitionCreateButton);
            this.diskControlsGroupBox.Controls.Add(eraseButton);
            this.diskControlsGroupBox.Controls.Add(formatButton);
            this.diskControlsGroupBox.Location = new System.Drawing.Point(257, 243);
            this.diskControlsGroupBox.Name = "diskControlsGroupBox";
            this.diskControlsGroupBox.Size = new System.Drawing.Size(234, 260);
            this.diskControlsGroupBox.TabIndex = 0;
            this.diskControlsGroupBox.TabStop = false;
            this.diskControlsGroupBox.Text = "Disk Controls";
            // 
            // diskInfoGroupBox
            // 
            this.diskInfoGroupBox.Controls.Add(filesystemButton);
            this.diskInfoGroupBox.Controls.Add(partitionButton);
            this.diskInfoGroupBox.Controls.Add(diskButton);
            this.diskInfoGroupBox.Location = new System.Drawing.Point(17, 243);
            this.diskInfoGroupBox.Name = "diskInfoGroupBox";
            this.diskInfoGroupBox.Size = new System.Drawing.Size(234, 141);
            this.diskInfoGroupBox.TabIndex = 0;
            this.diskInfoGroupBox.TabStop = false;
            this.diskInfoGroupBox.Text = "Disk Information";
            // 
            // diskComboBox
            // 
            this.diskComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.diskComboBox.FormattingEnabled = true;
            this.diskComboBox.Location = new System.Drawing.Point(77, 68);
            this.diskComboBox.Name = "diskComboBox";
            this.diskComboBox.Size = new System.Drawing.Size(309, 24);
            this.diskComboBox.TabIndex = 1;
            this.diskComboBox.SelectedIndexChanged += new System.EventHandler(this.diskComboBox_SelectedIndexChanged);
            // 
            // diskSelectionGroupBox
            // 
            this.diskSelectionGroupBox.Controls.Add(this.partitionLabel);
            this.diskSelectionGroupBox.Controls.Add(this.diskLabel);
            this.diskSelectionGroupBox.Controls.Add(rescanButton);
            this.diskSelectionGroupBox.Controls.Add(this.partitionComboBox);
            this.diskSelectionGroupBox.Controls.Add(this.diskComboBox);
            this.diskSelectionGroupBox.Location = new System.Drawing.Point(17, 13);
            this.diskSelectionGroupBox.Name = "diskSelectionGroupBox";
            this.diskSelectionGroupBox.Size = new System.Drawing.Size(474, 224);
            this.diskSelectionGroupBox.TabIndex = 2;
            this.diskSelectionGroupBox.TabStop = false;
            this.diskSelectionGroupBox.Text = "Disk Selection";
            // 
            // partitionLabel
            // 
            this.partitionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.partitionLabel.AutoSize = true;
            this.partitionLabel.Location = new System.Drawing.Point(74, 95);
            this.partitionLabel.Name = "partitionLabel";
            this.partitionLabel.Size = new System.Drawing.Size(60, 17);
            this.partitionLabel.TabIndex = 0;
            this.partitionLabel.Text = "Partition";
            // 
            // diskLabel
            // 
            this.diskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.diskLabel.AutoSize = true;
            this.diskLabel.Location = new System.Drawing.Point(74, 48);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(35, 17);
            this.diskLabel.TabIndex = 0;
            this.diskLabel.Text = "Disk";
            // 
            // partitionComboBox
            // 
            this.partitionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.partitionComboBox.FormattingEnabled = true;
            this.partitionComboBox.Location = new System.Drawing.Point(77, 119);
            this.partitionComboBox.Name = "partitionComboBox";
            this.partitionComboBox.Size = new System.Drawing.Size(121, 24);
            this.partitionComboBox.TabIndex = 1;
            // 
            // diskMountControlsGroupBox
            // 
            this.diskMountControlsGroupBox.Controls.Add(unmountButton);
            this.diskMountControlsGroupBox.Controls.Add(mountButton);
            this.diskMountControlsGroupBox.Location = new System.Drawing.Point(17, 390);
            this.diskMountControlsGroupBox.Name = "diskMountControlsGroupBox";
            this.diskMountControlsGroupBox.Size = new System.Drawing.Size(234, 113);
            this.diskMountControlsGroupBox.TabIndex = 0;
            this.diskMountControlsGroupBox.TabStop = false;
            this.diskMountControlsGroupBox.Text = "Disk Mount Controls";
            // 
            // fsTextBox
            // 
            this.fsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fsTextBox.Location = new System.Drawing.Point(99, 54);
            this.fsTextBox.Name = "fsTextBox";
            this.fsTextBox.Size = new System.Drawing.Size(81, 22);
            this.fsTextBox.TabIndex = 1;
            this.fsTextBox.Text = "fat32";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "FS =";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeTextBox.Location = new System.Drawing.Point(113, 80);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(67, 22);
            this.sizeTextBox.TabIndex = 3;
            this.sizeTextBox.Text = "1024";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size = ";
            // 
            // radiate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(505, 516);
            this.Controls.Add(this.diskSelectionGroupBox);
            this.Controls.Add(this.diskInfoGroupBox);
            this.Controls.Add(this.diskMountControlsGroupBox);
            this.Controls.Add(this.diskControlsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "radiate";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Raidiate";
            this.diskControlsGroupBox.ResumeLayout(false);
            this.diskControlsGroupBox.PerformLayout();
            this.diskInfoGroupBox.ResumeLayout(false);
            this.diskSelectionGroupBox.ResumeLayout(false);
            this.diskSelectionGroupBox.PerformLayout();
            this.diskMountControlsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox diskControlsGroupBox;
        private System.Windows.Forms.GroupBox diskInfoGroupBox;
        private System.Windows.Forms.ComboBox diskComboBox;
        private System.Windows.Forms.GroupBox diskSelectionGroupBox;
        private System.Windows.Forms.Label diskLabel;
        private System.Windows.Forms.Label partitionLabel;
        private System.Windows.Forms.ComboBox partitionComboBox;
        private System.Windows.Forms.GroupBox diskMountControlsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sizeTextBox;
    }
}

