

// Generated on 05/18/2023 16:29:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class OrnamentSelectRequestMessage : NetworkMessage
    {
        public const uint Id = 2562;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint ornamentId;
        
        public OrnamentSelectRequestMessage()
        {
        }
        
        public OrnamentSelectRequestMessage(uint ornamentId)
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