

// Generated on 05/18/2023 15:10:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SpellVariantActivationRequestMessage : NetworkMessage
    {
        public const uint Id = 1521;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint spellId;
        
        public SpellVariantActivationRequestMessage()
        {
        }
        
        public SpellVariantActivationRequestMessage(uint spellId)
        {
            this.spellId = spellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)spellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            spellId = reader.ReadVarUShort();
        }
        
    }
    
}