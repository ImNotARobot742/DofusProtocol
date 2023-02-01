

// Generated on 02/01/2023 12:54:51
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Documents")]
    public class Document : IDataObject
    {
        private const String MODULE = "Documents";
        public int id;
        public uint typeId;
        public Boolean showTitle;
        public Boolean showBackgroundImage;
        public uint titleId;
        public uint authorId;
        public uint subTitleId;
        public uint contentId;
        public String contentCSS;
        public String clientProperties;
    }
}