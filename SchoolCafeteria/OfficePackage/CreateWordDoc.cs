using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml;
using System.Xml.Xsl;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace SchoolCafeteria.OfficePackage
{
    public static class CreateWordDoc
    {
        public static void CreteDocument()
        {
            StringWriter stringWriter = new StringWriter();
            XmlWriter xmlWriter = XmlWriter.Create(stringWriter);

            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load("docXSL.xslt");

            XmlReader reader = XmlReader.Create("xmlDoc");

            transform.Transform(reader, xmlWriter);

            XmlDocument newWordContent = new XmlDocument();
            newWordContent.LoadXml(stringWriter.ToString());
            using WordprocessingDocument doc = WordprocessingDocument.Open("шаблон.docx", true);

            Body updatedBodyContent = new Body(newWordContent.DocumentElement.InnerXml);

            doc.MainDocumentPart.Document.Body = updatedBodyContent;

            doc.MainDocumentPart.Document.Save();

            reader.Dispose();
        }
    }
}
