using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class Pizza:Food
    {
        private int numSlices;

        public int NumSlices
        {
            get { return numSlices; }
            set { numSlices = value; }
        }

    }
}
