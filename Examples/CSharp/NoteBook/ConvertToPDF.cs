
using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.NoteBook
{
    public class ConvertToPDF
    {
        public static void Run()
        {
            // ExStart:ConvertToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // Load a OneNote Notebook
            var notebook = new Notebook(dataDir + "Notizbuch �ffnen.onetoc2");

            dataDir = dataDir + "ConvertToPDF_out_.pdf";

            // Save the Notebook
            notebook.Save(dataDir);

            // ExEnd:ConvertToImage
            Console.WriteLine("\nNoteBook document converted to pdf successfully.\nFile saved at " + dataDir);
        }
    }
}