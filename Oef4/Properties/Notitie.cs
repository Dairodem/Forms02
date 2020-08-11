using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotitieBoekje
{
    public class Notitie
    {
        public string Note;
        public string Name;
        public List<string> NotesList = new List<string>();
        DateTime myTime = new DateTime();


        public Notitie(string name)
        {
            myTime = DateTime.Now;
            Name = name;

        }
        public string GetOpschrift()
        {
            return Note;

        }
        public void SetOpschrift(string tekst)
        {
            Note = tekst;
        }
        public void Bijschrijven(string bijschrift)
        {
            NotesList.Add(bijschrift);

        }
        public DateTime GetTime()
        {
            return myTime;
        }
    }
}
