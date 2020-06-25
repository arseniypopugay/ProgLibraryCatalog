using System;
using System.Collections.Generic;
using System.Text;

namespace ProgLibraryCatalog.Book
{
    class Available
    {
        public int have { get; private set; }
        public int possible { get; private set; }

        public Available(int possible)
        {
            this.possible = possible;
            this.have = possible;
        }

        public void get()
        {
            if (this.have>0)
            {
                this.have -= 1;
            }
        }

        public void Ret()
        {
            this.have += 1;
        }
    }
}
