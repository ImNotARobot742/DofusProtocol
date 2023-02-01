

// Generated on 02/01/2023 12:53:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PaddockRemoveItemRequestMessage : NetworkMessage
    {
        public const uint Id = 5808;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint cellId;
        
        public PaddockRemoveItemRequestMessage()
        {
        }
        
        public PaddockRemoveItemRequestMessage(uint cellId)
        {
            this.cellId = cellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)cellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            cellId = reader.ReadVarUShort();
        }
        
    }
    
}