﻿using LTMCB_Final.FunctionClass;

namespace LTMCB_Final
{
    internal static class Program
    {
        public static ClientTcpConnection tcpConnection; //Mỗi lần mở app tạo 1 Tcp Connection
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ChonPhim());

            tcpConnection = new ClientTcpConnection();
            tcpConnection.TcpConnect();
        }
    }
}