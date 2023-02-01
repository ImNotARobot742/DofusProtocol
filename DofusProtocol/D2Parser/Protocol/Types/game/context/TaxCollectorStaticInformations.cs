

// Generated on 02/01/2023 12:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TaxCollectorStaticInformations
    {
        public const short Id = 3183;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint firstNameId;
        public uint lastNameId;
        public Types.GuildInformations guildIdentity;
        public double callerId;
        
        public TaxCollectorStaticInformations()
        {
        }
        
        public TaxCollectorStaticInformations(uint firstNameId, uint lastNameId, Types.GuildInformations guildIdentity, double callerId)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.guildIdentity = guildIdentity;
            this.callerId = callerId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)firstNameId);
            writer.WriteVarShort((short)lastNameId);
            guildIdentity.Serialize(writer);
            writer.WriteVarLong(callerId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            firstNameId = reader.ReadVarUShort();
            lastNameId = reader.ReadVarUShort();
            guildIdentity = new Types.GuildInformations();
            guildIdentity.Deserialize(reader);
            callerId = reader.ReadVarULong();
        }
        
    }
    
}