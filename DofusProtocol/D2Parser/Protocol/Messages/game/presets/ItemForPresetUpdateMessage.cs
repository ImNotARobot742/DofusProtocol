

// Generated on 01/01/2022 14:39:52
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ItemForPresetUpdateMessage : NetworkMessage
    {
        public const uint Id = 2377;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short presetId;
        public Types.ItemForPreset presetItem;
        
        public ItemForPresetUpdateMessage()
        {
        }
        
        public ItemForPresetUpdateMessage(short presetId, Types.ItemForPreset presetItem)
        {
            this.presetId = presetId;
            this.presetItem = presetItem;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(presetId);
            presetItem.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            presetId = reader.ReadShort();
            presetItem = new Types.ItemForPreset();
            presetItem.Deserialize(reader);
        }
        
    }
    
}