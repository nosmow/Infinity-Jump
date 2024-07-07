using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Canvas canvasStart;
    [SerializeField] Canvas canvasScore;
    [SerializeField] Canvas canvasEnd;

    [SerializeField] MoveLeft moveLeft;
    [SerializeField] GameObject spawnManagerObject;
    SpawnManager spawnManager;

    [SerializeField] PlayerController playerController;

    TextMeshProUGUI textScore;
    int score = 0;

    private void Awake()
    {
        canvasScore.enabled = false;

        canvasEnd.enabled = false;

        moveLeft.enabled = false;
        spawnManagerObject.SetActive(false);

        playerController.enabled = false;
        playerController.dirtParticle.Stop();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canvasStart.enabled)
        {
            canvasStart.enabled = false;
            canvasScore.enabled = true;

            moveLeft.enabled = true;
            spawnManagerObject.SetActive(true);
            playerController.enabled = true;

            playerController.speedF = 1f;
            playerController.dirtParticle.Play();
        }

        if (playerController.gameOver)
        {
            AudioListener al = FindAnyObjectByType<AudioListener>();

            canvasEnd.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.R) && canvasEnd.enabled)
        {
            SceneManager.LoadScene(0);
        }
    }
}
