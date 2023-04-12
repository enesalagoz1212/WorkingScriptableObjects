using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[CreateAssetMenu(fileName = "New Enemy Type", menuName = "Enemy Type")]

public class EnemyType : ScriptableObject
{
    public Color enemyColor = Color.blue;
    public float enemySpeed = 5;
    public Vector3 enemyScale = Vector3.one;
    public string typeName = "type";


}
