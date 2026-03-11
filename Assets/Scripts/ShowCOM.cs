using UnityEngine;

public class ShowCOM : MonoBehaviour
{
    void OnDrawGizmosSelected()
    {
        var rb = GetComponent<Rigidbody>();
        if (!rb) return;

        Gizmos.color = Color.yellow;
        Vector3 worldCOM = rb.worldCenterOfMass;
        Gizmos.DrawSphere(worldCOM, 0.05f);

        print("OnDrawGizmosSelected");
    }
}
