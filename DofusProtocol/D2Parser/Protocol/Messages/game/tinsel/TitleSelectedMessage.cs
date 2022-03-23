

// Generated on 03/23/2022 09:50:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TitleSelectedMessage : NetworkMessage
    {
        public const uint Id = 1578;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint titleId;
        
        public TitleSelectedMessage()
        {
        }
        
        public TitleSelectedMessage(uint titleId)
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