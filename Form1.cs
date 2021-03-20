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
using WK.Libraries.BetterFolderBrowserNS;

namespace HatPackageFixer
{
    public partial class Form1 : Form
    {
        private BetterFolderBrowser betterFolderBrowser1;
        private List<ModFolder> AllMods;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllMods = new List<ModFolder>();
        }

        public struct ModFolder
        {
            public string ModName;
            public string versionString; //(#, #, ..., #)
            public string filePath;
            public List<string> packagePaths;
            public List<int> fileVersions;
            public int fileCount;
            public bool isChecked; //So we can cache this result
        }

        //Handles setting up the Mod Folders upon selectin a Mod Directory
        private void buttonModDirectory_Click(object sender, EventArgs e)
        {
            if (betterFolderBrowser1 == null)
            {
                betterFolderBrowser1 = new BetterFolderBrowser();

                betterFolderBrowser1.Title = "Select Mod Folder Directory";
                //betterFolderBrowser1.RootFolder = "C:\\";
            }

            if (betterFolderBrowser1.ShowDialog(this.FindForm()) == DialogResult.OK)
            {

                //Refresh Mods and CheckBoxList
                getModFolders(betterFolderBrowser1.SelectedPath);

                //Maybe the user selected a direct Mod folder instead of the directory, lets see.
                if(AllMods.Count <= 0)
                {
                    ModFolder NewMod;
                    NewMod = new ModFolder();
                    NewMod.filePath = betterFolderBrowser1.SelectedPath;
                    NewMod.ModName = Path.GetFileName(NewMod.filePath);
                    NewMod.fileVersions = new List<int>();
                    NewMod.packagePaths = new List<string>();
                    NewMod.fileCount = isValidModFolder(NewMod.filePath, ref NewMod.fileVersions, ref NewMod.packagePaths);

                    //This is now a valid mod.
                    if (NewMod.fileCount > 0)
                    {
                        NewMod.versionString = buildVersionString(ref NewMod.fileVersions);

                        AllMods.Add(NewMod);

                        setCheckBoxList();
                    }

                }
            }
        }

        //Grabs Mod Folders (Starts from scratch)
        private void getModFolders(string modDirectory)
        {
            AllMods.Clear();

            //Grabs all possible Mod Folders
            List<string> possFolders = new List<string>(Directory.GetDirectories(betterFolderBrowser1.SelectedPath));

            for(int i = 0; i < possFolders.Count; i++)
            {
                //Make a new Mod
                ModFolder NewMod;

                NewMod = new ModFolder();

                //This is the path to the Mod Folder
                NewMod.filePath = Path.GetFullPath(possFolders.ElementAt(i).TrimEnd(Path.DirectorySeparatorChar));

                //This is the name we refer to the Mod by in the checkboxes
                NewMod.ModName = Path.GetFileName(NewMod.filePath);

                //Initialize file versions list
                NewMod.fileVersions = new List<int>();

                //Initialize package paths list
                NewMod.packagePaths = new List<string>();

                //Update accordingly
                NewMod.fileCount = isValidModFolder(NewMod.filePath, ref NewMod.fileVersions, ref NewMod.packagePaths);

                //This is now a valid mod.
                if(NewMod.fileCount > 0)
                {
                    NewMod.versionString = buildVersionString(ref NewMod.fileVersions);

                    AllMods.Add(NewMod);
                }

            }

            //Refresh Checkbox with new Mods
            setCheckBoxList();

        }

        //Updates Mod Folders (Keeps same mods present)
        private void updateModFolders()
        {
            for(int i = 0; i < AllMods.Count; i++)
            {
                ModFolder updatedMod;
                updatedMod = new ModFolder();
                updatedMod = AllMods.ElementAt(i);

                //Since this is what should be changing
                updatedMod.fileVersions.Clear();

                updatedMod.fileCount = isValidModFolder(updatedMod.filePath, ref updatedMod.fileVersions, ref updatedMod.packagePaths);

                updatedMod.versionString = buildVersionString(ref updatedMod.fileVersions);

                AllMods[i] = updatedMod;
            }

            updateCheckBoxList();
        }

        //Sets Check Box List (From Scratch)
        private void setCheckBoxList()
        {
            checkedListBox1.Items.Clear();

            for (int i = 0; i < AllMods.Count; i++)
            {
                checkedListBox1.Items.Add(AllMods.ElementAt(i).ModName + " - " + AllMods.ElementAt(i).fileCount + " Package Files " + AllMods.ElementAt(i).versionString);
            }

            setAllCheckListBoxState(true);
            
            if (checkedListBox1.Items.Count > 0)
            {
                checkedListBox1.Visible = true;
                buttonEnableAllCB.Enabled = true;
                buttonDisableAllCB.Enabled = true;

                labelFixerInformation.Text = "Select Mods -> Select Package Versions -> Press " +
                    "\"Change Mod Package Versions\" to apply!";
            }
            else
            {
                checkedListBox1.Visible = false;
                buttonEnableAllCB.Enabled = false;
                buttonDisableAllCB.Enabled = false;

                labelFixerInformation.Text = "No Mods Found! Open the Mod Directory.";
            }

            checkButtonMPVStatus();
        }

        //Updates the Check Box List
        private void updateCheckBoxList()
        {
            for(int i = 0; i < AllMods.Count; i++)
            {
                checkedListBox1.Items[i] = AllMods.ElementAt(i).ModName + " - " + AllMods.ElementAt(i).fileCount + " Package Files " + AllMods.ElementAt(i).versionString;
            }
        }

        //Returns version string for a set of versions
        private string buildVersionString(ref List<int> fileVersions)
        {
            StringBuilder versionString = new StringBuilder();
            versionString.Append("(");
            for (int j = 0; j < fileVersions.Count; j++)
            {
                versionString.Append(fileVersions.ElementAt(j));
                if (j < fileVersions.Count - 1)
                {
                    versionString.Append(", ");
                }
            }
            versionString.Append(")");
            return versionString.ToString();
        }

        //Ensures the subfolders are that of a Mod folder
        //Returns the # of relevant files found in the mod directory
        private int isValidModFolder(string fullPath, ref List<int> fileVersions, ref List<string> packagePaths)
        {
            int relevantFiles = 0;

            if(Directory.Exists(fullPath + "\\CompiledScripts"))
            {
                relevantFiles += getRelevantFileCount(fullPath + "\\CompiledScripts", ref fileVersions, ref packagePaths);
            }

            if(Directory.Exists(fullPath + "\\CookedPC"))
            {
                relevantFiles += getRelevantFileCount(fullPath + "\\CookedPC", ref fileVersions, ref packagePaths);
            }

            if(Directory.Exists(fullPath + "\\Content"))
            {
                relevantFiles += getRelevantFileCount(fullPath + "\\Content", ref fileVersions, ref packagePaths);
            }

            if(Directory.Exists(fullPath + "\\maps"))
            {
                relevantFiles += getRelevantFileCount(fullPath + "\\maps", ref fileVersions, ref packagePaths);
            }
            if (Directory.Exists(fullPath + "\\Shadercache"))
            {
                relevantFiles += getRelevantFileCount(fullPath + "\\Shadercache", ref fileVersions, ref packagePaths);
            }

            //Clean it up
            fileVersions.Sort();

            return relevantFiles;
        }

        private int getRelevantFileCount(string fullPath, ref List<int> fileVersions, ref List<string> packagePaths)
        {
            int RelevantFiles = 0;
            List<string> Files = new List<string>(Directory.GetFiles(fullPath, "*.u"));
            Files.AddRange(new List<string>(Directory.GetFiles(fullPath, "*.upk")));
            Files.AddRange(new List<string>(Directory.GetFiles(fullPath, "*.umap")));
            RelevantFiles += Files.Count();

            for(int i = 0; i < Files.Count; i++)
            {
                int newVersion = getFileVersion(Files.ElementAt(i));
                if(!fileVersions.Contains(newVersion))
                {
                    //Debug.WriteLine("Adding Version " + newVersion);
                    fileVersions.Add(newVersion);
                }
            }

            packagePaths.AddRange(Files);

            return RelevantFiles;
        }

        private int getFileVersion(string fullFilePath)
        {
            try
            {
                BinaryReader binReader = new BinaryReader(File.Open(fullFilePath, FileMode.Open));
                binReader.ReadInt32();
                int result = binReader.ReadUInt16();

                binReader.Close();
                return result;
            }
            catch(Exception e)
            {
                Debug.WriteLine("Exception {0}", e);
            }
            

            return -1;
        }

        private void setAllCheckListBoxState(bool newState)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, newState);
            }
        }

        private void buttonEnableAllCB_Click(object sender, EventArgs e)
        {
            setAllCheckListBoxState(true);
            checkButtonMPVStatus();
        }

        private void buttonDisableAllCB_Click(object sender, EventArgs e)
        {
            setAllCheckListBoxState(false);
            checkButtonMPVStatus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxChangeAllVersions.CheckState == CheckState.Checked)
            {
                numericUpDownOldVersion.Enabled = false;
            }
            else
            {
                numericUpDownOldVersion.Enabled = true;
            }

            checkButtonMPVStatus();
        }

        //Performs actual operation of changing package versions, returns # of files altered
        private int changeModPackageVersion(ModFolder Mod, ushort NewVersion, bool changeAllVersions, ushort OldVersion)
        {
            int modifiedFileCount = 0;

            for(int i = 0; i < Mod.packagePaths.Count; i++)
            {
                try
                {
                    //First double check this file should be written to
                    BinaryReader binReader = new BinaryReader(File.Open(Mod.packagePaths.ElementAt(i), FileMode.Open));
                    binReader.ReadInt32(); //Skip a 32 bit integer size
                    ushort fileVersion = binReader.ReadUInt16();

                    binReader.Close();

                    //Make sure we aren't writing the exact same version and that this version is one intended to be written to
                    if (fileVersion != NewVersion && (changeAllVersions || fileVersion == OldVersion))
                    {
                        BinaryWriter binWriter = new BinaryWriter(File.Open(Mod.packagePaths.ElementAt(i), FileMode.Open));
                        binWriter.Seek(4, SeekOrigin.Begin); //Skip a 32 bit integer size

                        binWriter.Write(NewVersion); //Write the 16 bit unsigned integer package version number

                        binWriter.Close();

                        modifiedFileCount++;
                    }
                    
                }
                catch (Exception e)
                {
                    Debug.WriteLine("Exception {0}", e);
                }
            }

            return modifiedFileCount;
        }

        //Time to actually change the mod package versions!!!!
        private void buttonChangeModPackageVersions_Click(object sender, EventArgs e)
        {
            //If we're trying to change things to the exact same version we're not changing all versions, don't even try
            if (((ushort)numericUpDownNewVersion.Value == (ushort)numericUpDownOldVersion.Value) && !checkBoxChangeAllVersions.Checked) return;

            int totalModifiedFiles = 0;
            for(int i = 0; i < AllMods.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    totalModifiedFiles += changeModPackageVersion(AllMods.ElementAt(i), (ushort)numericUpDownNewVersion.Value, checkBoxChangeAllVersions.Checked, (ushort)numericUpDownOldVersion.Value);
                }
                
            }

            labelFixerInformation.Text = "Modified " + totalModifiedFiles + " Package Files to Package Version " + (int)numericUpDownNewVersion.Value + "!";

            updateModFolders();
        }

        private void numericUpDownOldVersion_ValueChanged(object sender, EventArgs e)
        {
            checkButtonMPVStatus();
        }

        private void numericUpDownNewVersion_ValueChanged(object sender, EventArgs e)
        {
            checkButtonMPVStatus();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkButtonMPVStatus();
        }

        private void checkButtonMPVStatus()
        {
            buttonChangeModPackageVersions.Enabled = true;

            if ((int)numericUpDownNewVersion.Value == (int)numericUpDownOldVersion.Value && !checkBoxChangeAllVersions.Checked)
            {
                buttonChangeModPackageVersions.Enabled = false;
            }
            else if(checkedListBox1.Items.Count <= 0 || checkedListBox1.CheckedItems.Count <= 0)
            {
                buttonChangeModPackageVersions.Enabled = false;
            }
        }
    }
}
