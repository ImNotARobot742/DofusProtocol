

// Generated on 06/13/2023 16:59:29
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceSummaryRequestMessage : PaginationRequestAbstractMessage
    {
        public const uint Id = 5726;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string nameFilter;
        public string tagFilter;
        public string playerNameFilter;
        public sbyte sortType;
        public bool sortDescending;
        
        public AllianceSummaryRequestMessage()
        {
        }
        
        public AllianceSummaryRequestMessage(double offset, uint count, string nameFilter, string tagFilter, string playerNameFilter, sbyte sortType, bool sortDescending)
         : base(offset, count)
        {
            this.nameFilter = nameFilter;
            this.tagFilter = tagFilter;
            this.playerNameFilter = playerNameFilter;
            this.sortType = sortType;
            this.sortDescending = sortDescending;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(nameFilter);
            writer.WriteUTF(tagFilter);
            writer.WriteUTF(playerNameFilter);
            writer.WriteSbyte(sortType);
            writer.WriteBoolean(sortDescending);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            nameFilter = reader.ReadUTF();
            tagFilter = reader.ReadUTF();
            playerNameFilter = reader.ReadUTF();
            sortType = reader.ReadSbyte();
            sortDescending = reader.ReadBoolean();
        }
        
    }
    
}