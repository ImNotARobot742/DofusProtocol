

// Generated on 05/18/2023 15:10:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterFirstSelectionMessage : CharacterSelectionMessage
    {
        public const uint Id = 159;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool doTutorial;
        
        public CharacterFirstSelectionMessage()
        {
        }
        
        public CharacterFirstSelectionMessage(double id, bool doTutorial)
         : base(id)
        {
            this.doTutorial = doTutorial;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(doTutorial);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            doTutorial = reader.ReadBoolean();
        }
        
    }
    
}