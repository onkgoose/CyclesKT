using UnityEngine;

public class sort : MonoBehaviour
{
    public Transform[] cubes;

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;

        for (int i = 0; i < cubes.Length - 1; i++)
            for (int j = 0; j < cubes.Length - i - 1; j++)
                if (cubes[j].localScale.x < cubes[j + 1].localScale.x)
                    (cubes[j], cubes[j + 1]) = (cubes[j + 1], cubes[j]);

        float x = 0f;
        foreach (var c in cubes)
        {
            float s = c.localScale.x;
            c.position = new Vector3(x + s * 0.5f, s * 0.5f, 0f);
            x += s + 0.5f;
        }
    }
}
