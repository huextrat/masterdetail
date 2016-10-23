using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail
{
    public class Champ
    {
        public string Name { get; private set; }
        public Uri ImageChamp { get; private set; }
        public string IconChamp { get; private set; }
        public string PosChamp { get; private set; }
        public string HistChamp { get; private set; }
        public Uri VideoChamp { get; private set; }
        public Uri MusicChamp { get; private set; }
        public Champ(string name, Uri imageChamp, string iconChamp, string posChamp, string histChamp, Uri videoChamp, Uri musicChamp)
        {
            Name = name;
            ImageChamp = imageChamp;
            IconChamp = iconChamp;
            PosChamp = posChamp;
            HistChamp = histChamp;
            VideoChamp = videoChamp;
            MusicChamp = musicChamp;
        }
    }
}
