using UnityEngine;

namespace Arcturus.Recolor.Internal
{
    [System.Serializable]
    public struct ColorMatch
    {
        [SerializeField] private Color ogColor;
        public Color newColor;

        public ColorMatch(Color ogColor)
        {
            this.ogColor = ogColor;
            newColor = ogColor;
        }
    }
}