using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Bai05
{
    public enum Respond_Type
    {
        Add_Food,
        See_Food,
        Choose_Food
    }

    [Serializable]

    public class Respond_Packet
    {
        public Respond_Type Type { get; set; }

        public string Food_Name { get; set; }

        public string Image { get; set; }
 
        public string Name_NCC { get; set; }
    }
}
