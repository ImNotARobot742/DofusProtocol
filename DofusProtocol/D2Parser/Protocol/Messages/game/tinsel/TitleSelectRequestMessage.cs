

// Generated on 06/13/2023 16:59:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TitleSelectRequestMessage : NetworkMessage
    {
        public const uint Id = 8672;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint titleId;
        
        public TitleSelectRequestMessage()
        {
        }
        
        public TitleSelectRequestMessage(uint titleId)
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