using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManage : MonoBehaviour
{
    [SerializeField] Sprite Knob;
    [SerializeField] Transform CanvasPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            ClickEffect();
        }
    }
    public void ClickEffect(){
        Vector3 mousePos = Input.mousePosition;
        Debug.Log(mousePos);
        GameObject clickEff = new GameObject("clickEff");
        clickEff.transform.position = mousePos;
        clickEff.AddComponent<Image>();
        clickEff.transform.SetParent(CanvasPos);
    }
    public Image CreateImageUi(Vector3 _pos){
        Image image = null;
        return image;
    }


}
