

// Generated on 06/13/2023 16:59:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayFightRequestCanceledMessage : NetworkMessage
    {
        public const uint Id = 98;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint fightId;
        public double sourceId;
        public double targetId;
        
        public GameRolePlayFightRequestCanceledMessage()
        {
        }
        
        public GameRolePlayFightRequestCanceledMessage(uint fightId, double sourceId, double targetId)
        {
            this.fightId = fightId;
            this.sourceId = sourceId;
            this.targetId = targetId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)fightId);
            writer.WriteDouble(sourceId);
            writer.WriteDouble(targetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadVarUShort();
            sourceId = reader.ReadDouble();
            targetId = reader.ReadDouble();
        }
        
    }
    
}