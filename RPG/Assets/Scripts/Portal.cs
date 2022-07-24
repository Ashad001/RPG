using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Portal : Collidable
{
    public string[] SceneNames;
    protected override void OnCollide(Collider2D collide)
    {
        if(collide.name == "Player")
        {
            string SceneName = SceneNames[Random.Range(0, SceneNames.Length)];
            EditorSceneManager.LoadScene(SceneName);
        }
    }
}
