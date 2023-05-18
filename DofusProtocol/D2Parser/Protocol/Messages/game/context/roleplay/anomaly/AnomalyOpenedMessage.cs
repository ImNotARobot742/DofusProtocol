

// Generated on 05/18/2023 16:28:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AnomalyOpenedMessage : NetworkMessage
    {
        public const uint Id = 370;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        
        public AnomalyOpenedMessage()
        {
        }
        
        public AnomalyOpenedMessage(uint subAreaId)
        {
            this.subAreaId = subAreaId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)subAreaId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            subAreaId = reader.ReadVarUShort();
        }
        
    }
    
}