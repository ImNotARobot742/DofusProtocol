

// Generated on 05/18/2023 16:29:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ObjectEffectDuration : ObjectEffect
    {
        public const short Id = 8604;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint days;
        public sbyte hours;
        public sbyte minutes;
        
        public ObjectEffectDuration()
        {
        }
        
        public ObjectEffectDuration(uint actionId, uint days, sbyte hours, sbyte minutes)
         : base(actionId)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)days);
            writer.WriteSbyte(hours);
            writer.WriteSbyte(minutes);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            days = reader.ReadVarUShort();
            hours = reader.ReadSbyte();
            minutes = reader.ReadSbyte();
        }
        
    }
    
}