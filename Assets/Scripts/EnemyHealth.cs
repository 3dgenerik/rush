using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 10;
    int currentHitPoints = 0;

    private void Update() {
    }

    private void OnParticleCollision(GameObject other)
    {
        ParticleHit();
    }

    private void ParticleHit()
    {
        currentHitPoints++;
        if (currentHitPoints >= maxHitPoints)
        {
            Destroy(this.gameObject);
            currentHitPoints = 0;
        }
    }
}
