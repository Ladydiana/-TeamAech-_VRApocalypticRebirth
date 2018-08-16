﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


namespace EgyptCartoonPack
{


    public enum HouseTypesEnum
    {
        BigHouse, MedHouse, SmallHouse
    }

    public class GameManager : MonoBehaviour
    {


        public Vector3 LastDoor;

        public Quaternion PlayerRotation;

        //houses
        public Transform BigHouseSpawn;
        public Transform MedHouseSpawn;
        public Transform SmallHouseSpawn;
        public HouseTypesEnum HouseTypeTarget;

        //exterior 
        public Transform TempleSpawn;
        public Transform PyramidSpawn;

        public AudioClip TempleMusic; // licensed music
        public AudioClip MainMusic;



        [HideInInspector]
        public int lastLevel = 0;

        // Use this for initialization
        void Start()
        {

            DontDestroyOnLoad(transform.gameObject);

            Application.LoadLevel(1);

            SceneManager.sceneLoaded += OnSceneLoaded;

        }

        // 1 = exterior 2 = house 3 = pyramide 4 = temple

        // Update is called once per frame
        public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {

            GameObject player = FindPlayer();


            if (scene.buildIndex == 1)
            {

                player.transform.rotation = PlayerRotation;
                player.transform.position = LastDoor;

                /*this.GetComponent<AudioSource>().clip = MainMusic;
                this.GetComponent<AudioSource>().volume = 0.7f;
                this.GetComponent<AudioSource>().Play();*/

                lastLevel = 1;
            }

            if (scene.buildIndex == 2)
            {

                this.GetComponent<AudioSource>().volume = 0.3f;

                if (this.HouseTypeTarget == HouseTypesEnum.BigHouse)
                    player.transform.position = BigHouseSpawn.position;
                else if (this.HouseTypeTarget == HouseTypesEnum.MedHouse)
                    player.transform.position = MedHouseSpawn.position;
                else if (this.HouseTypeTarget == HouseTypesEnum.SmallHouse)
                    player.transform.position = SmallHouseSpawn.position;

                lastLevel = 2;
            }

            if (scene.buildIndex == 3)
            {
                /*this.GetComponent<AudioSource>().clip = TempleMusic;
                this.GetComponent<AudioSource>().volume = 0.6f;
                this.GetComponent<AudioSource>().Play();*/
                lastLevel = 3;
            }

            if (scene.buildIndex == 4)
            {
                /*this.GetComponent<AudioSource>().clip = TempleMusic;
                this.GetComponent<AudioSource>().volume = 0.6f;
                this.GetComponent<AudioSource>().Play();*/
                lastLevel = 4;
            }
        }

        public GameObject FindPlayer()
        {
            GameObject o;

            //THIS NEED TO BE YOUR PLAYER
            o = GameObject.FindGameObjectWithTag("Player");

            return o;
        }

    }
}
