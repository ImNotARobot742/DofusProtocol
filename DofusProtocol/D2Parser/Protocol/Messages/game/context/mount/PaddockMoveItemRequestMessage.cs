

// Generated on 02/01/2023 12:53:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PaddockMoveItemRequestMessage : NetworkMessage
    {
        public const uint Id = 9794;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint oldCellId;
        public uint newCellId;
        
        public PaddockMoveItemRequestMessage()
        {
        }
        
        public PaddockMoveItemRequestMessage(uint oldCellId, uint newCellId)
        {
            this.oldCellId = oldCellId;
            this.newCellId = newCellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)oldCellId);
            writer.WriteVarShort((short)newCellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            oldCellId = reader.ReadVarUShort();
            newCellId = reader.ReadVarUShort();
        }
        
    }
    
}