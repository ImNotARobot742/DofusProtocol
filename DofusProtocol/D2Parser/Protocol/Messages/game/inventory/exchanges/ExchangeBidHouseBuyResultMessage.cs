

// Generated on 05/18/2023 16:29:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeBidHouseBuyResultMessage : NetworkMessage
    {
        public const uint Id = 7213;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint uid;
        public bool bought;
        
        public ExchangeBidHouseBuyResultMessage()
        {
        }
        
        public ExchangeBidHouseBuyResultMessage(uint uid, bool bought)
        {
            this.uid = uid;
            this.bought = bought;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)uid);
            writer.WriteBoolean(bought);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            uid = reader.ReadVarUInt();
            bought = reader.ReadBoolean();
        }
        
    }
    
}