

// Generated on 06/13/2023 16:59:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildPaddockBoughtMessage : NetworkMessage
    {
        public const uint Id = 2166;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.PaddockContentInformations paddockInfo;
        
        public GuildPaddockBoughtMessage()
        {
        }
        
        public GuildPaddockBoughtMessage(Types.PaddockContentInformations paddockInfo)
        {
            this.paddockInfo = paddockInfo;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            paddockInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            paddockInfo = new Types.PaddockContentInformations();
            paddockInfo.Deserialize(reader);
        }
        
    }
    
}