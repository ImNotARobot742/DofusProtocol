

// Generated on 06/13/2023 16:59:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiConfirmationMessage : NetworkMessage
    {
        public const uint Id = 7492;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double kamas;
        public double amount;
        public uint rate;
        public sbyte action;
        public string transaction;
        
        public HaapiConfirmationMessage()
        {
        }
        
        public HaapiConfirmationMessage(double kamas, double amount, uint rate, sbyte action, string transaction)
        {
            this.kamas = kamas;
            this.amount = amount;
            this.rate = rate;
            this.action = action;
            this.transaction = transaction;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(kamas);
            writer.WriteVarLong(amount);
            writer.WriteVarShort((short)rate);
            writer.WriteSbyte(action);
            writer.WriteUTF(transaction);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            kamas = reader.ReadVarULong();
            amount = reader.ReadVarULong();
            rate = reader.ReadVarUShort();
            action = reader.ReadSbyte();
            transaction = reader.ReadUTF();
        }
        
    }
    
}