

// Generated on 02/01/2023 12:53:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PresetUseRequestMessage : NetworkMessage
    {
        public const uint Id = 8428;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short presetId;
        
        public PresetUseRequestMessage()
        {
        }
        
        public PresetUseRequestMessage(short presetId)
        {
            this.presetId = presetId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(presetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            presetId = reader.ReadShort();
        }
        
    }
    
}