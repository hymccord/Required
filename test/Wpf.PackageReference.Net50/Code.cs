namespace Code
{
    public class NormalClass
    {
        public required string NormalProp { get; set; }
    }

    public class WeirdClass
    {
        public required string _weirdField;

        [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WeirdClass()
        {
            _weirdField = "x";
        }
    }

    public static class User
    {
        public static void UseExternalInit()
        {
            _ = typeof(System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute);
        }


        public static void UseNormalClass()
        {
            var instance = new NormalClass() { NormalProp = "NormalProp" };
            //instance.NormalProp = "Should be an error.";
        }

        public static void UseWeirdClass()
        {
            var instance = new WeirdClass();
            //instance.CtorProp = "Should be an error.";
            //instance.NormalProp = "Should be an error.";
        }
    }
}
