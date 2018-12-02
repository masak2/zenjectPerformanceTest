using Zenject;

public class UntitledInstaller : MonoInstaller
{

    public override void InstallBindings()
    {
        Container.Bind<SingletonImpl>().AsSingle();

        Container.BindFactory<HogeZenject, HogeZenject.Factory>();
        Container.BindFactory<HogeHeavyZenject, HogeHeavyZenject.Factory>();
    }



}