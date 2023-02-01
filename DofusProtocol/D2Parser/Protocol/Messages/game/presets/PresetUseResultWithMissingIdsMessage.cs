

// Generated on 02/01/2023 12:53:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PresetUseResultWithMissingIdsMessage : PresetUseResultMessage
    {
        public const uint Id = 4515;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] missingIds;
        
        public PresetUseResultWithMissingIdsMessage()
        {
        }
        
        public PresetUseResultWithMissingIdsMessage(short presetId, sbyte code, uint[] missingIds)
         : base(presetId, code)
        {
            this.missingIds = missingIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)missingIds.Length);
            foreach (var entry in missingIds)
            {
                 writer.WriteVarShort((short)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            missingIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 missingIds[i] = reader.ReadVarUShort();
            }
        }
        
    }
    
}