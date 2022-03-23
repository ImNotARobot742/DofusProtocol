

// Generated on 03/23/2022 09:50:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class NotificationUpdateFlagMessage : NetworkMessage
    {
        public const uint Id = 4857;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint index;
        
        public NotificationUpdateFlagMessage()
        {
        }
        
        public NotificationUpdateFlagMessage(uint index)
        {
            this.index = index;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)index);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            index = reader.ReadVarUShort();
        }
        
    }
    
}