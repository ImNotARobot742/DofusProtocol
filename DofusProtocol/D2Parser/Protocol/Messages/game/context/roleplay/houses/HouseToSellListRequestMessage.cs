

// Generated on 06/02/2023 19:00:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseToSellListRequestMessage : NetworkMessage
    {
        public const uint Id = 4871;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint pageIndex;
        
        public HouseToSellListRequestMessage()
        {
        }
        
        public HouseToSellListRequestMessage(uint pageIndex)
        {
            this.pageIndex = pageIndex;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)pageIndex);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            pageIndex = reader.ReadVarUShort();
        }
        
    }
    
}