

// Generated on 03/23/2022 09:50:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SetCharacterRestrictionsMessage : NetworkMessage
    {
        public const uint Id = 1254;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double actorId;
        public Types.ActorRestrictionsInformations restrictions;
        
        public SetCharacterRestrictionsMessage()
        {
        }
        
        public SetCharacterRestrictionsMessage(double actorId, Types.ActorRestrictionsInformations restrictions)
        {
            this.actorId = actorId;
            this.restrictions = restrictions;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(actorId);
            restrictions.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            actorId = reader.ReadDouble();
            restrictions = new Types.ActorRestrictionsInformations();
            restrictions.Deserialize(reader);
        }
        
    }
    
}