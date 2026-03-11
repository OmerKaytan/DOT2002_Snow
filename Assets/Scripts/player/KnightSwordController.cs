using UnityEngine;

public class KnightSwordController : MonoBehaviour
{
    public GameObject OriginalSword;
    public GameObject FakeSword;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dusman"))
        {
            other.GetComponent<ObjectController>().CanAzalt(20) ;

            
        }
    }

    public void ActivateOriginalSword(bool isActivating)
    {
        OriginalSword.SetActive(isActivating);
    }
    public void ActivateFakeSword(bool isActivating)
    {
        FakeSword.SetActive(isActivating);
    }
}
