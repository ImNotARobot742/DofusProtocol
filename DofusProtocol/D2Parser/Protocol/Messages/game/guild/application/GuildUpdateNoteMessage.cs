

// Generated on 02/01/2023 12:53:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildUpdateNoteMessage : NetworkMessage
    {
        public const uint Id = 5967;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double memberId;
        public string note;
        
        public GuildUpdateNoteMessage()
        {
        }
        
        public GuildUpdateNoteMessage(double memberId, string note)
        {
            this.memberId = memberId;
            this.note = note;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(memberId);
            writer.WriteUTF(note);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            memberId = reader.ReadVarULong();
            note = reader.ReadUTF();
        }
        
    }
    
}