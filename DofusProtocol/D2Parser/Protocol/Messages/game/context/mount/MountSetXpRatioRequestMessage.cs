

// Generated on 01/01/2022 14:39:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountSetXpRatioRequestMessage : NetworkMessage
    {
        public const uint Id = 9275;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte xpRatio;
        
        public MountSetXpRatioRequestMessage()
        {
        }
        
        public MountSetXpRatioRequestMessage(sbyte xpRatio)
        {
            this.xpRatio = xpRatio;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(xpRatio);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            xpRatio = reader.ReadSbyte();
        }
        
    }
    
}