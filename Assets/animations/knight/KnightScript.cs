using UnityEngine;
using UnityEngine.UIElements;

public class KnightScript : MonoBehaviour
{
    [Header("Component Referanslari")]
    public Rigidbody rb;
    public Animator KnightAnimator;
    public KnightSwordController knightSwordController;
    [Space(8)]


    [Header("Karakter Ozellik Referanslari")]
    [Range(0f,1f)]
    public float speed;
    public float donmeHizi;
    [Space(8)]
    [Header("Silah Referanslari")]

    public Transform LongSpear;
    public GameObject LongSpearPrefab;
    public Transform ok;
    public GameObject okPrefab;
    public GameObject sirttakiBow;
    public GameObject eldekiBow;

    [Space(15)]
    [Header("Animator Parametreleri")]
    public bool isCombatMode = false;
    public bool isRunning = false;
    public bool jump = false;
    public bool rightClick = false;
    public bool yayEldeMi = false;
    public bool yayAlma = false;
    public bool isRunningLeft = false;
    public bool isRunningRight = false;

    public Transform cameraTransform;
    float xRotation = 0f;

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = !isRunning;

            if ((Input.GetKeyDown(KeyCode.W) && isRunning == true))
            {
                KnightAnimator.SetTrigger("isRunning");
            }

            else
            {
                KnightAnimator.SetTrigger("isRunning");
            }
        }


        if (Input.GetKeyDown(KeyCode.D) && isRunning == true)
        {
            isRunningLeft = !isRunningLeft;
            if (isRunningLeft == true)
            {
                KnightAnimator.SetTrigger("isRunningLeft");
            }

            else
            {
                KnightAnimator.SetTrigger("isRunningLeft");
            }
        }


        if (Input.GetKeyDown(KeyCode.D) && isRunning == true)
        {
            isRunningRight = !isRunningRight;
            if (isRunningRight == true)
            {
                KnightAnimator.SetTrigger("isRunningRight");
            }

            else
            {
                KnightAnimator.SetTrigger("isRunningRight");
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;

            if (jump == true)
            {
                KnightAnimator.SetTrigger("jump");
            }
        }


        if ((yayEldeMi = true) && (Input.GetMouseButtonDown(0)))
        {
            KnightAnimator.SetTrigger("okAlma");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            yayEldeMi = !yayEldeMi;
            KnightAnimator.SetTrigger("yayAlma");

        }



        float xMouseInputValue = Input.GetAxis("Mouse X");
        transform.Rotate(0, xMouseInputValue * donmeHizi, 0);

        float yMouseInputValue = Input.GetAxis("Mouse Y");

        xRotation -= yMouseInputValue * donmeHizi;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        float ilerimovementvalue = Input.GetAxis("Vertical");
        KnightAnimator.SetFloat("ileriValue", ilerimovementvalue);
        transform.Translate(Vector3.forward * ilerimovementvalue * speed);

        float yataymovementvalue = Input.GetAxis("Horizontal");
        KnightAnimator.SetFloat("yatayValue", yataymovementvalue * 0.7f);
        transform.Translate(Vector3.right * yataymovementvalue * speed);

        if (ilerimovementvalue > 0)
        {
            KnightAnimator.SetFloat("ileriValue", ilerimovementvalue);
            transform.Translate(Vector3.forward * ilerimovementvalue * speed);
        }
        if ((ilerimovementvalue > 0 ) && isRunning == true)
        {
            KnightAnimator.SetFloat("ileriValue", ilerimovementvalue);
            transform.Translate(Vector3.forward * ilerimovementvalue * speed * 5f);
        }
        if ((ilerimovementvalue > 0) && isRunningLeft == true)
        {
            KnightAnimator.SetFloat("yatayValue", yataymovementvalue);
            transform.Translate(Vector3.left * yataymovementvalue * speed * 5f);
        }
        if ((ilerimovementvalue > 0) && isRunningRight == true)
        {
            KnightAnimator.SetFloat("yatayValue", yataymovementvalue);
            transform.Translate(Vector3.right * yataymovementvalue * speed * 5f);
        }

    }

    //public void KilicYerlestirme()
    //{
    //    knightSwordController.ActivateFakeSword(!isCombatMode);
    //    knightSwordController.ActivateOriginalSword(isCombatMode);
    //}

    //if (Input.GetKey(KeyCode.Mouse0))
    //{
    //    rightClick = !rightClick;

    //        KnightAnimator.SetTrigger("rightClick");

    //    if (Input.GetKeyUp(KeyCode.Mouse0))
    //    {
    //        KnightAnimator.SetTrigger("rightClick");
    //    }
    //}



    //if (Input.GetMouseButtonDown(0) && isCombatMode)
    //{
    //    KnightAnimator.SetTrigger("Attack");
    //}

    //if (Input.GetMouseButtonDown(1))
    //{
    //    KnightAnimator.SetTrigger("saðtik");
    //}



    void DurarakZiplama()
    {
        rb.AddForce(new Vector3(0, 150f, 0));
    }

    void KosarakZiplama()
    {
        rb.AddForce(new Vector3(0, 150f, 0));
    }

    //void MizrakAtma()
    //{

    //    Vector3 Pos = LongSpear.position;
    //    Quaternion Rot = LongSpear.rotation;

    //    LongSpear.gameObject.SetActive(false);
    //    GameObject spawn_edilen_mizrak = Instantiate(LongSpearPrefab, Pos, Rot);

    //    Rigidbody Spear_rb = spawn_edilen_mizrak.GetComponent<Rigidbody>();


    //    Debug.Log("AFTER Pos" + LongSpear.position + "  Rot :" + LongSpear.rotation.eulerAngles);




    //    Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
    //    Spear_rb.isKinematic = false;
    //    Spear_rb.AddForce(spawn_edilen_mizrak.transform.forward * 100f, ForceMode.Impulse);




    //}

    void OkAtma()
    {
        Vector3 Pos = ok.position;
        Quaternion Rot = ok.rotation;

        ok.gameObject.SetActive(false);
        GameObject spawn_edilen_ok = Instantiate(okPrefab, Pos, Rot);

        Rigidbody ok_rb = spawn_edilen_ok.GetComponent<Rigidbody>();


        print("AFTER Pos" + ok.position + "  Rot :" + ok.rotation.eulerAngles);




        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        ok_rb.isKinematic = false;
        ok_rb.AddForce(spawn_edilen_ok.transform.forward * 100f, ForceMode.Impulse);
    }

}