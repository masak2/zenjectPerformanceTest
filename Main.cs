using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
public class Main : MonoBehaviour {
    private const int kTotal = 1000;
    [Inject]
    private HogeZenject.Factory factoryHogeZenject;
    [Inject]
    private HogeHeavyZenject.Factory factoryHogeHeavyZenject;
    [Inject]
    private SingletonImpl singleton;
	// Use this for initialization
	IEnumerator Start () {

        var listNormal = new HogeNormal[kTotal];
        var listZenject = new HogeZenject[kTotal];
        var listHeavyZenject = new HogeHeavyZenject[kTotal];
        yield return new WaitForSeconds(1f);


        float before = Time.realtimeSinceStartup;
		for(int i=0;i<kTotal;++i)
        {
            var a  = new HogeNormal();
            a.singleton = singleton;
            listNormal[i] = a;
        }
        float normalTime = Time.realtimeSinceStartup - before;

        yield return new WaitForSeconds(1f);

        before = Time.realtimeSinceStartup;
        for(int i=0;i<kTotal;++i)
        {
            var a = factoryHogeZenject.Create();
            listZenject[i] = a;
        }
        float zenjectTime = Time.realtimeSinceStartup - before;


        yield return new WaitForSeconds(1f);
        before = Time.realtimeSinceStartup;
        for (int i = 0; i < kTotal; ++i)
        {
            var a = factoryHogeHeavyZenject.Create();
            listHeavyZenject[i] = a;
        }
        float heavyZenjectTime = Time.realtimeSinceStartup - before;


        yield return new WaitForSeconds(1f);

	}
	
}
