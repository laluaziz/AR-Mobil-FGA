using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AturDeskripsi : MonoBehaviour
{
    private bool[] isMarker;
    private GameObject mobil;
    private int hitungMarker;
    [SerializeField] int jmlMarker;
    [SerializeField] private Text txNama, txDeskr;

    private void Start()
    {
        isMarker = new bool[jmlMarker];
    }

    public void SetMarkerOn(int indexmarker)
    {
        if (!isMarker[indexmarker])
        {
            isMarker[indexmarker] = true;
            hitungMarker++;
        }
    }

    public void SetMarkerOff(int indexmarker)
    {
        if (!isMarker[indexmarker])
        {
            isMarker[indexmarker] = false;
            hitungMarker--;
        }
    }

    public void SetMobil(GameObject mobil)
    {
        this.mobil = mobil;
    }

    private void SetUI(bool b)
    {
        txNama.transform.parent.gameObject.SetActive(b);
        txDeskr.transform.parent.gameObject.SetActive(b);
    }

    private void Update()
    {
        if (hitungMarker == 0)
        {
            SetUI(false);

            return;
        }

        if(mobil != null)
        {
            for(int i=0; i < isMarker.Length; i++)
            {
                txNama.text = mobil.GetComponent<planet>().GetNama();
                txDeskr.text = mobil.GetComponent<planet>().GetDeskripsi();
            }
        }
    }
}
