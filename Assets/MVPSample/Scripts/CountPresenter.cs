using System;
using UniRx;
using Zenject;

namespace MVPSample.Scripts
{
    public sealed class CountPresenter : IInitializable, IDisposable
    {
        readonly CountView countView;
        readonly CountModel countModel;
        
        readonly CompositeDisposable compositeDisposable = new CompositeDisposable();

        public CountPresenter(CountView countView, CountModel countModel)
        {
            this.countView = countView;
            this.countModel = countModel;
        }

        void IInitializable.Initialize()
        {
            countView.OnCountUpButtonClickAsObservable()
                .Subscribe(_ => countModel.CountUp())
                .AddTo(compositeDisposable);
            
            countModel.Count
                .Subscribe(countView.UpdateCountLabel)
                .AddTo(compositeDisposable);
        }

        void IDisposable.Dispose()
        {
            compositeDisposable.Dispose();
        }
    }
}
