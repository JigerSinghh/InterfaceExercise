using System;
namespace InterfaceExercise
{
	public class Car : IVehicle , ICompany
	{
        public int Wheels { get; set; } = 4;
        public string Doors { get; set; } = "Four";
        public int Seats { get; set; } = 5;
        public string Speakers { get; set; } = "Harman and Kardon";
        public string CompanyName { get; set; } = "Mercedes";
        public string Logo { get; set; } = "Star with circle";
        public bool HasChangedGears { get ; set; } 

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving foward...");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {

                Console.WriteLine($"{GetType().Name} now driving backwards...");
                HasChangedGears = false;
            }

            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }
        public void Park()
        {
            Console.WriteLine($"{GetType().Name} now not moving...");
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        bool IVehicle.ChangeGears(bool isChanged)
        {
            throw new NotImplementedException();
        }

        public Car()
        {
          
        }
		
			
		
	}
}

