

// Generated on 01/01/2022 14:39:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceModificationValidMessage : NetworkMessage
    {
        public const uint Id = 4144;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string allianceName;
        public string allianceTag;
        public Types.GuildEmblem Alliancemblem;
        
        public AllianceModificationValidMessage()
        {
        }
        
        public AllianceModificationValidMessage(string allianceName, string allianceTag, Types.GuildEmblem Alliancemblem)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
            this.Alliancemblem = Alliancemblem;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
            Alliancemblem.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
            Alliancemblem = new Types.GuildEmblem();
            Alliancemblem.Deserialize(reader);
        }
        
    }
    
}