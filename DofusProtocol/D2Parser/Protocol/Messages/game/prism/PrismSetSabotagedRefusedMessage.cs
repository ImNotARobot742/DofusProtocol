

// Generated on 06/13/2023 16:59:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismSetSabotagedRefusedMessage : NetworkMessage
    {
        public const uint Id = 4345;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        public sbyte reason;
        
        public PrismSetSabotagedRefusedMessage()
        {
        }
        
        public PrismSetSabotagedRefusedMessage(uint subAreaId, sbyte reason)
        {
            this.subAreaId = subAreaId;
            this.reason = reason;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)subAreaId);
            writer.WriteSbyte(reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            subAreaId = reader.ReadVarUShort();
            reason = reader.ReadSbyte();
        }
        
    }
    
}