public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        var cars = new (int pos, double time)[n];

        for(int i = 0; i < n; i++)
            cars[i] = (position[i], (double)(target - position[i])/speed[i]);

        Array.Sort(cars, (a,b) => b.pos.CompareTo(a.pos));

        Stack<double> fleets = new Stack<double>();

        foreach(var car in cars)
        {
            double t = car.time;
            if(fleets.Count == 0 || t > fleets.Peek())
                fleets.Push(t);
        }

        return fleets.Count;
    }
}