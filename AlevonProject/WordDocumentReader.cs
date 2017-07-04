using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;

namespace AlevonProject
{
    class WordDocumentReader
    {
        public WordDocumentReader(string path, RichTextBox richTextBox)
        {
            object filename = path;
            var AC = new Word.Application();
            var doc = new Word.Document();
            object readOnly = false;
            object isVisible = true;
            object missing = System.Reflection.Missing.Value;
            try
            {
                doc = AC.Documents.Open(ref filename, ref missing, ref readOnly, ref missing, 
                    ref missing, ref missing, ref missing, ref missing, 
                    ref missing, ref missing, ref missing, ref isVisible);
                doc.Content.Select();
                doc.Content.Copy();
                richTextBox.Paste();
                //focus to the start of the document
                richTextBox.SelectionLength = 0;
                richTextBox.SelectionStart = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                doc.Close(ref missing, ref missing, ref missing);
            }
        }
    }
}
