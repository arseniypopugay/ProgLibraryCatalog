using ProgLibraryCatalog.Book;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProgLibraryCatalog
{
    class BookCard
    {
        public string title { get; private set; }
        public Authors authors { get; private set; }
        public string annotation { get; private set; }
        public Available available { get; private set; }

        public BookCard (string title, Authors authors, string annotation, Available available)
        {
            this.title = title;
            this.authors = authors;
            this.annotation = annotation;
            this.available = available;
        }

        public Status get()
        {
            if (!(this.available.have > 0))
                return Status.Problem;

            available.get();
            return Status.OK;
        }

        public Status ret()
        {
            available.Ret();
            return Status.OK;
        }
        
    }
}
