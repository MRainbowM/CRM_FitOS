﻿using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CRM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autorizatsiya());
            //Application.Run(new проверка_подключения());
        }
    }
}