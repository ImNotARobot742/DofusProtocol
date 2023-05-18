

// Generated on 05/18/2023 15:10:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SymbioticObjectAssociatedMessage : NetworkMessage
    {
        public const uint Id = 6005;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint hostUID;
        
        public SymbioticObjectAssociatedMessage()
        {
        }
        
        public SymbioticObjectAssociatedMessage(uint hostUID)
        {
            this.hostUID = hostUID;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)hostUID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            hostUID = reader.ReadVarUInt();
        }
        
    }
    
}