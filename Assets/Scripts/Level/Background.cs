using UnityEngine;

namespace Stickman
{
    public class Background : MonoBehaviour
    {
        private Vector2 InitalPos;
        private readonly float RepeatWidth = 40.96f;

        private void Start()
        {
            InitalPos = transform.position;
        }

        private void FixedUpdate()
        {
            transform.Translate(Game.Speed * Time.deltaTime * Vector3.left);

            if (transform.position.x < InitalPos.x - RepeatWidth)
            {
                transform.position = InitalPos;
            }
        }
    }
}