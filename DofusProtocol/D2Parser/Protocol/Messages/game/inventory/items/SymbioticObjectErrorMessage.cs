

// Generated on 03/23/2022 09:50:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SymbioticObjectErrorMessage : ObjectErrorMessage
    {
        public const uint Id = 7936;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte errorCode;
        
        public SymbioticObjectErrorMessage()
        {
        }
        
        public SymbioticObjectErrorMessage(sbyte reason, sbyte errorCode)
         : base(reason)
        {
            this.errorCode = errorCode;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(errorCode);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            errorCode = reader.ReadSbyte();
        }
        
    }
    
}