

// Generated on 03/23/2022 09:50:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class WrapperObjectDissociateRequestMessage : NetworkMessage
    {
        public const uint Id = 8460;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint hostUID;
        public byte hostPos;
        
        public WrapperObjectDissociateRequestMessage()
        {
        }
        
        public WrapperObjectDissociateRequestMessage(uint hostUID, byte hostPos)
        {
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)hostUID);
            writer.WriteByte(hostPos);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            hostUID = reader.ReadVarUInt();
            hostPos = reader.ReadByte();
        }
        
    }
    
}