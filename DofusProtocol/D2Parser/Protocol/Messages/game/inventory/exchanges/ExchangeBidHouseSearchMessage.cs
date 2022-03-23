

// Generated on 03/23/2022 09:50:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeBidHouseSearchMessage : NetworkMessage
    {
        public const uint Id = 6174;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint genId;
        public bool follow;
        
        public ExchangeBidHouseSearchMessage()
        {
        }
        
        public ExchangeBidHouseSearchMessage(uint genId, bool follow)
        {
            this.genId = genId;
            this.follow = follow;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)genId);
            writer.WriteBoolean(follow);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            genId = reader.ReadVarUShort();
            follow = reader.ReadBoolean();
        }
        
    }
    
}