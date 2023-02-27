using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;
    private List<Transform> _segments;
    public Transform segmentSnake;
    private  Rigidbody2D _rigidbody;
    private int points = 0;
    public Text pontsText;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _segments = new List<Transform>();
        _segments.Add(this.transform);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && _direction != Vector2.down)
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S) && _direction != Vector2.up)
        {
            _direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.D) && _direction != Vector2.left)
        {
            _direction = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.A) && _direction != Vector2.right)
        {
            _direction = Vector2.left;
        }
    }

    private void FixedUpdate()
    {
        for(int i = _segments.Count - 1; i > 0 ; i--)
        {
            _segments[i].position = _segments[i-1].position;
        }

        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f
        );
        /*if (_rigidbody.velocity.magnitude > maxspeed)
        {
            _rigidbody.velocity = Vector3.ClampMagnitude(_rigidbody.velocity, maxspeed);
        }
        else if (_rigidbody.velocity.magnitude < maxspeed)
        {
            _rigidbody.velocity = Vector3.ClampMagnitude(_rigidbody.velocity, speed);
        }*/
        

    }
    private void ResetState()
    {
        for (int i = 1; i < _segments.Count; i++)
        {
            Destroy(_segments[i].gameObject);
        }
        _segments.Clear();
        _segments.Add(this.transform);

        this.transform.position = Vector2.zero;
    }
    private void Grow()
    {
        Transform segment = Instantiate(this.segmentSnake);
        segment.position = _segments[_segments.Count - 1].position;
        _segments.Add(segment);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
        Grow();
        points++;
        pontsText.text = points.ToString();
        }
        else if(other.tag == "Obstacle")
        {
        ResetState();
        points = 0;
        pontsText.text = points.ToString();
        }
    }
}
