using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class MyString
    {
        private string str;

        public MyString()
        {
            str = "";
        }

        public void SetString(object str)
        {
            this.str = str.ToString();
        }

        public string Str
        {
            get
            {
                return str;
            }
        }
    }
}


