

// Generated on 03/23/2022 09:50:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TreasureHuntLegendaryRequestMessage : NetworkMessage
    {
        public const uint Id = 1909;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint legendaryId;
        
        public TreasureHuntLegendaryRequestMessage()
        {
        }
        
        public TreasureHuntLegendaryRequestMessage(uint legendaryId)
        {
            this.legendaryId = legendaryId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)legendaryId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            legendaryId = reader.ReadVarUShort();
        }
        
    }
    
}