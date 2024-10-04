using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;




public class BaseGun : MonoBehaviour
{
    public Transform barrelOrigin, sightOrigin, stockOrigin, magOrigin, gripOrigin;

    public BarrellScriptable barrellScriptable;

    private BarrellScriptable currentBarrel;



    private void Awake()
    {
        ApplyAttachments();
    }


    private void Update()
    {
       
    }




    void ApplyAttachments() {

        if (currentBarrel == barrellScriptable) return;
        Destroy(currentBarrel);
        if (barrellScriptable == null) return;
        currentBarrel = Instantiate(barrellScriptable.barrellPrefab, barrelOrigin.transform.position, Quaternion.identity).GetComponent<BarrellScriptable>();

        
    
    }



}
