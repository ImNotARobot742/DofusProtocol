

// Generated on 06/02/2023 19:00:42
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
        public const uint Id = 4791;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectGID;
        public bool follow;
        
        public ExchangeBidHouseSearchMessage()
        {
        }
        
        public ExchangeBidHouseSearchMessage(uint objectGID, bool follow)
        {
            this.objectGID = objectGID;
            this.follow = follow;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectGID);
            writer.WriteBoolean(follow);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectGID = reader.ReadVarUInt();
            follow = reader.ReadBoolean();
        }
        
    }
    
}