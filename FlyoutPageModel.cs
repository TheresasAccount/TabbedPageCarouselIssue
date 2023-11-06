using System.Windows.Input;

namespace FlyoutCarousel
{
    public class FlyoutPageModel
    {
        public List<Fruit> FruitList { get; set; }
        public Fruit? SelectedFruit { get; set; }
        public Command SelectFruitCommand { get; set; }

        public FlyoutPageModel()
        {
#pragma warning disable IDE0028 // Simplify collection initialization
            FruitList = new List<Fruit> { new("apple", "red"), new("banana", "yellow"), new("orange", "orange") };
#pragma warning restore IDE0028 // Simplify collection initialization

            SelectFruitCommand = new Command<Fruit>(SelectFruit);
        }

        public void SelectFruit(Fruit fruit)
        {
            SelectedFruit = fruit;
        }
    }
}
