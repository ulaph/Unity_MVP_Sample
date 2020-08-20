using UniRx;

namespace MVPSample.Scripts
{
    public sealed class CountModel
    {
        readonly ReactiveProperty<int> count = new ReactiveProperty<int>();
        public IReadOnlyReactiveProperty<int> Count => count;

        public void CountUp()
        {
            count.Value += 1;
        }
    }
}
