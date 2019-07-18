using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour {
    public static GameObject TextPoint;

    public static string[] StoryOne;




	// Use this for initialization
	void Start () {
        TextPoint = GameObject.Find("01");
        StoryOne[0] = ("出發！郊遊囉！總之先以那個亮亮的地方當作目的地吧！");
        StoryOne[1] = ("大姊，請您認真一點，我們現在可是肩負著國家的命運，要是失敗了……");
        StoryOne[2] = ("你的身體這麼僵硬可不行！要和我多學著點！你看，多麼光滑柔軟！");
        StoryOne[3] = ("我們兩個明明看起來就是一樣的。");
        StoryOne[4] = ("大姊，請加快速度吧，不然再這樣下去真的會追不上他們的。");
        StoryOne[5] = ("看來小弟你也很想去露營嘛！很好很好！衝阿！");
        StoryOne[6] = ("露營……？");
        StoryOne[7] = ("不好意思，剛剛不小心扭到腳了……沒關係，繼續前進吧！");
        StoryOne[8] = ("……唉呀！不小心踩到陷阱了呢！只好放慢速度了。");
        StoryOne[9] = ("大姊，謝謝妳，我已經沒問題了，請回到正常速度吧！");
        StoryOne[10] = ("可是我還沒休息夠……");
        StoryOne[11] = ("……請加快速度。");
        StoryOne[12] = ("");
    }
	
	// Update is called once per frame
	void Update () {

	}
}
