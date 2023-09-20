using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public bool HasSunRoof { get; set; } = false;
        public string Year { get; set; } = "2023";
        public double EngineSize { get; set; } = 6.4;
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Ram";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Dodge";
        public string Motto { get; set; } = "If you ain't first, you're last";
        public bool HasChangedGears { get; set; }
        

        public bool HasFourWheelDrive { get; set; } = true;
        
        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {Model} {GetType().Name} now driving foward. . .");
            }
            else
            {
                Console.WriteLine($"{Model} {GetType().Name} now driving foward. . .");
            }
        }
       
        
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{Model} {GetType().Name} now reversing. . .");
                HasChangedGears = false;

            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears ");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park. . .");
                HasChangedGears = false;

            }
            else
            {
                Console.WriteLine("Can't park until we change gears ");
            }
            
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}

