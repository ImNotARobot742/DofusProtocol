﻿
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaknaProxy.API.Utils.Logger
{
    public class ContainerLogger
    {

        #region Constructeur
        private readonly bool IsConsole;

        private delegate void LogDelegate(string Text);
        private delegate void ClearDelegate();
        
        public bool SaveLogs;
        //public MainClient Client;

        #endregion

        #region Builder

        //public ContainerLogger(RichTextBox container, bool isConsole, bool saveLogs, MainClient client = null)
        //{
        //    Container = container;
        //    LogCount = 0;
        //    IsConsole = isConsole;
        //    SaveLogs = saveLogs;
        //    Client = client;
        //}

        #endregion

        #region Methods

        public void Info(string Text)
        {
            if (IsConsole == true)
            {
                Log(string.Format("[{0}] <{1}> {2}" + '\n', DateTime.Now.ToString("HH:mm:ss"), "Info", Text));
            }
            else
            {
                Log(string.Format("[{0}] ({1}) {2}" + '\n', DateTime.Now.ToString("HH:mm:ss"), "Info", Text));
            }
        }

        public void Error(string Text)
        {
            if (IsConsole == true)
            {
                Log(string.Format("[{0}] <{1}> {2}" + '\n', DateTime.Now.ToString("HH:mm:ss"), "Erreur", Text));
            }
            else
            {
                Log(string.Format("[{0}] ({1}) {2}" + '\n', DateTime.Now.ToString("HH:mm:ss"), "Erreur", Text));
            }
        }

        public void Warning(string Text)
        {
            if (IsConsole == true)
            {
                Log(string.Format("[{0}] <{1}> {2}" + '\n', DateTime.Now.ToString("HH:mm:ss"), "Warning", Text));
            }
            else
            {
                Log(string.Format("[{0}] ({1}) {2}" + '\n', DateTime.Now.ToString("HH:mm:ss"), "Warning", Text));
            }
        }

        public void Debug(string Text)
        {
            if (IsConsole == true)
            {
                Log(string.Format("[{0}] <{1}> {2}" + '\n', DateTime.Now.ToString("HH:mm:ss"), "Debug", Text));
            }
            else
            {
                Log(string.Format("[{0}] ({1}) {2}" + '\n', DateTime.Now.ToString("HH:mm:ss"), "Debug", Text));
            }
        }

        public void Chat(string Text, string Prefix)
        {
            if (Prefix == "")
            {
                Log(string.Format("[{0}] {1}" + '\n', DateTime.Now.ToString("HH:mm:ss"), Text));
            }
            else
            {
                Log(string.Format("[{0}] ({1}) {2}" + '\n', DateTime.Now.ToString("HH:mm:ss"), Prefix, Text));
            }
        }

        public void Log(string Text)
        {
            Console.WriteLine(Text);
            //if (Container == null)
            //    return;

            //if (LogCount > 700)
            //{
            //    Clear();
            //}

            //try
            //{
            //    if (Container.InvokeRequired == true)
            //    {
            //        Container.Invoke(new LogDelegate(Log), new object[] { Text, Color });
            //        return;
            //    }
            //    else
            //    {
            //        Console.Write(Text);
            //        Container.SelectionColor = Color;
            //        Container.AppendText(Text);
            //        Container.ScrollToCaret();
            //        LogCount += 1;
            //    }
            //}
            //catch (Exception)
            //{ }

            //try
            //{
            //    if (SaveLogs)
            //    {
            //        if (!Directory.Exists(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Logs\")))
            //            Directory.CreateDirectory(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Logs\"));

            //        using (System.IO.StreamWriter file =
            //        new System.IO.StreamWriter(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Logs\Logs.txt"), true))
            //        {
            //            file.Write(Text);

            //            file.Close();
            //            file.Dispose();
            //        }
            //    }
            //}catch(Exception) { }

        }

        public void Clear()
        {
            //if (Container.InvokeRequired == true)
            //{
            //    Container.Invoke(new ClearDelegate(Clear));
            //}
            //else
            //{
            //    Container.Clear();
            //    LogCount = 0;
            //}
        }

        #endregion

    }
}
