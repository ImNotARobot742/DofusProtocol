

// Generated on 05/18/2023 15:10:25
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
        public const uint Id = 7694;
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