

// Generated on 01/01/2022 14:39:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AbstractGameActionMessage : NetworkMessage
    {
        public const uint Id = 5037;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint actionId;
        public double sourceId;
        
        public AbstractGameActionMessage()
        {
        }
        
        public AbstractGameActionMessage(uint actionId, double sourceId)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)actionId);
            writer.WriteDouble(sourceId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            actionId = reader.ReadVarUShort();
            sourceId = reader.ReadDouble();
        }
        
    }
    
}