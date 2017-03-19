using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace HTMLCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!AreProgramParametersValid(args))
            {
                Console.WriteLine("Supply XML file path as program parameter.");
                return;
            }

            var xmlFile = args.First();
            var solutionDir = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));

            var xmlFilePath = $"{solutionDir}\\Faculty\\{xmlFile}";
            var htmlFilePath = $"{solutionDir}\\HTMLCreator\\{xmlFile.Replace(".xml", ".html")}";

            Console.WriteLine("Creating HTML from XSLT file...");
            try
            {
                var xslCompiledTransform = new XslCompiledTransform();
                xslCompiledTransform.Load("Faculty.xslt");
                xslCompiledTransform.Transform(xmlFilePath, htmlFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static bool AreProgramParametersValid(string[] args)
        {
            if (args == null || args.Count() <= 0 || args.First() == null)
            {
                return false;
            }

            return true;
        }
    }
}
