using UnityEditor;
using UnityEngine;

namespace Arcturus.Recolor.Internal
{
    [CustomEditor(typeof(RecolorSprite))]
    public class RecolorInspector : Editor
    {
        public override void OnInspectorGUI()
        {
            // TODO:
            // Custom draw
            base.OnInspectorGUI();

            RecolorSprite reSprite = (RecolorSprite)target;

            if (reSprite.Sprite != null)
            {
                if (GUILayout.Button("Parse Sprite"))
                    reSprite.ParseColors();
            }
        }
    }
}
