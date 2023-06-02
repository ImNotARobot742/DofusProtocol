

// Generated on 06/02/2023 19:00:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectAddedMessage : NetworkMessage
    {
        public const uint Id = 9738;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ObjectItem @object;
        public sbyte origin;
        
        public ObjectAddedMessage()
        {
        }
        
        public ObjectAddedMessage(Types.ObjectItem @object, sbyte origin)
        {
            this.@object = @object;
            this.origin = origin;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            @object.Serialize(writer);
            writer.WriteSbyte(origin);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            @object = new Types.ObjectItem();
            @object.Deserialize(reader);
            origin = reader.ReadSbyte();
        }
        
    }
    
}