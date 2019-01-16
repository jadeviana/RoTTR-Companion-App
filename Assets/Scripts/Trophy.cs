using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Trophy", menuName = "Lists/Trophy")]
public class Trophy : ScriptableObject {

    public Sprite trophyImage;

    public string trophyName;
    public string description;

}
