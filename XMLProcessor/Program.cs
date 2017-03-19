using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace XMLProcessor
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

            var xmlFile = args.FirstOrDefault();
            var solutionDir = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));

            var xmlFilePath = $"{solutionDir}\\Faculty\\{xmlFile}";
            var xsdFilePath = $"{solutionDir}\\Faculty\\{xmlFile.Replace(".xml", ".xsd")}";
            var xsdExePath = $"{solutionDir}\\packages\\Codaxy.Xsd2.0.9.9\\tools\\Xsd2.exe";

            if (IsXMLFileValid(xmlFilePath, xsdFilePath))
            {
                DeserializeXSDFile(xsdExePath, xsdFilePath);
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

        static bool IsXMLFileValid(string xmlFilePath, string xsdFilePath)
        {
            if (!File.Exists(xmlFilePath))
            {
                Console.WriteLine($"File {Path.GetFileName(xmlFilePath)} does not exists.");
                return false;
            }

            XNamespace @namespace = "https://ww2.mini.pw.edu.pl/dla-studenta/plan/";

            var xdoc = XDocument.Load(xmlFilePath);
            var schema = new XmlSchemaSet();
            schema.Add(@namespace.ToString(), xsdFilePath);

            Console.WriteLine($"Validating {Path.GetFileName(xmlFilePath)} file against {Path.GetFileName(xsdFilePath)} file...");
            try
            {
                xdoc.Validate(schema, null);
            }
            catch (XmlSchemaValidationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        static void DeserializeXSDFile(string xsdExePath, string xsdFilePath)
        {
            Console.WriteLine($"Deserializing {xsdFilePath} file...");

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = xsdExePath;
            startInfo.Arguments = xsdFilePath;
            Process.Start(startInfo);
        }
    }
}
