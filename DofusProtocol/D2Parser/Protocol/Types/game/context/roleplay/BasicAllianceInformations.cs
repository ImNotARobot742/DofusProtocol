

// Generated on 03/23/2022 09:51:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class BasicAllianceInformations : AbstractSocialGroupInfos
    {
        public const short Id = 5732;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint allianceId;
        public string allianceTag;
        
        public BasicAllianceInformations()
        {
        }
        
        public BasicAllianceInformations(uint allianceId, string allianceTag)
        {
            this.allianceId = allianceId;
            this.allianceTag = allianceTag;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)allianceId);
            writer.WriteUTF(allianceTag);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            allianceId = reader.ReadVarUInt();
            allianceTag = reader.ReadUTF();
        }
        
    }
    
}