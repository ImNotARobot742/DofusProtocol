

// Generated on 01/01/2022 14:39:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildCreationResultMessage : NetworkMessage
    {
        public const uint Id = 42;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte result;
        
        public GuildCreationResultMessage()
        {
        }
        
        public GuildCreationResultMessage(sbyte result)
        {
            this.result = result;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(result);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            result = reader.ReadSbyte();
        }
        
    }
    
}