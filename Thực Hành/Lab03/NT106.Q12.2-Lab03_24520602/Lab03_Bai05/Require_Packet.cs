using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab03_Bai05
{
    public enum Require_Type
    {
        Add_Food,
        See_Food,
        Chosse_Food_Global,
        Choose_Food_Personal,
        Ho_Ten
    }

    [Serializable]

    public class Require_Packet
    {
        public Require_Type Type { get; set; }

        public string Ho_Ten { get; set; }

        public string Quyen_Han { get; set; }   

        public string Ten_Mon_An { get; set; }

        public string Hinh_Anh { get; set; }
    }
}
