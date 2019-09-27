namespace MethodsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.myhomework();
            prog.myhomework2(150, 5);

        }
        public void myhomework()
        {
            console.writeline("Homework is lovely");
        }
        public void myhomework2 (float param1f, float param2f)
        {
            var average = param1f / param2f;
            console.writeline(average); 
        }
    }
}
