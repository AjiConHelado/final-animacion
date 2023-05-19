using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapper : MonoBehaviour
{
    public Transform mainMesh;
    public Transform targetMesh;
    public Transform snapPoint;

    void Start()
    {
        SnapMesh();
    }

    void SnapMesh()
    {
        MeshFilter mainMeshFilter = mainMesh.GetComponent<MeshFilter>();
        MeshFilter targetMeshFilter = targetMesh.GetComponent<MeshFilter>();

        if (mainMeshFilter != null && targetMeshFilter != null)
        {
            Mesh mainMesh = mainMeshFilter.sharedMesh;
            Mesh targetMesh = targetMeshFilter.sharedMesh;

            Vector3[] mainVertices = mainMesh.vertices;
            Vector3[] targetVertices = targetMesh.vertices;

            Vector3 snapPointWorldPosition = snapPoint.position;
            Vector3 snapPointLocalPosition = mainMeshFilter.transform.InverseTransformPoint(snapPointWorldPosition);

            for (int i = 0; i < targetVertices.Length; i++)
            {
                targetVertices[i] += snapPointLocalPosition;
            }

            targetMesh.vertices = targetVertices;
            targetMesh.RecalculateBounds();
            targetMesh.RecalculateNormals();
        }
    }
}



