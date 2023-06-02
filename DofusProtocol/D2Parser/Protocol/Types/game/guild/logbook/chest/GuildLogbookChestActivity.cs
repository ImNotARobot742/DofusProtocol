

// Generated on 06/02/2023 19:01:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildLogbookChestActivity : GuildLogbookEntryBasicInformation
    {
        public const short Id = 4492;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double playerId;
        public string playerName;
        public sbyte eventType;
        public int quantity;
        public Types.ObjectItemNotInContainer @object;
        public int sourceTabId;
        public int destinationTabId;
        
        public GuildLogbookChestActivity()
        {
        }
        
        public GuildLogbookChestActivity(uint id, double date, double playerId, string playerName, sbyte eventType, int quantity, Types.ObjectItemNotInContainer @object, int sourceTabId, int destinationTabId)
         : base(id, date)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.eventType = eventType;
            this.quantity = quantity;
            this.@object = @object;
            this.sourceTabId = sourceTabId;
            this.destinationTabId = destinationTabId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSbyte(eventType);
            writer.WriteInt(quantity);
            @object.Serialize(writer);
            writer.WriteInt(sourceTabId);
            writer.WriteInt(destinationTabId);
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
            sourceTabId = reader.ReadInt();
            destinationTabId = reader.ReadInt();
        }
        
    }
    
}