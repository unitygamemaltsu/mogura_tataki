using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
　  public AudioClip[] clips;
    AudioSource audio;
    private static int lebel = 1;

    // スピードの設定
    private static int[] speeds = new int[] {10, 8, 6, 4, 2}; // 確認用
    // 現在のスピードを設定
    private static int nowSpeed = speeds[0]; // 確認用

    // レベルアップスコアの設定
    public static int[] upScores = new int[] {2, 4, 5, 6, 7 };
    //public static int lebel = 2;
    public static int getSpeed(){
        return nowSpeed;
    }

    public static void setSpeed(int val) {
        nowSpeed = val;
    }

    public static int getLebel() {
        return lebel;
    }

    public static void upLebel() {
        // レベルを上げスピードを2下げる
        lebel += 1;
        Debug.Log("Lebelup to " + lebel);
        // とりあえずテスト用として4を超えたらもとに戻るようにする
        if (lebel > upScores.Length) {
            lebel = 1;
            Debug.Log("Lebelinit " + lebel);
            nowSpeed = speeds[0];
        } else {
            nowSpeed = speeds[lebel - 1];
        }
    }

    // public void Setlevel(float setVal) {
    //     Lebelchange = setVal;
    // }

    public void ReplayGame()
    {
        audio = GetComponent<AudioSource>();
		audio.clip = clips[0];
        audio.Play();
        SceneManager.LoadScene("MainScene");
    }

    

}