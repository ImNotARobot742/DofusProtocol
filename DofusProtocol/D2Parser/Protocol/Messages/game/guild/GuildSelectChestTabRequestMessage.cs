

// Generated on 05/18/2023 16:28:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildSelectChestTabRequestMessage : NetworkMessage
    {
        public const uint Id = 2561;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint tabNumber;
        
        public GuildSelectChestTabRequestMessage()
        {
        }
        
        public GuildSelectChestTabRequestMessage(uint tabNumber)
        {
            this.tabNumber = tabNumber;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)tabNumber);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            tabNumber = reader.ReadVarUInt();
        }
        
    }
    
}