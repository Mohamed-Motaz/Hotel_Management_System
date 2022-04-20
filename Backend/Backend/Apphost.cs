using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Backend
{
    public class Apphost
    {
        public static string DB_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.sqlite");
    }
}