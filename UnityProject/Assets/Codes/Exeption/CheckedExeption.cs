using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Game
{
    public class CheckedExeption : MonoBehaviour
    {
        void Start()
        {
            try
            {
               if (FindObjectOfType<PlayerMove>().Force > 500f)
                {
                    throw new Exception();
                }
            }
            catch
            {
                Debug.Log("Пробросилось исключение, сила слишком большая!");
            }
        }
    }
}

