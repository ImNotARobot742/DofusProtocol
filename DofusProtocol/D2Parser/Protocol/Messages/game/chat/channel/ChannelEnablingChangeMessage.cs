

// Generated on 03/23/2022 09:50:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChannelEnablingChangeMessage : NetworkMessage
    {
        public const uint Id = 9894;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte channel;
        public bool enable;
        
        public ChannelEnablingChangeMessage()
        {
        }
        
        public ChannelEnablingChangeMessage(sbyte channel, bool enable)
        {
            this.channel = channel;
            this.enable = enable;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(channel);
            writer.WriteBoolean(enable);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            channel = reader.ReadSbyte();
            enable = reader.ReadBoolean();
        }
        
    }
    
}