

// Generated on 01/01/2022 14:39:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PaddockToSellListRequestMessage : NetworkMessage
    {
        public const uint Id = 456;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint pageIndex;
        
        public PaddockToSellListRequestMessage()
        {
        }
        
        public PaddockToSellListRequestMessage(uint pageIndex)
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