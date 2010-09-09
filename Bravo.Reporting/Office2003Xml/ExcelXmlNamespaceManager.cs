﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Bravo.Reporting.Office2003Xml
{
    internal sealed class ExcelXmlNamespaceManager : XmlNamespaceManager
    {
        public const string WorkbookNamespace = @"urn:schemas-microsoft-com:office:spreadsheet";
        public const string ONamespace = @"urn:schemas-microsoft-com:office:office";
        public const string XNamespace = @"urn:schemas-microsoft-com:office:excel";
        public const string SSNamespace = @"urn:schemas-microsoft-com:office:spreadsheet";
        public const string HtmlNamespace = @"http://www.w3.org/TR/REC-html40";
        public const string ExcelWorkbookNamespace = @"urn:schemas-microsoft-com:office:excel";

        public ExcelXmlNamespaceManager(XmlNameTable xnt)
            : base(xnt)
        {
        }

        public void LoadOpenDocumentNamespaces()
        {
            this.AddNamespace("o", ONamespace);
            this.AddNamespace("x", XNamespace);
            this.AddNamespace("ss", SSNamespace);
            this.AddNamespace("html", HtmlNamespace);
        }
    }
}