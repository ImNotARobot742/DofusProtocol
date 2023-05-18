

// Generated on 05/18/2023 15:10:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendAddRequestMessage : NetworkMessage
    {
        public const uint Id = 800;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AbstractPlayerSearchInformation target;
        
        public FriendAddRequestMessage()
        {
        }
        
        public FriendAddRequestMessage(Types.AbstractPlayerSearchInformation target)
        {
            this.target = target;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(target.TypeId);
            target.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
        }
        
    }
    
}