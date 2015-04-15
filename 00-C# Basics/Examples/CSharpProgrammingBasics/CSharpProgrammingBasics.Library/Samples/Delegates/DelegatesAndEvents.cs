using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Interfaces;
using CSharpProgrammingBasics.Library.Samples.Static;
using CSharpProgrammingBasics.Library.Samples.Inheritance;

namespace CSharpProgrammingBasics.Library.Samples.Delegates
{
    public class DelegatesAndEvents
    {
        public IList<ICar> CreateCars()
        {
            IList<ICar> _carsCreated = new List<ICar>();
            /*
            PaintCar _theCarPainterExpert = new PaintCar(this.CarPainter);
            //
            SpecializedCarFactory<CombustionEngineCar> _combustionEngineFactory = new SpecializedCarFactory<CombustionEngineCar>(_theCarPainterExpert);

            SpecializedCarFactory<CombustionEngineCarEnglishVersion> _combustionEngineEnglishFactory = new SpecializedCarFactory<CombustionEngineCarEnglishVersion>(_theCarPainterExpert);

            SpecializedCarFactory<ElectricCar> _electricFactory = new SpecializedCarFactory<ElectricCar>(this.CarPainter);
            //when using event this will no longer be possible
            _electricFactory.CarPainter = this.CarPainter;

            //
            ICar _newCar = _combustionEngineFactory.CreateNewCar(Colours.Red);
            _carsCreated.Add(_newCar);
            //
            _newCar = _combustionEngineEnglishFactory.CreateNewCar(Colours.Blue);
            _carsCreated.Add(_newCar);
            //
            _newCar = _electricFactory.CreateNewCar(Colours.Green);
            _carsCreated.Add(_newCar);
             */
            return _carsCreated;
        }

        /// <summary>
        /// The method that knows how to paint cars
        /// </summary>
        /// <param name="carToBePainted"></param>
        /// <param name="colourOfTheCar"></param>
        public static void CarPainter(ICar carToBePainted, Colours colourOfTheCar)
        {
            carToBePainted.Colour = colourOfTheCar;
        }
    }
}