using Arcturus.Recolor.Internal;
using System.Collections.Generic;
using UnityEngine;

namespace Arcturus.Recolor
{
    [CreateAssetMenu(fileName = "RecolorSprite", menuName = "New RecolorSprite")]
    public class RecolorSprite : ScriptableObject
    {
        [SerializeField] private Sprite originalSprite;
        [SerializeField] private List<RecolorProfile> recolorProfiles = new List<RecolorProfile>();
        public Sprite Sprite => originalSprite;

        public RecolorSprite(Sprite sprite)
        {
            originalSprite = sprite;
            ParseColors();
        }

        private Sprite GenerateRecolor(string recolorId)
        {
            // TODO:
            // Generate og duplicate and replace pixel color for another.
            return null;
        }

        public void ParseColors()
        {
            // TODO:
        }

        /// <summary>
        /// Returns a sprite of particular variation.<br/>
        /// Use blank id to get original sprite.
        /// </summary>
        /// <param name="recolorId"></param>
        /// <returns></returns>
        public Sprite GetSprite(string recolorId = "")
        {
            if (string.IsNullOrEmpty(recolorId))
                return originalSprite;
            else
                return GenerateRecolor(recolorId);
        }

        /// <summary>
        /// Returns a random sprite from both the original and all variants of sprite.
        /// </summary>
        /// <returns></returns>
        public Sprite GetRandomSprite()
        {
            var idList = new List<string>();
            idList.Add("OG");
            foreach (var profile in recolorProfiles)
                idList.Add(profile.id);

            var recolorId = idList[Random.Range(0, idList.Count)];
            if (recolorId == "OG")
                return originalSprite;
            else
                return GenerateRecolor(recolorId);
        }
    }
}
