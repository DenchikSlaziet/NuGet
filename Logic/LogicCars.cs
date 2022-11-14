namespace LogicKochetkovNuget
{
    public class LogicCars<T> where T : class
    {
        private List<T> Cars = new List<T>();

        public List<T> GetAll()
        {
            return Cars;
        }

        public void AddCar(T car)
        {
            Cars.Add(car);
        }

        public void DeleteCar(T car)
        {
            Cars.Remove(car);
        }

        public void ChangeCar(int index, T car)
        {  
            Cars[index] = car;
        }
    }
}