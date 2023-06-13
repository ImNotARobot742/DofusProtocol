

// Generated on 06/13/2023 16:59:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ForgettableSpellClientActionMessage : NetworkMessage
    {
        public const uint Id = 5708;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int spellId;
        public sbyte action;
        
        public ForgettableSpellClientActionMessage()
        {
        }
        
        public ForgettableSpellClientActionMessage(int spellId, sbyte action)
        {
            this.spellId = spellId;
            this.action = action;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(spellId);
            writer.WriteSbyte(action);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            spellId = reader.ReadInt();
            action = reader.ReadSbyte();
        }
        
    }
    
}