

// Generated on 01/01/2022 14:39:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SystemMessageDisplayMessage : NetworkMessage
    {
        public const uint Id = 4698;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool hangUp;
        public uint msgId;
        public string[] parameters;
        
        public SystemMessageDisplayMessage()
        {
        }
        
        public SystemMessageDisplayMessage(bool hangUp, uint msgId, string[] parameters)
        {
            this.hangUp = hangUp;
            this.msgId = msgId;
            this.parameters = parameters;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(hangUp);
            writer.WriteVarShort((short)msgId);
            writer.WriteShort((short)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            hangUp = reader.ReadBoolean();
            msgId = reader.ReadVarUShort();
            var limit = (ushort)reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
        }
        
    }
    
}