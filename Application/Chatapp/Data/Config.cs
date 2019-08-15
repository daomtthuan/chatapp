﻿using System.Drawing;

namespace Data
{
    /// <summary>
    /// Config of application
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// Icon server
        /// </summary>
        public static readonly Icon ServerIcon = Properties.Resources.SeverIcon;

        /// <summary>
        /// Icon client
        /// </summary>
        public static readonly Icon ClienIcon = Properties.Resources.ClientIcon;

        /// <summary>
        /// Connect string to sql server
        /// </summary>
        public static readonly string ConnectString = @"Data Source=(local);Initial Catalog=ChatApp;Integrated Security=True";

        /// <summary>
        /// IP Address
        /// </summary>
        public static readonly string IP = "127.0.0.1";

        /// <summary>
        /// Connect Port
        /// </summary>
        public static readonly int Port = 2019;
    }
}