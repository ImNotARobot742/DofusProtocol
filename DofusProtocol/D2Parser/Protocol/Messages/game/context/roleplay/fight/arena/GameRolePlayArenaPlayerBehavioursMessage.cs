

// Generated on 01/01/2022 14:39:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayArenaPlayerBehavioursMessage : NetworkMessage
    {
        public const uint Id = 92;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string[] flags;
        public string[] sanctions;
        public int banDuration;
        
        public GameRolePlayArenaPlayerBehavioursMessage()
        {
        }
        
        public GameRolePlayArenaPlayerBehavioursMessage(string[] flags, string[] sanctions, int banDuration)
        {
            this.flags = flags;
            this.sanctions = sanctions;
            this.banDuration = banDuration;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)flags.Length);
            foreach (var entry in flags)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteShort((short)sanctions.Length);
            foreach (var entry in sanctions)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteInt(banDuration);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            flags = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 flags[i] = reader.ReadUTF();
            }
            limit = (ushort)reader.ReadUShort();
            sanctions = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 sanctions[i] = reader.ReadUTF();
            }
            banDuration = reader.ReadInt();
        }
        
    }
    
}