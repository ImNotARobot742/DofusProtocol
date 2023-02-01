

// Generated on 02/01/2023 12:53:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MapComplementaryInformationsAnomalyMessage : MapComplementaryInformationsDataMessage
    {
        public const uint Id = 3607;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint level;
        public double closingTime;
        
        public MapComplementaryInformationsAnomalyMessage()
        {
        }
        
        public MapComplementaryInformationsAnomalyMessage(uint subAreaId, double mapId, Types.HouseInformations[] houses, Types.GameRolePlayActorInformations[] actors, Types.InteractiveElement[] interactiveElements, Types.StatedElement[] statedElements, Types.MapObstacle[] obstacles, Types.FightCommonInformations[] fights, bool hasAggressiveMonsters, Types.FightStartingPositions fightStartPositions, uint level, double closingTime)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights, hasAggressiveMonsters, fightStartPositions)
        {
            this.level = level;
            this.closingTime = closingTime;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)level);
            writer.WriteVarLong(closingTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            level = reader.ReadVarUShort();
            closingTime = reader.ReadVarULong();
        }
        
    }
    
}