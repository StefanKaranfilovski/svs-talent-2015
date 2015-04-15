using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Inheritance;
using CSharpProgrammingBasics.Library.Samples.Interfaces;

namespace CSharpProgrammingBasics.Library.Samples.Static
{

    /// <summary>
    /// Delegate to be used to paint a car
    /// </summary>
    /// <param name="carToBePainted"></param>
    /// <param name="colourOfTheCar"></param>
    /// <returns></returns>
    public delegate void PaintCar(ICar carToBePainted, Colours colourOfTheCar);

    /// <summary>
    /// The OnCompleteCar event arguments
    /// </summary>
    public class CarCompleteEventArgs : EventArgs
    {
        public CarCompleteEventArgs(ICar completedCar)
        {
            this.CompletedCar = completedCar;
        }

        public ICar CompletedCar { get; private set; }
    }


    /// <summary>
    /// Defines a generic class for a car facotry that is specialized for production of a certain type of cars
    /// </summary>
    public partial class SpecializedCarFactory<TCar> where TCar : ICar, new()
    {
        /// <summary>
        /// A static property that is specific to a SpecializedCarFactory-TCar combination
        /// </summary>
        public static TCar LastProducedCar { get; private set; }


        /// <summary>
        /// The event called when a car is completed
        /// </summary>
        public EventHandler<CarCompleteEventArgs> OnCarComplete;

        private PaintCar m_Painter;
        
        /// <summary>
        /// 
        /// </summary>
        //public PaintCar CarPainter { get; set; }

        public event PaintCar CarPainter; 
        //{ 
        //    add
        //    {
        //        m_Painter += value;
        //    }
        //    remove
        //    {
        //        m_Painter -= value;
        //    }
        //}

        ////dedicated field for the public event
        //private PaintCar m_CarPainter;
        ///// <summary>
        ///// The event that signals that the car needs to be painted by a specific car painter
        ///// </summary>
        //public event PaintCar CarPainter
        //{
        //    //note the keywords add/remove in comparison to get/set
        //    add { this.m_CarPainter += value; }
        //    remove { this.m_CarPainter -= value; }
        //}


        public SpecializedCarFactory(PaintCar carPainterDelegate)
        {
            Type _theType = typeof(TCar);
            //this.CarPainter = carPainterDelegate;
            this.CarPainter += carPainterDelegate;
        }

        /// <summary>
        /// Creates new car of a specific type
        /// </summary>
        /// <param name="carColour"></param>
        /// <returns></returns>
        public TCar CreateNewCar(Colours carColour)
        {
            //return default(TCar);
            TCar _result = new TCar();
            if (typeof(TCar) == typeof(ElectricCar))
            {
                _result.StartEngine(StartEngineOptions.TurnOffLightsBeforeStart | StartEngineOptions.TurnOffRadioBeforeStart);
            }            
            //this.CarPainter(null, carColour);
            if (this.CarPainter != null)
                this.CarPainter(_result, carColour);
            //set the last produced car property
            SpecializedCarFactory<TCar>.LastProducedCar = _result;
            //call the event to notify subscribers that the a car is completed
            if (this.OnCarComplete != null)
            {
                CarCompleteEventArgs _arguments = new CarCompleteEventArgs(_result);
                this.OnCarComplete(this, _arguments);
            }

            return _result;
        }
    }


}
