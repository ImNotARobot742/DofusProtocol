

// Generated on 06/13/2023 16:59:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildInvitedMessage : NetworkMessage
    {
        public const uint Id = 3794;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double recruterId;
        public string recruterName;
        public Types.BasicGuildInformations guildInfo;
        
        public GuildInvitedMessage()
        {
        }
        
        public GuildInvitedMessage(double recruterId, string recruterName, Types.BasicGuildInformations guildInfo)
        {
            this.recruterId = recruterId;
            this.recruterName = recruterName;
            this.guildInfo = guildInfo;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(recruterId);
            writer.WriteUTF(recruterName);
            guildInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            recruterId = reader.ReadVarULong();
            recruterName = reader.ReadUTF();
            guildInfo = new Types.BasicGuildInformations();
            guildInfo.Deserialize(reader);
        }
        
    }
    
}