

// Generated on 06/13/2023 16:59:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterNameSuggestionFailureMessage : NetworkMessage
    {
        public const uint Id = 1656;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        
        public CharacterNameSuggestionFailureMessage()
        {
        }
        
        public CharacterNameSuggestionFailureMessage(sbyte reason)
        {
            this.reason = reason;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            reason = reader.ReadSbyte();
        }
        
    }
    
}