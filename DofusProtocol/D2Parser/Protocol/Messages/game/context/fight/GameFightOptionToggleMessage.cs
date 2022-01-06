

// Generated on 01/01/2022 14:39:22
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightOptionToggleMessage : NetworkMessage
    {
        public const uint Id = 2382;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte option;
        
        public GameFightOptionToggleMessage()
        {
        }
        
        public GameFightOptionToggleMessage(sbyte option)
        {
            this.option = option;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(option);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            option = reader.ReadSbyte();
        }
        
    }
    
}