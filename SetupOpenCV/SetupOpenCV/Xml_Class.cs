using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SetupOpenCV
{
    class Xml_Class
    {
        public bool OS_default;
        public String OS_Path;
        public String VcProj_Ver;
        public String IncludeDefault ;
        public String IncludePath ;
        public String IncludePath_cv1 ;
        public String IncludePath_cv2 ;
        public String LibraayPath_D ;
        public String LibraayPath_sD ;

        public char nowisdugorrelease;

        public String Library_File_D;
        public String Library_File_sD;
        public List<string> Library_File_Da;
        public List<string> Library_File_sDa;

        public XmlDocument VcProjXml = new XmlDocument();
        public XmlDocument VcProjUserXml = new XmlDocument();

        public void Set_OS_Select_Path(bool IS64Bit)
        {
            if (IS64Bit)
                OS_Path = "\\x64";
            else
                OS_Path = "\\x86";
        }
        
        public void Set_VcProj_Ver_PathName(string Ver)
        {
            if (Ver == "v9")
            {
                VcProj_Ver = "\\vc9";
            }
            else if (Ver == "v100")
            {
                VcProj_Ver = "\\vc10";
            }
            else if (Ver == "v110")
            {
                VcProj_Ver = "\\vc11";
            }
            else if (Ver == "v120")
            {
                VcProj_Ver = "\\vc12";
            }
            else
            {
                VcProj_Ver = "";
            }
        }

        public void Get_CV_Lib_File()
        {

        }

        public void Set_CV_IncludePath(String in_path)
        {
            IncludeDefault = in_path + "\\build";
            IncludePath = IncludeDefault + "\\include";
            IncludePath_cv1 = IncludePath + "\\opencv";
            IncludePath_cv2 = IncludePath + "\\opencv2";
            //Set_CV_LibraryPath();
        }

        public void Set_CV_LibraryPath()
        {
            LibraayPath_D = IncludeDefault + OS_Path + VcProj_Ver +"\\lib";
            LibraayPath_sD = IncludeDefault + OS_Path + VcProj_Ver + "\\staticlib";
        }

    }
}
