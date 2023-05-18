

// Generated on 05/18/2023 15:10:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MapRunningFightDetailsRequestMessage : NetworkMessage
    {
        public const uint Id = 4060;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint fightId;
        
        public MapRunningFightDetailsRequestMessage()
        {
        }
        
        public MapRunningFightDetailsRequestMessage(uint fightId)
        {
            this.fightId = fightId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)fightId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadVarUShort();
        }
        
    }
    
}