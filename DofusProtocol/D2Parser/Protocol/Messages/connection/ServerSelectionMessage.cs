

// Generated on 05/18/2023 16:28:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ServerSelectionMessage : NetworkMessage
    {
        public const uint Id = 3946;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint serverId;
        
        public ServerSelectionMessage()
        {
        }
        
        public ServerSelectionMessage(uint serverId)
        {
            this.serverId = serverId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)serverId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            serverId = reader.ReadVarUShort();
        }
        
    }
    
}