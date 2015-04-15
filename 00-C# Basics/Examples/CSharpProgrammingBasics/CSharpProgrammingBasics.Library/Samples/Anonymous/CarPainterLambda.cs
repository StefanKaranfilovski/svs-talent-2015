using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Static;
using CSharpProgrammingBasics.Library.Samples.Interfaces;
using CSharpProgrammingBasics.Library.Samples.Inheritance;
using CSharpProgrammingBasics.Library.Samples.Delegates;

namespace CSharpProgrammingBasics.Library.Samples.Anonymous
{
    class CarPainterLambda
    {
        private void CreateCarPainterUsingLambda()
        {
            //named method implementation
            PaintCar _theCarPainterExpert = new PaintCar(DelegatesAndEvents.CarPainter);
            //anonymous method implementation
            _theCarPainterExpert = delegate(ICar carToPaint, Colours colour) { carToPaint.Colour = colour; };
            //lambda expression implementation
            _theCarPainterExpert = (ICar carToPaint, Colours colour) => { carToPaint.Colour = colour; };
            //lambda expression implementation, with type inference
            _theCarPainterExpert = (x, y) => x.Colour = y; 

        }
    }
}
