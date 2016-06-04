namespace SoftwareArchitecture.Data.Prototype
{
    public static class Context
    {
        private static readonly DatabaseContext context;

        static Context()
        {
            context = new DatabaseContext();
        }

        public static IPrototype GetConext()
        {
            return context.Clone();
        } 
    }
}
