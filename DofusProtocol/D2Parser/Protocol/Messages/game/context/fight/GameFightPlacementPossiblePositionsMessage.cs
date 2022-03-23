

// Generated on 03/23/2022 09:50:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightPlacementPossiblePositionsMessage : NetworkMessage
    {
        public const uint Id = 3107;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] positionsForChallengers;
        public uint[] positionsForDefenders;
        public sbyte teamNumber;
        
        public GameFightPlacementPossiblePositionsMessage()
        {
        }
        
        public GameFightPlacementPossiblePositionsMessage(uint[] positionsForChallengers, uint[] positionsForDefenders, sbyte teamNumber)
        {
            this.positionsForChallengers = positionsForChallengers;
            this.positionsForDefenders = positionsForDefenders;
            this.teamNumber = teamNumber;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)positionsForChallengers.Length);
            foreach (var entry in positionsForChallengers)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteShort((short)positionsForDefenders.Length);
            foreach (var entry in positionsForDefenders)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteSbyte(teamNumber);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            positionsForChallengers = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 positionsForChallengers[i] = reader.ReadVarUShort();
            }
            limit = (ushort)reader.ReadUShort();
            positionsForDefenders = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 positionsForDefenders[i] = reader.ReadVarUShort();
            }
            teamNumber = reader.ReadSbyte();
        }
        
    }
    
}