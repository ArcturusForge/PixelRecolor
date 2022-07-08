using System.Collections.Generic;
using UnityEngine;

namespace Arcturus.Recolor.Internal
{
    [System.Serializable]
    public class RecolorProfile
    {
        public string id;
        [SerializeField] private List<ColorMatch> colorReplacements;

        public RecolorProfile(List<Color> colors)
        {
            colorReplacements = new List<ColorMatch>();
            foreach (var color in colors)
                colorReplacements.Add(new ColorMatch(color));
        }
    }
}