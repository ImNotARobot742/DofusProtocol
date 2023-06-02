

// Generated on 06/02/2023 19:01:31
using System;
using System.Collections.Generic;
using AmaknaProxy.API.GameData.D2O;

namespace AmaknaProxy.API.Protocol.Data
{
    [D2oClass("Subhints")]
    public class Subhint : IDataObject
    {
        public const String MODULE = "Subhints";
        public int hint_id;
        public String hint_parent_uid;
        public String hint_anchored_element;
        public int hint_anchor;
        public int hint_position_x;
        public int hint_position_y;
        public int hint_width;
        public int hint_height;
        public String hint_highlighted_element;
        public int hint_order;
        public uint hint_tooltip_text;
        public int hint_tooltip_position_enum;
        public String hint_tooltip_url;
        public int hint_tooltip_offset_x;
        public int hint_tooltip_offset_y;
        public int hint_tooltip_width;
        public double hint_creation_date;
    }
}