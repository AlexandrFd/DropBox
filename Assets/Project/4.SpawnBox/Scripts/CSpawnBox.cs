using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSpawnBox : MonoBehaviour
{
    /// <summary>
    /// Генерация объектов по таймеру в 2 секунды в рандомной позиции по оси Х.  
    /// </summary>
    [SerializeField] private GameObject Box;
    bool spawnControll = true;
    bool speedControll = true;
    float spawnCoolDown = 2F;
    float speedCoolDown = 5F;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer();
        SpawnController();

        SpeedTimer();
        SpeedController();
    }
    void SpawnController() //Проверка Таймера
    {
        if (spawnCoolDown <= 0)
        {
            if (spawnControll)
            {
                BoxInstantiate();
                spawnCoolDown = 2;
                spawnControll = true;
            }
        }
    }
    void BoxInstantiate() // Создание обьекта с рандомными координатами
    {
        Instantiate(Box, new Vector3(Random.Range(-3.5F, 3.5F), transform.position.y, 0F), Quaternion.identity);
        spawnControll = false;
    }
    void SpawnTimer() // Таймер
    {
        spawnCoolDown -= Time.deltaTime;
    }

    void SpeedController() //Контролирует увеличение скорости
    {
        if (speedCoolDown <=0)
        {
            if (speedControll)
            {
                IncreaseSpeed();
                speedCoolDown = 5;
                speedControll = true;
            } 
        }
    }
    void IncreaseSpeed() //Увеличивает гравитацию, соответственно и скорость падения
    {
        Box.GetComponent<Rigidbody2D>().gravityScale += 0.05F;
        speedControll = false;
    }
    void SpeedTimer() // Таймер  для увеличения скорости падения
    {
        speedCoolDown -= Time.deltaTime;
    }

}
