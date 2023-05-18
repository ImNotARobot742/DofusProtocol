

// Generated on 05/18/2023 15:10:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterCreationResultMessage : NetworkMessage
    {
        public const uint Id = 5313;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte result;
        public sbyte reason;
        
        public CharacterCreationResultMessage()
        {
        }
        
        public CharacterCreationResultMessage(sbyte result, sbyte reason)
        {
            this.result = result;
            this.reason = reason;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(result);
            writer.WriteSbyte(reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            result = reader.ReadSbyte();
            reason = reader.ReadSbyte();
        }
        
    }
    
}