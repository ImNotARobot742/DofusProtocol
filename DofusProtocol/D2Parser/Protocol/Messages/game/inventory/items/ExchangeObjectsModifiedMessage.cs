

// Generated on 06/13/2023 16:59:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeObjectsModifiedMessage : ExchangeObjectMessage
    {
        public const uint Id = 8936;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ObjectItem[] @object;
        
        public ExchangeObjectsModifiedMessage()
        {
        }
        
        public ExchangeObjectsModifiedMessage(bool remote, Types.ObjectItem[] @object)
         : base(remote)
        {
            this.@object = @object;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)@object.Length);
            foreach (var entry in @object)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            @object = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 @object[i] = new Types.ObjectItem();
                 @object[i].Deserialize(reader);
            }
        }
        
    }
    
}