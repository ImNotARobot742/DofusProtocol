

// Generated on 05/18/2023 16:28:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountXpRatioMessage : NetworkMessage
    {
        public const uint Id = 294;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte ratio;
        
        public MountXpRatioMessage()
        {
        }
        
        public MountXpRatioMessage(sbyte ratio)
        {
            this.ratio = ratio;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(ratio);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            ratio = reader.ReadSbyte();
        }
        
    }
    
}