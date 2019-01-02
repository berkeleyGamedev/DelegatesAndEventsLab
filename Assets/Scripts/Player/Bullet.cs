using UnityEngine;

[DisallowMultipleComponent]
public class Bullet : MonoBehaviour
{
    #region Delegates and Events
    // TODO: CODE HERE
    public delegate void EnemyHitDelegate();
    public static event EnemyHitDelegate EnemyDestroyedEvent;

    #endregion

    #region Collision Methods
    private void OnParticleCollision(GameObject other)
   {
        if (other.CompareTag("Enemy") && EnemyDestroyedEvent != null)
        {
            EnemyDestroyedEvent();
            other.SetActive(false);
        }

    }
    #endregion

    #region Unity Misc
    private void OnParticleSystemStopped()
   {
      gameObject.SetActive(false);
   }
   #endregion
}
