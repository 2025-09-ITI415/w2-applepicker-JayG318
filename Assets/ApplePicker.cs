using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    
    void Start()
    {
        basketList = new List<GameObject>();
        for (int i=0; i < numBaskets; i++) {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }

    public void AppleMissed() {
        GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
            foreach (GameObject tempGO in appleArray) {
                Destroy(tempGO);
            }
            // Destroy one Basket
            int basketIndex = basketList.Count - 1; // Last Basket index
            GameObject basketGO = basketList[basketIndex]; // Reference that Basket GameObject
            basketList.RemoveAt(basketIndex); // Remove Basket from List and Destroy its GameObject
            Destroy(basketGO);

            if (basketList.Count == 0) {
                SceneManager.LoadScene("_Scene_0"); // Restart if no more baskets
            }
    }
}
