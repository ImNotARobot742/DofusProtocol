

// Generated on 06/13/2023 16:59:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IgnoredAddedMessage : NetworkMessage
    {
        public const uint Id = 4677;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.IgnoredInformations ignoreAdded;
        public bool session;
        
        public IgnoredAddedMessage()
        {
        }
        
        public IgnoredAddedMessage(Types.IgnoredInformations ignoreAdded, bool session)
        {
            this.ignoreAdded = ignoreAdded;
            this.session = session;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(ignoreAdded.TypeId);
            ignoreAdded.Serialize(writer);
            writer.WriteBoolean(session);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            ignoreAdded = ProtocolTypeManager.GetInstance<Types.IgnoredInformations>(reader.ReadUShort());
            ignoreAdded.Deserialize(reader);
            session = reader.ReadBoolean();
        }
        
    }
    
}