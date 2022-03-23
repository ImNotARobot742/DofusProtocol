

// Generated on 03/23/2022 09:51:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameRolePlayPrismInformations : GameRolePlayActorInformations
    {
        public const short Id = 882;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.PrismInformation prism;
        
        public GameRolePlayPrismInformations()
        {
        }
        
        public GameRolePlayPrismInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.PrismInformation prism)
         : base(contextualId, disposition, look)
        {
            this.prism = prism;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(prism.TypeId);
            prism.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            prism = ProtocolTypeManager.GetInstance<Types.PrismInformation>(reader.ReadUShort());
            prism.Deserialize(reader);
        }
        
    }
    
}