

// Generated on 06/02/2023 19:00:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IdentificationAccountForceMessage : IdentificationMessage
    {
        public const uint Id = 8300;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string forcerAccountLogin;
        
        public IdentificationAccountForceMessage()
        {
        }
        
        public IdentificationAccountForceMessage(bool autoconnect, bool useCertificate, bool useLoginToken, Types.Version version, string lang, sbyte[] credentials, short serverId, double sessionOptionalSalt, uint[] failedAttempts, string forcerAccountLogin)
         : base(autoconnect, useCertificate, useLoginToken, version, lang, credentials, serverId, sessionOptionalSalt, failedAttempts)
        {
            this.forcerAccountLogin = forcerAccountLogin;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(forcerAccountLogin);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            forcerAccountLogin = reader.ReadUTF();
        }
        
    }
    
}