namespace Fridge
{
    public class Beer
    {
        private string _brewery;
        private double _abv;
        private int _quantity;
        private BeerStyle _style;

        public Beer(string name, string brewery, double abv, BeerStyle style, int quantity)
        {
            Name = name;
            Brewery = brewery;
            ABV = abv;
            Style = style;
            Quantity = quantity;
        }

        public string Name { get; }

        public string Brewery { get; }

        public double ABV { get; }

        public BeerStyle Style { get; }

        public int Quantity { get; }
    }

    public enum BeerStyle
    {
        IPA = 1,
        DIPA = 2,
        LightLager = 3,
        Stout = 4
    }
}