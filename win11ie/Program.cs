
// To hide the console windows change solution prperties to "windows application"

namespace Main
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // The SHDocVw object requires a refrence to COM object "Microsoft Internet Controls"
            SHDocVw.InternetExplorer IE = new();
            object URL;

            if (args.Length >= 1)
            {
                URL = args[0];
            }
            else
            {
                URL = "http://www.google.com"; // home page
            }

            // Call the IE instance to open the specified URL 
            IE.Visible = true;
            IE.Navigate2(ref URL);
        }
    }
}