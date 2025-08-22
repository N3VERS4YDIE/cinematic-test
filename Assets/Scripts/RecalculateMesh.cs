using UnityEngine;

public class RecalculateMesh : MonoBehaviour
{
    void Start()
    {
        MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();

        foreach (MeshFilter meshFilter in meshFilters)
        {
            if (meshFilter.sharedMesh != null)
            {
                meshFilter.sharedMesh.RecalculateBounds();
                meshFilter.sharedMesh.RecalculateNormals();
                meshFilter.sharedMesh.RecalculateTangents();
                meshFilter.sharedMesh.RecalculateUVDistributionMetrics();
                Debug.Log($"Recalculated mesh: {meshFilter.sharedMesh.name}");
            }
        }
    }
}
