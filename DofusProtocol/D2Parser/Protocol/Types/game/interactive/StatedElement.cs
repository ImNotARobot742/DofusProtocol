

// Generated on 02/01/2023 12:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class StatedElement
    {
        public const short Id = 9515;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int elementId;
        public uint elementCellId;
        public uint elementState;
        public bool onCurrentMap;
        
        public StatedElement()
        {
        }
        
        public StatedElement(int elementId, uint elementCellId, uint elementState, bool onCurrentMap)
        {
            this.elementId = elementId;
            this.elementCellId = elementCellId;
            this.elementState = elementState;
            this.onCurrentMap = onCurrentMap;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(elementId);
            writer.WriteVarShort((short)elementCellId);
            writer.WriteVarInt((int)elementState);
            writer.WriteBoolean(onCurrentMap);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            elementId = reader.ReadInt();
            elementCellId = reader.ReadVarUShort();
            elementState = reader.ReadVarUInt();
            onCurrentMap = reader.ReadBoolean();
        }
        
    }
    
}