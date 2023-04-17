using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet : MonoBehaviour
{
    [SerializeField] private string nama;
    [SerializeField] [TextArea] private string deskripsi;

    public string GetNama()
    {
        return nama;
    }

    public string GetDeskripsi()
    {
        return deskripsi;
    }
}
