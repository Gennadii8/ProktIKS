

namespace Decorator
{
    class AutoAppearance : DecoratorOptions
    {
        public AutoAppearance(AutoBase p , string t) : base(p,t)
        {
            AutoProperty = p;

            Name = p.Name + "Body kit";
            Description = p.Description + ". " + this.Title +
                ".Matt + Wide frame";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 649.99;
        }
    }
}
