﻿using System.Collections.Generic;
using DS_Network.Network;

namespace DS_Network.Sync
{
    public interface ISyncAlgorithmClient
    {
        /// <summary>
        /// Send request
        /// </summary>
        void SendSyncRequestToAllHosts(List<NodeInfo> toSendHosts);

        void SendSyncRequestToMaster(NodeInfo masterNode);

        /// <summary>
        /// Access critical point
        /// </summary>
        /// <returns>resource</returns>
        void Release();
    }
}


