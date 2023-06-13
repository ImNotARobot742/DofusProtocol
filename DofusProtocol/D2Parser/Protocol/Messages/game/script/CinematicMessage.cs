

// Generated on 06/13/2023 16:59:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CinematicMessage : NetworkMessage
    {
        public const uint Id = 2481;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint cinematicId;
        
        public CinematicMessage()
        {
        }
        
        public CinematicMessage(uint cinematicId)
        {
            this.cinematicId = cinematicId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)cinematicId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            cinematicId = reader.ReadVarUShort();
        }
        
    }
    
}