

// Generated on 05/18/2023 16:28:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class RefreshFollowedQuestsOrderRequestMessage : NetworkMessage
    {
        public const uint Id = 5554;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] quests;
        
        public RefreshFollowedQuestsOrderRequestMessage()
        {
        }
        
        public RefreshFollowedQuestsOrderRequestMessage(uint[] quests)
        {
            this.quests = quests;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)quests.Length);
            foreach (var entry in quests)
            {
                 writer.WriteVarShort((short)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            quests = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 quests[i] = reader.ReadVarUShort();
            }
        }
        
    }
    
}