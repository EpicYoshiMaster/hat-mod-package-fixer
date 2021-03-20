
namespace HatPackageFixer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownOldVersion = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDownNewVersion = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxChangeAllVersions = new System.Windows.Forms.CheckBox();
            this.buttonChangeModPackageVersions = new System.Windows.Forms.Button();
            this.labelFixerInformation = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonModDirectory = new System.Windows.Forms.Button();
            this.buttonDisableAllCB = new System.Windows.Forms.Button();
            this.buttonEnableAllCB = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldVersion)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewVersion)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.checkedListBox1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelFixerInformation, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(379, 311);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 106);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(373, 202);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.Visible = false;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.checkBoxChangeAllVersions, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonChangeModPackageVersions, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(373, 63);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownOldVersion);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Package Version";
            // 
            // numericUpDownOldVersion
            // 
            this.numericUpDownOldVersion.Location = new System.Drawing.Point(116, 3);
            this.numericUpDownOldVersion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownOldVersion.Name = "numericUpDownOldVersion";
            this.numericUpDownOldVersion.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownOldVersion.TabIndex = 1;
            this.numericUpDownOldVersion.Value = new decimal(new int[] {
            889,
            0,
            0,
            0});
            this.numericUpDownOldVersion.ValueChanged += new System.EventHandler(this.numericUpDownOldVersion_ValueChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.numericUpDownNewVersion);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(186, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(187, 31);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // numericUpDownNewVersion
            // 
            this.numericUpDownNewVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownNewVersion.Location = new System.Drawing.Point(136, 3);
            this.numericUpDownNewVersion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNewVersion.Name = "numericUpDownNewVersion";
            this.numericUpDownNewVersion.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownNewVersion.TabIndex = 1;
            this.numericUpDownNewVersion.Value = new decimal(new int[] {
            888,
            0,
            0,
            0});
            this.numericUpDownNewVersion.ValueChanged += new System.EventHandler(this.numericUpDownNewVersion_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Package Version";
            // 
            // checkBoxChangeAllVersions
            // 
            this.checkBoxChangeAllVersions.AutoSize = true;
            this.checkBoxChangeAllVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxChangeAllVersions.Location = new System.Drawing.Point(3, 34);
            this.checkBoxChangeAllVersions.Name = "checkBoxChangeAllVersions";
            this.checkBoxChangeAllVersions.Size = new System.Drawing.Size(180, 26);
            this.checkBoxChangeAllVersions.TabIndex = 2;
            this.checkBoxChangeAllVersions.Text = "Change Any Version";
            this.checkBoxChangeAllVersions.UseVisualStyleBackColor = true;
            this.checkBoxChangeAllVersions.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonChangeModPackageVersions
            // 
            this.buttonChangeModPackageVersions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeModPackageVersions.Enabled = false;
            this.buttonChangeModPackageVersions.Location = new System.Drawing.Point(189, 34);
            this.buttonChangeModPackageVersions.Name = "buttonChangeModPackageVersions";
            this.buttonChangeModPackageVersions.Size = new System.Drawing.Size(181, 22);
            this.buttonChangeModPackageVersions.TabIndex = 3;
            this.buttonChangeModPackageVersions.Text = "Change Mod Package Versions";
            this.buttonChangeModPackageVersions.UseVisualStyleBackColor = true;
            this.buttonChangeModPackageVersions.Click += new System.EventHandler(this.buttonChangeModPackageVersions_Click);
            // 
            // labelFixerInformation
            // 
            this.labelFixerInformation.AutoSize = true;
            this.labelFixerInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFixerInformation.Location = new System.Drawing.Point(3, 0);
            this.labelFixerInformation.Name = "labelFixerInformation";
            this.labelFixerInformation.Size = new System.Drawing.Size(373, 34);
            this.labelFixerInformation.TabIndex = 3;
            this.labelFixerInformation.Text = "No Mods Found! Open the Mod Directory.";
            this.labelFixerInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFixerInformation.UseMnemonic = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.buttonModDirectory, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonDisableAllCB, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonEnableAllCB, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 320);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(379, 100);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonModDirectory
            // 
            this.buttonModDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonModDirectory.Location = new System.Drawing.Point(1, 67);
            this.buttonModDirectory.Margin = new System.Windows.Forms.Padding(1);
            this.buttonModDirectory.Name = "buttonModDirectory";
            this.buttonModDirectory.Size = new System.Drawing.Size(377, 32);
            this.buttonModDirectory.TabIndex = 0;
            this.buttonModDirectory.Text = "Open Mod Directory...";
            this.buttonModDirectory.UseVisualStyleBackColor = true;
            this.buttonModDirectory.Click += new System.EventHandler(this.buttonModDirectory_Click);
            // 
            // buttonDisableAllCB
            // 
            this.buttonDisableAllCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDisableAllCB.Enabled = false;
            this.buttonDisableAllCB.Location = new System.Drawing.Point(1, 34);
            this.buttonDisableAllCB.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDisableAllCB.Name = "buttonDisableAllCB";
            this.buttonDisableAllCB.Size = new System.Drawing.Size(377, 31);
            this.buttonDisableAllCB.TabIndex = 1;
            this.buttonDisableAllCB.Text = "Select None";
            this.buttonDisableAllCB.UseVisualStyleBackColor = true;
            this.buttonDisableAllCB.Click += new System.EventHandler(this.buttonDisableAllCB_Click);
            // 
            // buttonEnableAllCB
            // 
            this.buttonEnableAllCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEnableAllCB.Enabled = false;
            this.buttonEnableAllCB.Location = new System.Drawing.Point(1, 1);
            this.buttonEnableAllCB.Margin = new System.Windows.Forms.Padding(1);
            this.buttonEnableAllCB.Name = "buttonEnableAllCB";
            this.buttonEnableAllCB.Size = new System.Drawing.Size(377, 31);
            this.buttonEnableAllCB.TabIndex = 2;
            this.buttonEnableAllCB.Text = "Select All";
            this.buttonEnableAllCB.UseVisualStyleBackColor = true;
            this.buttonEnableAllCB.Click += new System.EventHandler(this.buttonEnableAllCB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(385, 423);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mod Package Fixer v0.0.0 by EpicYoshiMaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldVersion)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewVersion)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonModDirectory;
        private System.Windows.Forms.Button buttonDisableAllCB;
        private System.Windows.Forms.Button buttonEnableAllCB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownOldVersion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxChangeAllVersions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownNewVersion;
        private System.Windows.Forms.Button buttonChangeModPackageVersions;
        private System.Windows.Forms.Label labelFixerInformation;
    }
}

