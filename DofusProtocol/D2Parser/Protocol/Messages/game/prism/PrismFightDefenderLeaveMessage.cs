

// Generated on 05/18/2023 15:10:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismFightDefenderLeaveMessage : NetworkMessage
    {
        public const uint Id = 9907;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        public uint fightId;
        public double fighterToRemoveId;
        
        public PrismFightDefenderLeaveMessage()
        {
        }
        
        public PrismFightDefenderLeaveMessage(uint subAreaId, uint fightId, double fighterToRemoveId)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.fighterToRemoveId = fighterToRemoveId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)subAreaId);
            writer.WriteVarShort((short)fightId);
            writer.WriteVarLong(fighterToRemoveId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            subAreaId = reader.ReadVarUShort();
            fightId = reader.ReadVarUShort();
            fighterToRemoveId = reader.ReadVarULong();
        }
        
    }
    
}