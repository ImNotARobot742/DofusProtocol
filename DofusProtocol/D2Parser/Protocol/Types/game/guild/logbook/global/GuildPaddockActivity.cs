

// Generated on 06/13/2023 17:00:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildPaddockActivity : GuildLogbookEntryBasicInformation
    {
        public const short Id = 3056;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double playerId;
        public string playerName;
        public Types.MapCoordinatesExtended paddockCoordinates;
        public double farmId;
        public sbyte paddockEventType;
        
        public GuildPaddockActivity()
        {
        }
        
        public GuildPaddockActivity(uint id, double date, double playerId, string playerName, Types.MapCoordinatesExtended paddockCoordinates, double farmId, sbyte paddockEventType)
         : base(id, date)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.paddockCoordinates = paddockCoordinates;
            this.farmId = farmId;
            this.paddockEventType = paddockEventType;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            paddockCoordinates.Serialize(writer);
            writer.WriteDouble(farmId);
            writer.WriteSbyte(paddockEventType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarULong();
            playerName = reader.ReadUTF();
            paddockCoordinates = new Types.MapCoordinatesExtended();
            paddockCoordinates.Deserialize(reader);
            farmId = reader.ReadDouble();
            paddockEventType = reader.ReadSbyte();
        }
        
    }
    
}