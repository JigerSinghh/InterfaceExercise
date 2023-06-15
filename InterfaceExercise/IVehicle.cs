using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int Wheels { get; set; }
		public string Doors { get; set; }
		public int Seats { get; set; }
		public string Speakers { get; set; }
		public bool HasChangedGears { get; set; }
		public void Drive();
		public void Reverse();
		public void Park();
		public bool ChangeGears(bool isChanged);
		

	}
}

