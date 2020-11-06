using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetici : MonoBehaviour

{
    [SerializeField]
    private GameObject Clap;
    [SerializeField]
    private GameObject Tick;
    [SerializeField]
    private GameObject opage;
    [SerializeField]
    private GameObject mainmusic;
    [SerializeField]
    private GameObject gameover;
    [SerializeField]
    private GameObject Correct;
    [SerializeField]
    private GameObject Wrong;

    int yerlestirilen_parca = 0;
    int toplam_puzzle = 4;


    void Start()
    {
        Tick.SetActive(false);
        Clap.SetActive(false);
        gameover.SetActive(false);
        Correct.SetActive(false);
        Wrong.SetActive(false);

        StartCoroutine(WaitBeforeShow());
        mainmusic.SetActive(true);

    }

    IEnumerator WaitBeforeShow()
    {
        opage.SetActive(true);
        yield return new WaitForSeconds(3);
        opage.SetActive(false);
    }

    IEnumerator WaitBeforeGameOver()
    {
        gameover.SetActive(false);
        yield return new WaitForSeconds(4);
        gameover.SetActive(true);
    }



    IEnumerator CorrectSetToFalse()
    {
        Correct.SetActive(true);
        yield return new WaitForSeconds(1);
        Correct.SetActive(false);
    }


    IEnumerator WrongSetToFalse()
    {
        Wrong.SetActive(true);
        yield return new WaitForSeconds(1);
        Wrong.SetActive(false);
    }


    public void correct_place()
    {
        StartCoroutine(CorrectSetToFalse());
    }

    public void wrong_place()
    {
        StartCoroutine(WrongSetToFalse());
    }




    public void sayi_arttir()
    {
        yerlestirilen_parca++;
         if (yerlestirilen_parca==toplam_puzzle)
        {

            Tick.SetActive(true);
            Clap.SetActive(true);
            StartCoroutine(WaitBeforeGameOver());

        }
             
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
