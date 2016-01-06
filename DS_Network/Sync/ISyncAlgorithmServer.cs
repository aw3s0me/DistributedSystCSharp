﻿using CookComputing.XmlRpc;

namespace DS_Network.Sync
{
    public interface ISyncAlgorithmServer
    {
        /// <summary>
        /// Call handler of server
        /// HANDLE
        /// </summary>
        [XmlRpcMethod("Host.getSyncRequest")]
        void GetSyncRequest(int timestamp, long id, string ipAndPort);

        [XmlRpcMethod("Host.getAcceptResponse")]
        void GetAcceptResponse(string fromIpAndPort);

        [XmlRpcMethod("Host.getReleasedMsg")]
        void GetReleasedMsg(string fromIpAndPort);
    }
}
