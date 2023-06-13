

// Generated on 06/13/2023 16:59:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class EmotePlayMessage : EmotePlayAbstractMessage
    {
        public const uint Id = 4527;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double actorId;
        public int accountId;
        
        public EmotePlayMessage()
        {
        }
        
        public EmotePlayMessage(ushort emoteId, double emoteStartTime, double actorId, int accountId)
         : base(emoteId, emoteStartTime)
        {
            this.actorId = actorId;
            this.accountId = accountId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(actorId);
            writer.WriteInt(accountId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            actorId = reader.ReadDouble();
            accountId = reader.ReadInt();
        }
        
    }
    
}