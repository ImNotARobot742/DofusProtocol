

// Generated on 05/18/2023 16:28:51
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class JobMultiCraftAvailableSkillsMessage : JobAllowMultiCraftRequestMessage
    {
        public const uint Id = 832;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double playerId;
        public uint[] skills;
        
        public JobMultiCraftAvailableSkillsMessage()
        {
        }
        
        public JobMultiCraftAvailableSkillsMessage(bool enabled, double playerId, uint[] skills)
         : base(enabled)
        {
            this.playerId = playerId;
            this.skills = skills;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteShort((short)skills.Length);
            foreach (var entry in skills)
            {
                 writer.WriteVarShort((short)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarULong();
            var limit = (ushort)reader.ReadUShort();
            skills = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 skills[i] = reader.ReadVarUShort();
            }
        }
        
    }
    
}