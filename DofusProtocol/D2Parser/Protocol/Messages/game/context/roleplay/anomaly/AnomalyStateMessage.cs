

// Generated on 02/01/2023 12:53:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AnomalyStateMessage : NetworkMessage
    {
        public const uint Id = 3282;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        public bool open;
        public double closingTime;
        
        public AnomalyStateMessage()
        {
        }
        
        public AnomalyStateMessage(uint subAreaId, bool open, double closingTime)
        {
            this.subAreaId = subAreaId;
            this.open = open;
            this.closingTime = closingTime;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)subAreaId);
            writer.WriteBoolean(open);
            writer.WriteVarLong(closingTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            subAreaId = reader.ReadVarUShort();
            open = reader.ReadBoolean();
            closingTime = reader.ReadVarULong();
        }
        
    }
    
}