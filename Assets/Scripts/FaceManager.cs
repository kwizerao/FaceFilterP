using UnityEngine;
using UnityEngine.UI;


public class FaceManager : MonoBehaviour
{
    public Button redbtn;
    public Button greenBtn;
    public Button blueBtn;


    private GameObject objInstace;
    private MeshRenderer mr;

    private void Start()
    {
        redbtn.onClick.AddListener(() =>
        {
            GetObject();
            mr.material.color = Color.red;
        });

        greenBtn.onClick.AddListener(() =>
        {
            GetObject();
            mr.material.color = Color.green;
        }
        );

        blueBtn.onClick.AddListener(() =>
        {
            GetObject();
            mr.material.color = Color.blue;
        });
    }

    public void GetObject()
    {
        objInstace = GameObject.FindGameObjectWithTag("face");
        if(objInstace != null)
        {
            mr = objInstace.GetComponent<MeshRenderer>(); 
        }
    }



}


