

// Generated on 05/18/2023 15:10:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AuthenticationTicketMessage : NetworkMessage
    {
        public const uint Id = 3786;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string lang;
        public string ticket;
        
        public AuthenticationTicketMessage()
        {
        }
        
        public AuthenticationTicketMessage(string lang, string ticket)
        {
            this.lang = lang;
            this.ticket = ticket;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(lang);
            writer.WriteUTF(ticket);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            lang = reader.ReadUTF();
            ticket = reader.ReadUTF();
        }
        
    }
    
}