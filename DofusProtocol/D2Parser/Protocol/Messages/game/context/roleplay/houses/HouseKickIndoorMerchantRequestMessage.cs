

// Generated on 05/18/2023 15:10:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseKickIndoorMerchantRequestMessage : NetworkMessage
    {
        public const uint Id = 3052;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint cellId;
        
        public HouseKickIndoorMerchantRequestMessage()
        {
        }
        
        public HouseKickIndoorMerchantRequestMessage(uint cellId)
        {
            this.cellId = cellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)cellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            cellId = reader.ReadVarUShort();
        }
        
    }
    
}