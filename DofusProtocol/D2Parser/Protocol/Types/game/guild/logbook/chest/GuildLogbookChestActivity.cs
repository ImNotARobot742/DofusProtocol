

// Generated on 03/23/2022 09:51:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildLogbookChestActivity : GuildLogbookEntryBasicInformation
    {
        public const short Id = 3291;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double playerId;
        public string playerName;
        public sbyte eventType;
        public int quantity;
        public Types.ObjectItemNotInContainer @object;
        
        public GuildLogbookChestActivity()
        {
        }
        
        public GuildLogbookChestActivity(uint id, double date, double playerId, string playerName, sbyte eventType, int quantity, Types.ObjectItemNotInContainer @object)
         : base(id, date)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.eventType = eventType;
            this.quantity = quantity;
            this.@object = @object;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSbyte(eventType);
            writer.WriteInt(quantity);
            @object.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarULong();
            playerName = reader.ReadUTF();
            eventType = reader.ReadSbyte();
            quantity = reader.ReadInt();
            @object = new Types.ObjectItemNotInContainer();
            @object.Deserialize(reader);
        }
        
    }
    
}