using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace RES.LogicaNegocio
{
    /*
     * Autor: Edwin Rafael Larrea Buste
     * Fecha: 17/07/2021
     */
    public class EventosLog
    {
        
        public static void Write_EventLog(string MsjLog, string  LugarLog, EventLogEntryType Type)
        {
            string Archivo = "";
            switch (Type)
            {
                case EventLogEntryType.Error:
                    Archivo = string.Concat(@"Err_", LugarLog, ".log");
                    break;
                case EventLogEntryType.FailureAudit:
                    Archivo = string.Concat(@"FaiAud_", LugarLog, ".log");
                    break;
                case EventLogEntryType.Information:
                    Archivo = string.Concat(@"Info_", LugarLog, ".log");
                    break;
                case EventLogEntryType.SuccessAudit:
                    Archivo = string.Concat(@"SucAud_", LugarLog, ".log");
                    break;
                case EventLogEntryType.Warning:
                    Archivo = string.Concat(@"Adv_", LugarLog, ".log");
                    break;
                default:
                    break;
            }
            using (FileStream fs = new FileStream(string.Concat(AppDomain.CurrentDomain.BaseDirectory, @"\Log\", Archivo), FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sr = new StreamWriter(fs)) 
                {
                    sr.WriteLine(string.Concat(Convert.ToString(DateTime.Now)," :",MsjLog));
                }
            }
            //if (!EventLog.SourceExists(LugarLog)) { EventLog.CreateEventSource(LugarLog, LugarLog); }
            //EventLog.WriteEntry(LugarLog, MsjLog, Type);
        }
    }
}
