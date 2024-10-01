using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class EnemyMove : MonoBehaviour
    {
        public List<Transform> enemies;                   // Список противников
        [SerializeField] private float moveSpeed;         // Скорость движения противников
        [SerializeField] private float moveDownDistance;  // Сколько вниз опускаются враги
        [SerializeField] private float boundaryX;         // Границы движения по оси X

        private Vector2 direction = Vector2.right;

        private void Update()
        {
            MoveEnemies();
        }

        private void MoveEnemies()
        {
            enemies.RemoveAll(enemy => enemy == null);
        
            if (enemies.Count == 0) return;
        
            Vector2 moveDirection = direction * (moveSpeed * Time.deltaTime);

            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i]?.Translate(moveDirection);
            
                float clampedX = Mathf.Clamp(enemies[i].position.x, -boundaryX, boundaryX);
                enemies[i].position = new Vector2(clampedX, enemies[i].position.y);
            }
        
            if (enemies.Count > 0 && (enemies[0].position.x <= -boundaryX || enemies[enemies.Count - 1].position.x >= boundaryX))
            {
                direction *= -1;
                MoveEnemiesDown();
            }
        }

        private void MoveEnemiesDown()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i] != null)
                {
                    enemies[i].position += new Vector3(0, -moveDownDistance, 0);
                }
            }
        }
    }
}