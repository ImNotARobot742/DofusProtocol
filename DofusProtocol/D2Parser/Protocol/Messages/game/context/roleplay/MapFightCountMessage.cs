

// Generated on 05/18/2023 15:10:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MapFightCountMessage : NetworkMessage
    {
        public const uint Id = 7673;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint fightCount;
        
        public MapFightCountMessage()
        {
        }
        
        public MapFightCountMessage(uint fightCount)
        {
            this.fightCount = fightCount;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)fightCount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightCount = reader.ReadVarUShort();
        }
        
    }
    
}