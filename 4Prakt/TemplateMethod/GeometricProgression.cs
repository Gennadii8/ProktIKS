
namespace TemplateMethod
{
    class GeometricProgression : Progression
    {
        public GeometricProgression(int f, int l, int h) : base(f,l,h) { }

        public override void Progress()
        {
            int fe = First;
            do
            {
                progList.Add(fe);
                fe = fe * H;
            }
            while (fe < Last);
        }
    }
}
