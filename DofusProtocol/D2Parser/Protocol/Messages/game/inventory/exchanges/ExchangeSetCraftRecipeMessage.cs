

// Generated on 03/23/2022 09:50:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeSetCraftRecipeMessage : NetworkMessage
    {
        public const uint Id = 9961;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectGID;
        
        public ExchangeSetCraftRecipeMessage()
        {
        }
        
        public ExchangeSetCraftRecipeMessage(uint objectGID)
        {
            this.objectGID = objectGID;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)objectGID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectGID = reader.ReadVarUShort();
        }
        
    }
    
}