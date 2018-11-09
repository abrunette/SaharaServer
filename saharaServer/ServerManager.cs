﻿using System;
using System.Collections.Generic;
using SaharaLib;

namespace SaharaServer
{
    public class ServerManager : BaseSingleton<ServerManager>
    {
        public List<UserConnection> Connections { get; set; }

        private ServerManager()
        {
            Connections = new List<UserConnection>();
        }

        public void AddConnection(UserConnection newConnection)
        {
            Connections.Add(newConnection);
        }


    }
}