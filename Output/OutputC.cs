namespace Output
{
    class OutputC
    {
        static void Main(string[] args)
        {
            Console.Write("Hey!");
            Console.WriteLine("Hello World!"); // Write only, doesn't do a enter in the end of the line 

            // \a bell; \b backspace; \f form feed; \n new line; \r carriege return; \t horizontal tab; \v vertical tab; \' single quotation mark
            // \" double quotation mark; \\ backslash; \? literal question mark

            Console.ReadKey();
        }
    }
}
