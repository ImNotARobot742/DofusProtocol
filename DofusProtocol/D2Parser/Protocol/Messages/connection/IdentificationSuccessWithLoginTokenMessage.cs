

// Generated on 05/18/2023 15:10:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IdentificationSuccessWithLoginTokenMessage : IdentificationSuccessMessage
    {
        public const uint Id = 8626;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string loginToken;
        
        public IdentificationSuccessWithLoginTokenMessage()
        {
        }
        
        public IdentificationSuccessWithLoginTokenMessage(bool hasRights, bool hasConsoleRight, bool wasAlreadyConnected, bool isAccountForced, string login, Types.AccountTagInformation accountTag, int accountId, sbyte communityId, string secretQuestion, double accountCreation, double subscriptionElapsedDuration, double subscriptionEndDate, byte havenbagAvailableRoom, string loginToken)
         : base(hasRights, hasConsoleRight, wasAlreadyConnected, isAccountForced, login, accountTag, accountId, communityId, secretQuestion, accountCreation, subscriptionElapsedDuration, subscriptionEndDate, havenbagAvailableRoom)
        {
            this.loginToken = loginToken;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(loginToken);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            loginToken = reader.ReadUTF();
        }
        
    }
    
}