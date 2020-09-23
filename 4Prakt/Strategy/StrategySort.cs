

namespace Strategy
{
    abstract class StrategySort
    {
        public string Title { get; set; }

        public abstract void Sort(int[] array);
    }
}
