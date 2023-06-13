

// Generated on 06/13/2023 16:59:26
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
        public const uint Id = 1172;
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