
namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Progression val = new ArithmeticProgression(1, 20, 3);
            val.TemplateMethod();
            Progression geom = new GeometricProgression(1, 100, 3);
            geom.TemplateMethod();
        }
    }
}
