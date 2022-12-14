using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class uiControler : MonoBehaviour
{

    private int score;

    [SerializeField] protected HealthSystem healthUpdate;
    [SerializeField] private HealthSystem playerHealth;

    [SerializeField] private TextMeshProUGUI health_Ui;
    [SerializeField] private TextMeshProUGUI score_Ui;
    // Start is called before the first frame update
    void Awake()
    {
        //updates health on wake
        health_Ui.text = "Health: " + playerHealth.HitPoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        healthUpdate.OnHealthChanged += upDateHealthUi;
        Enemy.OnEnemyKilled += upDateScore;
    } 
    private void OnDisable()
    {
        healthUpdate.OnHealthChanged -= upDateHealthUi;
        Enemy.OnEnemyKilled -= upDateScore;
    }
    private void upDateHealthUi()
    {
        health_Ui.text = "Health: " + playerHealth.HitPoints;
        if (playerHealth.HitPoints <= 0) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }

    private void upDateScore(){
        score += 25;
        score_Ui.text = "Score: " + score;
    }
}
