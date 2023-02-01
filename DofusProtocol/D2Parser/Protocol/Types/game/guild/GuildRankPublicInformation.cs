

// Generated on 02/01/2023 12:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildRankPublicInformation : GuildRankMinimalInformation
    {
        public const short Id = 5645;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint order;
        public uint gfxId;
        
        public GuildRankPublicInformation()
        {
        }
        
        public GuildRankPublicInformation(uint id, string name, uint order, uint gfxId)
         : base(id, name)
        {
            this.order = order;
            this.gfxId = gfxId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)order);
            writer.WriteVarInt((int)gfxId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            order = reader.ReadVarUInt();
            gfxId = reader.ReadVarUInt();
        }
        
    }
    
}