using UnityEngine;
using UnityEditor;

public class SpriteProcessor : AssetPostprocessor
{
    int pixelsPerUnit = 16;

    void OnPreprocessTexture()
    {
        TextureImporter textureImporter = (TextureImporter) assetImporter;

        textureImporter.spritePixelsPerUnit = pixelsPerUnit;
        textureImporter.filterMode = FilterMode.Point;
    }
}