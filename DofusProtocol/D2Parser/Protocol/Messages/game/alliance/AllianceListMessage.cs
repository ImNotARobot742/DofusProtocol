

// Generated on 03/23/2022 09:50:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceListMessage : NetworkMessage
    {
        public const uint Id = 8557;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AllianceFactSheetInformations[] alliances;
        
        public AllianceListMessage()
        {
        }
        
        public AllianceListMessage(Types.AllianceFactSheetInformations[] alliances)
        {
            this.alliances = alliances;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)alliances.Length);
            foreach (var entry in alliances)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            alliances = new Types.AllianceFactSheetInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliances[i] = new Types.AllianceFactSheetInformations();
                 alliances[i].Deserialize(reader);
            }
        }
        
    }
    
}