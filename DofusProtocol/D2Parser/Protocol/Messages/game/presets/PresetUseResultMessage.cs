

// Generated on 02/01/2023 12:53:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PresetUseResultMessage : NetworkMessage
    {
        public const uint Id = 2423;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short presetId;
        public sbyte code;
        
        public PresetUseResultMessage()
        {
        }
        
        public PresetUseResultMessage(short presetId, sbyte code)
        {
            this.presetId = presetId;
            this.code = code;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(presetId);
            writer.WriteSbyte(code);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            presetId = reader.ReadShort();
            code = reader.ReadSbyte();
        }
        
    }
    
}