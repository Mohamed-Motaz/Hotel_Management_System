﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Backend.Models.Loggers
{
    public class FileLogger : Logger
    {
        private string CurrentDirectory
        {
            get;
            set;
        }
        private string FileName
        {
            get;
            set;
        }
        private string FilePath
        {
            get;
            set;
        }
        public FileLogger(int level)
        {
            this.level = level;
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Log/txt";
            this.FilePath = this.CurrentDirectory + "/" + this.FileName;
        }

        public override void write(string messages)
        {

            using (StreamWriter w = File.AppendText(this.FilePath))
            {
                w.Write("/r/nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine("   :{0}", messages);
                w.WriteLine("----------------------------------------------");
            }

            /*string logFilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            FileInfo logFileInfo = new FileInfo(logFilePath);
            DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            using (FileStream fileStream = new FileStream(logFilePath, FileMode.Append))
            {
                using (StreamWriter log = new StreamWriter(fileStream))
                {
                    log.WriteLine(messages);
                }
            }*/
        }
    }
}