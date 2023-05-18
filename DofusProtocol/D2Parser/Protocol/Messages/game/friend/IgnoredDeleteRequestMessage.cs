

// Generated on 05/18/2023 16:28:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IgnoredDeleteRequestMessage : NetworkMessage
    {
        public const uint Id = 1640;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int accountId;
        public bool session;
        
        public IgnoredDeleteRequestMessage()
        {
        }
        
        public IgnoredDeleteRequestMessage(int accountId, bool session)
        {
            this.accountId = accountId;
            this.session = session;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(accountId);
            writer.WriteBoolean(session);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            accountId = reader.ReadInt();
            session = reader.ReadBoolean();
        }
        
    }
    
}