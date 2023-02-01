

// Generated on 02/01/2023 12:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AllianceFactSheetInformations : AllianceInformations
    {
        public const short Id = 4137;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public int creationDate;
        public uint nbGuilds;
        public uint nbMembers;
        public uint nbSubarea;
        
        public AllianceFactSheetInformations()
        {
        }
        
        public AllianceFactSheetInformations(uint allianceId, string allianceTag, string allianceName, Types.GuildEmblem allianceEmblem, int creationDate, uint nbGuilds, uint nbMembers, uint nbSubarea)
         : base(allianceId, allianceTag, allianceName, allianceEmblem)
        {
            this.creationDate = creationDate;
            this.nbGuilds = nbGuilds;
            this.nbMembers = nbMembers;
            this.nbSubarea = nbSubarea;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(creationDate);
            writer.WriteVarShort((short)nbGuilds);
            writer.WriteVarShort((short)nbMembers);
            writer.WriteVarShort((short)nbSubarea);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            creationDate = reader.ReadInt();
            nbGuilds = reader.ReadVarUShort();
            nbMembers = reader.ReadVarUShort();
            nbSubarea = reader.ReadVarUShort();
        }
        
    }
    
}