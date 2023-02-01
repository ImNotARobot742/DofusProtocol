

// Generated on 02/01/2023 12:53:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LivingObjectMessageMessage : NetworkMessage
    {
        public const uint Id = 9837;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint msgId;
        public int timeStamp;
        public string owner;
        public uint objectGenericId;
        
        public LivingObjectMessageMessage()
        {
        }
        
        public LivingObjectMessageMessage(uint msgId, int timeStamp, string owner, uint objectGenericId)
        {
            this.msgId = msgId;
            this.timeStamp = timeStamp;
            this.owner = owner;
            this.objectGenericId = objectGenericId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)msgId);
            writer.WriteInt(timeStamp);
            writer.WriteUTF(owner);
            writer.WriteVarShort((short)objectGenericId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            msgId = reader.ReadVarUShort();
            timeStamp = reader.ReadInt();
            owner = reader.ReadUTF();
            objectGenericId = reader.ReadVarUShort();
        }
        
    }
    
}