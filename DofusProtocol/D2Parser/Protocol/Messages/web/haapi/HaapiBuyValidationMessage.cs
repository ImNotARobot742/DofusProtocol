

// Generated on 03/23/2022 09:50:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiBuyValidationMessage : HaapiValidationMessage
    {
        public const uint Id = 1897;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double amount;
        public string email;
        
        public HaapiBuyValidationMessage()
        {
        }
        
        public HaapiBuyValidationMessage(sbyte action, sbyte code, double amount, string email)
         : base(action, code)
        {
            this.amount = amount;
            this.email = email;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(amount);
            writer.WriteUTF(email);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            amount = reader.ReadVarULong();
            email = reader.ReadUTF();
        }
        
    }
    
}