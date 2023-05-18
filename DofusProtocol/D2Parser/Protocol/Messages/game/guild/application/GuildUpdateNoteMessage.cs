

// Generated on 05/18/2023 16:29:00
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
        public const uint Id = 717;
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