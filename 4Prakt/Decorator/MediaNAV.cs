﻿

namespace Decorator
{
    class MediaNAV : DecoratorOptions
    {
        public MediaNAV(AutoBase p, string t) : base(p,t)
        {
            AutoProperty = p;

            Name = p.Name + ". Contemporary";
            Description = p.Description + ". " + this.Title + ". Refresh multimedia NAV system";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 15.99;
        }
    }
}
