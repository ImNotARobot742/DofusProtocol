

// Generated on 03/23/2022 09:50:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeCraftResultWithObjectIdMessage : ExchangeCraftResultMessage
    {
        public const uint Id = 7497;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectGenericId;
        
        public ExchangeCraftResultWithObjectIdMessage()
        {
        }
        
        public ExchangeCraftResultWithObjectIdMessage(sbyte craftResult, uint objectGenericId)
         : base(craftResult)
        {
            this.objectGenericId = objectGenericId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)objectGenericId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            objectGenericId = reader.ReadVarUShort();
        }
        
    }
    
}