

// Generated on 02/01/2023 12:53:23
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LockableShowCodeDialogMessage : NetworkMessage
    {
        public const uint Id = 5125;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool changeOrUse;
        public sbyte codeSize;
        
        public LockableShowCodeDialogMessage()
        {
        }
        
        public LockableShowCodeDialogMessage(bool changeOrUse, sbyte codeSize)
        {
            this.changeOrUse = changeOrUse;
            this.codeSize = codeSize;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(changeOrUse);
            writer.WriteSbyte(codeSize);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            changeOrUse = reader.ReadBoolean();
            codeSize = reader.ReadSbyte();
        }
        
    }
    
}