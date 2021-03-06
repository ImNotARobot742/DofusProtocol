

// Generated on 03/23/2022 09:50:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StatsUpgradeResultMessage : NetworkMessage
    {
        public const uint Id = 99;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte result;
        public uint nbCharacBoost;
        
        public StatsUpgradeResultMessage()
        {
        }
        
        public StatsUpgradeResultMessage(sbyte result, uint nbCharacBoost)
        {
            this.result = result;
            this.nbCharacBoost = nbCharacBoost;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(result);
            writer.WriteVarShort((short)nbCharacBoost);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            result = reader.ReadSbyte();
            nbCharacBoost = reader.ReadVarUShort();
        }
        
    }
    
}