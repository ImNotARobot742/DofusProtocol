

// Generated on 06/13/2023 16:59:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IdolsPresetSaveRequestMessage : IconPresetSaveRequestMessage
    {
        public const uint Id = 4344;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public IdolsPresetSaveRequestMessage()
        {
        }
        
        public IdolsPresetSaveRequestMessage(short presetId, sbyte symbolId, bool updateData)
         : base(presetId, symbolId, updateData)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}