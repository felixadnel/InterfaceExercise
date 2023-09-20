using System;
namespace InterfaceExercise
{
	public class Car : IVehicle , ICompany
	{
		public Car()
		{
		}
        public bool HasSunRoof { get; set; } = false;
        public string Year { get; set; } = "2022";
        public double EngineSize { get; set; } = 5.7;
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "RT";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Dodge";
        public string Motto { get; set; } = "If you ain't first, you're last";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Model} {GetType().Name} now driving foward. . .");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . .");
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

