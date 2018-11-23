using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
　  public AudioClip[] clips;
    AudioSource audio;
    private static int level = 1;

    // スピードの設定
    private static int[] speeds = new int[] {10, 8, 6, 4, 2}; // 確認用
    // 現在のスピードを設定
    private static int nowSpeed = speeds[0]; // 確認用

    // レベルアップスコアの設定かつレベル数の定義
    public static int[] upScores = new int[] {10, 20, 27, 35};
    //public static int level = 2;
    public static int getSpeed(){
        return nowSpeed;
    }

    public static void setSpeed(int val) {
        nowSpeed = val;
    }

    public static int getLevel() {
        return level;
    }

    public static void upLevel() {
        // レベルを上げスピードを2下げる
        level += 1;
        Debug.Log("Lebelup to " + level);
        // とりあえずテスト用として4を超えたらもとに戻るようにする
        if (level > upScores.Length) {
            level = 1;
            Debug.Log("Lebelinit " + level);
            nowSpeed = speeds[0];
        } else {
            nowSpeed = speeds[level - 1];
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