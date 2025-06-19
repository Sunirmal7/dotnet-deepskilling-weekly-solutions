namespace Week1Exercises.DesignPatterns
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> instance = new(() => new Singleton());

        public static Singleton Instance => instance.Value;

        public string GetMessage()
        {
            return "Singleton instance says hello!";
        }

        private Singleton() { }
    }
}
