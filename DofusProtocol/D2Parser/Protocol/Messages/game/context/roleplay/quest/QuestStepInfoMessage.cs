

// Generated on 01/01/2022 14:39:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class QuestStepInfoMessage : NetworkMessage
    {
        public const uint Id = 7690;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.QuestActiveInformations infos;
        
        public QuestStepInfoMessage()
        {
        }
        
        public QuestStepInfoMessage(Types.QuestActiveInformations infos)
        {
            this.infos = infos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            infos = ProtocolTypeManager.GetInstance<Types.QuestActiveInformations>(reader.ReadUShort());
            infos.Deserialize(reader);
        }
        
    }
    
}