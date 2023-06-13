

// Generated on 06/13/2023 16:59:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildCharacsUpgradeRequestMessage : NetworkMessage
    {
        public const uint Id = 2078;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte charaTypeTarget;
        
        public GuildCharacsUpgradeRequestMessage()
        {
        }
        
        public GuildCharacsUpgradeRequestMessage(sbyte charaTypeTarget)
        {
            this.charaTypeTarget = charaTypeTarget;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(charaTypeTarget);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            charaTypeTarget = reader.ReadSbyte();
        }
        
    }
    
}