

// Generated on 05/18/2023 16:28:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LeaveDialogMessage : NetworkMessage
    {
        public const uint Id = 9859;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte dialogType;
        
        public LeaveDialogMessage()
        {
        }
        
        public LeaveDialogMessage(sbyte dialogType)
        {
            this.dialogType = dialogType;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(dialogType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            dialogType = reader.ReadSbyte();
        }
        
    }
    
}