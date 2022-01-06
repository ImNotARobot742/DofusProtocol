

// Generated on 01/01/2022 14:39:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class OrnamentSelectedMessage : NetworkMessage
    {
        public const uint Id = 7637;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint ornamentId;
        
        public OrnamentSelectedMessage()
        {
        }
        
        public OrnamentSelectedMessage(uint ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)ornamentId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            ornamentId = reader.ReadVarUShort();
        }
        
    }
    
}