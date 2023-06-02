

// Generated on 06/02/2023 19:00:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AlterationsUpdatedMessage : NetworkMessage
    {
        public const uint Id = 5631;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AlterationInfo[] alterations;
        
        public AlterationsUpdatedMessage()
        {
        }
        
        public AlterationsUpdatedMessage(Types.AlterationInfo[] alterations)
        {
            this.alterations = alterations;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)alterations.Length);
            foreach (var entry in alterations)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            alterations = new Types.AlterationInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 alterations[i] = new Types.AlterationInfo();
                 alterations[i].Deserialize(reader);
            }
        }
        
    }
    
}