using System;
using UnityEngine;
using Zenject;

namespace MVPSample.Scripts.Installer
{
    public class MVPSampleSceneInstaller : MonoInstaller
    {
        [SerializeField] CountView countView;
        public override void InstallBindings()
        {
            Container.Bind<CountView>().FromInstance(countView).AsSingle();
            Container.Bind(typeof(IInitializable), typeof(IDisposable)).To<CountPresenter>().AsSingle();
            Container.Bind<CountModel>().AsSingle();
        }
    }
}