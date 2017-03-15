using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Data.Linq;

namespace RUISView.DatabaseModel
{
    [Table(Name = "P_Rules")]
    public class P_Rules
    {
        [Column]
        private int _p_PhotoId;

        private EntityRef<Photos> _Photos;
        [Association(Storage = "_Photos", OtherKey = "_p_PhotoId", IsForeignKey = true)]
        public Photos Photos
        {
            get { return this._Photos.Entity; }
            set { this._Photos.Entity = value; }
        }

        [Column]
        private int _m_MapId;

        private EntityRef<Maps> _Maps;
        [Association(Storage = "_Maps", OtherKey = "_m_MapId", IsForeignKey = true)]
        public Maps Maps
        {
            get { return this._Maps.Entity; }
            set { this._Maps.Entity = value; }
        }
    }
}
