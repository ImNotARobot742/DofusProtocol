

// Generated on 05/18/2023 15:10:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TopTaxCollectorListMessage : AbstractTaxCollectorListMessage
    {
        public const uint Id = 9339;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool isDungeon;
        
        public TopTaxCollectorListMessage()
        {
        }
        
        public TopTaxCollectorListMessage(Types.TaxCollectorInformations[] informations, bool isDungeon)
         : base(informations)
        {
            this.isDungeon = isDungeon;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(isDungeon);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            isDungeon = reader.ReadBoolean();
        }
        
    }
    
}