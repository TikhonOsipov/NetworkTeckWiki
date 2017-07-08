using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlevonProject
{
    class PdfDocumentReader
    {
        public PdfDocumentReader(string path, WebBrowser browser)
        {
            object filename = path;
            browser.Navigate(path);
        }
    }
}
