﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWindowsService
{
    public static class Library
    {
        public static void WriteErrorLog(string Message) {
            StreamWriter sw = null;
            try
            {
sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory+"\\LogFile.txt",true);
                sw.Flush();
                sw.Close();
            }
            catch
            {
             
            }
        }
  

    }
}