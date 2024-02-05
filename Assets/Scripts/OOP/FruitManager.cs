using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public List<Fruit> fruitSalad;
    // Start is called before the first frame update
    void Start()
    {
        fruitSalad = new List<Fruit>(); //defining fruit salad

        Fruit apple = new Fruit("apple", Color.yellow, 2.1f);

        fruitSalad.Add(apple);

        createFruitSalad();
        DisplayFruitSalad();
    }

    private void DisplayFruitSalad()
    {
        for (int i = 0; i < fruitSalad.Count; i++)
        {
            print(fruitSalad[i].color.ToString() + " " + fruitSalad[i].name + " weighing " + fruitSalad[i].weight + " units");
                //fruitSalad[i].weight);
        }
    }

    private void createFruitSalad()
    {
        fruitSalad.Add(new Fruit());

        fruitSalad.Add(new Fruit("strawberry"));

        fruitSalad.Add(new Fruit(Color.red));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
