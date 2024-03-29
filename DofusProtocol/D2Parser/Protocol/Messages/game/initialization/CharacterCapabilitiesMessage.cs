

// Generated on 06/13/2023 16:59:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterCapabilitiesMessage : NetworkMessage
    {
        public const uint Id = 1153;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint guildEmblemSymbolCategories;
        
        public CharacterCapabilitiesMessage()
        {
        }
        
        public CharacterCapabilitiesMessage(uint guildEmblemSymbolCategories)
        {
            this.guildEmblemSymbolCategories = guildEmblemSymbolCategories;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)guildEmblemSymbolCategories);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            guildEmblemSymbolCategories = reader.ReadVarUInt();
        }
        
    }
    
}