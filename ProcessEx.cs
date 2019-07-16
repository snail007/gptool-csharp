using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace GoProxyTool
{
    //在刚学C#，用ManagementObjectSearcher 竟然不能解析到头文件，需要手动 Add Referance..
    //我们用到的主要类是ManagementObjectSearcher,该类在System.Management命名空间下
    public static class ProcessEx

    {
        /// <summary>
        /// 结束进程树
        /// </summary>
        /// <param name="parent">父进程</param>
        public static void KillProcessTree(this Process parent)
        {
            var searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + parent.Id);
            var moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                Process childProcess = Process.GetProcessById(Convert.ToInt32(mo["ProcessID"]));//通过子进程ID获取该进程实例
                childProcess.KillProcessTree();//调用拓展方法结束当前进程的所有子进程
            }
            Console.WriteLine(string.Format("kill process by id {0}!", parent.Id));
            //不能结束自己
            if (parent.Id != Process.GetCurrentProcess().Id)
                parent.Kill();//结束当前进程
        }
        /// <summary>
        /// 结束指定进程和它的进程树（所有子进程）
        /// </summary>
        /// <param name="pid">进程Id</param>
        public static void KillProcessTreeById(int pid)
        {
            try
            {
                var process = Process.GetProcessById(pid);//获取当前进程
                try
                {
                    process.KillProcessTree();//结束进程树
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch
            {
                Console.WriteLine("failed to get the process!");
                var searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid);
                var moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    Process childProcess = Process.GetProcessById(Convert.ToInt32(mo["ProcessID"]));//通过子进程ID获取该进程实例
                    childProcess.KillProcessTree();//调用拓展方法结束当前进程的所有子进程
                }
            }
        }
    }
}
