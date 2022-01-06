

// Generated on 01/01/2022 14:39:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterSelectionMessage : NetworkMessage
    {
        public const uint Id = 3123;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double id;
        
        public CharacterSelectionMessage()
        {
        }
        
        public CharacterSelectionMessage(double id)
        {
            this.id = id;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(id);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarULong();
        }
        
    }
    
}