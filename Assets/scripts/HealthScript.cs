using UnityEngine;

/// <summary>
/// Handle hitpoints and damages
/// </summary>
public class HealthScript : MonoBehaviour
{
  /// <summary>
  /// Total hitpoints
  /// </summary>
  public int hp = 1;

  //Score Value
  public int scoreValue = 10;

  /// <summary>
  /// Enemy or player?
  /// </summary>
  public bool isEnemy = true;

  public GameObject player;

  /// <summary>
  /// Inflicts damage and check if the object should be destroyed
  /// </summary>
  /// <param name="damageCount"></param>
  public void Damage(int damageCount)
  {
    hp -= damageCount;
	  ScoreManager.score += scoreValue;
    if (hp <= 0)
    {

		  Destroy(gameObject);
      SoundEffectsHelper.Instance.MakeExplosionSound();
      SpecialEffectsHelper.Instance.Explosion(transform.position);
      if(!isEnemy){
        PlayerSpawner.playerAlive = false;
      }
	  
    }
  }

  void OnTriggerEnter2D(Collider2D otherCollider)
  {
    // Is this a shot?
    ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
    if (shot != null)
    {
      // Avoid friendly fire
      if (shot.isEnemyShot != isEnemy)
      {
        Damage(shot.damage);

        // Destroy the shot
        Destroy(shot.gameObject); // Remember to always target the game object, otherwise you will just remove the script
        SoundEffectsHelper.Instance.MakeExplosionSound();
      }
    }
  }
}