

// Generated on 06/13/2023 16:59:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameDataPaddockObjectAddMessage : NetworkMessage
    {
        public const uint Id = 3922;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.PaddockItem paddockItemDescription;
        
        public GameDataPaddockObjectAddMessage()
        {
        }
        
        public GameDataPaddockObjectAddMessage(Types.PaddockItem paddockItemDescription)
        {
            this.paddockItemDescription = paddockItemDescription;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            paddockItemDescription.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            paddockItemDescription = new Types.PaddockItem();
            paddockItemDescription.Deserialize(reader);
        }
        
    }
    
}