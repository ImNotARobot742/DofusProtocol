

// Generated on 05/18/2023 16:28:59
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