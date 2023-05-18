

// Generated on 05/18/2023 15:10:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeOnHumanVendorRequestMessage : NetworkMessage
    {
        public const uint Id = 8093;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double humanVendorId;
        public uint humanVendorCell;
        
        public ExchangeOnHumanVendorRequestMessage()
        {
        }
        
        public ExchangeOnHumanVendorRequestMessage(double humanVendorId, uint humanVendorCell)
        {
            this.humanVendorId = humanVendorId;
            this.humanVendorCell = humanVendorCell;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(humanVendorId);
            writer.WriteVarShort((short)humanVendorCell);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            humanVendorId = reader.ReadVarULong();
            humanVendorCell = reader.ReadVarUShort();
        }
        
    }
    
}