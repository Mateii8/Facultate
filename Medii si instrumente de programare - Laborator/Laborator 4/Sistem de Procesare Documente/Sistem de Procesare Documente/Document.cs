using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_de_Procesare_Documente
{
    public class Document
    { 
        public string Title { get; set; }  
        public string Content { get; set; }
        
        public string Author { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Content: {Content}";
        }
    }
}
