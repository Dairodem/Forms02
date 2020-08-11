using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotitieBoekje
{
    public class Notitieboek
    {
        public Notitieboek()
        {
            NotitieLijst = new List<Notitie>();

        }
        public List<Notitie> NotitieLijst { get; set; }
        public void AddNotitie(string name)
        {
                Notitie notitie = new Notitie(name);

                NotitieLijst.Add(notitie);
        }
        public void RemoveNotitie(int index)
        {
            if (index < NotitieLijst.Count && index >= 0)
            {
                NotitieLijst.RemoveAt(index);
            }
        }
    }
}
