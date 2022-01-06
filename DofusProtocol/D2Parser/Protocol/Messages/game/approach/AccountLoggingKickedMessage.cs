

// Generated on 01/01/2022 14:39:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AccountLoggingKickedMessage : NetworkMessage
    {
        public const uint Id = 7661;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint days;
        public sbyte hours;
        public sbyte minutes;
        
        public AccountLoggingKickedMessage()
        {
        }
        
        public AccountLoggingKickedMessage(uint days, sbyte hours, sbyte minutes)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((short)days);
            writer.WriteSbyte(hours);
            writer.WriteSbyte(minutes);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            days = reader.ReadVarUShort();
            hours = reader.ReadSbyte();
            minutes = reader.ReadSbyte();
        }
        
    }
    
}