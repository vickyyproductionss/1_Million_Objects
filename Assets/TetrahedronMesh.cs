using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class TetrahedronMesh : MonoBehaviour
{

    void Start()
    {
        GenerateAndSaveTetrahedronMesh();
    }
    [ContextMenu("Generate and Save Tetrahedron Mesh")]
    void GenerateAndSaveTetrahedronMesh()
    {
        Mesh mesh = new Mesh();
        mesh.name = "Tetrahedron";

        // Define the vertices of the tetrahedron
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(1, 1, 1),
            new Vector3(-1, -1, 1),
            new Vector3(-1, 1, -1),
            new Vector3(1, -1, -1)
        };

        // Define the triangles (each set of 3 numbers represents a triangle)
        int[] triangles = new int[]
        {
            0, 1, 2,
            0, 3, 1,
            0, 2, 3,
            1, 3, 2
        };

        // Assign the vertices and triangles to the mesh
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        // Recalculate normals for proper lighting
        mesh.RecalculateNormals();

        // Save the mesh as an asset
        SaveMeshAsAsset(mesh);
    }

#if UNITY_EDITOR
    void SaveMeshAsAsset(Mesh mesh)
    {
        // Create a folder for the mesh if it doesn't exist
        string path = "Assets/TetrahedronMeshes";
        if (!AssetDatabase.IsValidFolder(path))
        {
            AssetDatabase.CreateFolder("Assets", "TetrahedronMeshes");
        }

        // Save the mesh asset
        string assetPath = path + "/Tetrahedron.asset";
        AssetDatabase.CreateAsset(mesh, assetPath);
        AssetDatabase.SaveAssets();

        Debug.Log("Mesh saved as: " + assetPath);
    }
#endif
}
