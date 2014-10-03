using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
//using System.Diagnostics;
//using System.Management;

namespace SetupOpenCV
{
    public partial class Form1 : Form
    {
        Xml_Class ProjXml = new Xml_Class();

        public Form1()
        {
            InitializeComponent();
            Check_System_OS_bit();
        }
        
        private void Check_System_OS_bit()
        {
            //// Is64bit = Environment.Is64BitOperatingSystem;  //// << this is for .NET 4.0 up
            //if ((IntPtr.Size) == 8)
            if (Environment.Is64BitOperatingSystem)
            {
                groupBox_OSDefault.Text = "1. System OS is : x64 (64 bit)" ;
                comboBox_SelectOS.SelectedIndex = 1;
                ProjXml.OS_default = true;
                ProjXml.Set_OS_Select_Path(ProjXml.OS_default);
            }
            else
            {
                groupBox_OSDefault.Text = "1. System OS is : x86 (32 bit)" ;
                comboBox_SelectOS.SelectedIndex = 0;
                ProjXml.OS_default = false;
                ProjXml.Set_OS_Select_Path(ProjXml.OS_default);
            }
        }

        private void OS_Select_index_Chenge(object sender, EventArgs e)
        {
            Check_comboBox_SelectOS_State();
        }

        private void Check_comboBox_SelectOS_State()
        {
            if (comboBox_SelectOS.SelectedIndex == 0) /// 0 ==> x86
                ProjXml.Set_OS_Select_Path(false);
            else
                ProjXml.Set_OS_Select_Path(true);
        }

        private void Check_comboBox_VsVer_Change(object sender, EventArgs e)
        {
            String OrignalText = "Your Visual Studio Ver is : ";
            if (comboBox_VSVer.SelectedIndex == 0)
            {
                groupBox_VSVer.Text = OrignalText + "VC9";
                ProjXml.Set_VcProj_Ver_PathName("v9");
                label_VSVer.Text = "Visual Studio 2008";
            }
            else if (comboBox_VSVer.SelectedIndex == 1)
            {
                groupBox_VSVer.Text = OrignalText + "VC10";
                ProjXml.Set_VcProj_Ver_PathName("v100");
                label_VSVer.Text = "Visual Studio 2010";
            }
            else if (comboBox_VSVer.SelectedIndex == 2)
            {
                groupBox_VSVer.Text = OrignalText + "VC11";
                ProjXml.Set_VcProj_Ver_PathName("v110");
                label_VSVer.Text = "Visual Studio 2012";
            }
            else if (comboBox_VSVer.SelectedIndex == 3)
            {
                groupBox_VSVer.Text = OrignalText + "VC12";
                ProjXml.Set_VcProj_Ver_PathName("v120");
                label_VSVer.Text = "Visual Studio 2013";
            }
            else
            {
                groupBox_VSVer.Text = OrignalText;
                ProjXml.Set_VcProj_Ver_PathName("");
                label_VSVer.Text = "";
            }

        }

        private void ToolStripMenuItem_What_Howtouse_Click(object sender, EventArgs e)
        {
           
        }

        private void ToolStripMenuItem_What_About_Click(object sender, EventArgs e)
        {
            AboutBox_A setup_About_Form = new AboutBox_A();
            setup_About_Form.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void button_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_CvPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_CVPath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox_CVPath.Text = folderBrowserDialog_CVPath.SelectedPath;
                ProjXml.Set_CV_IncludePath(folderBrowserDialog_CVPath.SelectedPath);
            }
            else
            {
                if (textBox_CVPath.Text == "")
                {
                    textBox_CVPath.Text = "Where is your OpenCV Path ???";
                }
                else
                {
                    textBox_CVPath.Text = textBox_CVPath.Text;
                }
            }

        }

        private void button_PrjPath_Click(object sender, EventArgs e)
        {
            openFileDialog_PrjPath.Filter = "*.vcxproj|*.vcxproj";
            if (openFileDialog_PrjPath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox_PrjPath.Text = openFileDialog_PrjPath.FileName;
                ProjXml.VcProjXml.Load(openFileDialog_PrjPath.FileName);
                Read_VCProject_Set_Use_Xml(textBox_CVPath.Text);
            }
            else
            {

                if (textBox_PrjPath.Text == "")
                    textBox_PrjPath.Text = "Where is your C Program .vcxproj File ???";
                else
                    textBox_PrjPath.Text = textBox_PrjPath.Text;
                
            }

        }
       
        private void button_Start_Click(object sender, EventArgs e)
        {

            if ((textBox_CVPath.Text == "") || (textBox_CVPath.Text == "Where is your OpenCV Path ???") || (textBox_CVPath.Text == null))
            {
                textBox_Debug.Text = " 3. Where is your OpenCV Path ???\r\n";
                return;
            }

            if ((textBox_PrjPath.Text == "") || (textBox_PrjPath.Text == "Where is your C Program .vcxproj File ???") || (textBox_PrjPath.Text == null))
            {
                textBox_Debug.Text = " 4. Where is your C Program .vcxproj File ???";
                return;
            }

            Get_TextBoxInfo();
            Check_comboBox_SelectOS_State();
            Get_Library_File();
            Write_VCProject_Set_Use_Xml();

            textBox_Debug.Text = "Already create a *.vcxproj in this folder. \r\nPlease copy this *.vcxproj to your project folder.\r\n"  ;
            Check_System_PATH_Have_CV_OrNot();
        }       
        
        private void Get_TextBoxInfo()
        {
            ProjXml.Set_CV_IncludePath(textBox_CVPath.Text);
            ProjXml.VcProjXml.Load(textBox_PrjPath.Text);
           //// ProjXml.VcProjUserXml.Load(textBox_PrjPath.Text + ".user");  ///////SomeTime will make error, what's this control , I'm not sure
        }

        private void Get_Library_File()
        {
            ProjXml.LibraayPath_D = ProjXml.IncludeDefault + ProjXml.OS_Path + ProjXml.VcProj_Ver + "\\lib";
            //ProjXml.LibraayPath_sD = ProjXml.IncludeDefault + ProjXml.OS_Path + ProjXml.VcProj_Ver + "\\staticlib";
            ProjXml.LibraayPath_sD = ProjXml.LibraayPath_D;
            ProjXml.Library_File_Da = new List<string>();
            ProjXml.Library_File_sDa = new List<string>();

            foreach (string fname in System.IO.Directory.GetFiles(ProjXml.LibraayPath_D))
            {
                String[] words = fname.Split('\\');
                foreach (String sbfname in words)
                {
                    if (sbfname.EndsWith("d.lib"))
                    {
                        ProjXml.Library_File_D = ProjXml.Library_File_D + sbfname +  ";" ;
                        ProjXml.Library_File_Da.Add(sbfname.Trim());
                    }
                }
            }

            ///// Load static library (no *d.lib) 
            ///// BUT seem NOT use here, Because in Release mode (in program)
            ///// this place still usd /lib (not *d.lib)
            foreach (string fname in System.IO.Directory.GetFiles(ProjXml.LibraayPath_sD))
            {
                String[] words = fname.Split('\\');
                foreach (String sbfname in words)
                {
                    if (!sbfname.EndsWith("d.lib"))
                    {
                        if (sbfname.EndsWith(".lib"))
                        {
                            ProjXml.Library_File_sD = ProjXml.Library_File_sD + sbfname + ";";
                            ProjXml.Library_File_sDa.Add(sbfname.Trim());
                        }
                    }
                }
            }
            


        }

        private void Read_VCProject_Set_Use_Xml(string thisTextBox_CVPath)
        {
            for (int i = 0; i < ProjXml.VcProjXml.DocumentElement.ChildNodes.Count; i++)
            {
                if (ProjXml.VcProjXml.DocumentElement.ChildNodes[i].Name.ToString() == "PropertyGroup")
                {
                    for (int j = 0; j < ProjXml.VcProjXml.DocumentElement.ChildNodes[i].ChildNodes.Count; j++)
                    {
                        if (ProjXml.VcProjXml.DocumentElement.ChildNodes[i].ChildNodes[j].Name.ToString() == "PlatformToolset")
                        {
                            ProjXml.Set_VcProj_Ver_PathName(ProjXml.VcProjXml.DocumentElement.ChildNodes[i].ChildNodes[j].InnerText);
                        }
                    }
                }
            }            

        }

        private void Write_VCProject_Set_Use_Xml()
        {
            string WantAddPath = textBox_CVPath.Text + @"\build" + ProjXml.OS_Path + ProjXml.VcProj_Ver + @"\bin";

            //// Because it will create "xmlns=" in XmlElement or XmlNode when create(AppendChild), so need remove here and set back in the end ////
            String xmlns = ProjXml.VcProjXml.DocumentElement.NamespaceURI;
            ProjXml.VcProjXml.LoadXml(ProjXml.VcProjXml.OuterXml.Replace(ProjXml.VcProjXml.DocumentElement.NamespaceURI, ""));

            for (int i = 0; i < ProjXml.VcProjXml.DocumentElement.ChildNodes.Count; i++)
            {

                if (ProjXml.VcProjXml.DocumentElement.ChildNodes[i].Name.ToString() == "ItemDefinitionGroup")
                {
                    char delimiterChars = '|';
                    String findThisType = ProjXml.VcProjXml.DocumentElement.ChildNodes[i].OuterXml;
                    String[] words = findThisType.Split(delimiterChars);

                    for (int j = 0; j < ProjXml.VcProjXml.DocumentElement.ChildNodes[i].ChildNodes.Count; j++) 
                    {
                        if (ProjXml.VcProjXml.DocumentElement.ChildNodes[i].ChildNodes[j].Name.ToString() == "ClCompile")
                        {
                            
                            XmlElement CV_include = ProjXml.VcProjXml.CreateElement("AdditionalIncludeDirectories", ProjXml.VcProjXml.NamespaceURI);
                            CV_include.InnerText = ProjXml.IncludePath + ";" + ProjXml.IncludePath_cv1 + ";" + ProjXml.IncludePath_cv2;//+ "(AdditionalIncludeDirectories)";
                            ProjXml.VcProjXml.DocumentElement.ChildNodes[i].ChildNodes[j].AppendChild(CV_include);
                        }

                        if (ProjXml.VcProjXml.DocumentElement.ChildNodes[i].ChildNodes[j].Name.ToString() == "Link")
                        {
                            foreach (string jud in words)
                            {
                                if (jud.EndsWith("Debug"))
                                {
                                    XmlElement CV_includeLib = ProjXml.VcProjXml.CreateElement("AdditionalLibraryDirectories", ProjXml.VcProjXml.NamespaceURI);
                                    CV_includeLib.InnerText = ProjXml.LibraayPath_D;// +";";// +"%(AdditionalLibraryDirectories)";
                                    ProjXml.VcProjXml.DocumentElement.ChildNodes[i].ChildNodes[j].AppendChild(CV_includeLib);

                                    XmlElement CV_includeLibFile = ProjXml.VcProjXml.CreateElement("AdditionalDependencies", ProjXml.VcProjXml.NamespaceURI);
                                    CV_includeLibFile.InnerText = ProjXml.Library_File_D;// +";";// +"%(AdditionalDependencies)";
                                    ProjXml.VcProjXml.DocumentElement.ChildNodes[i].ChildNodes[j].AppendChild(CV_includeLibFile);
                                }
                                else if (jud.EndsWith("Release"))
                                {
                                    XmlElement CV_includeLibR = ProjXml.VcProjXml.CreateElement("AdditionalLibraryDirectories", ProjXml.VcProjXml.NamespaceURI);
                                    CV_includeLibR.InnerText = ProjXml.LibraayPath_sD;// +";";// +"%(AdditionalLibraryDirectories)";
                                    ProjXml.VcProjXml.DocumentElement.ChildNodes[i].ChildNodes[j].AppendChild(CV_includeLibR);

                                    XmlElement CV_includeLibRFile = ProjXml.VcProjXml.CreateElement("AdditionalDependencies", ProjXml.VcProjXml.NamespaceURI);
                                    CV_includeLibRFile.InnerText = ProjXml.Library_File_sD;// +";";// +"%(AdditionalDependencies)";
                                    ProjXml.VcProjXml.DocumentElement.ChildNodes[i].ChildNodes[j].AppendChild(CV_includeLibRFile);
                                }
                            }

                        }
                    }
                }
            }
           
            XmlAttribute returnxmlns = ProjXml.VcProjXml.CreateAttribute("xmlns");
            returnxmlns.Value = xmlns;
            ProjXml.VcProjXml.DocumentElement.Attributes.Append(returnxmlns);
            String[] OutputFileSubset = textBox_PrjPath.Text.Split('\\');
            String OutputFileName;
            foreach (String OFN in OutputFileSubset)
            {
                if (OFN.EndsWith("vcxproj"))
                {
                    OutputFileName = OFN;
                    ProjXml.VcProjXml.Save(OutputFileName);
                }
            }

            
        }

        private void Check_System_PATH_Have_CV_OrNot()
        {
            string WantAddPath = textBox_CVPath.Text + @"\build" + ProjXml.OS_Path +  ProjXml.VcProj_Ver + @"\bin";
            string ThisOSAllPath = Environment.GetEnvironmentVariable("PATH");
            string[] ThisOSPath = ThisOSAllPath.Split(';');

            bool AlreadyHave = false;

            foreach (string onePath in ThisOSPath)
            {
                if ( string.Compare(onePath, WantAddPath, false)  == 0 )
                    AlreadyHave = true;
            }

            if (AlreadyHave)
                textBox_Debug.Text += "System path already include OpenCV path.\r\nOpenCV path is :\r\n" + WantAddPath;
            else
                textBox_Debug.Text += "System path NOT include OpenCV path yet.\r\nOpenCV path is :\r\n" + WantAddPath + "\r\nPlease include system path by yourself.";
        }

    }

}
////  C:\Sec Program Files (x86)\opencv