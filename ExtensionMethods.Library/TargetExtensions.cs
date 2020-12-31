namespace ExtensionMethods.Library
{
    public static class TargetExtensions
    {
        public static string GetStandardizedId(this Target target)
        {
            return target.GetId().ToUpper();
        }

        // is accesible
        internal static void ExtendInternal(this InternalTarget target)
        {
            // to implement, is only a sample 
        }

        /*
         * not accesible
        internal static void ExtendInternalProtected(this InternalTarget.ProtectedSubClass target)
        {
        }
        */

    }
}
