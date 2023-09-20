using System;
namespace InterfaceExercise
{
	public class Suv : IVehicle, ICompany
	{
		public Suv()
		{
		}
        public bool HasSunRoof { get; set; } = true;
        public string Year { get; set; } = "2024";
        public double EngineSize { get; set; } = 6.4;
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Durango";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Dodge";
        public string Motto { get; set; } = "If you ain't first, you're last";
        public bool HasChangedGears { get; set; }

        
        public void Drive()
        {
            if (HasSunRoof == true)
            {
                Console.WriteLine($"With sunroof open {Model} {GetType().Name} is now driving foward. . .");
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

