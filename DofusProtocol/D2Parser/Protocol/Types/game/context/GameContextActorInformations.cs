

// Generated on 06/13/2023 17:00:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameContextActorInformations : GameContextActorPositionInformations
    {
        public const short Id = 7693;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.EntityLook look;
        
        public GameContextActorInformations()
        {
        }
        
        public GameContextActorInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look)
         : base(contextualId, disposition)
        {
            this.look = look;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            look.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            look = new Types.EntityLook();
            look.Deserialize(reader);
        }
        
    }
    
}