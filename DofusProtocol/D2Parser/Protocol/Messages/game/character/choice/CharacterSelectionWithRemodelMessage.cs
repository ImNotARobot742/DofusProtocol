

// Generated on 03/23/2022 09:50:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterSelectionWithRemodelMessage : CharacterSelectionMessage
    {
        public const uint Id = 772;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.RemodelingInformation remodel;
        
        public CharacterSelectionWithRemodelMessage()
        {
        }
        
        public CharacterSelectionWithRemodelMessage(double id, Types.RemodelingInformation remodel)
         : base(id)
        {
            this.remodel = remodel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            remodel.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            remodel = new Types.RemodelingInformation();
            remodel.Deserialize(reader);
        }
        
    }
    
}