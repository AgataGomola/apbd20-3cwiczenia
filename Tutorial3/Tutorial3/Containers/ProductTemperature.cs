using System.Collections.Generic;

namespace Tutorial3.Containers
{
    public class ProductTemperature
    {
        public static Dictionary<PossibleProducts, double> temperatures = new Dictionary<PossibleProducts, double>()
        {
            { PossibleProducts.Banana, 13.3 },
            { PossibleProducts.Chocolate , 18},
            { PossibleProducts.Fish , 2},
            { PossibleProducts.Meat , -15},
            { PossibleProducts.IceCream , -18},
            { PossibleProducts.FrozenPizza , -30},
            { PossibleProducts.Cheese , 7.2},
            { PossibleProducts.Sausages , 5},
            { PossibleProducts.Butter , 20.5},
            { PossibleProducts.Eggs , 19}

        };
    }
}