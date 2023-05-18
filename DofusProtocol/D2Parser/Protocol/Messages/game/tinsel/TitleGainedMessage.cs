

// Generated on 05/18/2023 15:10:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TitleGainedMessage : NetworkMessage
    {
        public const uint Id = 2189;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint titleId;
        
        public TitleGainedMessage()
        {
        }
        
        public TitleGainedMessage(uint titleId)
        {
            this.titleId = titleId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)titleId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            titleId = reader.ReadVarUShort();
        }
        
    }
    
}