using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.Diagnostics;

namespace Probando_la_vaina_que_se_apaga
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class class_apagado
    {
        string argumento = null;
        DateTime tmp;
        public class_apagado(string argumento, DateTime tmp)
        {
            this.argumento = argumento;
            this.tmp = tmp;
        }
        public void Shut_Down()
        {
            try
            {
                while (true)
                {
                    if (tmp.ToLongTimeString() == DateTime.Now.ToLongTimeString())
                    {
                        Process proceso = new Process();
                        proceso.StartInfo.UseShellExecute = false;
                        proceso.StartInfo.RedirectStandardOutput = true;
                        proceso.StartInfo.FileName = "shutdown.exe";
                        proceso.StartInfo.Arguments = this.argumento;
                        proceso.Start();
                        break;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
