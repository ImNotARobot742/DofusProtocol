

// Generated on 05/18/2023 15:10:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceSummaryMessage : PaginationAnswerAbstractMessage
    {
        public const uint Id = 2726;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AllianceFactSheetInformations[] alliances;
        
        public AllianceSummaryMessage()
        {
        }
        
        public AllianceSummaryMessage(double offset, uint count, uint total, Types.AllianceFactSheetInformations[] alliances)
         : base(offset, count, total)
        {
            this.alliances = alliances;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)alliances.Length);
            foreach (var entry in alliances)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
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