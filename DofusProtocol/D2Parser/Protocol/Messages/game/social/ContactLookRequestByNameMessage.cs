

// Generated on 02/01/2023 12:53:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ContactLookRequestByNameMessage : ContactLookRequestMessage
    {
        public const uint Id = 8512;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string playerName;
        
        public ContactLookRequestByNameMessage()
        {
        }
        
        public ContactLookRequestByNameMessage(byte requestId, sbyte contactType, string playerName)
         : base(requestId, contactType)
        {
            this.playerName = playerName;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(playerName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            playerName = reader.ReadUTF();
        }
        
    }
    
}