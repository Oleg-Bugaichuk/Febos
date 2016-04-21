using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Febos
{
    class ClassWordInsertText
    {
        //метод добавления данных в документ! 
        public static void InsertTextToDocument(string stub, string text, Word.Document document)
        {
            var range = document.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stub, ReplaceWith: text);
        }
    }
}
