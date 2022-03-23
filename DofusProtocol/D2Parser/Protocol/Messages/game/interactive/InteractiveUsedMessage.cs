

// Generated on 03/23/2022 09:50:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class InteractiveUsedMessage : NetworkMessage
    {
        public const uint Id = 1847;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double entityId;
        public uint elemId;
        public uint skillId;
        public uint duration;
        public bool canMove;
        
        public InteractiveUsedMessage()
        {
        }
        
        public InteractiveUsedMessage(double entityId, uint elemId, uint skillId, uint duration, bool canMove)
        {
            this.entityId = entityId;
            this.elemId = elemId;
            this.skillId = skillId;
            this.duration = duration;
            this.canMove = canMove;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(entityId);
            writer.WriteVarInt((int)elemId);
            writer.WriteVarShort((short)skillId);
            writer.WriteVarShort((short)duration);
            writer.WriteBoolean(canMove);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            entityId = reader.ReadVarULong();
            elemId = reader.ReadVarUInt();
            skillId = reader.ReadVarUShort();
            duration = reader.ReadVarUShort();
            canMove = reader.ReadBoolean();
        }
        
    }
    
}