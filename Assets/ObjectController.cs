using UnityEngine;

public class ObjectController : MonoBehaviour
{
    private float can = 100;
    
    public void CanAzalt(float amount)
    {
        can -= amount;

        if(can <= 0)
        {
            Destroy(gameObject);
        }
    }
}
