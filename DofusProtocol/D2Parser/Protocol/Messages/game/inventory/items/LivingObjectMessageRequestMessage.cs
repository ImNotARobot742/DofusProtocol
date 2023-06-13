

// Generated on 06/13/2023 16:59:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LivingObjectMessageRequestMessage : NetworkMessage
    {
        public const uint Id = 8644;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint msgId;
        public string[] parameters;
        public uint livingObject;
        
        public LivingObjectMessageRequestMessage()
        {
        }
        
        public LivingObjectMessageRequestMessage(uint msgId, string[] parameters, uint livingObject)
        {
            this.msgId = msgId;
            this.parameters = parameters;
            this.livingObject = livingObject;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)msgId);
            writer.WriteShort((short)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteVarInt((int)livingObject);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            msgId = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            livingObject = reader.ReadVarUInt();
        }
        
    }
    
}