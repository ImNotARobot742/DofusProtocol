

// Generated on 06/13/2023 16:59:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiConfirmationRequestMessage : NetworkMessage
    {
        public const uint Id = 1223;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double kamas;
        public double ogrines;
        public uint rate;
        public sbyte action;
        
        public HaapiConfirmationRequestMessage()
        {
        }
        
        public HaapiConfirmationRequestMessage(double kamas, double ogrines, uint rate, sbyte action)
        {
            this.kamas = kamas;
            this.ogrines = ogrines;
            this.rate = rate;
            this.action = action;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(kamas);
            writer.WriteVarLong(ogrines);
            writer.WriteVarShort((short)rate);
            writer.WriteSbyte(action);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            kamas = reader.ReadVarULong();
            ogrines = reader.ReadVarULong();
            rate = reader.ReadVarUShort();
            action = reader.ReadSbyte();
        }
        
    }
    
}