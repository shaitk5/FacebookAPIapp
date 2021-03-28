using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;
using Facebook;
using FacebookApiApp;

namespace FacebookApiApp
{
     public static class Program
     {
          [STAThread]
          public static void Main()
          {
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new FormProfile());
          }
     }
}
