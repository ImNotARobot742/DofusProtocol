

// Generated on 03/23/2022 09:50:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceInvitedMessage : NetworkMessage
    {
        public const uint Id = 4726;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double recruterId;
        public string recruterName;
        public Types.BasicNamedAllianceInformations allianceInfo;
        
        public AllianceInvitedMessage()
        {
        }
        
        public AllianceInvitedMessage(double recruterId, string recruterName, Types.BasicNamedAllianceInformations allianceInfo)
        {
            this.recruterId = recruterId;
            this.recruterName = recruterName;
            this.allianceInfo = allianceInfo;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(recruterId);
            writer.WriteUTF(recruterName);
            allianceInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            recruterId = reader.ReadVarULong();
            recruterName = reader.ReadUTF();
            allianceInfo = new Types.BasicNamedAllianceInformations();
            allianceInfo.Deserialize(reader);
        }
        
    }
    
}