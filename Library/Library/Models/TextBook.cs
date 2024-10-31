using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;

internal class TextBook(string author, string title, string publisher, string editor) : Publication(author, title, publisher)
{
    public string Editor { get; set; } = editor;
}
