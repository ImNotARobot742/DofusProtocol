

// Generated on 06/13/2023 16:59:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BasicWhoIsRequestMessage : NetworkMessage
    {
        public const uint Id = 9147;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool verbose;
        public Types.AbstractPlayerSearchInformation target;
        
        public BasicWhoIsRequestMessage()
        {
        }
        
        public BasicWhoIsRequestMessage(bool verbose, Types.AbstractPlayerSearchInformation target)
        {
            this.verbose = verbose;
            this.target = target;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(verbose);
            writer.WriteShort(target.TypeId);
            target.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            verbose = reader.ReadBoolean();
            target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
        }
        
    }
    
}