

// Generated on 01/01/2022 14:39:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeCraftResultWithObjectDescMessage : ExchangeCraftResultMessage
    {
        public const uint Id = 118;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ObjectItemNotInContainer objectInfo;
        
        public ExchangeCraftResultWithObjectDescMessage()
        {
        }
        
        public ExchangeCraftResultWithObjectDescMessage(sbyte craftResult, Types.ObjectItemNotInContainer objectInfo)
         : base(craftResult)
        {
            this.objectInfo = objectInfo;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            objectInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            objectInfo = new Types.ObjectItemNotInContainer();
            objectInfo.Deserialize(reader);
        }
        
    }
    
}