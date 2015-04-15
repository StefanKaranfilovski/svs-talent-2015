using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Inheritance;
using CSharpProgrammingBasics.Library.Samples.Static;
using CSharpProgrammingBasics.Library.Samples.Exceptions;
using CSharpProgrammingBasics.Library.Samples.Interfaces;
using DelegateExample;
using System.IO;
using System.Collections;
using CSharpProgrammingBasics.Library.Samples.Extensions;

namespace ProgrammingBasics.ConsolaApp
{
    public class Bike:ICar
    {
        string ICar.Name
        {
            get { throw new NotImplementedException(); }
        }

        bool ICar.IsEngineRunning
        {
            get { throw new NotImplementedException(); }
        }

        bool ICar.IsLightsOn
        {
            get { throw new NotImplementedException(); }
        }

        bool ICar.IsRadioOn
        {
            get { throw new NotImplementedException(); }
        }

        Colours ICar.Colour
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        int ICar.NumberOfWheels
        {
            get { throw new NotImplementedException(); }
        }

        CarDiagnostics ICar.StartEngine(StartEngineOptions options)
        {
            throw new NotImplementedException();
        }

        CarDiagnostics ICar.StopEngine()
        {
            throw new NotImplementedException();
        }

        void ICar.LightSwitch(bool isLightsOn)
        {
            throw new NotImplementedException();
        }

        void ICar.RadioSwitch(bool isRadioOn)
        {
            throw new NotImplementedException();
        }

        int ICar.OpenWindow(WindowLocation whichWindow, int increment)
        {
            throw new NotImplementedException();
        }

        int ICar.CloseWindow(WindowLocation whichWindow, int increment)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }
    }

    public struct Point
    {
        public int X;
        public int Y;
    }

    public enum Day 
    { 
        None = 0,
        Sunday = 1, 
        Monday = 2 
    };

    class Program
    {
        static void Main(string[] args)
        {

            ICar _theCar = CarFactory.CreateNewElectricCar();
            //
            //_theCar.ToString();
            //_theCar.StopEngine();
            //notice how this is called
            _theCar.CloseAllWindows();
            //
            CarExtensions.CloseAllWindows(_theCar);
            return;
            
            //SpecializedCarFactory<ElectricCar> _electricCarFactory = new SpecializedCarFactory<ElectricCar>(null);
            //_electricCarFactory.OnCarComplete += Program.HandleOnCarComplete;
            //_electricCarFactory.CreateNewCar(Colours.Red);
            //return;
            ////
            //ICar _theCar = CarFactory.CreateNewCar();
            //ICar _theSecondCar = CarFactory.CreateNewCar();
            ////
            //ArrayList _arrayOfCars = new ArrayList();
            //_arrayOfCars.Add(_theCar);
            //_arrayOfCars.Add(_theSecondCar);

            ////
            //_arrayOfCars.Add("Ne e kola");

            //List<ICar> _arrayOfCarsGeneric = new List<ICar>();
            //_arrayOfCarsGeneric.Add(_theCar);
            //_arrayOfCarsGeneric.Add(_theSecondCar);
            ////_arrayOfCarsGeneric.Add("Ne e kola");

            //return;

            ////get the car park
            ////CarPark _park = CarFactory.GetCarPark(CarParkLocation.East);
            ////CarPark _parkIndexer = CarFactory[CarParkLocation.East];

            //WindowLocation _theLocation = WindowLocation.FrontLeft | WindowLocation.FrontRight;
            //Day _theDay = Day.Monday;
            ////_theDay = "Monday";
            ////if (_days.First(x=>x == "Moday")
            //string _theDayString = "Monday";
            //_theDay = (Day) Enum.Parse(typeof(Day), _theDayString);
            ////_theDay = WindowLocation.FrontLeft;
            //_theDay = (Day)10;
            //if (_theDay is Day)
            //{
            //    Console.WriteLine("OK");
            //}
            ////
            //return;
            //if (_theDay == Day.Sunday)
            //    return;
            ////
            //if ((_theLocation & WindowLocation.FrontLeft) == WindowLocation.FrontLeft)
            //{
            //    return;
            //}

            ////
            //Point? _nullablePoint = null;
            //Nullable<Point> _nullable = null;
            //Point _thePoint = new Point();
            //Console.WriteLine("X={0}, Y={1}",_thePoint.X, _thePoint.Y);
            //Console.ReadLine();
            //return;
            //_thePoint.X = 12;
            //_thePoint.Y = 10;
            //return;
            //CombustionEngineCar _theCarWithInterface = new CombustionEngineCar();
            ////test combustion engine car
            //CarFactory.TestTheCar(_theCarWithInterface);
            ////test electric car
            //ElectricCar _theElectricCarWithInterface = new ElectricCar();
            //CarFactory.TestTheCar(_theElectricCarWithInterface);
            ////
            //Bike _theBike = new Bike();
            //ICar _theInterface = _theBike;
            ////
            //CarFactory.TestTheCar(_theBike);
            //return;
            ////AbstractCar _carInstance = new CombustionEngineCar();
            //ElectricCar _carInstance = new ElectricCar();
            ////ElectricCar _carInstanceElectric = new ElectricCar();

            ////_carInstance = _carInstanceElectric;
            ////_carInstanceElectric = _carInstance;

            //_carInstance.StartEngine(StartEngineOptions.TurnOffLightsBeforeStart);
            //Console.ReadLine();
            //return;
            ////call read from file
            //ReadFromFile();
            ////
            //_theCar = new ElectricCar();
            ////
            //_theCar.OpenWindow(WindowLocation.FrontLeft, 50);
            ////
            ////_theCar["FrontLeft"];

            ////Console.WriteLine("FrontLeft {0}", _theCar[WindowLocation.FrontLeft]);
            ////Console.WriteLine("FrontRight {0}", _theCar[WindowLocation.FrontRight]);
            ////Console.WriteLine("RearLeft {0}", _theCar[WindowLocation.RearLeft]);
            ////Console.WriteLine("RearRight {0}", _theCar[WindowLocation.RearRight]);
            ////Building _theBuilding = new Building();
            ////_theBuilding.LeftElevator = new BaseElevator();
            ////_theBuilding.RightElevator = new JapaneseTurboElevator();
            //////left goes up
            ////_theBuilding.LeftElevator.GoUp(10);
            //////right goes up
            ////_theBuilding.RightElevator.GoUp(5);
            //////
            ////JapaneseTurboElevator _theJapanese = new JapaneseTurboElevator();
            ////_theJapanese.GoUp(5);
            //////
            //System.Console.ReadLine();

            //FlyThePlain();

            //SpecializedCarFactory<CombustionEngineCar> _tmpFactory = new SpecializedCarFactory<CombustionEngineCar>();

            CarPark _parking = new CarPark();

            ICar _theCarToPark = null;
            //
            try
            {
                CallParkCar(_parking, _theCarToPark);
            }
            catch (CarParkFullException carParFullEx)
            {
                System.Console.WriteLine("The carpark is full");
                System.Console.WriteLine(carParFullEx.Message);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Se sluci nekoja greska!");
                System.Console.WriteLine(ex.ToString());
                throw ex;
            }
            finally
            {
                System.Console.WriteLine("Oooop finally");
            }
            //
            System.Console.WriteLine("Aftr ParkCar method call!");

        }

        private static void HandleOnCarComplete(object doesNotNeedToHaveTheSameName, CarCompleteEventArgs hereAlso)
        {
            Console.WriteLine("OK");
        }

        private static void CallParkCar(CarPark _parking, ICar _theCarToPark)
        {
            try
            {
                _parking.ParkCar(_theCarToPark);
                System.Console.WriteLine("CallParkCar method logic after exception!");
            }
            catch (Exception)
            {                
                throw;
            }
        }


        private static void FlyThePlain()
        {
            Coordinates _coor  = new Coordinates();
            _coor.x = 10;
            _coor.y = 11;
            _coor.z = -2;

            Plane _plane = new Plane();
            EngageAutoPilot _handler = new EngageAutoPilot(_plane_AutopilotHandler);
            //_plane.AutopilotHandler += _handler;
            //_plane.AutopilotHandler -= _handler;
            _plane.AutopilotHandler += new EngageAutoPilot(_plane_AutopilotHandler);
            _plane.AutopilotHandler += new EngageAutoPilot(_plane_AutopilotHandler);
            _plane.AutopilotHandler -= new EngageAutoPilot(_plane_AutopilotHandler);
            //_plane.
            //_plane.AutopilotHandler = new EngageAutoPilot(Program.AutoPilotOn);
            _plane.FlyToDestination(_coor);
            //
            System.Console.ReadLine();
        }

        static void _plane_AutopilotHandler(int time, Coordinates coorinates)
        {
            throw new NotImplementedException();
        }

        /*
        public static void AutoPilotOn(int time, Coordinates coordinates)
        {
            Console.WriteLine("The plain will fly:{0} minutes, to Coordinates x:{1}, y:{2}, z:{3}", time, coordinates.x, coordinates.y, coordinates.z);
        }
         */

        static void ReadFromFile()
        {
            
            string _fileName = "D:\\TestFile.txt";
            string _fileContent = File.ReadAllText(_fileName);
            //
            FileStream _fs = new FileStream(_fileName, FileMode.Open);
            //
            //
            Console.WriteLine("File content:{0}",_fileContent);
            //
            System.Console.ReadLine();
        }
    }
}
