using UnityEngine;
using UnityEngine.Assertions;
using Zenject;
public class HogeNormal
{
    public SingletonImpl singleton;
    

}

public class HogeZenject
{
    [Inject]
    public SingletonImpl singleton;


    public class Factory : PlaceholderFactory<HogeZenject>
    { }

}

public class HogeHeavyZenject
{
    [Inject] public SingletonImpl singleton0;
    [Inject] public SingletonImpl singleton1;
    [Inject] public SingletonImpl singleton2;
    [Inject] public SingletonImpl singleton3;
    [Inject] public SingletonImpl singleton4;
    [Inject] public SingletonImpl singleton5;
    [Inject] public SingletonImpl singleton6;
    [Inject] public SingletonImpl singleton7;
    [Inject] public SingletonImpl singleton8;
    [Inject] public SingletonImpl singleton9;

    public class Factory : PlaceholderFactory<HogeHeavyZenject>
    { }

}

public class SingletonImpl 
{
    public void Method()
    {
        Debug.Log("a");
    }
}
