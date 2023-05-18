

// Generated on 05/18/2023 16:29:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeBidHouseTypeMessage : NetworkMessage
    {
        public const uint Id = 1523;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint type;
        public bool follow;
        
        public ExchangeBidHouseTypeMessage()
        {
        }
        
        public ExchangeBidHouseTypeMessage(uint type, bool follow)
        {
            this.type = type;
            this.follow = follow;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)type);
            writer.WriteBoolean(follow);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            type = reader.ReadVarUInt();
            follow = reader.ReadBoolean();
        }
        
    }
    
}