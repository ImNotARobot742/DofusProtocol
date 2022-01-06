

// Generated on 01/01/2022 14:39:53
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ShortcutBarRemovedMessage : NetworkMessage
    {
        public const uint Id = 5087;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte barType;
        public sbyte slot;
        
        public ShortcutBarRemovedMessage()
        {
        }
        
        public ShortcutBarRemovedMessage(sbyte barType, sbyte slot)
        {
            this.barType = barType;
            this.slot = slot;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(barType);
            writer.WriteSbyte(slot);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            barType = reader.ReadSbyte();
            slot = reader.ReadSbyte();
        }
        
    }
    
}