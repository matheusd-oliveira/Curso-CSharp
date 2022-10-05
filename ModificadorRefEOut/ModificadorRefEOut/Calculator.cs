namespace ModificadorRefEOut
{
    class Calculator
    {   
        // Modificador ref
        public static void Triple(ref int x)
        {
            x *= 3;
        }

        public static void Double(int origin, out int result)
        {
            result = origin * 2;
        }
    }
}
