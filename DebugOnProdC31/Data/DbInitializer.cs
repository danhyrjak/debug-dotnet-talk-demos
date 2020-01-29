namespace DebugOnProdC31.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RegistrationsDbContext context) 
        {
            context.Database.EnsureCreated();
        }
    }
}
