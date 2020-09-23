

namespace Decorator
{
    class SystemSecurity :DecoratorOptions
    {
        public SystemSecurity(AutoBase p, string t) : base(p,t)
        {
            AutoProperty = p;

            Name = p.Name + ". Higher security";
            Description = p.Description + ". " + this.Title +
                ". Front side security pillow, ESP - dinamic stabilisation system";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 20.99;
        }
    }
}
