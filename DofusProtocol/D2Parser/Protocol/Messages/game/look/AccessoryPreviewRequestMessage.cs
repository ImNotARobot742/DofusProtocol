

// Generated on 05/18/2023 16:29:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AccessoryPreviewRequestMessage : NetworkMessage
    {
        public const uint Id = 9868;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] genericId;
        
        public AccessoryPreviewRequestMessage()
        {
        }
        
        public AccessoryPreviewRequestMessage(uint[] genericId)
        {
            this.genericId = genericId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)genericId.Length);
            foreach (var entry in genericId)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            genericId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 genericId[i] = reader.ReadVarUInt();
            }
        }
        
    }
    
}