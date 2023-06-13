

// Generated on 06/13/2023 16:59:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ShowCellMessage : NetworkMessage
    {
        public const uint Id = 5097;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double sourceId;
        public uint cellId;
        
        public ShowCellMessage()
        {
        }
        
        public ShowCellMessage(double sourceId, uint cellId)
        {
            this.sourceId = sourceId;
            this.cellId = cellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(sourceId);
            writer.WriteVarShort((short)cellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            sourceId = reader.ReadDouble();
            cellId = reader.ReadVarUShort();
        }
        
    }
    
}