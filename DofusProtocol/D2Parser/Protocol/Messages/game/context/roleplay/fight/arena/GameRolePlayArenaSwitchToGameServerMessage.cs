

// Generated on 06/13/2023 16:59:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayArenaSwitchToGameServerMessage : NetworkMessage
    {
        public const uint Id = 5157;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool validToken;
        public sbyte[] ticket;
        public short homeServerId;
        
        public GameRolePlayArenaSwitchToGameServerMessage()
        {
        }
        
        public GameRolePlayArenaSwitchToGameServerMessage(bool validToken, sbyte[] ticket, short homeServerId)
        {
            this.validToken = validToken;
            this.ticket = ticket;
            this.homeServerId = homeServerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(validToken);
            writer.WriteVarInt((int)(ushort)ticket.Length);
            foreach (var entry in ticket)
            {
                 writer.WriteSbyte(entry);
            }
            writer.WriteShort(homeServerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            validToken = reader.ReadBoolean();
            var limit = (ushort)reader.ReadVarInt();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 ticket[i] = reader.ReadSbyte();
            }
            homeServerId = reader.ReadShort();
        }
        
    }
    
}