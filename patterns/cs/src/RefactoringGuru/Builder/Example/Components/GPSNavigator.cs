using System;

namespace RefactoringGuru.Builder.Example.Components
{
    /**
     * EN: Just another feature of a car.
     * 
     * RU: Одна из фишек автомобиля.
     */
    public class GPSNavigator
    {
        private string route;

        public GPSNavigator()
        {
            this.route = "221b, Baker Street, London  to Scotland Yard, 8-10 Broadway, London";
        }

        public GPSNavigator(String manualRoute)
        {
            this.route = manualRoute;
        }

        public String GetRoute()
        {
            return route;
        }
    }
}
