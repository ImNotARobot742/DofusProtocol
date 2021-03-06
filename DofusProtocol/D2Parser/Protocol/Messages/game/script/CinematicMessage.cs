

// Generated on 03/23/2022 09:50:41
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
        public const uint Id = 7716;
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