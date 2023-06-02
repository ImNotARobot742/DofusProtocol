

// Generated on 06/02/2023 19:00:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IdentificationFailedForBadVersionMessage : IdentificationFailedMessage
    {
        public const uint Id = 210;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.Version requiredVersion;
        
        public IdentificationFailedForBadVersionMessage()
        {
        }
        
        public IdentificationFailedForBadVersionMessage(sbyte reason, Types.Version requiredVersion)
         : base(reason)
        {
            this.requiredVersion = requiredVersion;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            requiredVersion.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            requiredVersion = new Types.Version();
            requiredVersion.Deserialize(reader);
        }
        
    }
    
}