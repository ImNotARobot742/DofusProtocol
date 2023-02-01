

// Generated on 02/01/2023 12:53:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MapRewardRateMessage : NetworkMessage
    {
        public const uint Id = 3202;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int mapRate;
        public int subAreaRate;
        public int totalRate;
        
        public MapRewardRateMessage()
        {
        }
        
        public MapRewardRateMessage(int mapRate, int subAreaRate, int totalRate)
        {
            this.mapRate = mapRate;
            this.subAreaRate = subAreaRate;
            this.totalRate = totalRate;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)mapRate);
            writer.WriteVarShort((short)subAreaRate);
            writer.WriteVarShort((short)totalRate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mapRate = reader.ReadVarShort();
            subAreaRate = reader.ReadVarShort();
            totalRate = reader.ReadVarShort();
        }
        
    }
    
}