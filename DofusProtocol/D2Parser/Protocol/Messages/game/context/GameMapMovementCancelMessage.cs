

// Generated on 05/18/2023 16:28:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameMapMovementCancelMessage : NetworkMessage
    {
        public const uint Id = 5205;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint cellId;
        
        public GameMapMovementCancelMessage()
        {
        }
        
        public GameMapMovementCancelMessage(uint cellId)
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