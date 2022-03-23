

// Generated on 03/23/2022 09:50:20
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
        public const uint Id = 6028;
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