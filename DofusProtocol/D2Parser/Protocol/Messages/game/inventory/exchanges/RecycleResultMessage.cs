

// Generated on 03/23/2022 09:50:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class RecycleResultMessage : NetworkMessage
    {
        public const uint Id = 1416;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint nuggetsForPrism;
        public uint nuggetsForPlayer;
        
        public RecycleResultMessage()
        {
        }
        
        public RecycleResultMessage(uint nuggetsForPrism, uint nuggetsForPlayer)
        {
            this.nuggetsForPrism = nuggetsForPrism;
            this.nuggetsForPlayer = nuggetsForPlayer;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)nuggetsForPrism);
            writer.WriteVarInt((int)nuggetsForPlayer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            nuggetsForPrism = reader.ReadVarUInt();
            nuggetsForPlayer = reader.ReadVarUInt();
        }
        
    }
    
}