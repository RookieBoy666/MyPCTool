using System;
using System.Diagnostics;

namespace MyPCTool.ClassHelper
{
    public static class StartExeFile
    {
        public static void runExe(string path,string fileName)
        {
            //string targetDir1 = AppDomain.CurrentDomain.BaseDirectory; //或者这样写，获取程序目录

            Process process = new Process();   // params 为 string 类型的参数，多个参数以空格分隔，如果某个参数为空，可以传入””
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo.FileName = fileName;
            process.StartInfo.WorkingDirectory = path;
            process.Start();
        }
    }
}
