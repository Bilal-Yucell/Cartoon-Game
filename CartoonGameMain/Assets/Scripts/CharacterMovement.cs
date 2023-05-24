using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5f; // Karakterin hızı
    public float pathOffset = 1f; // Yolların küpten ne kadar uzakta olacağı

    private float pathWidth; // Yolların genişliği
    private float middlePathPosition; // Orta yolun pozisyonu
    private float rightPathPosition; // Sağ yolun pozisyonu
    private float leftPathPosition; // Sol yolun pozisyonu
    private Transform currentPath; // Geçerli yolun transformu

    void Start()
    {
        // Küpün genişliğini ve konumunu alarak yolları hesapla
        pathWidth = transform.localScale.x;
        middlePathPosition = transform.position.x;
        rightPathPosition = middlePathPosition + (pathWidth / 2f);
        leftPathPosition = middlePathPosition - (pathWidth / 2f);

        // Başlangıçta karakteri orta yola yerleştir
        currentPath = transform;
        transform.position = currentPath.position;
    }

    void Update()
    {
        // Yol değişikliği olduğunda hedef pozisyonu güncelle
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentPath.position.x == middlePathPosition)
                currentPath = transform;
            else if (currentPath.position.x == leftPathPosition)
                currentPath = transform;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentPath.position.x == middlePathPosition)
                currentPath = transform;
            else if (currentPath.position.x == rightPathPosition)
                currentPath = transform;
        }

        // Karakteri hedef pozisyona doğru hareket ettir
        transform.position = Vector3.MoveTowards(transform.position, currentPath.position, speed * Time.deltaTime);
    }
}