﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class KataRemoveChar
    {
        public static string Remove_char(string s)
        {
            if (s.Length == 2)
            {
                return string.Empty;
            }
            return s.Substring(1, s.Length - 2);
        }
    }
}
