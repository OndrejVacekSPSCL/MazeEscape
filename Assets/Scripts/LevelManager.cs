using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static LevelManager instance;

    private void Awake() {
        if (LevelManager.instance == null) {

        }
    }

}
