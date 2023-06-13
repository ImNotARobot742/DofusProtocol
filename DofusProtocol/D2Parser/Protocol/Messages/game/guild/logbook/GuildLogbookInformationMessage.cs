

// Generated on 06/13/2023 16:59:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildLogbookInformationMessage : NetworkMessage
    {
        public const uint Id = 9577;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.GuildLogbookEntryBasicInformation[] globalActivities;
        public Types.GuildLogbookEntryBasicInformation[] chestActivities;
        
        public GuildLogbookInformationMessage()
        {
        }
        
        public GuildLogbookInformationMessage(Types.GuildLogbookEntryBasicInformation[] globalActivities, Types.GuildLogbookEntryBasicInformation[] chestActivities)
        {
            this.globalActivities = globalActivities;
            this.chestActivities = chestActivities;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)globalActivities.Length);
            foreach (var entry in globalActivities)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)chestActivities.Length);
            foreach (var entry in chestActivities)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            globalActivities = new Types.GuildLogbookEntryBasicInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 globalActivities[i] = ProtocolTypeManager.GetInstance<Types.GuildLogbookEntryBasicInformation>(reader.ReadUShort());
                 globalActivities[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            chestActivities = new Types.GuildLogbookEntryBasicInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 chestActivities[i] = ProtocolTypeManager.GetInstance<Types.GuildLogbookEntryBasicInformation>(reader.ReadUShort());
                 chestActivities[i].Deserialize(reader);
            }
        }
        
    }
    
}