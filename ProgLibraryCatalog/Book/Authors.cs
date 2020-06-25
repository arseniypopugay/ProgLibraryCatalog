using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProgLibraryCatalog.Book
{
    class Authors
    {
        public List<string> authors { get; private set; }

        public Authors(string they)
        {
 
            foreach(String a in they.Split(','))
            {
                authors.Add(a.Trim());
            }

        }

        public bool contains(String author)
        {
            return authors.Contains(author);
        }

    }
}
